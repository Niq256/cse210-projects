using System;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.CalculateTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;

        return productTotal + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\nName: {_customer.Name}\n{_customer.Address.FormatAddress()}";
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AECS20250324.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }


    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El precio debe tener solo numeros")]
    public decimal Price { get; set; }

    public decimal PurchasePrice { get; set; }

    public int? WarehouseId { get; set; }

    public int? BrandId { get; set; }


    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}

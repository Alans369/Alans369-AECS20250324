using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AECS20250324.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    public string ProductName { get; set; } = null!;
    [Display(Name = "Descripcion")]
    public string? Description { get; set; }


    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El precio debe tener solo numeros")]
    [Display(Name = "Precio")]
    public decimal Price { get; set; }

    [Display(Name = "Precio compra")]
    public decimal PurchasePrice { get; set; }

    [Display(Name = "Marca")]
    public int? WarehouseId { get; set; }

    [Display(Name = "Almacen")]
    public int? BrandId { get; set; }

    [Display(Name = "Marca")]
    public virtual Brand? Brand { get; set; }

    [Display(Name = "Almacen")]
    public virtual Warehouse? Warehouse { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AECS20250324.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El Nombre de la bodega es obligatorio")]
    [Display(Name = "Bodega")]
    public string WarehouseName { get; set; } = null!;

    

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

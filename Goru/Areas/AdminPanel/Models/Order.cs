﻿using System.ComponentModel.DataAnnotations;
using Goru.Areas.AdminPanel.Enums;

public class Order
{
    /// <summary>
    /// Артикль товара
    /// </summary>
    public int Article { get; set; }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Цена товара
    /// </summary>
    public int Price { get; set; }
    
    /// <summary>
    /// Размер товара
    /// </summary>
    public SizeEnum Size { get; set; }
    
    /// <summary>
    /// Скидка на товар
    /// </summary>
    public float Offer { get; set; }
    
    /// <summary>
    /// Категория товара
    /// </summary>
    public int CategoryId { get; set; }
}


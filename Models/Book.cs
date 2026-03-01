using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Library2.Models;

[Index("Isbn", Name = "UQ__Books__447D36EAE4C54C86", IsUnique = true)]
public partial class Book
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    [StringLength(100)]
    public string Author { get; set; } = null!;

    [StringLength(100)]
    public string Category { get; set; } = null!;

    [Column("ISBN")]
    [StringLength(50)]
    public string Isbn { get; set; } = null!;

    public int Quantity { get; set; }

    public string? Description { get; set; }

    [StringLength(255)]
    public string? CoverImagePath { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
}

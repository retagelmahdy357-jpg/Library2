using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Library2.Models;

public partial class BorrowRecord
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public int BookId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BorrowDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [StringLength(20)]
    public string Status { get; set; } = null!;

    [ForeignKey("BookId")]
    [InverseProperty("BorrowRecords")]
    public virtual Book Book { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("BorrowRecords")]
    public virtual User User { get; set; } = null!;
}

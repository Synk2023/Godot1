﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model;

/// <summary>
/// A collection of FRAMEWORK_TIERS records
/// </summary>
public partial class FRAMEWORK_TIERS
{
    [Key]
    [StringLength(50)]
    public string Tier { get; set; }

    [Required]
    [StringLength(50)]
    public string FullName { get; set; }

    public int TierOrder { get; set; }

    [InverseProperty("TierNavigation")]
    public virtual ICollection<FRAMEWORK_TIER_DEFINITIONS> FRAMEWORK_TIER_DEFINITIONS { get; set; } = new List<FRAMEWORK_TIER_DEFINITIONS>();

    [InverseProperty("TierNavigation")]
    public virtual ICollection<FRAMEWORK_TIER_TYPE_ANSWER> FRAMEWORK_TIER_TYPE_ANSWER { get; set; } = new List<FRAMEWORK_TIER_TYPE_ANSWER>();
}
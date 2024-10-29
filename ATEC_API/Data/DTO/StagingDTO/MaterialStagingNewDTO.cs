// <copyright file="MaterialStagingNewDTO.cs" company="ATEC">
// Copyright (c) ATEC. All rights reserved.
// </copyright>

namespace ATEC_API.Data.DTO.StagingDTO
{
    using System.ComponentModel.DataAnnotations;

    public class MaterialStagingNewDTO
    {
        [Required]
        public string Sid { get; set; }

        [Required]
        public string MaterialId { get; set; }

        [Required]
        public string Serial { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public int MaterialType { get; set; }

        [Required]
        public int Usercode { get; set; }
    }
}
// <copyright file="MagazineHistoryInput.cs" company="ATEC">
// Copyright (c) ATEC. All rights reserved.
// </copyright>

namespace ATEC_API.Data.DTO.StagingDTO
{
    public class MagazineHistoryInput
    {
        public string searchValue { get; set; }

        public int stageValue { get; set; }

        public int customerCode { get; set; }

        public DateTime? dateFrom { get; set; }

        public DateTime? dateTo { get; set; }

        public int currentPage { get; set; }

        public int pageSize { get; set; }
    }
}

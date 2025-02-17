// <copyright file="LogSheetController.cs" company="ATEC">
// Copyright (c) ATEC. All rights reserved.
// </copyright>

namespace ATEC_API.Controllers
{
    using ATEC_API.Data.DTO.LogSheetDTO;
    using ATEC_API.Data.IRepositories;
    using ATEC_API.GeneralModels;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class LogSheetController
        (ILogSheetRepository _logSheetRepository)
        : ControllerBase
    {
        [HttpGet("GetLogsheetFields")]
        public async Task<IActionResult> GetLogsheetFields([FromQuery] string fieldColumn)
        {
            var logSheetFieldsDTO = new LogSheetFieldsDTO
            {
                FieldColumn = fieldColumn,
            };

            var getlogSheetDetials = await _logSheetRepository.GetLogSheetFields(logSheetFieldsDTO);

            return this.Ok(new GeneralResponse
            {
                Details = getlogSheetDetials,
            });
        }

        [HttpGet("GetLogsheetName")]
        public async Task<IActionResult> GetLogsheetName()
        {
            var getlogSheetDetials = await _logSheetRepository.GetLogSheetName();

            return this.Ok(new GeneralResponse
            {
                Details = getlogSheetDetials,
            });
        }
    }
}

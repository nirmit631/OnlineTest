﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTest.Services.DTO.AddDTO;
using OnlineTest.Services.DTO.UpdateDTO;
using OnlineTest.Services.Interface;

namespace OnlineTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {
        #region Field
        private readonly ITestService _testService;
        #endregion
        #region Constructor
        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        #endregion

        #region Methods
        [HttpGet]
        public IActionResult GetTestsByTechnologyId(int id)
        {
            return Ok(_testService.GetTestsByTechnologyId(id));
        }

        [HttpGet("paginated")]
        public IActionResult GetTests(int PageNo, int RowsPerPage)
        {

            return Ok(_testService.GetTestsPagination(PageNo, RowsPerPage));
        }
        [HttpGet("id")]
        public IActionResult GetTestById(int id)
        {
            return Ok(_testService.GetTestById(id));
        }

        [HttpPost]
        public IActionResult AddTest(AddTestDTO test)
        {

            return Ok(_testService.AddTest(test));
        }

        [HttpPut]
        public IActionResult UpdateTest(UpdateTestDTO test)
        {

            return Ok(_testService.UpdateTest(test));
        }
        [HttpDelete]
        public IActionResult DeleteTest(int id)
        {
            return Ok(_testService.DeleteTest(id));
        }
        #endregion

    }
}

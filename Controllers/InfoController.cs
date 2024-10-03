﻿using BackEndDevelopment.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.Versioning;

namespace BackEndDevelopment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        [Route("client")]
        public IActionResult GetUserInfo()
        {
            string ip = Request.HttpContext.Connection.RemoteIpAddress!.MapToIPv4().ToString();
            var userInfo = new UserInfoDTO()
            {
                Ip = ip,
                UserAgent = Request.Headers.UserAgent.ToString(),
                Path = Request.Path,
            };

            return Ok(userInfo);
        }

        [HttpGet]
        [Route("server")]
        public IActionResult GetServerInfo()
        {


            var serverInfo = new ServerInfoDTO()
            {
                ServerName = "IIS EXPRESS",
                Language = "C#",
                Framework = "ASP.Net Core 8.0"
            };
            return Ok(serverInfo);
        }

        [HttpGet]
        [Route("database")]
        public IActionResult GetDataBaseInfo()
        {
            var db = new DataBaseDTO()
            {
                Name = "Postgres",
                Version = 16
            };
            return Ok(db);
        }
    }
}
using Clarivate.com.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clarivate.com.Controllers
{
    [Route("api/[controller]/HealthCheck")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/<HealthCheckController>
        [HttpGet]
        public void GetHealthCheck()
        {
            SampleHealthCheck sampleHealthCheck = new SampleHealthCheck();
            HealthCheckContext healthCheckContext = new HealthCheckContext();
           sampleHealthCheck.CheckHealthAsync(healthCheckContext);
           

        }
    }
}

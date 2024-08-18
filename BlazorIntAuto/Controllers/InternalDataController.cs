using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorIntAuto.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class InternalDataController : ControllerBase
    {
        [Authorize]
        [HttpGet(nameof(GetData))]
        public IEnumerable<int> GetData()
        {
            return Enumerable.Range(1, 5).Select(index =>
                Random.Shared.Next(1, 100))
                .ToArray();
        }
    }
}

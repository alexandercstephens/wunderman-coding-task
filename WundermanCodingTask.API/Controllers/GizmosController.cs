using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WundermanCodingTask.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GizmosController : ControllerBase
    {
        private readonly IGizmoRepository _repository;

        public GizmosController(IGizmoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Gizmo> Get()
        {
            return _repository.All();
        }
    }
}

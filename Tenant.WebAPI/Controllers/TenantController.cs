using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Tenant.WebAPI.Controllers
{
    [ApiController]
    [Route("api/tenant")]
    public class TenantController : Controller
    {
        private readonly ILogger<TenantController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TenantController(
            ILogger<TenantController> logger,
            IMediator mediator,
            IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Add Tenant By sysAdmin
        /// </summary>
        //[Authorize]
        //[HttpPost("add-new-tenant-by-admin")]
        //public async Task<IActionResult> Add(AddTenantDto dto, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        //var command = _mapper.Map<AddRoleCommand>(addRoleDto);
        //        var roleId = await _mediator.Send(dto, cancellationToken);
        //        return Ok(roleId);
        //    }
        //    catch (AlreadyExistRoleForThisTenantException ex)
        //    {
        //        return BadRequest(new { ex.Message });
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}

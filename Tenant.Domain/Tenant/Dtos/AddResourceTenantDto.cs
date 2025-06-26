using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tenant.Domain.Tenant.Dtos
{
    public class AddResourceTenantDto
    {
        public ResourceType Type { get; set; }
        public string Name { get; set; }
    }
}

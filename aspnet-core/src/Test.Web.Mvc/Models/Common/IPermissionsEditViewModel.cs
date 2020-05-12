using System.Collections.Generic;
using Test.Roles.Dto;

namespace Test.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
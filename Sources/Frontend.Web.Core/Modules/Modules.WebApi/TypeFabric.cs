﻿using Libraries.Core.Backend.Common;
using Libraries.Core.Backend.WebApi.Repositories;
using Microsoft.Practices.Unity;
using Modules.WebApi.Identity;


namespace Modules.WebApi
{
    public class TypeFabric:BaseTypeFabric
    {
        public override void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IVersionRepository, VersionRepository>();
            container.RegisterType<IIdentityApiRepository, IdentityApiRepository>();
            container.RegisterType<IIdentityApiController, IdentityApiController>();
        }
    }
}

using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;

namespace RestoAddicted
{
    public class RestoAddictedApplicationModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(RestoAddictedCoreModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

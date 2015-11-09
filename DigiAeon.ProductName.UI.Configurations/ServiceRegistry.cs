namespace DigiAeon.ProductName.UI.Configurations
{
    using DigiAeon.ProductName.Services;

    using StructureMap.Configuration.DSL;

    /// <summary>
    /// The rule with service registry.
    /// </summary>
    public class ServiceRegistry : Registry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRegistry"/> class.
        /// </summary>
        public ServiceRegistry()
        {
            // Since WCF ServiceHost only supports class service types
            this.For<WcfTestService>().Use(() => new WcfTestService(Config.UserToken));
        }
    }
}

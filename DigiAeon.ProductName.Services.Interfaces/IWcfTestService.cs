namespace DigiAeon.ProductName.Services.Interfaces
{
    using System;
    using System.ServiceModel;

    /// <summary>
    /// The WCF Test Service interface.
    /// </summary>
    [ServiceContract]
    public interface IWcfTestService
    {
        /// <summary>
        /// The user token from config.
        /// </summary>
        /// <returns>
        /// The <see cref="Guid"/>.
        /// </returns>
        [OperationContract]
        Guid UserTokenFromConfig();
    }
}

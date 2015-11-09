namespace DigiAeon.ProductName.Services
{
    using System;
    using System.ServiceModel;

    using DigiAeon.ProductName.Services.Interfaces;

    /// <summary>
    /// The WCF test service.
    /// </summary>
    [ServiceBehavior]
    public class WcfTestService : IWcfTestService
    {
        /// <summary>
        /// The _user token.
        /// </summary>
        private readonly Guid _userToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfTestService"/> class.
        /// </summary>
        /// <param name="userToken">
        /// The user token.
        /// </param>
        public WcfTestService(Guid userToken)
        {
            this._userToken = userToken;
        }

        /// <summary>
        /// The user token from config.
        /// </summary>
        /// <returns>
        /// The <see cref="Guid"/>.
        /// </returns>
        public Guid UserTokenFromConfig()
        {
            return this._userToken;
        }
    }
}

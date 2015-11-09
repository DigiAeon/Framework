namespace DigiAeon.ProductName.UI.Configurations
{
    using System;
    using System.Configuration;

    /// <summary>
    /// The configuration.
    /// </summary>
    internal class Config
    {
        /// <summary>
        /// Gets the user token.
        /// </summary>
        public static Guid UserToken
        {
            get
            {
                return new Guid(ConfigurationManager.AppSettings["UserToken"]);
            }
        }
    }
}
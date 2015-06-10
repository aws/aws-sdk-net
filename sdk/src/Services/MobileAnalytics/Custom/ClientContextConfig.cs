using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.MobileAnalytics
{
    public class ClientContextConfig
    {
        private string _clientId = "";
        private string _appTitle = "";
        private string _appVersionName = "";
        private string _appVersionCode = "";
        private string _appPackageName = "";
        private string _appId = "";

        /// <summary>
        /// Initializes a new instance of the ClientContextConfig class.
        /// </summary>
        /// <param name="clientId">Client ID - A unique identifier representing this installation instance of your app.</param>
        /// <param name="appTitle">App title - The title of your app. For example, My App.</param>
        /// <param name="appId">App identifier - AWS Mobile Analytics App ID corresponding to your App</param>
        public ClientContextConfig(string clientId, string appTitle, string appId)
        {

            if (string.IsNullOrEmpty(clientId))
            {
                throw new ArgumentNullException("clientId");
            }

            if (string.IsNullOrEmpty(appTitle))
            {
                throw new ArgumentNullException("appTitle");
            }

            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException("appId");
            }

            this._clientId = clientId;
            this._appTitle = appTitle;
            this._appId = appId;
        }

        /// <summary>
        /// Initializes a new instance of the ClientContextConfig class.
        /// </summary>
        /// <param name="clientId">Client ID - A unique identifier representing this installation instance of your app.</param>
        /// <param name="appTitle">App title - The title of your app. For example, My App.</param>
        /// <param name="appVersionName">App version name - The version of your app. For example, V2.0.</param>
        /// <param name="appVersionCode">App version code - The version code for your app. For example, 3.</param>
        /// <param name="appPackageName">App package name - The name of your package. For example, com.example.my_app.</param>
        /// <param name="appId">App identifier - AWS Mobile Analytics App ID corresponding to your App</param>
        public ClientContextConfig(string clientId, string appTitle, string appVersionName, string appVersionCode, string appPackageName, string appId)
        {

            if (string.IsNullOrEmpty(_clientId))
            {
                throw new ArgumentNullException("clientId");
            }

            if (string.IsNullOrEmpty(appTitle))
            {
                throw new ArgumentNullException("appTitle");
            }

            if (string.IsNullOrEmpty(appVersionName))
            {
                throw new ArgumentNullException("appVersionName");
            }

            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException("appId");
            }

            if (string.IsNullOrEmpty(appPackageName))
            {
                throw new ArgumentNullException("appPackageName");
            }

            if (string.IsNullOrEmpty(appVersionCode))
            {
                throw new ArgumentNullException("appVersionCode");
            }

            this._clientId = clientId;
            this._appTitle = appTitle;
            this._appVersionName = appVersionName;
            this._appVersionCode = appVersionCode;
            this._appPackageName = appPackageName;
            this._appId = appId;
        }

        /// <summary>
        /// A unique identifier representing this installation instance of your app.
        /// </summary>
        /// <value>The client identifier.</value>
        public string ClientId { get { return _clientId; } }

        /// <summary>
        /// The title of your app. For example, My App.
        /// </summary>
        /// <value>The app title.</value>
        public string AppTitle { get { return _appTitle; } }

        /// <summary>
        /// The version of your app. For example, V2.0.
        /// </summary>
        /// <value>The name of the app version.</value>
        public string AppVersionName { get { return _appVersionName; } }

        /// <summary>
        /// The version code for your app. For example, 3.
        /// </summary>
        /// <value>The app version code.</value>
        public string AppVersionCode { get { return _appVersionCode; } }

        /// <summary>
        /// The name of your package. For example, com.example.my_app.
        /// </summary>
        /// <value>The name of the app package.</value>
        public string AppPackageName { get { return _appPackageName; } }

        /// <summary>
        /// Gets the app identifier. This is same as the Mobile Analytics App Id when you create the APP on the AWS
        /// Mobile Analytics Console.
        /// </summary>
        /// <value>The app identifier.</value>
        public string AppId { get { return _appId; } }
    }
}

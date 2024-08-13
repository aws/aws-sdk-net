/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required when using SAPOData.
    /// </summary>
    public partial class SAPODataConnectorProfileProperties
    {
        private string _applicationHostUrl;
        private string _applicationServicePath;
        private string _clientNumber;
        private bool? _disablesso;
        private string _logonLanguage;
        private OAuthProperties _oAuthProperties;
        private int? _portNumber;
        private string _privateLinkServiceName;

        /// <summary>
        /// Gets and sets the property ApplicationHostUrl. 
        /// <para>
        ///  The location of the SAPOData resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ApplicationHostUrl
        {
            get { return this._applicationHostUrl; }
            set { this._applicationHostUrl = value; }
        }

        // Check to see if ApplicationHostUrl property is set
        internal bool IsSetApplicationHostUrl()
        {
            return this._applicationHostUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationServicePath. 
        /// <para>
        ///  The application path to catalog service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string ApplicationServicePath
        {
            get { return this._applicationServicePath; }
            set { this._applicationServicePath = value; }
        }

        // Check to see if ApplicationServicePath property is set
        internal bool IsSetApplicationServicePath()
        {
            return this._applicationServicePath != null;
        }

        /// <summary>
        /// Gets and sets the property ClientNumber. 
        /// <para>
        ///  The client number for the client creating the connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
        public string ClientNumber
        {
            get { return this._clientNumber; }
            set { this._clientNumber = value; }
        }

        // Check to see if ClientNumber property is set
        internal bool IsSetClientNumber()
        {
            return this._clientNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DisableSSO. 
        /// <para>
        /// If you set this parameter to <c>true</c>, Amazon AppFlow bypasses the single sign-on
        /// (SSO) settings in your SAP account when it accesses your SAP OData instance.
        /// </para>
        ///  
        /// <para>
        /// Whether you need this option depends on the types of credentials that you applied
        /// to your SAP OData connection profile. If your profile uses basic authentication credentials,
        /// SAP SSO can prevent Amazon AppFlow from connecting to your account with your username
        /// and password. In this case, bypassing SSO makes it possible for Amazon AppFlow to
        /// connect successfully. However, if your profile uses OAuth credentials, this parameter
        /// has no affect.
        /// </para>
        /// </summary>
        public bool? DisableSSO
        {
            get { return this._disablesso; }
            set { this._disablesso = value; }
        }

        // Check to see if DisableSSO property is set
        internal bool IsSetDisableSSO()
        {
            return this._disablesso.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogonLanguage. 
        /// <para>
        ///  The logon language of SAPOData instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public string LogonLanguage
        {
            get { return this._logonLanguage; }
            set { this._logonLanguage = value; }
        }

        // Check to see if LogonLanguage property is set
        internal bool IsSetLogonLanguage()
        {
            return this._logonLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthProperties. 
        /// <para>
        ///  The SAPOData OAuth properties required for OAuth type authentication. 
        /// </para>
        /// </summary>
        public OAuthProperties OAuthProperties
        {
            get { return this._oAuthProperties; }
            set { this._oAuthProperties = value; }
        }

        // Check to see if OAuthProperties property is set
        internal bool IsSetOAuthProperties()
        {
            return this._oAuthProperties != null;
        }

        /// <summary>
        /// Gets and sets the property PortNumber. 
        /// <para>
        ///  The port number of the SAPOData instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? PortNumber
        {
            get { return this._portNumber; }
            set { this._portNumber = value; }
        }

        // Check to see if PortNumber property is set
        internal bool IsSetPortNumber()
        {
            return this._portNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateLinkServiceName. 
        /// <para>
        ///  The SAPOData Private Link service name to be used for private data transfers. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string PrivateLinkServiceName
        {
            get { return this._privateLinkServiceName; }
            set { this._privateLinkServiceName = value; }
        }

        // Check to see if PrivateLinkServiceName property is set
        internal bool IsSetPrivateLinkServiceName()
        {
            return this._privateLinkServiceName != null;
        }

    }
}
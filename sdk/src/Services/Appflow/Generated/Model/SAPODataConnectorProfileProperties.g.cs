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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApplicationHostUrl. 
        /// <para>
        ///  The location of the SAPOData resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ApplicationHostUrl { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationHostUrl property is set.
        /// </summary>
        internal bool IsSetApplicationHostUrl() => this.ApplicationHostUrl != null;

        /// <summary>
        /// Gets and sets the property ApplicationServicePath. 
        /// <para>
        ///  The application path to catalog service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string ApplicationServicePath { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationServicePath property is set.
        /// </summary>
        internal bool IsSetApplicationServicePath() => this.ApplicationServicePath != null;

        /// <summary>
        /// Gets and sets the property ClientNumber. 
        /// <para>
        ///  The client number for the client creating the connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 3)]
        public string ClientNumber { get; set; }

        /// <summary>
        /// Checks to see if the ClientNumber property is set.
        /// </summary>
        internal bool IsSetClientNumber() => this.ClientNumber != null;

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
        public bool? DisableSSO { get; set; }

        /// <summary>
        /// Checks to see if the DisableSSO property is set.
        /// </summary>
        internal bool IsSetDisableSSO() => this.DisableSSO.HasValue;

        /// <summary>
        /// Gets and sets the property LogonLanguage. 
        /// <para>
        ///  The logon language of SAPOData instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public string LogonLanguage { get; set; }

        /// <summary>
        /// Checks to see if the LogonLanguage property is set.
        /// </summary>
        internal bool IsSetLogonLanguage() => this.LogonLanguage != null;

        /// <summary>
        /// Gets and sets the property OAuthProperties. 
        /// <para>
        ///  The SAPOData OAuth properties required for OAuth type authentication. 
        /// </para>
        /// </summary>
        public OAuthProperties OAuthProperties { get; set; }

        /// <summary>
        /// Checks to see if the OAuthProperties property is set.
        /// </summary>
        internal bool IsSetOAuthProperties() => this.OAuthProperties != null;

        /// <summary>
        /// Gets and sets the property PortNumber. 
        /// <para>
        ///  The port number of the SAPOData instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? PortNumber { get; set; }

        /// <summary>
        /// Checks to see if the PortNumber property is set.
        /// </summary>
        internal bool IsSetPortNumber() => this.PortNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateLinkServiceName. 
        /// <para>
        ///  The SAPOData Private Link service name to be used for private data transfers. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string PrivateLinkServiceName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateLinkServiceName property is set.
        /// </summary>
        internal bool IsSetPrivateLinkServiceName() => this.PrivateLinkServiceName != null;
    }
}

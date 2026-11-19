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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// The configuration of a connector to Microsoft Azure.
    /// </summary>
    public partial class AzureConnectorConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClientIdentifier. 
        /// <para>
        /// The application (client) ID of the Azure app registration. The app registration must
        /// have a federated identity credential that trusts the Amazon Web Services OpenID Connect
        /// (OIDC) issuer for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ClientIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClientIdentifier property is set.
        /// </summary>
        internal bool IsSetClientIdentifier() => this.ClientIdentifier != null;

        /// <summary>
        /// Gets and sets the property TenantIdentifier. 
        /// <para>
        /// The ID of the Microsoft Entra ID tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string TenantIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TenantIdentifier property is set.
        /// </summary>
        internal bool IsSetTenantIdentifier() => this.TenantIdentifier != null;
    }
}

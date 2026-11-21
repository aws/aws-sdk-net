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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration for an external OpenID Connect IdP that uses the authorization code
    /// flow with a confidential client. Client secret values are never included.
    /// </summary>
    public partial class ExternalIdpConfidentialAuthCodeAuthorizingConfig
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth 2.0 client ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecrets. 
        /// <para>
        /// The client secrets of the confidential client, with the Amazon Web Services Secrets
        /// Manager ARN for each Region. Secret values are never included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<ExternalIdpConfidentialClientSecret> ClientSecrets { get; set; } = AWSConfigs.InitializeCollections ? new List<ExternalIdpConfidentialClientSecret>() : null;

        /// <summary>
        /// Checks to see if the ClientSecrets property is set.
        /// </summary>
        internal bool IsSetClientSecrets() => this.ClientSecrets != null && (this.ClientSecrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The issuer URL of the external OpenID Connect IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Checks to see if the IssuerUrl property is set.
        /// </summary>
        internal bool IsSetIssuerUrl() => this.IssuerUrl != null;
    }
}

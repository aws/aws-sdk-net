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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Contains details about a network endpoint for a Remote Desktop Services (RDS) license
    /// server.
    /// </summary>
    public partial class LicenseServerEndpoint
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when License Manager created the license server endpoint.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity provider that's associated with the
        /// RDS license server endpoint.
        /// </para>
        /// </summary>
        public string IdentityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderArn property is set.
        /// </summary>
        internal bool IsSetIdentityProviderArn() => this.IdentityProviderArn != null;

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointArn. 
        /// <para>
        /// The ARN of the <c>ServerEndpoint</c> resource for the RDS license server.
        /// </para>
        /// </summary>
        public string LicenseServerEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseServerEndpointArn property is set.
        /// </summary>
        internal bool IsSetLicenseServerEndpointArn() => this.LicenseServerEndpointArn != null;

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointId. 
        /// <para>
        /// The ID of the license server endpoint.
        /// </para>
        /// </summary>
        public string LicenseServerEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the LicenseServerEndpointId property is set.
        /// </summary>
        internal bool IsSetLicenseServerEndpointId() => this.LicenseServerEndpointId != null;

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointProvisioningStatus. 
        /// <para>
        /// The current state of the provisioning process for the RDS license server endpoint
        /// </para>
        /// </summary>
        public LicenseServerEndpointProvisioningStatus LicenseServerEndpointProvisioningStatus { get; set; }

        /// <summary>
        /// Checks to see if the LicenseServerEndpointProvisioningStatus property is set.
        /// </summary>
        internal bool IsSetLicenseServerEndpointProvisioningStatus() => this.LicenseServerEndpointProvisioningStatus != null;

        /// <summary>
        /// Gets and sets the property LicenseServers. 
        /// <para>
        /// An array of <c>LicenseServer</c> resources that represent the license servers that
        /// are accessed through this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseServer> LicenseServers { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseServer>() : null;

        /// <summary>
        /// Checks to see if the LicenseServers property is set.
        /// </summary>
        internal bool IsSetLicenseServers() => this.LicenseServers != null && (this.LicenseServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServerEndpoint. 
        /// <para>
        /// The <c>ServerEndpoint</c> resource contains the network address of the RDS license
        /// server endpoint.
        /// </para>
        /// </summary>
        public ServerEndpoint ServerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ServerEndpoint property is set.
        /// </summary>
        internal bool IsSetServerEndpoint() => this.ServerEndpoint != null;

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        /// The type of license server.
        /// </para>
        /// </summary>
        public ServerType ServerType { get; set; }

        /// <summary>
        /// Checks to see if the ServerType property is set.
        /// </summary>
        internal bool IsSetServerType() => this.ServerType != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The message associated with the provisioning status, if there is one.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}

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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
        private DateTime? _creationTime;
        private string _identityProviderArn;
        private string _licenseServerEndpointArn;
        private string _licenseServerEndpointId;
        private LicenseServerEndpointProvisioningStatus _licenseServerEndpointProvisioningStatus;
        private List<LicenseServer> _licenseServers = AWSConfigs.InitializeCollections ? new List<LicenseServer>() : null;
        private ServerEndpoint _serverEndpoint;
        private ServerType _serverType;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when License Manager created the license server endpoint.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity provider that's associated with the
        /// RDS license server endpoint.
        /// </para>
        /// </summary>
        public string IdentityProviderArn
        {
            get { return this._identityProviderArn; }
            set { this._identityProviderArn = value; }
        }

        // Check to see if IdentityProviderArn property is set
        internal bool IsSetIdentityProviderArn()
        {
            return this._identityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointArn. 
        /// <para>
        /// The ARN of the <c>ServerEndpoint</c> resource for the RDS license server.
        /// </para>
        /// </summary>
        public string LicenseServerEndpointArn
        {
            get { return this._licenseServerEndpointArn; }
            set { this._licenseServerEndpointArn = value; }
        }

        // Check to see if LicenseServerEndpointArn property is set
        internal bool IsSetLicenseServerEndpointArn()
        {
            return this._licenseServerEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointId. 
        /// <para>
        /// The ID of the license server endpoint.
        /// </para>
        /// </summary>
        public string LicenseServerEndpointId
        {
            get { return this._licenseServerEndpointId; }
            set { this._licenseServerEndpointId = value; }
        }

        // Check to see if LicenseServerEndpointId property is set
        internal bool IsSetLicenseServerEndpointId()
        {
            return this._licenseServerEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointProvisioningStatus. 
        /// <para>
        /// The current state of the provisioning process for the RDS license server endpoint
        /// </para>
        /// </summary>
        public LicenseServerEndpointProvisioningStatus LicenseServerEndpointProvisioningStatus
        {
            get { return this._licenseServerEndpointProvisioningStatus; }
            set { this._licenseServerEndpointProvisioningStatus = value; }
        }

        // Check to see if LicenseServerEndpointProvisioningStatus property is set
        internal bool IsSetLicenseServerEndpointProvisioningStatus()
        {
            return this._licenseServerEndpointProvisioningStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServers. 
        /// <para>
        /// An array of <c>LicenseServer</c> resources that represent the license servers that
        /// are accessed through this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseServer> LicenseServers
        {
            get { return this._licenseServers; }
            set { this._licenseServers = value; }
        }

        // Check to see if LicenseServers property is set
        internal bool IsSetLicenseServers()
        {
            return this._licenseServers != null && (this._licenseServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerEndpoint. 
        /// <para>
        /// The <c>ServerEndpoint</c> resource contains the network address of the RDS license
        /// server endpoint.
        /// </para>
        /// </summary>
        public ServerEndpoint ServerEndpoint
        {
            get { return this._serverEndpoint; }
            set { this._serverEndpoint = value; }
        }

        // Check to see if ServerEndpoint property is set
        internal bool IsSetServerEndpoint()
        {
            return this._serverEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        /// The type of license server.
        /// </para>
        /// </summary>
        public ServerType ServerType
        {
            get { return this._serverType; }
            set { this._serverType = value; }
        }

        // Check to see if ServerType property is set
        internal bool IsSetServerType()
        {
            return this._serverType != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The message associated with the provisioning status, if there is one.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}
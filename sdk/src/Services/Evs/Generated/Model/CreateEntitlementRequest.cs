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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEntitlement operation.
    /// Creates a Windows Server License entitlement for virtual machines in an Amazon EVS
    /// environment using the provided vCenter Server connector. This is an asynchronous operation.
    /// Amazon EVS validates the specified virtual machines before starting usage tracking.
    /// </summary>
    public partial class CreateEntitlementRequest : AmazonEvsRequest
    {
        private string _clientToken;
        private string _connectorId;
        private EntitlementType _entitlementType;
        private string _environmentId;
        private List<string> _vmIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// <note> 
        /// <para>
        /// This parameter is not used in Amazon EVS currently. If you supply input for this parameter,
        /// it will have no effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the entitlement creation request. If you do not specify a client token, a randomly
        /// generated token is used for the request to ensure idempotency.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// A unique ID for the connector associated with the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementType. 
        /// <para>
        /// The type of entitlement to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntitlementType EntitlementType
        {
            get { return this._entitlementType; }
            set { this._entitlementType = value; }
        }

        // Check to see if EntitlementType property is set
        internal bool IsSetEntitlementType()
        {
            return this._entitlementType != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment to create the entitlement in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property VmIds. 
        /// <para>
        /// The list of VMware vSphere virtual machine managed object IDs to create entitlements
        /// for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> VmIds
        {
            get { return this._vmIds; }
            set { this._vmIds = value; }
        }

        // Check to see if VmIds property is set
        internal bool IsSetVmIds()
        {
            return this._vmIds != null && (this._vmIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
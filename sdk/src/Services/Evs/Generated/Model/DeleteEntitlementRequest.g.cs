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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEntitlement operation. Deletes a Windows
    /// Server License entitlement for virtual machines in an Amazon EVS environment. Deleting
    /// an entitlement stops usage tracking for the specified virtual machines.
    /// </summary>
    public partial class DeleteEntitlementRequest : AmazonEvsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. <note> 
        /// <para>
        /// This parameter is not used in Amazon EVS currently. If you supply input for this parameter,
        /// it will have no effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the entitlement deletion request. If you do not specify a client token, a randomly
        /// generated token is used for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// A unique ID for the connector associated with the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property EntitlementType. 
        /// <para>
        /// The type of entitlement to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntitlementType EntitlementType { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementType property is set.
        /// </summary>
        internal bool IsSetEntitlementType() => this.EntitlementType != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment that the entitlement belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property VmIds. 
        /// <para>
        /// The list of VMware vSphere virtual machine managed object IDs to delete entitlements
        /// for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> VmIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VmIds property is set.
        /// </summary>
        internal bool IsSetVmIds() => this.VmIds != null && (this.VmIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

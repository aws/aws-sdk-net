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
    /// Updates the registered identity provider’s product related configuration settings
    /// such as the subnets to provision VPC endpoints.
    /// </summary>
    public partial class UpdateSettings
    {
        /// <summary>
        /// Gets and sets the property AddSubnets. 
        /// <para>
        /// The ID of one or more subnets in which License Manager will create a VPC endpoint
        /// for products that require connectivity to activation servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AddSubnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddSubnets property is set.
        /// </summary>
        internal bool IsSetAddSubnets() => this.AddSubnets != null && (this.AddSubnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveSubnets. 
        /// <para>
        /// The ID of one or more subnets to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> RemoveSubnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveSubnets property is set.
        /// </summary>
        internal bool IsSetRemoveSubnets() => this.RemoveSubnets != null && (this.RemoveSubnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// A security group ID that allows inbound TCP port 1688 communication between resources
        /// in your VPC and the VPC endpoints for activation servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupId() => this.SecurityGroupId != null;
    }
}

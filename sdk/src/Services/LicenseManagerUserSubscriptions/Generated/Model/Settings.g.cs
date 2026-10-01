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
    /// The registered identity provider’s product related configuration settings such as
    /// the subnets to provision VPC endpoints, and the security group ID that is associated
    /// with the VPC endpoints. The security group should permit inbound TCP port 1688 communication
    /// from resources in the VPC.
    /// </summary>
    public partial class Settings
    {
        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// A security group ID that allows inbound TCP port 1688 communication between resources
        /// in your VPC and the VPC endpoint for activation servers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 200)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupId() => this.SecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The subnets defined for the registered identity provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Subnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subnets property is set.
        /// </summary>
        internal bool IsSetSubnets() => this.Subnets != null && (this.Subnets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

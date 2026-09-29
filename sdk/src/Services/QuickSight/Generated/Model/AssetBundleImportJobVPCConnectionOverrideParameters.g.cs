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
    /// The override parameters for a single VPC connection that is imported.
    /// </summary>
    public partial class AssetBundleImportJobVPCConnectionOverrideParameters
    {
        /// <summary>
        /// Gets and sets the property DnsResolvers. 
        /// <para>
        /// An optional override of DNS resolvers to be used by the VPC connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public List<string> DnsResolvers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsResolvers property is set.
        /// </summary>
        internal bool IsSetDnsResolvers() => this.DnsResolvers != null && (this.DnsResolvers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the VPC connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An optional override of the role ARN to be used by the VPC connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A new security group ID for the VPC connection you are importing. This field is required
        /// if you are importing the VPC connection from another Amazon Web Services account or
        /// Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of new subnet IDs for the VPC connection you are importing. This field is required
        /// if you are importing the VPC connection from another Amazon Web Services account or
        /// Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 15)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCConnectionId. 
        /// <para>
        /// The ID of the VPC Connection to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string VPCConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VPCConnectionId property is set.
        /// </summary>
        internal bool IsSetVPCConnectionId() => this.VPCConnectionId != null;
    }
}

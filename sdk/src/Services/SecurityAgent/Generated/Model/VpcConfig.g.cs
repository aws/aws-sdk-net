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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The VPC configuration for a pentest, specifying the VPC, security groups, and subnets
    /// to use during testing.
    /// </summary>
    public partial class VpcConfig
    {
        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the security groups for the VPC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupArns property is set.
        /// </summary>
        internal bool IsSetSecurityGroupArns() => this.SecurityGroupArns != null && (this.SecurityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the subnets for the VPC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetArns property is set.
        /// </summary>
        internal bool IsSetSubnetArns() => this.SubnetArns != null && (this.SubnetArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC.
        /// </para>
        /// </summary>
        public string VpcArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcArn property is set.
        /// </summary>
        internal bool IsSetVpcArn() => this.VpcArn != null;
    }
}

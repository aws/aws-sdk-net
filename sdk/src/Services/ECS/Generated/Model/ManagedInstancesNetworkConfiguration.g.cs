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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The network configuration for Amazon ECS Managed Instances. This specifies the VPC
    /// subnets and security groups that instances use for network connectivity. Amazon ECS
    /// Managed Instances support multiple network modes including <c>awsvpc</c> (instances
    /// receive ENIs for task isolation), <c>host</c> (instances share network namespace with
    /// tasks), and <c>none</c> (no external network connectivity), ensuring backward compatibility
    /// for migrating workloads from Fargate or Amazon EC2.
    /// </summary>
    public partial class ManagedInstancesNetworkConfiguration
    {
        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The list of security group IDs to apply to Amazon ECS Managed Instances. These security
        /// groups control the network traffic allowed to and from the instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The list of subnet IDs where Amazon ECS can launch Amazon ECS Managed Instances. Instances
        /// are distributed across the specified subnets for high availability. All subnets must
        /// be in the same VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subnets property is set.
        /// </summary>
        internal bool IsSetSubnets() => this.Subnets != null && (this.Subnets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

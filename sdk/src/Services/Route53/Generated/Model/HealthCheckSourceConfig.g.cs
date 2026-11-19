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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the virtual private cloud (VPC), subnets, and security
    /// groups for a health check source. You can't change these values after you create the
    /// source.
    /// </summary>
    public partial class HealthCheckSourceConfig
    {
        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC) that contains the subnets for the health
        /// check source. All subnets in <c>SubnetConfigurationList</c> must belong to this VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property SubnetConfigurationList. 
        /// <para>
        /// A complex type that contains two or three <c>SubnetConfiguration</c> elements, one
        /// in each Availability Zone that Route 53 uses for private endpoint health checks in
        /// the Amazon Web Services Region. The Availability Zones must be distinct. Route 53
        /// creates network interfaces in each subnet and sends health check requests from all
        /// of them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 3)]
        public List<SubnetConfiguration> SubnetConfigurationList { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SubnetConfigurationList property is set.
        /// </summary>
        internal bool IsSetSubnetConfigurationList() => this.SubnetConfigurationList != null && (this.SubnetConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

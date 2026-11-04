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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBProxyEndpoint operation. Creates a <c>DBProxyEndpoint</c>.
    /// Only applies to proxies that are associated with Aurora DB clusters. You can use DB
    /// proxy endpoints to specify read/write or read-only access to the DB cluster. You can
    /// also use DB proxy endpoints to access a DB proxy through a different VPC than the
    /// proxy's default VPC.
    /// </summary>
    public partial class CreateDBProxyEndpointRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBProxyEndpointName. 
        /// <para>
        /// The name of the DB proxy endpoint to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DBProxyEndpointName { get; set; }

        /// <summary>
        /// Checks to see if the DBProxyEndpointName property is set.
        /// </summary>
        internal bool IsSetDBProxyEndpointName() => this.DBProxyEndpointName != null;

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The name of the DB proxy associated with the DB proxy endpoint that you create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DBProxyName { get; set; }

        /// <summary>
        /// Checks to see if the DBProxyName property is set.
        /// </summary>
        internal bool IsSetDBProxyName() => this.DBProxyName != null;

        /// <summary>
        /// Gets and sets the property EndpointNetworkType. 
        /// <para>
        /// The network type of the DB proxy endpoint. The network type determines the IP version
        /// that the proxy endpoint supports.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> - The proxy endpoint supports IPv4 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IPV6</c> - The proxy endpoint supports IPv6 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> - The proxy endpoint supports both IPv4 and IPv6.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>IPV4</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>IPV6</c> or <c>DUAL</c>, the VPC and all subnets must have an IPv6
        /// CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>IPV6</c> or <c>DUAL</c>, the VPC tenancy cannot be <c>dedicated</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndpointNetworkType EndpointNetworkType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointNetworkType property is set.
        /// </summary>
        internal bool IsSetEndpointNetworkType() => this.EndpointNetworkType != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetRole. 
        /// <para>
        /// The role of the DB proxy endpoint. The role determines whether the endpoint can be
        /// used for read/write or only read operations. The default is <c>READ_WRITE</c>. The
        /// only role that proxies for RDS for Microsoft SQL Server support is <c>READ_WRITE</c>.
        /// </para>
        /// </summary>
        public DBProxyEndpointTargetRole TargetRole { get; set; }

        /// <summary>
        /// Checks to see if the TargetRole property is set.
        /// </summary>
        internal bool IsSetTargetRole() => this.TargetRole != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs for the DB proxy endpoint that you create. You can specify
        /// a different set of security group IDs than for the original DB proxy. The default
        /// is the default security group for the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// The VPC subnet IDs for the DB proxy endpoint that you create. You can specify a different
        /// set of subnet IDs than for the original DB proxy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> VpcSubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSubnetIds property is set.
        /// </summary>
        internal bool IsSetVpcSubnetIds() => this.VpcSubnetIds != null && (this.VpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

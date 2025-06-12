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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of one of the following operations:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateCacheSubnetGroup</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModifyCacheSubnetGroup</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CacheSubnetGroup
    {
        private string _arn;
        private string _cacheSubnetGroupDescription;
        private string _cacheSubnetGroupName;
        private List<Subnet> _subnets = AWSConfigs.InitializeCollections ? new List<Subnet>() : null;
        private List<string> _supportedNetworkTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the cache subnet group.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CacheSubnetGroupDescription. 
        /// <para>
        /// The description of the cache subnet group.
        /// </para>
        /// </summary>
        public string CacheSubnetGroupDescription
        {
            get { return this._cacheSubnetGroupDescription; }
            set { this._cacheSubnetGroupDescription = value; }
        }

        // Check to see if CacheSubnetGroupDescription property is set
        internal bool IsSetCacheSubnetGroupDescription()
        {
            return this._cacheSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// The name of the cache subnet group.
        /// </para>
        /// </summary>
        public string CacheSubnetGroupName
        {
            get { return this._cacheSubnetGroupName; }
            set { this._cacheSubnetGroupName = value; }
        }

        // Check to see if CacheSubnetGroupName property is set
        internal bool IsSetCacheSubnetGroupName()
        {
            return this._cacheSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// A list of subnets associated with the cache subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// Either <c>ipv4</c> | <c>ipv6</c> | <c>dual_stack</c>. IPv6 is supported for workloads
        /// using Valkey 7.2 and above, Redis OSS engine version 6.2 to 7.1 or Memcached engine
        /// version 1.6.6 and above on all instances built on the <a href="http://aws.amazon.com/ec2/nitro/">Nitro
        /// system</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes
        {
            get { return this._supportedNetworkTypes; }
            set { this._supportedNetworkTypes = value; }
        }

        // Check to see if SupportedNetworkTypes property is set
        internal bool IsSetSupportedNetworkTypes()
        {
            return this._supportedNetworkTypes != null && (this._supportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The Amazon Virtual Private Cloud identifier (VPC ID) of the cache subnet group.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}
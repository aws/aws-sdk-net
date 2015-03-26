/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of one of the following actions:
    /// 
    ///  <ul> <li> <i>CreateCacheSubnetGroup</i> </li> <li> <i>ModifyCacheSubnetGroup</i>
    /// </li> </ul>
    /// </summary>
    public partial class CacheSubnetGroup
    {
        private string _cacheSubnetGroupDescription;
        private string _cacheSubnetGroupName;
        private List<Subnet> _subnets = new List<Subnet>();
        private string _vpcId;

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
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
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
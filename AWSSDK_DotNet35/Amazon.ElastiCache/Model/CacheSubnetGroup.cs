/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the output of one of the following operations:</para>
    /// <ul>
    /// <li> <i>CreateCacheSubnetGroup</i> </li>
    /// <li> <i>ModifyCacheSubnetGroup</i> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class CacheSubnetGroup : AmazonWebServiceResponse
    {
        
        private string cacheSubnetGroupName;
        private string cacheSubnetGroupDescription;
        private string vpcId;
        private List<Subnet> subnets = new List<Subnet>();


        /// <summary>
        /// The name of the cache subnet group.
        ///  
        /// </summary>
        public string CacheSubnetGroupName
        {
            get { return this.cacheSubnetGroupName; }
            set { this.cacheSubnetGroupName = value; }
        }

        // Check to see if CacheSubnetGroupName property is set
        internal bool IsSetCacheSubnetGroupName()
        {
            return this.cacheSubnetGroupName != null;
        }

        /// <summary>
        /// The description of the cache subnet group.
        ///  
        /// </summary>
        public string CacheSubnetGroupDescription
        {
            get { return this.cacheSubnetGroupDescription; }
            set { this.cacheSubnetGroupDescription = value; }
        }

        // Check to see if CacheSubnetGroupDescription property is set
        internal bool IsSetCacheSubnetGroupDescription()
        {
            return this.cacheSubnetGroupDescription != null;
        }

        /// <summary>
        /// The Amazon Virtual Private Cloud identifier (VPC ID) of the cache subnet group.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// A list of subnets associated with the cache subnet group.
        ///  
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this.subnets; }
            set { this.subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this.subnets.Count > 0;
        }
    }
}

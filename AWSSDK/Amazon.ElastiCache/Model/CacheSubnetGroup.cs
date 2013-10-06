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
    public class CacheSubnetGroup
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

        /// <summary>
        /// Sets the CacheSubnetGroupName property
        /// </summary>
        /// <param name="cacheSubnetGroupName">The value to set for the CacheSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheSubnetGroup WithCacheSubnetGroupName(string cacheSubnetGroupName)
        {
            this.cacheSubnetGroupName = cacheSubnetGroupName;
            return this;
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

        /// <summary>
        /// Sets the CacheSubnetGroupDescription property
        /// </summary>
        /// <param name="cacheSubnetGroupDescription">The value to set for the CacheSubnetGroupDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheSubnetGroup WithCacheSubnetGroupDescription(string cacheSubnetGroupDescription)
        {
            this.cacheSubnetGroupDescription = cacheSubnetGroupDescription;
            return this;
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

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheSubnetGroup WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
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
        /// <summary>
        /// Adds elements to the Subnets collection
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheSubnetGroup WithSubnets(params Subnet[] subnets)
        {
            foreach (Subnet element in subnets)
            {
                this.subnets.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Subnets collection
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheSubnetGroup WithSubnets(IEnumerable<Subnet> subnets)
        {
            foreach (Subnet element in subnets)
            {
                this.subnets.Add(element);
            }

            return this;
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this.subnets.Count > 0;
        }
    }
}

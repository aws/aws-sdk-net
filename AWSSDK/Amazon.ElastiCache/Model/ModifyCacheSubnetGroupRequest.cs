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
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCacheSubnetGroup operation.
    /// <para> Modifies an existing Cache Subnet Group. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheSubnetGroup"/>
    public class ModifyCacheSubnetGroupRequest : AmazonWebServiceRequest
    {
        private string cacheSubnetGroupName;
        private string cacheSubnetGroupDescription;
        private List<string> subnetIds = new List<string>();

        /// <summary>
        /// The name for the Cache Subnet Group. This value is stored as a lowercase string. Constraints: Must contain no more than 255 alphanumeric
        /// characters or hyphens. Example: <c>mysubnetgroup</c>
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
        public ModifyCacheSubnetGroupRequest WithCacheSubnetGroupName(string cacheSubnetGroupName)
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
        /// The description for the Cache Subnet Group.
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
        public ModifyCacheSubnetGroupRequest WithCacheSubnetGroupDescription(string cacheSubnetGroupDescription)
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
        /// The EC2 Subnet IDs for the Cache Subnet Group.
        ///  
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this.subnetIds; }
            set { this.subnetIds = value; }
        }
        /// <summary>
        /// Adds elements to the SubnetIds collection
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        public ModifyCacheSubnetGroupRequest WithSubnetIds(params string[] subnetIds)
        {
            foreach (string element in subnetIds)
            {
                this.subnetIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SubnetIds collection
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        public ModifyCacheSubnetGroupRequest WithSubnetIds(IEnumerable<string> subnetIds)
        {
            foreach (string element in subnetIds)
            {
                this.subnetIds.Add(element);
            }

            return this;
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this.subnetIds.Count > 0;
        }
    }
}
    

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
    /// <para> Defines a set of EC2 Security groups that are allowed to access a Cache Cluster. </para>
    /// </summary>
    public class CacheSecurityGroup
    {
        
        private string ownerId;
        private string cacheSecurityGroupName;
        private string description;
        private List<EC2SecurityGroup> eC2SecurityGroups = new List<EC2SecurityGroup>();

        /// <summary>
        /// Provides the AWS ID of the owner of a specific Cache Security Group.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        /// <summary>
        /// Sets the OwnerId property
        /// </summary>
        /// <param name="ownerId">The value to set for the OwnerId property </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroup WithOwnerId(string ownerId)
        {
            this.ownerId = ownerId;
            return this;
        }
            

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// Specifies the name of the Cache Security Group.
        ///  
        /// </summary>
        public string CacheSecurityGroupName
        {
            get { return this.cacheSecurityGroupName; }
            set { this.cacheSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheSecurityGroupName property
        /// </summary>
        /// <param name="cacheSecurityGroupName">The value to set for the CacheSecurityGroupName property </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroup WithCacheSecurityGroupName(string cacheSecurityGroupName)
        {
            this.cacheSecurityGroupName = cacheSecurityGroupName;
            return this;
        }
            

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this.cacheSecurityGroupName != null;
        }

        /// <summary>
        /// Provides the description of the Cache Security Group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroup WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// Contains a list of <a>EC2SecurityGroup</a> elements.
        ///  
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this.eC2SecurityGroups; }
            set { this.eC2SecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the EC2SecurityGroups collection
        /// </summary>
        /// <param name="eC2SecurityGroups">The values to add to the EC2SecurityGroups collection </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroup WithEC2SecurityGroups(params EC2SecurityGroup[] eC2SecurityGroups)
        {
            foreach (EC2SecurityGroup element in eC2SecurityGroups)
            {
                this.eC2SecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the EC2SecurityGroups collection
        /// </summary>
        /// <param name="eC2SecurityGroups">The values to add to the EC2SecurityGroups collection </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroup WithEC2SecurityGroups(IEnumerable<EC2SecurityGroup> eC2SecurityGroups)
        {
            foreach (EC2SecurityGroup element in eC2SecurityGroups)
            {
                this.eC2SecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this.eC2SecurityGroups.Count > 0;
        }
    }
}

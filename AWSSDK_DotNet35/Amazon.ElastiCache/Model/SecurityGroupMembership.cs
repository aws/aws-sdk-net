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
    /// <para>Represents a single cache security group and its status..</para>
    /// </summary>
    public class SecurityGroupMembership
    {
        
        private string securityGroupId;
        private string status;


        /// <summary>
        /// The identifier of the cache security group.
        ///  
        /// </summary>
        public string SecurityGroupId
        {
            get { return this.securityGroupId; }
            set { this.securityGroupId = value; }
        }

        // Check to see if SecurityGroupId property is set
        internal bool IsSetSecurityGroupId()
        {
            return this.securityGroupId != null;
        }

        /// <summary>
        /// The status of the cache security group membership. The status changes whenever a cache security group is modified, or when the cache
        /// security groups assigned to a cache cluster are modified.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}

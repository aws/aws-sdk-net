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
    /// <para>Represents the output of a <i>DescribeReplicationGroups</i> operation.</para>
    /// </summary>
    public class DescribeReplicationGroupsResult
    {
        
        private string marker;
        private List<ReplicationGroup> replicationGroups = new List<ReplicationGroup>();

        /// <summary>
        /// Provides an identifier to allow retrieval of paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReplicationGroupsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of replication groups. Each item in the list contains detailed information about one replication group.
        ///  
        /// </summary>
        public List<ReplicationGroup> ReplicationGroups
        {
            get { return this.replicationGroups; }
            set { this.replicationGroups = value; }
        }
        /// <summary>
        /// Adds elements to the ReplicationGroups collection
        /// </summary>
        /// <param name="replicationGroups">The values to add to the ReplicationGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReplicationGroupsResult WithReplicationGroups(params ReplicationGroup[] replicationGroups)
        {
            foreach (ReplicationGroup element in replicationGroups)
            {
                this.replicationGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ReplicationGroups collection
        /// </summary>
        /// <param name="replicationGroups">The values to add to the ReplicationGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReplicationGroupsResult WithReplicationGroups(IEnumerable<ReplicationGroup> replicationGroups)
        {
            foreach (ReplicationGroup element in replicationGroups)
            {
                this.replicationGroups.Add(element);
            }

            return this;
        }

        // Check to see if ReplicationGroups property is set
        internal bool IsSetReplicationGroups()
        {
            return this.replicationGroups.Count > 0;
        }
    }
}

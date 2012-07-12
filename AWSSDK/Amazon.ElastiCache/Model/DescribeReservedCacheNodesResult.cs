/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Contains the result of a successful invocation of the DescribeReservedCacheNodes action. </para>
    /// </summary>
    public class DescribeReservedCacheNodesResult  
    {
        
        private string marker;
        private List<ReservedCacheNode> reservedCacheNodes = new List<ReservedCacheNode>();

        /// <summary>
        /// The marker provided for paginated results.
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
        public DescribeReservedCacheNodesResult WithMarker(string marker)
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
        /// A list of of reserved Cache Nodes.
        ///  
        /// </summary>
        public List<ReservedCacheNode> ReservedCacheNodes
        {
            get { return this.reservedCacheNodes; }
            set { this.reservedCacheNodes = value; }
        }
        /// <summary>
        /// Adds elements to the ReservedCacheNodes collection
        /// </summary>
        /// <param name="reservedCacheNodes">The values to add to the ReservedCacheNodes collection </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesResult WithReservedCacheNodes(params ReservedCacheNode[] reservedCacheNodes)
        {
            foreach (ReservedCacheNode element in reservedCacheNodes)
            {
                this.reservedCacheNodes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ReservedCacheNodes collection
        /// </summary>
        /// <param name="reservedCacheNodes">The values to add to the ReservedCacheNodes collection </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesResult WithReservedCacheNodes(IEnumerable<ReservedCacheNode> reservedCacheNodes)
        {
            foreach (ReservedCacheNode element in reservedCacheNodes)
            {
                this.reservedCacheNodes.Add(element);
            }

            return this;
        }

        // Check to see if ReservedCacheNodes property is set
        internal bool IsSetReservedCacheNodes()
        {
            return this.reservedCacheNodes.Count > 0;       
        }
    }
}

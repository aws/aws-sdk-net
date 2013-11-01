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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>The detailed status of the cluster.</para>
    /// </summary>
    public class ClusterStatus
    {
        
        private ClusterState state;
        private ClusterStateChangeReason stateChangeReason;
        private ClusterTimeline timeline;


        /// <summary>
        /// The current state of the cluster.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>STARTING, BOOTSTRAPPING, RUNNING, WAITING, TERMINATING, TERMINATED, TERMINATED_WITH_ERRORS</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ClusterState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The reason for the cluster status change.
        ///  
        /// </summary>
        public ClusterStateChangeReason StateChangeReason
        {
            get { return this.stateChangeReason; }
            set { this.stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this.stateChangeReason != null;
        }

        /// <summary>
        /// A timeline that represents the status of a cluster over the lifetime of the cluster.
        ///  
        /// </summary>
        public ClusterTimeline Timeline
        {
            get { return this.timeline; }
            set { this.timeline = value; }
        }

        // Check to see if Timeline property is set
        internal bool IsSetTimeline()
        {
            return this.timeline != null;
        }
    }
}

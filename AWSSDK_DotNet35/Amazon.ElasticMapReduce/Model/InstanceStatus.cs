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
    /// <para>The instance status details.</para>
    /// </summary>
    public class InstanceStatus
    {
        
        private InstanceState state;
        private InstanceStateChangeReason stateChangeReason;
        private InstanceTimeline timeline;


        /// <summary>
        /// The current state of the instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING, TERMINATED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceState State
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
        /// The details of the status change reason for the instance.
        ///  
        /// </summary>
        public InstanceStateChangeReason StateChangeReason
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
        /// The timeline of the instance status over time.
        ///  
        /// </summary>
        public InstanceTimeline Timeline
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

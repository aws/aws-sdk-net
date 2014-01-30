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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the status of an instance.</para>
    /// </summary>
    public class InstanceStatus
    {
        
        private string instanceId;
        private string availabilityZone;
        private List<InstanceStatusEvent> events = new List<InstanceStatusEvent>();
        private InstanceState instanceState;
        private InstanceStatusSummary systemStatus;
        private InstanceStatusSummary status;


        /// <summary>
        /// The ID of the instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The Availability Zone of the instance.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// Extra information regarding events associated with the instance.
        ///  
        /// </summary>
        public List<InstanceStatusEvent> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this.events.Count > 0;
        }

        /// <summary>
        /// The intended state of the instance. <a>DescribeInstanceStatus</a> requires that an instance be in the <c>running</c> state.
        ///  
        /// </summary>
        public InstanceState InstanceState
        {
            get { return this.instanceState; }
            set { this.instanceState = value; }
        }

        // Check to see if InstanceState property is set
        internal bool IsSetInstanceState()
        {
            return this.instanceState != null;
        }

        /// <summary>
        /// Reports impaired functionality that stems from issues related to the systems that support an instance, such as hardware failures and network
        /// connectivity problems.
        ///  
        /// </summary>
        public InstanceStatusSummary SystemStatus
        {
            get { return this.systemStatus; }
            set { this.systemStatus = value; }
        }

        // Check to see if SystemStatus property is set
        internal bool IsSetSystemStatus()
        {
            return this.systemStatus != null;
        }

        /// <summary>
        /// Reports impaired functionality that stems from issues internal to the instance, such as impaired reachability.
        ///  
        /// </summary>
        public InstanceStatusSummary Status
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

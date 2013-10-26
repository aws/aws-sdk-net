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
    /// <para> Represents the status of an Amazon EC2 instance. </para>
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
        /// The ID of the Amazon EC2 instance.
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
        /// The Amazon EC2 instance's availability zone.
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
        /// Events that affect the status of the associated Amazon EC2 instance.
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
        /// Represents the state of an Amazon EC2 instance.
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

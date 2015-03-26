/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the status of an instance.
    /// </summary>
    public partial class InstanceStatus
    {
        private string _availabilityZone;
        private List<InstanceStatusEvent> _events = new List<InstanceStatusEvent>();
        private string _instanceId;
        private InstanceState _instanceState;
        private InstanceStatusSummary _status;
        private InstanceStatusSummary _systemStatus;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the instance.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Extra information regarding events associated with the instance.
        /// </para>
        /// </summary>
        public List<InstanceStatusEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceState. 
        /// <para>
        /// The intended state of the instance. <a>DescribeInstanceStatus</a> requires that an
        /// instance be in the <code>running</code> state.
        /// </para>
        /// </summary>
        public InstanceState InstanceState
        {
            get { return this._instanceState; }
            set { this._instanceState = value; }
        }

        // Check to see if InstanceState property is set
        internal bool IsSetInstanceState()
        {
            return this._instanceState != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Reports impaired functionality that stems from issues internal to the instance, such
        /// as impaired reachability.
        /// </para>
        /// </summary>
        public InstanceStatusSummary Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SystemStatus. 
        /// <para>
        /// Reports impaired functionality that stems from issues related to the systems that
        /// support an instance, such as hardware failures and network connectivity problems.
        /// </para>
        /// </summary>
        public InstanceStatusSummary SystemStatus
        {
            get { return this._systemStatus; }
            set { this._systemStatus = value; }
        }

        // Check to see if SystemStatus property is set
        internal bool IsSetSystemStatus()
        {
            return this._systemStatus != null;
        }

    }
}
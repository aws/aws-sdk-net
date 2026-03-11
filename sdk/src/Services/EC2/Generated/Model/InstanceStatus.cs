/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the status of an instance.
    /// </summary>
    public partial class InstanceStatus
    {
        private EbsStatusSummary _attachedEbsStatus;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private List<InstanceStatusEvent> _events = AWSConfigs.InitializeCollections ? new List<InstanceStatusEvent>() : null;
        private string _instanceId;
        private InstanceState _instanceState;
        private OperatorResponse _operator;
        private string _outpostArn;
        private InstanceStatusSummary _status;
        private InstanceStatusSummary _systemStatus;

        /// <summary>
        /// Gets and sets the property AttachedEbsStatus. 
        /// <para>
        /// Reports impaired functionality that stems from an attached Amazon EBS volume that
        /// is unreachable and unable to complete I/O operations.
        /// </para>
        /// </summary>
        public EbsStatusSummary AttachedEbsStatus
        {
            get { return this._attachedEbsStatus; }
            set { this._attachedEbsStatus = value; }
        }

        // Check to see if AttachedEbsStatus property is set
        internal bool IsSetAttachedEbsStatus()
        {
            return this._attachedEbsStatus != null;
        }

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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the instance.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Any scheduled events associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceStatusEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// instance be in the <c>running</c> state.
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the instance.
        /// </para>
        /// </summary>
        public OperatorResponse Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
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
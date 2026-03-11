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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A summary of a router input, including its name, type, ARN, ID, state, and other key
    /// details. This structure is used in the response of the ListRouterInputs operation.
    /// </summary>
    public partial class ListedRouterInput
    {
        private string _arn;
        private string _availabilityZone;
        private DateTime? _createdAt;
        private string _id;
        private RouterInputType _inputType;
        private MaintenanceSchedule _maintenanceSchedule;
        private MaintenanceScheduleType _maintenanceScheduleType;
        private long? _maximumBitrate;
        private int? _messageCount;
        private string _name;
        private string _networkInterfaceArn;
        private string _regionName;
        private int? _routedOutputs;
        private RoutingScope _routingScope;
        private RouterInputState _state;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the router input was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The type of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterInputType InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The details of the maintenance schedule for the listed router input.
        /// </para>
        /// </summary>
        public MaintenanceSchedule MaintenanceSchedule
        {
            get { return this._maintenanceSchedule; }
            set { this._maintenanceSchedule = value; }
        }

        // Check to see if MaintenanceSchedule property is set
        internal bool IsSetMaintenanceSchedule()
        {
            return this._maintenanceSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceScheduleType. 
        /// <para>
        /// The type of maintenance schedule currently associated with the listed router input.
        /// </para>
        /// </summary>
        public MaintenanceScheduleType MaintenanceScheduleType
        {
            get { return this._maintenanceScheduleType; }
            set { this._maintenanceScheduleType = value; }
        }

        // Check to see if MaintenanceScheduleType property is set
        internal bool IsSetMaintenanceScheduleType()
        {
            return this._maintenanceScheduleType != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? MaximumBitrate
        {
            get { return this._maximumBitrate; }
            set { this._maximumBitrate = value; }
        }

        // Check to see if MaximumBitrate property is set
        internal bool IsSetMaximumBitrate()
        {
            return this._maximumBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageCount. 
        /// <para>
        /// The number of messages associated with the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MessageCount
        {
            get { return this._messageCount; }
            set { this._messageCount = value; }
        }

        // Check to see if MessageCount property is set
        internal bool IsSetMessageCount()
        {
            return this._messageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceArn. 
        /// <para>
        /// The ARN of the network interface associated with the router input.
        /// </para>
        /// </summary>
        public string NetworkInterfaceArn
        {
            get { return this._networkInterfaceArn; }
            set { this._networkInterfaceArn = value; }
        }

        // Check to see if NetworkInterfaceArn property is set
        internal bool IsSetNetworkInterfaceArn()
        {
            return this._networkInterfaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region where the router input is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property RoutedOutputs. 
        /// <para>
        /// The number of router outputs that are associated with this router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RoutedOutputs
        {
            get { return this._routedOutputs; }
            set { this._routedOutputs = value; }
        }

        // Check to see if RoutedOutputs property is set
        internal bool IsSetRoutedOutputs()
        {
            return this._routedOutputs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Indicates whether the router input is configured for Regional or global routing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingScope RoutingScope
        {
            get { return this._routingScope; }
            set { this._routingScope = value; }
        }

        // Check to see if RoutingScope property is set
        internal bool IsSetRoutingScope()
        {
            return this._routingScope != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The overall state of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterInputState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the router input was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}
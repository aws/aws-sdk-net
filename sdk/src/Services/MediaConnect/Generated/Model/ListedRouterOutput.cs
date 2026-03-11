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
    /// A summary of a router output, including its name, type, ARN, ID, state, routed state,
    /// and other key details. This structure is used in the response of the ListRouterOutputs
    /// operation.
    /// </summary>
    public partial class ListedRouterOutput
    {
        private string _arn;
        private string _availabilityZone;
        private DateTime? _createdAt;
        private string _id;
        private MaintenanceSchedule _maintenanceSchedule;
        private MaintenanceScheduleType _maintenanceScheduleType;
        private long? _maximumBitrate;
        private int? _messageCount;
        private string _name;
        private string _networkInterfaceArn;
        private RouterOutputType _outputType;
        private string _regionName;
        private string _routedInputArn;
        private RouterOutputRoutedState _routedState;
        private RoutingScope _routingScope;
        private RouterOutputState _state;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router output.
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
        /// The Availability Zone of the router output.
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
        /// The timestamp when the router output was created.
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
        /// The unique identifier of the router output.
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
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The details of the maintenance schedule for the listed router output.
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
        /// The type of maintenance schedule currently associated with the listed router output.
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
        /// The maximum bitrate of the router output.
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
        /// The number of messages associated with the router output.
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
        /// The name of the router output.
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
        /// The ARN of the network interface associated with the router output.
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
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The type of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputType OutputType
        {
            get { return this._outputType; }
            set { this._outputType = value; }
        }

        // Check to see if OutputType property is set
        internal bool IsSetOutputType()
        {
            return this._outputType != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The AAmazon Web Services Region where the router output is located.
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
        /// Gets and sets the property RoutedInputArn. 
        /// <para>
        /// The ARN of the router input associated with the output.
        /// </para>
        /// </summary>
        public string RoutedInputArn
        {
            get { return this._routedInputArn; }
            set { this._routedInputArn = value; }
        }

        // Check to see if RoutedInputArn property is set
        internal bool IsSetRoutedInputArn()
        {
            return this._routedInputArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutedState. 
        /// <para>
        /// The current state of the association between the router output and its input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputRoutedState RoutedState
        {
            get { return this._routedState; }
            set { this._routedState = value; }
        }

        // Check to see if RoutedState property is set
        internal bool IsSetRoutedState()
        {
            return this._routedState != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Indicates whether the router output is configured for Regional or global routing.
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
        /// The overall state of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputState State
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
        /// The timestamp when the router output was last updated.
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
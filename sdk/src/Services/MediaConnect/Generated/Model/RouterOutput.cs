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
    /// A router output in AWS Elemental MediaConnect. A router output is a destination for
    /// media content that can receive input from one or more router inputs.
    /// </summary>
    public partial class RouterOutput
    {
        private string _arn;
        private string _availabilityZone;
        private RouterOutputConfiguration _configuration;
        private DateTime? _createdAt;
        private string _id;
        private string _ipAddress;
        private MaintenanceConfiguration _maintenanceConfiguration;
        private MaintenanceSchedule _maintenanceSchedule;
        private MaintenanceScheduleType _maintenanceScheduleType;
        private MaintenanceType _maintenanceType;
        private long? _maximumBitrate;
        private List<RouterOutputMessage> _messages = AWSConfigs.InitializeCollections ? new List<RouterOutputMessage>() : null;
        private string _name;
        private RouterOutputType _outputType;
        private string _regionName;
        private string _routedInputArn;
        private RouterOutputRoutedState _routedState;
        private RoutingScope _routingScope;
        private RouterOutputState _state;
        private RouterOutputStreamDetails _streamDetails;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RouterOutputTier _tier;
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
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the router output was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the router output.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceConfiguration. 
        /// <para>
        /// The maintenance configuration settings applied to this router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MaintenanceConfiguration MaintenanceConfiguration
        {
            get { return this._maintenanceConfiguration; }
            set { this._maintenanceConfiguration = value; }
        }

        // Check to see if MaintenanceConfiguration property is set
        internal bool IsSetMaintenanceConfiguration()
        {
            return this._maintenanceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The current maintenance schedule details for this router output.
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
        /// The type of maintenance schedule currently in effect for this router output.
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
        /// Gets and sets the property MaintenanceType. 
        /// <para>
        /// The type of maintenance configuration applied to this router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MaintenanceType MaintenanceType
        {
            get { return this._maintenanceType; }
            set { this._maintenanceType = value; }
        }

        // Check to see if MaintenanceType property is set
        internal bool IsSetMaintenanceType()
        {
            return this._maintenanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long MaximumBitrate
        {
            get { return this._maximumBitrate.GetValueOrDefault(); }
            set { this._maximumBitrate = value; }
        }

        // Check to see if MaximumBitrate property is set
        internal bool IsSetMaximumBitrate()
        {
            return this._maximumBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages associated with the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouterOutputMessage> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The AWS Region where the router output is located.
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
        /// The Amazon Resource Name (ARN) of the router input associated with the output.
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
        /// Gets and sets the property StreamDetails.
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputStreamDetails StreamDetails
        {
            get { return this._streamDetails; }
            set { this._streamDetails = value; }
        }

        // Check to see if StreamDetails property is set
        internal bool IsSetStreamDetails()
        {
            return this._streamDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to tag and organize this router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier level of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the router output was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}
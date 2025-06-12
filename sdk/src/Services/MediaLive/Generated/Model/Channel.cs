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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for Channel
    /// </summary>
    public partial class Channel
    {
        private DescribeAnywhereSettings _anywhereSettings;
        private string _arn;
        private CdiInputSpecification _cdiInputSpecification;
        private ChannelClass _channelClass;
        private ChannelEngineVersionResponse _channelEngineVersion;
        private List<OutputDestination> _destinations = AWSConfigs.InitializeCollections ? new List<OutputDestination>() : null;
        private List<ChannelEgressEndpoint> _egressEndpoints = AWSConfigs.InitializeCollections ? new List<ChannelEgressEndpoint>() : null;
        private EncoderSettings _encoderSettings;
        private string _id;
        private List<InputAttachment> _inputAttachments = AWSConfigs.InitializeCollections ? new List<InputAttachment>() : null;
        private InputSpecification _inputSpecification;
        private LogLevel _logLevel;
        private MaintenanceStatus _maintenance;
        private string _name;
        private List<PipelineDetail> _pipelineDetails = AWSConfigs.InitializeCollections ? new List<PipelineDetail>() : null;
        private int? _pipelinesRunningCount;
        private string _roleArn;
        private ChannelState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VpcOutputSettingsDescription _vpc;

        /// <summary>
        /// Gets and sets the property AnywhereSettings. Anywhere settings for this channel.
        /// </summary>
        public DescribeAnywhereSettings AnywhereSettings
        {
            get { return this._anywhereSettings; }
            set { this._anywhereSettings = value; }
        }

        // Check to see if AnywhereSettings property is set
        internal bool IsSetAnywhereSettings()
        {
            return this._anywhereSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. The unique arn of the channel.
        /// </summary>
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
        /// Gets and sets the property CdiInputSpecification. Specification of CDI inputs for
        /// this channel
        /// </summary>
        public CdiInputSpecification CdiInputSpecification
        {
            get { return this._cdiInputSpecification; }
            set { this._cdiInputSpecification = value; }
        }

        // Check to see if CdiInputSpecification property is set
        internal bool IsSetCdiInputSpecification()
        {
            return this._cdiInputSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelClass. The class for this channel. STANDARD for
        /// a channel with two pipelines or SINGLE_PIPELINE for a channel with one pipeline.
        /// </summary>
        public ChannelClass ChannelClass
        {
            get { return this._channelClass; }
            set { this._channelClass = value; }
        }

        // Check to see if ChannelClass property is set
        internal bool IsSetChannelClass()
        {
            return this._channelClass != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelEngineVersion. Requested engine version for this
        /// channel.
        /// </summary>
        public ChannelEngineVersionResponse ChannelEngineVersion
        {
            get { return this._channelEngineVersion; }
            set { this._channelEngineVersion = value; }
        }

        // Check to see if ChannelEngineVersion property is set
        internal bool IsSetChannelEngineVersion()
        {
            return this._channelEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Destinations. A list of destinations of the channel. For
        /// UDP outputs, there is onedestination per output. For other types (HLS, for example),
        /// there isone destination per packager.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EgressEndpoints. The endpoints where outgoing connections
        /// initiate from
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChannelEgressEndpoint> EgressEndpoints
        {
            get { return this._egressEndpoints; }
            set { this._egressEndpoints = value; }
        }

        // Check to see if EgressEndpoints property is set
        internal bool IsSetEgressEndpoints()
        {
            return this._egressEndpoints != null && (this._egressEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncoderSettings.
        /// </summary>
        public EncoderSettings EncoderSettings
        {
            get { return this._encoderSettings; }
            set { this._encoderSettings = value; }
        }

        // Check to see if EncoderSettings property is set
        internal bool IsSetEncoderSettings()
        {
            return this._encoderSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The unique id of the channel.
        /// </summary>
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
        /// Gets and sets the property InputAttachments. List of input attachments for channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputAttachment> InputAttachments
        {
            get { return this._inputAttachments; }
            set { this._inputAttachments = value; }
        }

        // Check to see if InputAttachments property is set
        internal bool IsSetInputAttachments()
        {
            return this._inputAttachments != null && (this._inputAttachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputSpecification. Specification of network and file inputs
        /// for this channel
        /// </summary>
        public InputSpecification InputSpecification
        {
            get { return this._inputSpecification; }
            set { this._inputSpecification = value; }
        }

        // Check to see if InputSpecification property is set
        internal bool IsSetInputSpecification()
        {
            return this._inputSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. The log level being written to CloudWatch Logs.
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Maintenance. Maintenance settings for this channel.
        /// </summary>
        public MaintenanceStatus Maintenance
        {
            get { return this._maintenance; }
            set { this._maintenance = value; }
        }

        // Check to see if Maintenance property is set
        internal bool IsSetMaintenance()
        {
            return this._maintenance != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the channel. (user-mutable)
        /// </summary>
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
        /// Gets and sets the property PipelineDetails. Runtime details for the pipelines of a
        /// running channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PipelineDetail> PipelineDetails
        {
            get { return this._pipelineDetails; }
            set { this._pipelineDetails = value; }
        }

        // Check to see if PipelineDetails property is set
        internal bool IsSetPipelineDetails()
        {
            return this._pipelineDetails != null && (this._pipelineDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelinesRunningCount. The number of currently healthy
        /// pipelines.
        /// </summary>
        public int? PipelinesRunningCount
        {
            get { return this._pipelinesRunningCount; }
            set { this._pipelinesRunningCount = value; }
        }

        // Check to see if PipelinesRunningCount property is set
        internal bool IsSetPipelinesRunningCount()
        {
            return this._pipelinesRunningCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the role assumed
        /// when running the Channel.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public ChannelState State
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
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Vpc. Settings for VPC output
        /// </summary>
        public VpcOutputSettingsDescription Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}
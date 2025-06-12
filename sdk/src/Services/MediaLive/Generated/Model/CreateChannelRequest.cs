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
    /// Container for the parameters to the CreateChannel operation.
    /// Creates a new channel
    /// </summary>
    public partial class CreateChannelRequest : AmazonMediaLiveRequest
    {
        private AnywhereSettings _anywhereSettings;
        private CdiInputSpecification _cdiInputSpecification;
        private ChannelClass _channelClass;
        private ChannelEngineVersionRequest _channelEngineVersion;
        private List<OutputDestination> _destinations = AWSConfigs.InitializeCollections ? new List<OutputDestination>() : null;
        private bool? _dryRun;
        private EncoderSettings _encoderSettings;
        private List<InputAttachment> _inputAttachments = AWSConfigs.InitializeCollections ? new List<InputAttachment>() : null;
        private InputSpecification _inputSpecification;
        private LogLevel _logLevel;
        private MaintenanceCreateSettings _maintenance;
        private string _name;
        private string _requestId;
        private string _reserved;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VpcOutputSettings _vpc;

        /// <summary>
        /// Gets and sets the property AnywhereSettings. The Elemental Anywhere settings for this
        /// channel.
        /// </summary>
        public AnywhereSettings AnywhereSettings
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
        /// Gets and sets the property ChannelEngineVersion. The desired engine version for this
        /// channel.
        /// </summary>
        public ChannelEngineVersionRequest ChannelEngineVersion
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
        /// Gets and sets the property Destinations.
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
        /// Gets and sets the property DryRun.
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        /// Gets and sets the property LogLevel. The log level to write to CloudWatch Logs.
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
        public MaintenanceCreateSettings Maintenance
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
        /// Gets and sets the property Name. Name of channel.
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
        /// Gets and sets the property RequestId. Unique request ID to be specified. This is needed
        /// to prevent retries fromcreating multiple resources.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Reserved. Deprecated field that's only usable by whitelisted
        /// customers.
        /// </summary>
        [Obsolete("Deprecated field that's only usable by whitelisted customers.")]
        public string Reserved
        {
            get { return this._reserved; }
            set { this._reserved = value; }
        }

        // Check to see if Reserved property is set
        internal bool IsSetReserved()
        {
            return this._reserved != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. An optional Amazon Resource Name (ARN) of the
        /// role to assume when running the Channel.
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
        /// Gets and sets the property Vpc. Settings for the VPC outputs
        /// </summary>
        public VpcOutputSettings Vpc
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
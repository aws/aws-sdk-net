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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for ChannelSummary
    /// </summary>
    public partial class ChannelSummary
    {
        private string _arn;
        private CdiInputSpecification _cdiInputSpecification;
        private ChannelClass _channelClass;
        private List<OutputDestination> _destinations = new List<OutputDestination>();
        private List<ChannelEgressEndpoint> _egressEndpoints = new List<ChannelEgressEndpoint>();
        private string _id;
        private List<InputAttachment> _inputAttachments = new List<InputAttachment>();
        private InputSpecification _inputSpecification;
        private LogLevel _logLevel;
        private string _name;
        private int? _pipelinesRunningCount;
        private string _roleArn;
        private ChannelState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Gets and sets the property Destinations. A list of destinations of the channel. For
        /// UDP outputs, there is onedestination per output. For other types (HLS, for example),
        /// there isone destination per packager.
        /// </summary>
        public List<OutputDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EgressEndpoints. The endpoints where outgoing connections
        /// initiate from
        /// </summary>
        public List<ChannelEgressEndpoint> EgressEndpoints
        {
            get { return this._egressEndpoints; }
            set { this._egressEndpoints = value; }
        }

        // Check to see if EgressEndpoints property is set
        internal bool IsSetEgressEndpoints()
        {
            return this._egressEndpoints != null && this._egressEndpoints.Count > 0; 
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
        /// </summary>
        public List<InputAttachment> InputAttachments
        {
            get { return this._inputAttachments; }
            set { this._inputAttachments = value; }
        }

        // Check to see if InputAttachments property is set
        internal bool IsSetInputAttachments()
        {
            return this._inputAttachments != null && this._inputAttachments.Count > 0; 
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
        /// Gets and sets the property PipelinesRunningCount. The number of currently healthy
        /// pipelines.
        /// </summary>
        public int PipelinesRunningCount
        {
            get { return this._pipelinesRunningCount.GetValueOrDefault(); }
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
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
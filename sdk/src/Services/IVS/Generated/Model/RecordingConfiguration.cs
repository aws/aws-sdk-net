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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// An object representing a configuration to record a channel stream.
    /// </summary>
    public partial class RecordingConfiguration
    {
        private string _arn;
        private DestinationConfiguration _destinationConfiguration;
        private string _name;
        private int? _recordingReconnectWindowSeconds;
        private RecordingConfigurationState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ThumbnailConfiguration _thumbnailConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Recording-configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// A complex type that contains information about where recorded video will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationConfiguration DestinationConfiguration
        {
            get { return this._destinationConfiguration; }
            set { this._destinationConfiguration = value; }
        }

        // Check to see if DestinationConfiguration property is set
        internal bool IsSetDestinationConfiguration()
        {
            return this._destinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Recording-configuration name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property RecordingReconnectWindowSeconds. 
        /// <para>
        /// If a broadcast disconnects and then reconnects within the specified interval, the
        /// multiple streams will be considered a single broadcast and merged together. Default:
        /// 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int RecordingReconnectWindowSeconds
        {
            get { return this._recordingReconnectWindowSeconds.GetValueOrDefault(); }
            set { this._recordingReconnectWindowSeconds = value; }
        }

        // Check to see if RecordingReconnectWindowSeconds property is set
        internal bool IsSetRecordingReconnectWindowSeconds()
        {
            return this._recordingReconnectWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates the current state of the recording configuration. When the state is <code>ACTIVE</code>,
        /// the configuration is ready for recording a channel stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordingConfigurationState State
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of 1-50 maps, each of the form <code>string:string
        /// (key:value)</code>. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> for more information, including restrictions that
        /// apply to tags and "Tag naming limits and requirements"; Amazon IVS has no service-specific
        /// constraints beyond what is documented there.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property ThumbnailConfiguration. 
        /// <para>
        /// A complex type that allows you to enable/disable the recording of thumbnails for a
        /// live session and modify the interval at which thumbnails are generated for the live
        /// session.
        /// </para>
        /// </summary>
        public ThumbnailConfiguration ThumbnailConfiguration
        {
            get { return this._thumbnailConfiguration; }
            set { this._thumbnailConfiguration = value; }
        }

        // Check to see if ThumbnailConfiguration property is set
        internal bool IsSetThumbnailConfiguration()
        {
            return this._thumbnailConfiguration != null;
        }

    }
}
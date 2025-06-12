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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRecordingConfiguration operation.
    /// Creates a new recording configuration, used to enable recording to Amazon S3.
    /// 
    ///  
    /// <para>
    ///  <b>Known issue:</b> In the us-east-1 region, if you use the Amazon Web Services CLI
    /// to create a recording configuration, it returns success even if the S3 bucket is in
    /// a different region. In this case, the <c>state</c> of the recording configuration
    /// is <c>CREATE_FAILED</c> (instead of <c>ACTIVE</c>). (In other regions, the CLI correctly
    /// returns failure if the bucket is in a different region.)
    /// </para>
    ///  
    /// <para>
    ///  <b>Workaround:</b> Ensure that your S3 bucket is in the same region as the recording
    /// configuration. If you create a recording configuration in a different region as your
    /// S3 bucket, delete that recording configuration and create a new one with an S3 bucket
    /// from the correct region.
    /// </para>
    /// </summary>
    public partial class CreateRecordingConfigurationRequest : AmazonIVSRequest
    {
        private DestinationConfiguration _destinationConfiguration;
        private string _name;
        private int? _recordingReconnectWindowSeconds;
        private RenditionConfiguration _renditionConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ThumbnailConfiguration _thumbnailConfiguration;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// A complex type that contains a destination configuration for where recorded video
        /// will be stored.
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
        public int? RecordingReconnectWindowSeconds
        {
            get { return this._recordingReconnectWindowSeconds; }
            set { this._recordingReconnectWindowSeconds = value; }
        }

        // Check to see if RecordingReconnectWindowSeconds property is set
        internal bool IsSetRecordingReconnectWindowSeconds()
        {
            return this._recordingReconnectWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RenditionConfiguration. 
        /// <para>
        /// Object that describes which renditions should be recorded for a stream.
        /// </para>
        /// </summary>
        public RenditionConfiguration RenditionConfiguration
        {
            get { return this._renditionConfiguration; }
            set { this._renditionConfiguration = value; }
        }

        // Check to see if RenditionConfiguration property is set
        internal bool IsSetRenditionConfiguration()
        {
            return this._renditionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Array of 1-50 maps, each of the form <c>string:string (key:value)</c>. See <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
        /// practices and strategies</a> in <i>Tagging Amazon Web Services Resources and Tag Editor</i>
        /// for details, including restrictions that apply to tags and "Tag naming limits and
        /// requirements"; Amazon IVS has no service-specific constraints beyond what is documented
        /// there.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
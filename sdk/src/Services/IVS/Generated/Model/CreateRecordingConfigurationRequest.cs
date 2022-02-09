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
    /// Container for the parameters to the CreateRecordingConfiguration operation.
    /// Creates a new recording configuration, used to enable recording to Amazon S3.
    /// 
    ///  
    /// <para>
    ///  <b>Known issue:</b> In the us-east-1 region, if you use the Amazon Web Services CLI
    /// to create a recording configuration, it returns success even if the S3 bucket is in
    /// a different region. In this case, the <code>state</code> of the recording configuration
    /// is <code>CREATE_FAILED</code> (instead of <code>ACTIVE</code>). (In other regions,
    /// the CLI correctly returns failure if the bucket is in a different region.)
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
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Array of 1-50 maps, each of the form <code>string:string (key:value)</code>.
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
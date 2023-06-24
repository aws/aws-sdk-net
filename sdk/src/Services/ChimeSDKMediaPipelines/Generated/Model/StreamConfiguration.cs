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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The configuration settings for a stream.
    /// </summary>
    public partial class StreamConfiguration
    {
        private string _fragmentNumber;
        private string _streamArn;
        private StreamChannelDefinition _streamChannelDefinition;

        /// <summary>
        /// Gets and sets the property FragmentNumber. 
        /// <para>
        /// The unique identifier of the fragment to begin processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FragmentNumber
        {
            get { return this._fragmentNumber; }
            set { this._fragmentNumber = value; }
        }

        // Check to see if FragmentNumber property is set
        internal bool IsSetFragmentNumber()
        {
            return this._fragmentNumber != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamChannelDefinition. 
        /// <para>
        /// The streaming channel definition in the stream configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamChannelDefinition StreamChannelDefinition
        {
            get { return this._streamChannelDefinition; }
            set { this._streamChannelDefinition = value; }
        }

        // Check to see if StreamChannelDefinition property is set
        internal bool IsSetStreamChannelDefinition()
        {
            return this._streamChannelDefinition != null;
        }

    }
}
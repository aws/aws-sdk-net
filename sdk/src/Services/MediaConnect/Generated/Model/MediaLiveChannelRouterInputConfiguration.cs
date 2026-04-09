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
    /// Configuration settings for connecting a router input to a MediaLive channel output.
    /// </summary>
    public partial class MediaLiveChannelRouterInputConfiguration
    {
        private string _mediaLiveChannelArn;
        private string _mediaLiveChannelOutputName;
        private MediaLiveChannelPipelineId _mediaLivePipelineId;
        private MediaLiveTransitEncryption _sourceTransitDecryption;

        /// <summary>
        /// Gets and sets the property MediaLiveChannelArn. 
        /// <para>
        /// The ARN of the MediaLive channel to connect to this router input.
        /// </para>
        /// </summary>
        public string MediaLiveChannelArn
        {
            get { return this._mediaLiveChannelArn; }
            set { this._mediaLiveChannelArn = value; }
        }

        // Check to see if MediaLiveChannelArn property is set
        internal bool IsSetMediaLiveChannelArn()
        {
            return this._mediaLiveChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaLiveChannelOutputName. 
        /// <para>
        /// The name of the MediaLive channel output to connect to this router input.
        /// </para>
        /// </summary>
        public string MediaLiveChannelOutputName
        {
            get { return this._mediaLiveChannelOutputName; }
            set { this._mediaLiveChannelOutputName = value; }
        }

        // Check to see if MediaLiveChannelOutputName property is set
        internal bool IsSetMediaLiveChannelOutputName()
        {
            return this._mediaLiveChannelOutputName != null;
        }

        /// <summary>
        /// Gets and sets the property MediaLivePipelineId. 
        /// <para>
        /// The index of the MediaLive pipeline to connect to this router input.
        /// </para>
        /// </summary>
        public MediaLiveChannelPipelineId MediaLivePipelineId
        {
            get { return this._mediaLivePipelineId; }
            set { this._mediaLivePipelineId = value; }
        }

        // Check to see if MediaLivePipelineId property is set
        internal bool IsSetMediaLivePipelineId()
        {
            return this._mediaLivePipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTransitDecryption.
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaLiveTransitEncryption SourceTransitDecryption
        {
            get { return this._sourceTransitDecryption; }
            set { this._sourceTransitDecryption = value; }
        }

        // Check to see if SourceTransitDecryption property is set
        internal bool IsSetSourceTransitDecryption()
        {
            return this._sourceTransitDecryption != null;
        }

    }
}
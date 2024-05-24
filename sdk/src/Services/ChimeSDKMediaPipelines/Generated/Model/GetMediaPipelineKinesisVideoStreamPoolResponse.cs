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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// This is the response object from the GetMediaPipelineKinesisVideoStreamPool operation.
    /// </summary>
    public partial class GetMediaPipelineKinesisVideoStreamPoolResponse : AmazonWebServiceResponse
    {
        private KinesisVideoStreamPoolConfiguration _kinesisVideoStreamPoolConfiguration;

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamPoolConfiguration. 
        /// <para>
        /// The video stream pool configuration object.
        /// </para>
        /// </summary>
        public KinesisVideoStreamPoolConfiguration KinesisVideoStreamPoolConfiguration
        {
            get { return this._kinesisVideoStreamPoolConfiguration; }
            set { this._kinesisVideoStreamPoolConfiguration = value; }
        }

        // Check to see if KinesisVideoStreamPoolConfiguration property is set
        internal bool IsSetKinesisVideoStreamPoolConfiguration()
        {
            return this._kinesisVideoStreamPoolConfiguration != null;
        }

    }
}
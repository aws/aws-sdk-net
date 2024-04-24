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
    /// The source type and media pipeline configuration settings in a configuration object.
    /// </summary>
    public partial class ConcatenationSource
    {
        private MediaCapturePipelineSourceConfiguration _mediaCapturePipelineSourceConfiguration;
        private ConcatenationSourceType _type;

        /// <summary>
        /// Gets and sets the property MediaCapturePipelineSourceConfiguration. 
        /// <para>
        /// The concatenation settings for the media pipeline in a configuration object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaCapturePipelineSourceConfiguration MediaCapturePipelineSourceConfiguration
        {
            get { return this._mediaCapturePipelineSourceConfiguration; }
            set { this._mediaCapturePipelineSourceConfiguration = value; }
        }

        // Check to see if MediaCapturePipelineSourceConfiguration property is set
        internal bool IsSetMediaCapturePipelineSourceConfiguration()
        {
            return this._mediaCapturePipelineSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of concatenation source in a configuration object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConcatenationSourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
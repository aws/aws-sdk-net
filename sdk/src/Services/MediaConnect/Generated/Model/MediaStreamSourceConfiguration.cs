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
    /// The media stream that is associated with the source, and the parameters for that association.
    /// </summary>
    public partial class MediaStreamSourceConfiguration
    {
        private EncodingName _encodingName;
        private List<InputConfiguration> _inputConfigurations = AWSConfigs.InitializeCollections ? new List<InputConfiguration>() : null;
        private string _mediaStreamName;

        /// <summary>
        /// Gets and sets the property EncodingName. The format that was used to encode the data.
        /// For ancillary data streams, set the encoding name to smpte291. For audio streams,
        /// set the encoding name to pcm. For video, 2110 streams, set the encoding name to raw.
        /// For video, JPEG XS streams, set the encoding name to jxsv.
        /// </summary>
        [AWSProperty(Required=true)]
        public EncodingName EncodingName
        {
            get { return this._encodingName; }
            set { this._encodingName = value; }
        }

        // Check to see if EncodingName property is set
        internal bool IsSetEncodingName()
        {
            return this._encodingName != null;
        }

        /// <summary>
        /// Gets and sets the property InputConfigurations. The transport parameters that are
        /// associated with an incoming media stream.
        /// </summary>
        public List<InputConfiguration> InputConfigurations
        {
            get { return this._inputConfigurations; }
            set { this._inputConfigurations = value; }
        }

        // Check to see if InputConfigurations property is set
        internal bool IsSetInputConfigurations()
        {
            return this._inputConfigurations != null && (this._inputConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MediaStreamName. The name of the media stream.
        /// </summary>
        [AWSProperty(Required=true)]
        public string MediaStreamName
        {
            get { return this._mediaStreamName; }
            set { this._mediaStreamName = value; }
        }

        // Check to see if MediaStreamName property is set
        internal bool IsSetMediaStreamName()
        {
            return this._mediaStreamName != null;
        }

    }
}
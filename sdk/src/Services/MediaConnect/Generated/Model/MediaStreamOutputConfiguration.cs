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
    /// The media stream that is associated with the output, and the parameters for that association.
    /// </summary>
    public partial class MediaStreamOutputConfiguration
    {
        private List<DestinationConfiguration> _destinationConfigurations = AWSConfigs.InitializeCollections ? new List<DestinationConfiguration>() : null;
        private EncodingName _encodingName;
        private EncodingParameters _encodingParameters;
        private string _mediaStreamName;

        /// <summary>
        /// Gets and sets the property DestinationConfigurations. The transport parameters that
        /// are associated with each outbound media stream.
        /// </summary>
        public List<DestinationConfiguration> DestinationConfigurations
        {
            get { return this._destinationConfigurations; }
            set { this._destinationConfigurations = value; }
        }

        // Check to see if DestinationConfigurations property is set
        internal bool IsSetDestinationConfigurations()
        {
            return this._destinationConfigurations != null && (this._destinationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property EncodingParameters. Encoding parameters
        /// </summary>
        public EncodingParameters EncodingParameters
        {
            get { return this._encodingParameters; }
            set { this._encodingParameters = value; }
        }

        // Check to see if EncodingParameters property is set
        internal bool IsSetEncodingParameters()
        {
            return this._encodingParameters != null;
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
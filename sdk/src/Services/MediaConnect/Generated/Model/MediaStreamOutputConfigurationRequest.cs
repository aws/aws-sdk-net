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
    /// The media stream that you want to associate with the output, and the parameters for
    /// that association.
    /// </summary>
    public partial class MediaStreamOutputConfigurationRequest
    {
        private List<DestinationConfigurationRequest> _destinationConfigurations = AWSConfigs.InitializeCollections ? new List<DestinationConfigurationRequest>() : null;
        private EncodingName _encodingName;
        private EncodingParametersRequest _encodingParameters;
        private string _mediaStreamName;

        /// <summary>
        /// Gets and sets the property DestinationConfigurations. 
        /// <para>
        ///  The media streams that you want to associate with the output. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DestinationConfigurationRequest> DestinationConfigurations
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
        /// Gets and sets the property EncodingName. 
        /// <para>
        ///  The format that will be used to encode the data. For ancillary data streams, set
        /// the encoding name to smpte291. For audio streams, set the encoding name to pcm. For
        /// video, 2110 streams, set the encoding name to raw. For video, JPEG XS streams, set
        /// the encoding name to jxsv.
        /// </para>
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
        /// Gets and sets the property EncodingParameters. 
        /// <para>
        ///  A collection of parameters that determine how MediaConnect will convert the content.
        /// These fields only apply to outputs on flows that have a CDI source. 
        /// </para>
        /// </summary>
        public EncodingParametersRequest EncodingParameters
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
        /// Gets and sets the property MediaStreamName. 
        /// <para>
        ///  The name of the media stream that is associated with the output.
        /// </para>
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
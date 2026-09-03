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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EncodingName. 
        /// <para>
        ///  The format that was used to encode the data. For ancillary data streams, set the
        /// encoding name to smpte291. For audio streams, set the encoding name to pcm. For video,
        /// 2110 streams, set the encoding name to raw. For video, JPEG XS streams, set the encoding
        /// name to jxsv. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncodingName EncodingName { get; set; }

        /// <summary>
        /// Checks to see if the EncodingName property is set.
        /// </summary>
        internal bool IsSetEncodingName() => this.EncodingName != null;

        /// <summary>
        /// Gets and sets the property InputConfigurations. 
        /// <para>
        /// The media streams that you want to associate with the source. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputConfiguration> InputConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<InputConfiguration>() : null;

        /// <summary>
        /// Checks to see if the InputConfigurations property is set.
        /// </summary>
        internal bool IsSetInputConfigurations() => this.InputConfigurations != null && (this.InputConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaStreamName. 
        /// <para>
        /// A name that helps you distinguish one media stream from another. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MediaStreamName { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamName property is set.
        /// </summary>
        internal bool IsSetMediaStreamName() => this.MediaStreamName != null;
    }
}

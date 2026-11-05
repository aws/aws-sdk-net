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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Output settings. There can be multiple outputs within a group.
    /// </summary>
    public partial class Output
    {
        /// <summary>
        /// Gets and sets the property AudioDescriptionNames. The names of the AudioDescriptions
        /// used as audio sources for this output.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AudioDescriptionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AudioDescriptionNames property is set.
        /// </summary>
        internal bool IsSetAudioDescriptionNames() => this.AudioDescriptionNames != null && (this.AudioDescriptionNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptionDescriptionNames. The names of the CaptionDescriptions
        /// used as caption sources for this output.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CaptionDescriptionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CaptionDescriptionNames property is set.
        /// </summary>
        internal bool IsSetCaptionDescriptionNames() => this.CaptionDescriptionNames != null && (this.CaptionDescriptionNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputName. The name used to identify an output.
        /// </summary>
        public string OutputName { get; set; }

        /// <summary>
        /// Checks to see if the OutputName property is set.
        /// </summary>
        internal bool IsSetOutputName() => this.OutputName != null;

        /// <summary>
        /// Gets and sets the property OutputSettings. Output type-specific settings.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputSettings OutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the OutputSettings property is set.
        /// </summary>
        internal bool IsSetOutputSettings() => this.OutputSettings != null;

        /// <summary>
        /// Gets and sets the property VideoDescriptionName. The name of the VideoDescription
        /// used as the source for this output.
        /// </summary>
        public string VideoDescriptionName { get; set; }

        /// <summary>
        /// Checks to see if the VideoDescriptionName property is set.
        /// </summary>
        internal bool IsSetVideoDescriptionName() => this.VideoDescriptionName != null;
    }
}

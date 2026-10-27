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
    /// Maps a caption channel to an ISO 693-2 language code (http://www.loc.gov/standards/iso639-2),
    /// with an optional description.
    /// </summary>
    public partial class CaptionLanguageMapping
    {
        /// <summary>
        /// Gets and sets the property CaptionChannel. The closed caption channel being described
        /// by this CaptionLanguageMapping. Each channel mapping must have a unique channel number
        /// (maximum of 4)
        /// </summary>
        [AWSProperty(Required = true)]
        public int? CaptionChannel { get; set; }

        /// <summary>
        /// Checks to see if the CaptionChannel property is set.
        /// </summary>
        internal bool IsSetCaptionChannel() => this.CaptionChannel.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. Three character ISO 639-2 language code (see
        /// http://www.loc.gov/standards/iso639-2)
        /// </summary>
        [AWSProperty(Required = true)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageDescription. Textual description of language
        /// </summary>
        [AWSProperty(Required = true)]
        public string LanguageDescription { get; set; }

        /// <summary>
        /// Checks to see if the LanguageDescription property is set.
        /// </summary>
        internal bool IsSetLanguageDescription() => this.LanguageDescription != null;
    }
}

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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Caption Language Mapping
    /// </summary>
    public partial class HlsCaptionLanguageMapping
    {
        /// <summary>
        /// Gets and sets the property CaptionChannel. Caption channel.
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? CaptionChannel { get; set; }

        /// <summary>
        /// Checks to see if the CaptionChannel property is set.
        /// </summary>
        internal bool IsSetCaptionChannel() => this.CaptionChannel.HasValue;

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. Specify the language, using an ISO
        /// 639-2 three-letter code in all capital letters. You can find a list of codes at: https://www.loc.gov/standards/iso639-2/php/code_list.php
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CustomLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the CustomLanguageCode property is set.
        /// </summary>
        internal bool IsSetCustomLanguageCode() => this.CustomLanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. Specify the language, using an ISO 639-2
        /// three-letter code in all capital letters. You can find a list of codes at: https://www.loc.gov/standards/iso639-2/php/code_list.php
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageDescription. Caption language description.
        /// </summary>
        public string LanguageDescription { get; set; }

        /// <summary>
        /// Checks to see if the LanguageDescription property is set.
        /// </summary>
        internal bool IsSetLanguageDescription() => this.LanguageDescription != null;
    }
}

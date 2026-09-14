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
    /// Settings specific to WebVTT sources in HLS alternative rendition group. Specify the
    /// properties (renditionGroupId, renditionName or renditionLanguageCode) to identify
    /// the unique subtitle track among the alternative rendition groups present in the HLS
    /// manifest. If no unique track is found, or multiple tracks match the specified properties,
    /// the job fails. If there is only one subtitle track in the rendition group, the settings
    /// can be left empty and the default subtitle track will be chosen. If your caption source
    /// is a sidecar file, use FileSourceSettings instead of WebvttHlsSourceSettings.
    /// </summary>
    public partial class WebvttHlsSourceSettings
    {
        /// <summary>
        /// Gets and sets the property RenditionGroupId. Optional. Specify alternative group ID
        /// </summary>
        public string RenditionGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RenditionGroupId property is set.
        /// </summary>
        internal bool IsSetRenditionGroupId() => this.RenditionGroupId != null;

        /// <summary>
        /// Gets and sets the property RenditionLanguageCode. Optionally specify the language,
        /// using an ISO 639-2 or ISO 639-3 three-letter code in all capital letters. You can
        /// find a list of codes at: https://www.loc.gov/standards/iso639-2/php/code_list.php
        /// </summary>
        public LanguageCode RenditionLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the RenditionLanguageCode property is set.
        /// </summary>
        internal bool IsSetRenditionLanguageCode() => this.RenditionLanguageCode != null;

        /// <summary>
        /// Gets and sets the property RenditionName. Optional. Specify media name
        /// </summary>
        public string RenditionName { get; set; }

        /// <summary>
        /// Checks to see if the RenditionName property is set.
        /// </summary>
        internal bool IsSetRenditionName() => this.RenditionName != null;
    }
}

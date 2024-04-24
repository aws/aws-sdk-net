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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
        private string _renditionGroupId;
        private LanguageCode _renditionLanguageCode;
        private string _renditionName;

        /// <summary>
        /// Gets and sets the property RenditionGroupId. Optional. Specify alternative group ID
        /// </summary>
        public string RenditionGroupId
        {
            get { return this._renditionGroupId; }
            set { this._renditionGroupId = value; }
        }

        // Check to see if RenditionGroupId property is set
        internal bool IsSetRenditionGroupId()
        {
            return this._renditionGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property RenditionLanguageCode. Optional. Specify ISO 639-2 or ISO
        /// 639-3 code in the language property
        /// </summary>
        public LanguageCode RenditionLanguageCode
        {
            get { return this._renditionLanguageCode; }
            set { this._renditionLanguageCode = value; }
        }

        // Check to see if RenditionLanguageCode property is set
        internal bool IsSetRenditionLanguageCode()
        {
            return this._renditionLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property RenditionName. Optional. Specify media name
        /// </summary>
        public string RenditionName
        {
            get { return this._renditionName; }
            set { this._renditionName = value; }
        }

        // Check to see if RenditionName property is set
        internal bool IsSetRenditionName()
        {
            return this._renditionName != null;
        }

    }
}
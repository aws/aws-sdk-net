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
    /// HDR (High Dynamic Range) metadata extracted from the container, including mastering
    /// display color volume and content light level information. This metadata is present
    /// in HDR10 and similar HDR content.
    /// </summary>
    public partial class HdrMetadata
    {
        /// <summary>
        /// Gets and sets the property ContentLightLevel. Content light level information (CTA-861.3).
        /// Describes the light level characteristics of the content.
        /// </summary>
        public ContentLightLevel ContentLightLevel { get; set; }

        /// <summary>
        /// Checks to see if the ContentLightLevel property is set.
        /// </summary>
        internal bool IsSetContentLightLevel() => this.ContentLightLevel != null;

        /// <summary>
        /// Gets and sets the property MasteringDisplayColorVolume. Mastering display color volume
        /// metadata (SMPTE ST 2086). Describes the color volume of the display used to master
        /// the content. Chromaticity coordinates are in units of 0.00002. Luminance values are
        /// in units of 0.0001 cd/m².
        /// </summary>
        public MasteringDisplayColorVolume MasteringDisplayColorVolume { get; set; }

        /// <summary>
        /// Checks to see if the MasteringDisplayColorVolume property is set.
        /// </summary>
        internal bool IsSetMasteringDisplayColorVolume() => this.MasteringDisplayColorVolume != null;
    }
}

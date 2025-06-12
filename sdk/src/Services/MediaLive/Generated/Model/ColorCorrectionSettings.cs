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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
    /// Property of encoderSettings. Controls color conversion when you are using 3D LUT files
    /// to perform color conversion on video.
    /// </summary>
    public partial class ColorCorrectionSettings
    {
        private List<ColorCorrection> _globalColorCorrections = AWSConfigs.InitializeCollections ? new List<ColorCorrection>() : null;

        /// <summary>
        /// Gets and sets the property GlobalColorCorrections. An array of colorCorrections that
        /// applies when you are using 3D LUT files to perform color conversion on video. Each
        /// colorCorrection contains one 3D LUT file (that defines the color mapping for converting
        /// an input color space to an output color space), and the input/output combination that
        /// this 3D LUT file applies to. MediaLive reads the color space in the input metadata,
        /// determines the color space that you have specified for the output, and finds and uses
        /// the LUT file that applies to this combination.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ColorCorrection> GlobalColorCorrections
        {
            get { return this._globalColorCorrections; }
            set { this._globalColorCorrections = value; }
        }

        // Check to see if GlobalColorCorrections property is set
        internal bool IsSetGlobalColorCorrections()
        {
            return this._globalColorCorrections != null && (this._globalColorCorrections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
    /// Custom 3D lut settings
    /// </summary>
    public partial class ColorConversion3DLUTSetting
    {
        /// <summary>
        /// Gets and sets the property FileInput. Specify the input file S3, HTTP, or HTTPS URL
        /// for your 3D LUT .cube file. Note that MediaConvert accepts 3D LUT files up to 8MB
        /// in size.
        /// </summary>
        [AWSProperty(Min = 14)]
        public string FileInput { get; set; }

        /// <summary>
        /// Checks to see if the FileInput property is set.
        /// </summary>
        internal bool IsSetFileInput() => this.FileInput != null;

        /// <summary>
        /// Gets and sets the property InputColorSpace. Specify which inputs use this 3D LUT,
        /// according to their color space.
        /// </summary>
        public ColorSpace InputColorSpace { get; set; }

        /// <summary>
        /// Checks to see if the InputColorSpace property is set.
        /// </summary>
        internal bool IsSetInputColorSpace() => this.InputColorSpace != null;

        /// <summary>
        /// Gets and sets the property InputMasteringLuminance. Specify which inputs use this
        /// 3D LUT, according to their luminance. To apply this 3D LUT to HDR10 or P3D65 (HDR)
        /// inputs with a specific mastering luminance: Enter an integer from 0 to 2147483647,
        /// corresponding to the input's Maximum luminance value. To apply this 3D LUT to any
        /// input regardless of its luminance: Leave blank, or enter 0.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? InputMasteringLuminance { get; set; }

        /// <summary>
        /// Checks to see if the InputMasteringLuminance property is set.
        /// </summary>
        internal bool IsSetInputMasteringLuminance() => this.InputMasteringLuminance.HasValue;

        /// <summary>
        /// Gets and sets the property OutputColorSpace. Specify which outputs use this 3D LUT,
        /// according to their color space.
        /// </summary>
        public ColorSpace OutputColorSpace { get; set; }

        /// <summary>
        /// Checks to see if the OutputColorSpace property is set.
        /// </summary>
        internal bool IsSetOutputColorSpace() => this.OutputColorSpace != null;

        /// <summary>
        /// Gets and sets the property OutputMasteringLuminance. Specify which outputs use this
        /// 3D LUT, according to their luminance. To apply this 3D LUT to HDR10 or P3D65 (HDR)
        /// outputs with a specific luminance: Enter an integer from 0 to 2147483647, corresponding
        /// to the output's luminance. To apply this 3D LUT to any output regardless of its luminance:
        /// Leave blank, or enter 0.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? OutputMasteringLuminance { get; set; }

        /// <summary>
        /// Checks to see if the OutputMasteringLuminance property is set.
        /// </summary>
        internal bool IsSetOutputMasteringLuminance() => this.OutputMasteringLuminance.HasValue;
    }
}

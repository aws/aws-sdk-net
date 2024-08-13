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
    /// Custom 3D lut settings
    /// </summary>
    public partial class ColorConversion3DLUTSetting
    {
        private string _fileInput;
        private ColorSpace _inputColorSpace;
        private int? _inputMasteringLuminance;
        private ColorSpace _outputColorSpace;
        private int? _outputMasteringLuminance;

        /// <summary>
        /// Gets and sets the property FileInput. Specify the input file S3, HTTP, or HTTPS URL
        /// for your 3D LUT .cube file. Note that MediaConvert accepts 3D LUT files up to 8MB
        /// in size.
        /// </summary>
        [AWSProperty(Min=14)]
        public string FileInput
        {
            get { return this._fileInput; }
            set { this._fileInput = value; }
        }

        // Check to see if FileInput property is set
        internal bool IsSetFileInput()
        {
            return this._fileInput != null;
        }

        /// <summary>
        /// Gets and sets the property InputColorSpace. Specify which inputs use this 3D LUT,
        /// according to their color space.
        /// </summary>
        public ColorSpace InputColorSpace
        {
            get { return this._inputColorSpace; }
            set { this._inputColorSpace = value; }
        }

        // Check to see if InputColorSpace property is set
        internal bool IsSetInputColorSpace()
        {
            return this._inputColorSpace != null;
        }

        /// <summary>
        /// Gets and sets the property InputMasteringLuminance. Specify which inputs use this
        /// 3D LUT, according to their luminance. To apply this 3D LUT to HDR10 or P3D65 (HDR)
        /// inputs with a specific mastering luminance: Enter an integer from 0 to 2147483647,
        /// corresponding to the input's Maximum luminance value. To apply this 3D LUT to any
        /// input regardless of its luminance: Leave blank, or enter 0.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? InputMasteringLuminance
        {
            get { return this._inputMasteringLuminance; }
            set { this._inputMasteringLuminance = value; }
        }

        // Check to see if InputMasteringLuminance property is set
        internal bool IsSetInputMasteringLuminance()
        {
            return this._inputMasteringLuminance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputColorSpace. Specify which outputs use this 3D LUT,
        /// according to their color space.
        /// </summary>
        public ColorSpace OutputColorSpace
        {
            get { return this._outputColorSpace; }
            set { this._outputColorSpace = value; }
        }

        // Check to see if OutputColorSpace property is set
        internal bool IsSetOutputColorSpace()
        {
            return this._outputColorSpace != null;
        }

        /// <summary>
        /// Gets and sets the property OutputMasteringLuminance. Specify which outputs use this
        /// 3D LUT, according to their luminance. To apply this 3D LUT to HDR10 or P3D65 (HDR)
        /// outputs with a specific luminance: Enter an integer from 0 to 2147483647, corresponding
        /// to the output's luminance. To apply this 3D LUT to any output regardless of its luminance:
        /// Leave blank, or enter 0.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? OutputMasteringLuminance
        {
            get { return this._outputMasteringLuminance; }
            set { this._outputMasteringLuminance = value; }
        }

        // Check to see if OutputMasteringLuminance property is set
        internal bool IsSetOutputMasteringLuminance()
        {
            return this._outputMasteringLuminance.HasValue; 
        }

    }
}
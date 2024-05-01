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
    /// Property of ColorCorrectionSettings. Used for custom color space conversion. The object
    /// identifies one 3D LUT file and specifies the input/output color space combination
    /// that the file will be used for.
    /// </summary>
    public partial class ColorCorrection
    {
        private ColorSpace _inputColorSpace;
        private ColorSpace _outputColorSpace;
        private string _uri;

        /// <summary>
        /// Gets and sets the property InputColorSpace. The color space of the input.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OutputColorSpace. The color space of the output.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Uri. The URI of the 3D LUT file. The protocol must be 's3:'
        /// or 's3ssl:':.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// The image format of an AWS Signer platform or profile.
    /// </summary>
    public partial class SigningImageFormat
    {
        private ImageFormat _defaultFormat;
        private List<string> _supportedFormats = new List<string>();

        /// <summary>
        /// Gets and sets the property DefaultFormat. 
        /// <para>
        /// The default format of an AWS Signer signing image.
        /// </para>
        /// </summary>
        public ImageFormat DefaultFormat
        {
            get { return this._defaultFormat; }
            set { this._defaultFormat = value; }
        }

        // Check to see if DefaultFormat property is set
        internal bool IsSetDefaultFormat()
        {
            return this._defaultFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedFormats. 
        /// <para>
        /// The supported formats of an AWS Signer signing image.
        /// </para>
        /// </summary>
        public List<string> SupportedFormats
        {
            get { return this._supportedFormats; }
            set { this._supportedFormats = value; }
        }

        // Check to see if SupportedFormats property is set
        internal bool IsSetSupportedFormats()
        {
            return this._supportedFormats != null && this._supportedFormats.Count > 0; 
        }

    }
}
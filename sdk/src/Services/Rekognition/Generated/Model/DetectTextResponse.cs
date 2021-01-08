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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DetectText operation.
    /// </summary>
    public partial class DetectTextResponse : AmazonWebServiceResponse
    {
        private List<TextDetection> _textDetections = new List<TextDetection>();
        private string _textModelVersion;

        /// <summary>
        /// Gets and sets the property TextDetections. 
        /// <para>
        /// An array of text that was detected in the input image.
        /// </para>
        /// </summary>
        public List<TextDetection> TextDetections
        {
            get { return this._textDetections; }
            set { this._textDetections = value; }
        }

        // Check to see if TextDetections property is set
        internal bool IsSetTextDetections()
        {
            return this._textDetections != null && this._textDetections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TextModelVersion. 
        /// <para>
        /// The model version used to detect text.
        /// </para>
        /// </summary>
        public string TextModelVersion
        {
            get { return this._textModelVersion; }
            set { this._textModelVersion = value; }
        }

        // Check to see if TextModelVersion property is set
        internal bool IsSetTextModelVersion()
        {
            return this._textModelVersion != null;
        }

    }
}
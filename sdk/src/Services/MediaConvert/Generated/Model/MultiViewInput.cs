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
    /// Input settings for MultiView Settings. You can include exactly one input as enhancement
    /// layer.
    /// </summary>
    public partial class MultiViewInput
    {
        private string _fileInput;

        /// <summary>
        /// Gets and sets the property FileInput. Specify the input file S3, HTTP, or HTTPS URL
        /// for your right eye view video.
        /// </summary>
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

    }
}
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
    /// The input file that needs to be analyzed.
    /// </summary>
    public partial class ProbeInputFile
    {
        private string _fileUrl;

        /// <summary>
        /// Gets and sets the property FileUrl. The URI to your input file(s) that is stored in
        /// Amazon S3 or on an HTTP(S) server.
        /// </summary>
        public string FileUrl
        {
            get { return this._fileUrl; }
            set { this._fileUrl = value; }
        }

        // Check to see if FileUrl property is set
        internal bool IsSetFileUrl()
        {
            return this._fileUrl != null;
        }

    }
}
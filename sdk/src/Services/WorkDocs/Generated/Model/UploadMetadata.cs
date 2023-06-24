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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the upload.
    /// </summary>
    public partial class UploadMetadata
    {
        private Dictionary<string, string> _signedHeaders = new Dictionary<string, string>();
        private string _uploadUrl;

        /// <summary>
        /// Gets and sets the property SignedHeaders. 
        /// <para>
        /// The signed headers.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SignedHeaders
        {
            get { return this._signedHeaders; }
            set { this._signedHeaders = value; }
        }

        // Check to see if SignedHeaders property is set
        internal bool IsSetSignedHeaders()
        {
            return this._signedHeaders != null && this._signedHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UploadUrl. 
        /// <para>
        /// The URL of the upload.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string UploadUrl
        {
            get { return this._uploadUrl; }
            set { this._uploadUrl = value; }
        }

        // Check to see if UploadUrl property is set
        internal bool IsSetUploadUrl()
        {
            return this._uploadUrl != null;
        }

    }
}
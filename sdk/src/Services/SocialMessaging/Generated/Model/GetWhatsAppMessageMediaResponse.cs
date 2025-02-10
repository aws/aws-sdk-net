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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the GetWhatsAppMessageMedia operation.
    /// </summary>
    public partial class GetWhatsAppMessageMediaResponse : AmazonWebServiceResponse
    {
        private long? _fileSize;
        private string _mimeType;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// The file size of the media, in KB.
        /// </para>
        /// </summary>
        public long? FileSize
        {
            get { return this._fileSize; }
            set { this._fileSize = value; }
        }

        // Check to see if FileSize property is set
        internal bool IsSetFileSize()
        {
            return this._fileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the media.
        /// </para>
        /// </summary>
        public string MimeType
        {
            get { return this._mimeType; }
            set { this._mimeType = value; }
        }

        // Check to see if MimeType property is set
        internal bool IsSetMimeType()
        {
            return this._mimeType != null;
        }

    }
}
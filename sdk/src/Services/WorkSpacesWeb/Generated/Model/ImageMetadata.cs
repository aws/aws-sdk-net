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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Metadata information about an uploaded image file.
    /// </summary>
    public partial class ImageMetadata
    {
        private string _fileExtension;
        private DateTime? _lastUploadTimestamp;
        private MimeType _mimeType;

        /// <summary>
        /// Gets and sets the property FileExtension. 
        /// <para>
        /// The file extension of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
        public string FileExtension
        {
            get { return this._fileExtension; }
            set { this._fileExtension = value; }
        }

        // Check to see if FileExtension property is set
        internal bool IsSetFileExtension()
        {
            return this._fileExtension != null;
        }

        /// <summary>
        /// Gets and sets the property LastUploadTimestamp. 
        /// <para>
        /// The timestamp when the image was last uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUploadTimestamp
        {
            get { return this._lastUploadTimestamp; }
            set { this._lastUploadTimestamp = value; }
        }

        // Check to see if LastUploadTimestamp property is set
        internal bool IsSetLastUploadTimestamp()
        {
            return this._lastUploadTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MimeType MimeType
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
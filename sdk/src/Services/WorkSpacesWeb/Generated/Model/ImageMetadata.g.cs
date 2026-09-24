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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Metadata information about an uploaded image file.
    /// </summary>
    public partial class ImageMetadata
    {
        /// <summary>
        /// Gets and sets the property FileExtension. 
        /// <para>
        /// The file extension of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 131072)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Checks to see if the FileExtension property is set.
        /// </summary>
        internal bool IsSetFileExtension() => this.FileExtension != null;

        /// <summary>
        /// Gets and sets the property LastUploadTimestamp. 
        /// <para>
        /// The timestamp when the image was last uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUploadTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUploadTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUploadTimestamp() => this.LastUploadTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MimeType MimeType { get; set; }

        /// <summary>
        /// Checks to see if the MimeType property is set.
        /// </summary>
        internal bool IsSetMimeType() => this.MimeType != null;
    }
}

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
    /// The input for a wallpaper image. Provide the image as either a binary image file or
    /// an S3 URI. Maximum 5 MB in JPEG or PNG format.
    /// </summary>
    public partial class WallpaperImageInput
    {
        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// The image provided as a binary image file.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5242880)]
        public MemoryStream Blob { get; set; }

        /// <summary>
        /// Checks to see if the Blob property is set.
        /// </summary>
        internal bool IsSetBlob() => this.Blob != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 URI pointing to the image file. The URI must use the format <c>s3://bucket-name/key-name</c>.
        /// You must have read access to the S3 object.
        /// </para>
        /// </summary>
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}

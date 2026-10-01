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

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// A structure that contains the <c>Timestamp</c>, <c>Error</c>, and <c>ImageContent</c>.
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error message shown when the image for the provided timestamp was not extracted
        /// due to a non-tryable error. An error will be returned if: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is no media that exists for the specified <c>Timestamp</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// The media for the specified time does not allow an image to be extracted. In this
        /// case the media is audio only, or the incorrect media has been ingested.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ImageError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ImageContent. 
        /// <para>
        /// An attribute of the <c>Image</c> object that is Base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6291456)]
        public string ImageContent { get; set; }

        /// <summary>
        /// Checks to see if the ImageContent property is set.
        /// </summary>
        internal bool IsSetImageContent() => this.ImageContent != null;

        /// <summary>
        /// Gets and sets the property TimeStamp. 
        /// <para>
        /// An attribute of the <c>Image</c> object that is used to extract an image from the
        /// video stream. This field is used to manage gaps on images or to better understand
        /// the pagination window.
        /// </para>
        /// </summary>
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the TimeStamp property is set.
        /// </summary>
        internal bool IsSetTimeStamp() => this.TimeStamp.HasValue;
    }
}

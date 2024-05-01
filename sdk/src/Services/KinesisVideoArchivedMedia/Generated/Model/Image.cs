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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
        private ImageError _error;
        private string _imageContent;
        private DateTime? _timeStamp;

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
        public ImageError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ImageContent. 
        /// <para>
        /// An attribute of the <c>Image</c> object that is Base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6291456)]
        public string ImageContent
        {
            get { return this._imageContent; }
            set { this._imageContent = value; }
        }

        // Check to see if ImageContent property is set
        internal bool IsSetImageContent()
        {
            return this._imageContent != null;
        }

        /// <summary>
        /// Gets and sets the property TimeStamp. 
        /// <para>
        /// An attribute of the <c>Image</c> object that is used to extract an image from the
        /// video stream. This field is used to manage gaps on images or to better understand
        /// the pagination window.
        /// </para>
        /// </summary>
        public DateTime? TimeStamp
        {
            get { return this._timeStamp; }
            set { this._timeStamp = value; }
        }

        // Check to see if TimeStamp property is set
        internal bool IsSetTimeStamp()
        {
            return this._timeStamp.HasValue; 
        }

    }
}
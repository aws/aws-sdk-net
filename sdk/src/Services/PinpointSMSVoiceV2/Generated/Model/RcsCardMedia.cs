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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The media content of a rich card, including the file URL, optional thumbnail, and
    /// display height.
    /// </summary>
    public partial class RcsCardMedia
    {
        private string _fileUrl;
        private string _height;
        private string _thumbnailUrl;

        /// <summary>
        /// Gets and sets the property FileUrl. 
        /// <para>
        /// The S3 URI of the media file for the card, in the format <c>s3://bucket-name/key</c>.
        /// Maximum 2000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
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

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The display height of the media in the card. Valid values are SHORT, MEDIUM, and TALL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailUrl. 
        /// <para>
        /// The S3 URI of an optional thumbnail image for the card media. Maximum 2000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string ThumbnailUrl
        {
            get { return this._thumbnailUrl; }
            set { this._thumbnailUrl = value; }
        }

        // Check to see if ThumbnailUrl property is set
        internal bool IsSetThumbnailUrl()
        {
            return this._thumbnailUrl != null;
        }

    }
}
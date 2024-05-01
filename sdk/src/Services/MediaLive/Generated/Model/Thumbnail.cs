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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Details of a single thumbnail
    /// </summary>
    public partial class Thumbnail
    {
        private string _body;
        private string _contentType;
        private ThumbnailType _thumbnailType;
        private DateTime? _timeStamp;

        /// <summary>
        /// Gets and sets the property Body. The binary data for the latest thumbnail.
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. The content type for the latest thumbnail.
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailType. Thumbnail Type
        /// </summary>
        public ThumbnailType ThumbnailType
        {
            get { return this._thumbnailType; }
            set { this._thumbnailType = value; }
        }

        // Check to see if ThumbnailType property is set
        internal bool IsSetThumbnailType()
        {
            return this._thumbnailType != null;
        }

        /// <summary>
        /// Gets and sets the property TimeStamp. Time stamp for the latest thumbnail.
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
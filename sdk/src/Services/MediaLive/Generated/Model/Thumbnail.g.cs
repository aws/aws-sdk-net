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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Details of a single thumbnail
    /// </summary>
    public partial class Thumbnail
    {
        /// <summary>
        /// Gets and sets the property Body. The binary data for the latest thumbnail.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. The content type for the latest thumbnail.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property ThumbnailType. Thumbnail Type
        /// </summary>
        public ThumbnailType ThumbnailType { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailType property is set.
        /// </summary>
        internal bool IsSetThumbnailType() => this.ThumbnailType != null;

        /// <summary>
        /// Gets and sets the property TimeStamp. Time stamp for the latest thumbnail.
        /// </summary>
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the TimeStamp property is set.
        /// </summary>
        internal bool IsSetTimeStamp() => this.TimeStamp.HasValue;
    }
}

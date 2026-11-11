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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// A presigned URL for downloading an attachment, along with the date and time the URL
    /// expires. Returned by <a>GetAttachmentDownloadLink</a>.
    /// </summary>
    public partial class DownloadUrl
    {
        /// <summary>
        /// Gets and sets the property ExpiryDate. 
        /// <para>
        /// The date and time, in ISO-8601 format, when the presigned URL expires. Download the
        /// attachment before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 30)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryDate property is set.
        /// </summary>
        internal bool IsSetExpiryDate() => this.ExpiryDate != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The presigned HTTPS URL that you can use to download the attachment. Download URLs
        /// are served from <c>downloadv1.attachments.support.{region}.amazonaws.com</c>. The
        /// <c>downloadv1</c> prefix is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}

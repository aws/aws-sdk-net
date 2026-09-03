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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
        private string _expiryDate;
        private string _url;

        /// <summary>
        /// Gets and sets the property ExpiryDate. 
        /// <para>
        /// The date and time, in ISO-8601 format, when the presigned URL expires. Download the
        /// attachment before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=30)]
        public string ExpiryDate
        {
            get { return this._expiryDate; }
            set { this._expiryDate = value; }
        }

        // Check to see if ExpiryDate property is set
        internal bool IsSetExpiryDate()
        {
            return this._expiryDate != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The presigned HTTPS URL that you can use to download the attachment. Download URLs
        /// are served from <c>downloadv1.attachments.support.{region}.amazonaws.com</c>. The
        /// <c>downloadv1</c> prefix is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}
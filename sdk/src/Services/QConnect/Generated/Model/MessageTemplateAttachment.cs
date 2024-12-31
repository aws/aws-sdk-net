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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Information about the message template attachment.
    /// </summary>
    public partial class MessageTemplateAttachment
    {
        private string _attachmentId;
        private ContentDisposition _contentDisposition;
        private string _name;
        private DateTime? _uploadedTime;
        private string _url;
        private DateTime? _urlExpiry;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The identifier of the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// The presentation information for the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentDisposition ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        // Check to see if ContentDisposition property is set
        internal bool IsSetContentDisposition()
        {
            return this._contentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attachment file being uploaded. The name should include the file extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UploadedTime. 
        /// <para>
        /// The timestamp when the attachment file was uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UploadedTime
        {
            get { return this._uploadedTime; }
            set { this._uploadedTime = value; }
        }

        // Check to see if UploadedTime property is set
        internal bool IsSetUploadedTime()
        {
            return this._uploadedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A pre-signed Amazon S3 URL that can be used to download the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
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

        /// <summary>
        /// Gets and sets the property UrlExpiry. 
        /// <para>
        /// The expiration time of the pre-signed Amazon S3 URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UrlExpiry
        {
            get { return this._urlExpiry; }
            set { this._urlExpiry = value; }
        }

        // Check to see if UrlExpiry property is set
        internal bool IsSetUrlExpiry()
        {
            return this._urlExpiry.HasValue; 
        }

    }
}
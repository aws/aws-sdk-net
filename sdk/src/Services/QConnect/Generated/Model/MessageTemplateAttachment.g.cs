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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Information about the message template attachment.
    /// </summary>
    public partial class MessageTemplateAttachment
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The identifier of the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// The presentation information for the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentDisposition ContentDisposition { get; set; }

        /// <summary>
        /// Checks to see if the ContentDisposition property is set.
        /// </summary>
        internal bool IsSetContentDisposition() => this.ContentDisposition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attachment file being uploaded. The name should include the file extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UploadedTime. 
        /// <para>
        /// The timestamp when the attachment file was uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UploadedTime { get; set; }

        /// <summary>
        /// Checks to see if the UploadedTime property is set.
        /// </summary>
        internal bool IsSetUploadedTime() => this.UploadedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A pre-signed Amazon S3 URL that can be used to download the attachment file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property UrlExpiry. 
        /// <para>
        /// The expiration time of the pre-signed Amazon S3 URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UrlExpiry { get; set; }

        /// <summary>
        /// Checks to see if the UrlExpiry property is set.
        /// </summary>
        internal bool IsSetUrlExpiry() => this.UrlExpiry.HasValue;
    }
}

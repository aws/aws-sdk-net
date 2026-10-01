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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Contains metadata and attachment raw content.
    /// </summary>
    public partial class Attachment
    {
        /// <summary>
        /// Gets and sets the property ContentDescription. 
        /// <para>
        ///  A brief description of the attachment content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// Checks to see if the ContentDescription property is set.
        /// </summary>
        internal bool IsSetContentDescription() => this.ContentDescription != null;

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        ///  A standard descriptor indicating how the attachment should be rendered in the email.
        /// Supported values: <c>ATTACHMENT</c> or <c>INLINE</c>.
        /// </para>
        /// </summary>
        public AttachmentContentDisposition ContentDisposition { get; set; }

        /// <summary>
        /// Checks to see if the ContentDisposition property is set.
        /// </summary>
        internal bool IsSetContentDisposition() => this.ContentDisposition != null;

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        ///  Unique identifier for the attachment, used for referencing attachments with INLINE
        /// disposition in HTML content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 78)]
        public string ContentId { get; set; }

        /// <summary>
        /// Checks to see if the ContentId property is set.
        /// </summary>
        internal bool IsSetContentId() => this.ContentId != null;

        /// <summary>
        /// Gets and sets the property ContentTransferEncoding. 
        /// <para>
        ///  Specifies how the attachment is encoded. Supported values: <c>BASE64</c>, <c>QUOTED_PRINTABLE</c>,
        /// <c>SEVEN_BIT</c>.
        /// </para>
        /// </summary>
        public AttachmentContentTransferEncoding ContentTransferEncoding { get; set; }

        /// <summary>
        /// Checks to see if the ContentTransferEncoding property is set.
        /// </summary>
        internal bool IsSetContentTransferEncoding() => this.ContentTransferEncoding != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  The MIME type of the attachment.
        /// </para>
        ///  <note> 
        /// <para>
        /// Example: <c>application/pdf</c>, <c>image/jpeg</c> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 78)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The file name for the attachment as it will appear in the email. Amazon SES restricts
        /// certain file extensions. To ensure attachments are accepted, check the <a href="https://docs.aws.amazon.com/ses/latest/dg/mime-types.html">Unsupported
        /// attachment types</a> in the Amazon SES Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        ///  The raw data of the attachment. It needs to be base64-encoded if you are accessing
        /// Amazon SES directly through the HTTPS interface. If you are accessing Amazon SES using
        /// an Amazon Web Services SDK, the SDK takes care of the base 64-encoding for you.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream RawContent { get; set; }

        /// <summary>
        /// Checks to see if the RawContent property is set.
        /// </summary>
        internal bool IsSetRawContent() => this.RawContent != null;
    }
}

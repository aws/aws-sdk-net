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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// A file attached to a notification event.
    /// </summary>
    public partial class NotificationEventAttachment
    {
        /// <summary>
        /// Gets and sets the property AttachmentDownloadUrl. 
        /// <para>
        /// A temporary URL for downloading the attachment. The URL expires shortly after it's
        /// issued.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 4096)]
        public string AttachmentDownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentDownloadUrl property is set.
        /// </summary>
        internal bool IsSetAttachmentDownloadUrl() => this.AttachmentDownloadUrl != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME content type of the attachment, for example <c>application/pdf</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the attachment that recipients see.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;
    }
}

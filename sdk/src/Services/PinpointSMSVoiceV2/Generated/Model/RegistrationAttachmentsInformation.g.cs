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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Provides information on the specified registration attachments.
    /// </summary>
    public partial class RegistrationAttachmentsInformation
    {
        /// <summary>
        /// Gets and sets the property AttachmentStatus. 
        /// <para>
        /// The status of the registration attachment. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UPLOAD_IN_PROGRESS</c> The attachment is being uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPLOAD_COMPLETE</c> The attachment has been uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPLOAD_FAILED</c> The attachment failed to uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> The attachment has been deleted..
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttachmentStatus AttachmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentStatus property is set.
        /// </summary>
        internal bool IsSetAttachmentStatus() => this.AttachmentStatus != null;

        /// <summary>
        /// Gets and sets the property AttachmentUploadErrorReason. 
        /// <para>
        /// A description of why the upload didn't successfully complete.
        /// </para>
        /// </summary>
        public AttachmentUploadErrorReason AttachmentUploadErrorReason { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentUploadErrorReason property is set.
        /// </summary>
        internal bool IsSetAttachmentUploadErrorReason() => this.AttachmentUploadErrorReason != null;

        /// <summary>
        /// Gets and sets the property AttachmentUrl. 
        /// <para>
        /// The URL to the document that's associated with the registration attachment.
        /// </para>
        /// </summary>
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentUrl property is set.
        /// </summary>
        internal bool IsSetAttachmentUrl() => this.AttachmentUrl != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the registration attachment was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrationAttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registration attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationAttachmentArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationAttachmentArn property is set.
        /// </summary>
        internal bool IsSetRegistrationAttachmentArn() => this.RegistrationAttachmentArn != null;

        /// <summary>
        /// Gets and sets the property RegistrationAttachmentId. 
        /// <para>
        /// The unique identifier for the registration attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationAttachmentId property is set.
        /// </summary>
        internal bool IsSetRegistrationAttachmentId() => this.RegistrationAttachmentId != null;
    }
}

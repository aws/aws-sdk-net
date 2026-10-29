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
    /// A communication associated with a support case. The communication consists of the
    /// case ID, the message body, attachment information, the submitter of the communication,
    /// and the date and time of the communication.
    /// </summary>
    public partial class Communication
    {
        /// <summary>
        /// Gets and sets the property AttachmentSet. 
        /// <para>
        /// Information about the attachments to the case communication that are 5 MB or smaller.
        /// This field doesn't include attachments larger than 5 MB. To enumerate every attachment
        /// on the communication, including attachments larger than 5 MB, use the <c>attachments</c>
        /// field instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentDetails> AttachmentSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentDetails>() : null;

        /// <summary>
        /// Checks to see if the AttachmentSet property is set.
        /// </summary>
        internal bool IsSetAttachmentSet() => this.AttachmentSet != null && (this.AttachmentSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Information about all attachments on the case communication. This includes attachments
        /// added through <c>AddAttachmentsToSet</c> and attachments uploaded through <c>GetAttachmentUploadLinks</c>.
        /// </para>
        ///  
        /// <para>
        /// Use this field to enumerate every attachment on the communication. To download an
        /// attachment listed in this field, use <a>GetAttachmentDownloadLink</a>. <c>GetAttachmentDownloadLink</c>
        /// returns a presigned URL that works for attachments of any size. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentDetails> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentDetails>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The text of the communication between the customer and Amazon Web Services Support.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8000)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The support case ID requested or returned in the call. The case ID is an alphanumeric
        /// string formatted as shown in this example: case-<i>12345678910-exen-2025-c4c1d2bf33c5cf47</i>
        /// 
        /// </para>
        /// </summary>
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property SubmittedBy. 
        /// <para>
        /// The identity of the account that submitted, or responded to, the support case. Customer
        /// entries include the IAM role as well as the email address (for example, "AdminRole
        /// (Role) <janedoe@example.com>). Entries from the Amazon Web Services Support team display
        /// "Amazon Web Services," and don't show an email address. 
        /// </para>
        /// </summary>
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBy property is set.
        /// </summary>
        internal bool IsSetSubmittedBy() => this.SubmittedBy != null;

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// The time the communication was created.
        /// </para>
        /// </summary>
        public string TimeCreated { get; set; }

        /// <summary>
        /// Checks to see if the TimeCreated property is set.
        /// </summary>
        internal bool IsSetTimeCreated() => this.TimeCreated != null;
    }
}

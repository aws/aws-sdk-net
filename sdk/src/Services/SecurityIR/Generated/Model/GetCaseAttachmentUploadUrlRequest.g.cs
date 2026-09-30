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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the GetCaseAttachmentUploadUrl operation. Uploads
    /// an attachment to a case.
    /// </summary>
    public partial class GetCaseAttachmentUploadUrlRequest : AmazonSecurityIRRequest
    {
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for GetCaseAttachmentUploadUrl to identify the case ID for uploading
        /// an attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 32)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. <note> 
        /// <para>
        /// The <c>clientToken</c> field is an idempotency key used to ensure that repeated attempts
        /// for a single action will be ignored by the server during retries. A caller supplied
        /// unique ID (typically a UUID) should be provided. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// Required element for GetCaseAttachmentUploadUrl to identify the size of the file attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 104857600)]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Checks to see if the ContentLength property is set.
        /// </summary>
        internal bool IsSetContentLength() => this.ContentLength.HasValue;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// Required element for GetCaseAttachmentUploadUrl to identify the file name of the attachment
        /// to upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;
    }
}

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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the GetCaseAttachmentUploadUrl operation.
    /// Grants permission to upload an attachment to a case.
    /// </summary>
    public partial class GetCaseAttachmentUploadUrlRequest : AmazonSecurityIRRequest
    {
        private string _caseId;
        private string _clientToken;
        private long? _contentLength;
        private string _fileName;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for GetCaseAttachmentUploadUrl to identify the case ID for uploading
        /// an attachment to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=32)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Optional element for customer provided token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// Required element for GetCaseAttachmentUploadUrl to identify the size od the file attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=104857600)]
        public long ContentLength
        {
            get { return this._contentLength.GetValueOrDefault(); }
            set { this._contentLength = value; }
        }

        // Check to see if ContentLength property is set
        internal bool IsSetContentLength()
        {
            return this._contentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// Required element for GetCaseAttachmentUploadUrl to identify the file name of the attachment
        /// to upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

    }
}
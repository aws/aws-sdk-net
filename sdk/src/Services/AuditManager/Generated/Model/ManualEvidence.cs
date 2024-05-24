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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Evidence that's manually added to a control in Audit Manager. <c>manualEvidence</c>
    /// can be one of the following: <c>evidenceFileName</c>, <c>s3ResourcePath</c>, or <c>textResponse</c>.
    /// </summary>
    public partial class ManualEvidence
    {
        private string _evidenceFileName;
        private string _s3ResourcePath;
        private string _textResponse;

        /// <summary>
        /// Gets and sets the property EvidenceFileName. 
        /// <para>
        /// The name of the file that's uploaded as manual evidence. This name is populated using
        /// the <c>evidenceFileName</c> value from the <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_GetEvidenceFileUploadUrl.html">
        /// <c>GetEvidenceFileUploadUrl</c> </a> API response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=300)]
        public string EvidenceFileName
        {
            get { return this._evidenceFileName; }
            set { this._evidenceFileName = value; }
        }

        // Check to see if EvidenceFileName property is set
        internal bool IsSetEvidenceFileName()
        {
            return this._evidenceFileName != null;
        }

        /// <summary>
        /// Gets and sets the property S3ResourcePath. 
        /// <para>
        /// The S3 URL of the object that's imported as manual evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3ResourcePath
        {
            get { return this._s3ResourcePath; }
            set { this._s3ResourcePath = value; }
        }

        // Check to see if S3ResourcePath property is set
        internal bool IsSetS3ResourcePath()
        {
            return this._s3ResourcePath != null;
        }

        /// <summary>
        /// Gets and sets the property TextResponse. 
        /// <para>
        /// The plain text response that's entered and saved as manual evidence.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string TextResponse
        {
            get { return this._textResponse; }
            set { this._textResponse = value; }
        }

        // Check to see if TextResponse property is set
        internal bool IsSetTextResponse()
        {
            return this._textResponse != null;
        }

    }
}
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
    /// This is the response object from the GetEvidenceFileUploadUrl operation.
    /// </summary>
    public partial class GetEvidenceFileUploadUrlResponse : AmazonWebServiceResponse
    {
        private string _evidenceFileName;
        private string _uploadUrl;

        /// <summary>
        /// Gets and sets the property EvidenceFileName. 
        /// <para>
        /// The name of the uploaded manual evidence file that the presigned URL was generated
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property UploadUrl. 
        /// <para>
        /// The presigned URL that was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string UploadUrl
        {
            get { return this._uploadUrl; }
            set { this._uploadUrl = value; }
        }

        // Check to see if UploadUrl property is set
        internal bool IsSetUploadUrl()
        {
            return this._uploadUrl != null;
        }

    }
}
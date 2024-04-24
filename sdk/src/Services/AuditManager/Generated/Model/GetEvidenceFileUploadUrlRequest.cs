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
    /// Container for the parameters to the GetEvidenceFileUploadUrl operation.
    /// Creates a presigned Amazon S3 URL that can be used to upload a file as manual evidence.
    /// For instructions on how to use this operation, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/upload-evidence.html#how-to-upload-manual-evidence-files">Upload
    /// a file from your browser </a> in the <i>Audit Manager User Guide</i>.
    /// 
    ///  
    /// <para>
    /// The following restrictions apply to this operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Maximum size of an individual evidence file: 100 MB
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Number of daily manual evidence uploads per control: 100
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Supported file formats: See <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/upload-evidence.html#supported-manual-evidence-files">Supported
    /// file types for manual evidence</a> in the <i>Audit Manager User Guide</i> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about Audit Manager service restrictions, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
    /// and restrictions for Audit Manager</a>.
    /// </para>
    /// </summary>
    public partial class GetEvidenceFileUploadUrlRequest : AmazonAuditManagerRequest
    {
        private string _fileName;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The file that you want to upload. For a list of supported file formats, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/upload-evidence.html#supported-manual-evidence-files">Supported
        /// file types for manual evidence</a> in the <i>Audit Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=300)]
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
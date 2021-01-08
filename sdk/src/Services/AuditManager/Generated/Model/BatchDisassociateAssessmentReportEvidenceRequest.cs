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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisassociateAssessmentReportEvidence operation.
    /// Disassociates a list of evidence from the specified assessment report in AWS Audit
    /// Manager.
    /// </summary>
    public partial class BatchDisassociateAssessmentReportEvidenceRequest : AmazonAuditManagerRequest
    {
        private string _assessmentId;
        private string _evidenceFolderId;
        private List<string> _evidenceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the specified assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceFolderId. 
        /// <para>
        ///  The identifier for the folder in which evidence is stored. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string EvidenceFolderId
        {
            get { return this._evidenceFolderId; }
            set { this._evidenceFolderId = value; }
        }

        // Check to see if EvidenceFolderId property is set
        internal bool IsSetEvidenceFolderId()
        {
            return this._evidenceFolderId != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceIds. 
        /// <para>
        ///  The list of evidence identifiers. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> EvidenceIds
        {
            get { return this._evidenceIds; }
            set { this._evidenceIds = value; }
        }

        // Check to see if EvidenceIds property is set
        internal bool IsSetEvidenceIds()
        {
            return this._evidenceIds != null && this._evidenceIds.Count > 0; 
        }

    }
}
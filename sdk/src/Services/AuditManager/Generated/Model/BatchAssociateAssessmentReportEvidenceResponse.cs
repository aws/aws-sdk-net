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
    /// This is the response object from the BatchAssociateAssessmentReportEvidence operation.
    /// </summary>
    public partial class BatchAssociateAssessmentReportEvidenceResponse : AmazonWebServiceResponse
    {
        private List<AssessmentReportEvidenceError> _errors = new List<AssessmentReportEvidenceError>();
        private List<string> _evidenceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        ///  A list of errors returned by the <code>BatchAssociateAssessmentReportEvidence</code>
        /// API. 
        /// </para>
        /// </summary>
        public List<AssessmentReportEvidenceError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceIds. 
        /// <para>
        ///  The identifier for the evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
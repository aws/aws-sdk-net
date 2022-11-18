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
    /// Container for the parameters to the BatchImportEvidenceToAssessmentControl operation.
    /// Uploads one or more pieces of evidence to a control in an Audit Manager assessment.
    /// You can upload manual evidence from any Amazon Simple Storage Service (Amazon S3)
    /// bucket by specifying the S3 URI of the evidence. 
    /// 
    ///  
    /// <para>
    /// You must upload manual evidence to your S3 bucket before you can upload it to your
    /// assessment. For instructions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// in the <i>Amazon Simple Storage Service API Reference.</i> 
    /// </para>
    ///  
    /// <para>
    /// The following restrictions apply to this action:
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
    public partial class BatchImportEvidenceToAssessmentControlRequest : AmazonAuditManagerRequest
    {
        private string _assessmentId;
        private string _controlId;
        private string _controlSetId;
        private List<ManualEvidence> _manualEvidence = new List<ManualEvidence>();

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the assessment. 
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
        /// Gets and sets the property ControlId. 
        /// <para>
        ///  The identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string ControlSetId
        {
            get { return this._controlSetId; }
            set { this._controlSetId = value; }
        }

        // Check to see if ControlSetId property is set
        internal bool IsSetControlSetId()
        {
            return this._controlSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ManualEvidence. 
        /// <para>
        ///  The list of manual evidence objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<ManualEvidence> ManualEvidence
        {
            get { return this._manualEvidence; }
            set { this._manualEvidence = value; }
        }

        // Check to see if ManualEvidence property is set
        internal bool IsSetManualEvidence()
        {
            return this._manualEvidence != null && this._manualEvidence.Count > 0; 
        }

    }
}
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
    /// The control entity that represents a standard control or a custom control in an Audit
    /// Manager assessment.
    /// </summary>
    public partial class AssessmentControl
    {
        private int? _assessmentReportEvidenceCount;
        private List<ControlComment> _comments = new List<ControlComment>();
        private string _description;
        private int? _evidenceCount;
        private List<string> _evidenceSources = new List<string>();
        private string _id;
        private string _name;
        private ControlResponse _response;
        private ControlStatus _status;

        /// <summary>
        /// Gets and sets the property AssessmentReportEvidenceCount. 
        /// <para>
        ///  The amount of evidence in the assessment report. 
        /// </para>
        /// </summary>
        public int AssessmentReportEvidenceCount
        {
            get { return this._assessmentReportEvidenceCount.GetValueOrDefault(); }
            set { this._assessmentReportEvidenceCount = value; }
        }

        // Check to see if AssessmentReportEvidenceCount property is set
        internal bool IsSetAssessmentReportEvidenceCount()
        {
            return this._assessmentReportEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        ///  The list of comments that's attached to the control. 
        /// </para>
        /// </summary>
        public List<ControlComment> Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        // Check to see if Comments property is set
        internal bool IsSetComments()
        {
            return this._comments != null && this._comments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceCount. 
        /// <para>
        ///  The amount of evidence that's collected for the control. 
        /// </para>
        /// </summary>
        public int EvidenceCount
        {
            get { return this._evidenceCount.GetValueOrDefault(); }
            set { this._evidenceCount = value; }
        }

        // Check to see if EvidenceCount property is set
        internal bool IsSetEvidenceCount()
        {
            return this._evidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceSources. 
        /// <para>
        ///  The list of data sources for the evidence. 
        /// </para>
        /// </summary>
        public List<string> EvidenceSources
        {
            get { return this._evidenceSources; }
            set { this._evidenceSources = value; }
        }

        // Check to see if EvidenceSources property is set
        internal bool IsSetEvidenceSources()
        {
            return this._evidenceSources != null && this._evidenceSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        ///  The response of the control. 
        /// </para>
        /// </summary>
        public ControlResponse Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the control. 
        /// </para>
        /// </summary>
        public ControlStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
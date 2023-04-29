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
    /// A record that contains the information needed to demonstrate compliance with the
    /// requirements specified by a control. Examples of evidence include change activity
    /// invoked by a user, or a system configuration snapshot.
    /// </summary>
    public partial class Evidence
    {
        private string _assessmentReportSelection;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _awsAccountId;
        private string _awsOrganization;
        private string _complianceCheck;
        private string _dataSource;
        private string _eventName;
        private string _eventSource;
        private string _evidenceAwsAccountId;
        private string _evidenceByType;
        private string _evidenceFolderId;
        private string _iamId;
        private string _id;
        private List<Resource> _resourcesIncluded = new List<Resource>();
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property AssessmentReportSelection. 
        /// <para>
        ///  Specifies whether the evidence is included in the assessment report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string AssessmentReportSelection
        {
            get { return this._assessmentReportSelection; }
            set { this._assessmentReportSelection = value; }
        }

        // Check to see if AssessmentReportSelection property is set
        internal bool IsSetAssessmentReportSelection()
        {
            return this._assessmentReportSelection != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  The names and values that are used by the evidence event. This includes an attribute
        /// name (such as <code>allowUsersToChangePassword</code>) and value (such as <code>true</code>
        /// or <code>false</code>). 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        ///  The identifier for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsOrganization. 
        /// <para>
        ///  The Amazon Web Services account that the evidence is collected from, and its organization
        /// path. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string AwsOrganization
        {
            get { return this._awsOrganization; }
            set { this._awsOrganization = value; }
        }

        // Check to see if AwsOrganization property is set
        internal bool IsSetAwsOrganization()
        {
            return this._awsOrganization != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceCheck. 
        /// <para>
        /// The evaluation status for automated evidence that falls under the compliance check
        /// category.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Audit Manager classes evidence as non-compliant if Security Hub reports a <i>Fail</i>
        /// result, or if Config reports a <i>Non-compliant</i> result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Audit Manager classes evidence as compliant if Security Hub reports a <i>Pass</i>
        /// result, or if Config reports a <i>Compliant</i> result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a compliance check isn't available or applicable, then no compliance evaluation
        /// can be made for that evidence. This is the case if the evidence uses Config or Security
        /// Hub as the underlying data source type, but those services aren't enabled. This is
        /// also the case if the evidence uses an underlying data source type that doesn't support
        /// compliance checks (such as manual evidence, Amazon Web Services API calls, or CloudTrail).
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ComplianceCheck
        {
            get { return this._complianceCheck; }
            set { this._complianceCheck = value; }
        }

        // Check to see if ComplianceCheck property is set
        internal bool IsSetComplianceCheck()
        {
            return this._complianceCheck != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The data source where the evidence was collected from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        ///  The name of the evidence event. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        ///  The Amazon Web Service that the evidence is collected from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceAwsAccountId. 
        /// <para>
        ///  The identifier for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string EvidenceAwsAccountId
        {
            get { return this._evidenceAwsAccountId; }
            set { this._evidenceAwsAccountId = value; }
        }

        // Check to see if EvidenceAwsAccountId property is set
        internal bool IsSetEvidenceAwsAccountId()
        {
            return this._evidenceAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceByType. 
        /// <para>
        ///  The type of automated evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string EvidenceByType
        {
            get { return this._evidenceByType; }
            set { this._evidenceByType = value; }
        }

        // Check to see if EvidenceByType property is set
        internal bool IsSetEvidenceByType()
        {
            return this._evidenceByType != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceFolderId. 
        /// <para>
        ///  The identifier for the folder that the evidence is stored in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property IamId. 
        /// <para>
        ///  The unique identifier for the user or role that's associated with the evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamId
        {
            get { return this._iamId; }
            set { this._iamId = value; }
        }

        // Check to see if IamId property is set
        internal bool IsSetIamId()
        {
            return this._iamId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier for the evidence. 
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
        /// Gets and sets the property ResourcesIncluded. 
        /// <para>
        ///  The list of resources that are assessed to generate the evidence. 
        /// </para>
        /// </summary>
        public List<Resource> ResourcesIncluded
        {
            get { return this._resourcesIncluded; }
            set { this._resourcesIncluded = value; }
        }

        // Check to see if ResourcesIncluded property is set
        internal bool IsSetResourcesIncluded()
        {
            return this._resourcesIncluded != null && this._resourcesIncluded.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        ///  The timestamp that represents when the evidence was collected. 
        /// </para>
        /// </summary>
        public DateTime Time
        {
            get { return this._time.GetValueOrDefault(); }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides consistent format for the contents of the Security Hub-aggregated findings.
    /// AwsSecurityFinding format enables you to share findings between AWS security services
    /// and third-party solutions, and compliance checks.
    /// 
    ///  <note> 
    /// <para>
    /// A finding is a potential security issue generated either by AWS services (GuardDuty,
    /// Inspector, Macie) or by the integrated third-party solutions and compliance checks.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AwsSecurityFinding
    {
        private string _awsAccountId;
        private Compliance _compliance;
        private int? _confidence;
        private string _createdAt;
        private int? _criticality;
        private string _description;
        private string _firstObservedAt;
        private string _generatorId;
        private string _id;
        private string _lastObservedAt;
        private List<Malware> _malware = new List<Malware>();
        private Network _network;
        private Note _note;
        private ProcessDetails _process;
        private string _productArn;
        private Dictionary<string, string> _productFields = new Dictionary<string, string>();
        private RecordState _recordState;
        private List<RelatedFinding> _relatedFindings = new List<RelatedFinding>();
        private Remediation _remediation;
        private List<Resource> _resources = new List<Resource>();
        private string _schemaVersion;
        private Severity _severity;
        private string _sourceUrl;
        private List<ThreatIntelIndicator> _threatIntelIndicators = new List<ThreatIntelIndicator>();
        private string _title;
        private List<string> _types = new List<string>();
        private string _updatedAt;
        private Dictionary<string, string> _userDefinedFields = new Dictionary<string, string>();
        private VerificationState _verificationState;
        private WorkflowState _workflowState;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID in which a finding is generated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Compliance. 
        /// <para>
        /// This data type is exclusive to findings that are generated as the result of a check
        /// run against a specific rule in a supported standard (for example, AWS CIS Foundations).
        /// Contains compliance-related finding details.
        /// </para>
        /// </summary>
        public Compliance Compliance
        {
            get { return this._compliance; }
            set { this._compliance = value; }
        }

        // Check to see if Compliance property is set
        internal bool IsSetCompliance()
        {
            return this._compliance != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// A finding's confidence. Confidence is defined as the likelihood that a finding accurately
        /// identifies the behavior or issue that it was intended to identify. Confidence is scored
        /// on a 0-100 basis using a ratio scale. 0 equates zero percent confidence and 100 equates
        /// to 100 percent confidence.
        /// </para>
        /// </summary>
        public int Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the potential security issue captured
        /// by a finding was created by the security findings provider.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The level of importance assigned to the resources associated with the finding. A score
        /// of 0 means the underlying resources have no criticality, and a score of 100 is reserved
        /// for the most critical resources.
        /// </para>
        /// </summary>
        public int Criticality
        {
            get { return this._criticality.GetValueOrDefault(); }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A finding's description.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the potential security issue captured
        /// by a finding was first observed by the security findings provider.
        /// </para>
        /// </summary>
        public string FirstObservedAt
        {
            get { return this._firstObservedAt; }
            set { this._firstObservedAt = value; }
        }

        // Check to see if FirstObservedAt property is set
        internal bool IsSetFirstObservedAt()
        {
            return this._firstObservedAt != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratorId. 
        /// <para>
        /// This is the identifier for the solution-specific component (a discrete unit of logic)
        /// that generated a finding. In various security findings provider's solutions, this
        /// generator can be called a rule, a check, a detector, a plug-in, etc. 
        /// </para>
        /// </summary>
        public string GeneratorId
        {
            get { return this._generatorId; }
            set { this._generatorId = value; }
        }

        // Check to see if GeneratorId property is set
        internal bool IsSetGeneratorId()
        {
            return this._generatorId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The security findings provider-specific identifier for a finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the potential security issue captured
        /// by a finding was most recently observed by the security findings provider.
        /// </para>
        /// </summary>
        public string LastObservedAt
        {
            get { return this._lastObservedAt; }
            set { this._lastObservedAt = value; }
        }

        // Check to see if LastObservedAt property is set
        internal bool IsSetLastObservedAt()
        {
            return this._lastObservedAt != null;
        }

        /// <summary>
        /// Gets and sets the property Malware. 
        /// <para>
        /// A list of malware related to a finding.
        /// </para>
        /// </summary>
        public List<Malware> Malware
        {
            get { return this._malware; }
            set { this._malware = value; }
        }

        // Check to see if Malware property is set
        internal bool IsSetMalware()
        {
            return this._malware != null && this._malware.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The details of network-related information about a finding.
        /// </para>
        /// </summary>
        public Network Network
        {
            get { return this._network; }
            set { this._network = value; }
        }

        // Check to see if Network property is set
        internal bool IsSetNetwork()
        {
            return this._network != null;
        }

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A user-defined note added to a finding.
        /// </para>
        /// </summary>
        public Note Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// The details of process-related information about a finding.
        /// </para>
        /// </summary>
        public ProcessDetails Process
        {
            get { return this._process; }
            set { this._process = value; }
        }

        // Check to see if Process property is set
        internal bool IsSetProcess()
        {
            return this._process != null;
        }

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN generated by Security Hub that uniquely identifies a third-party company (security
        /// findings provider) once this provider's product (solution that generates findings)
        /// is registered with Security Hub. 
        /// </para>
        /// </summary>
        public string ProductArn
        {
            get { return this._productArn; }
            set { this._productArn = value; }
        }

        // Check to see if ProductArn property is set
        internal bool IsSetProductArn()
        {
            return this._productArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductFields. 
        /// <para>
        /// A data type where security findings providers can include additional solution-specific
        /// details that are not part of the defined AwsSecurityFinding format.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ProductFields
        {
            get { return this._productFields; }
            set { this._productFields = value; }
        }

        // Check to see if ProductFields property is set
        internal bool IsSetProductFields()
        {
            return this._productFields != null && this._productFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The record state of a finding.
        /// </para>
        /// </summary>
        public RecordState RecordState
        {
            get { return this._recordState; }
            set { this._recordState = value; }
        }

        // Check to see if RecordState property is set
        internal bool IsSetRecordState()
        {
            return this._recordState != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedFindings. 
        /// <para>
        /// A list of related findings.
        /// </para>
        /// </summary>
        public List<RelatedFinding> RelatedFindings
        {
            get { return this._relatedFindings; }
            set { this._relatedFindings = value; }
        }

        // Check to see if RelatedFindings property is set
        internal bool IsSetRelatedFindings()
        {
            return this._relatedFindings != null && this._relatedFindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// An data type that describes the remediation options for a finding.
        /// </para>
        /// </summary>
        public Remediation Remediation
        {
            get { return this._remediation; }
            set { this._remediation = value; }
        }

        // Check to see if Remediation property is set
        internal bool IsSetRemediation()
        {
            return this._remediation != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// A set of resource data types that describe the resources to which the finding refers.
        /// </para>
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version for which a finding is formatted.
        /// </para>
        /// </summary>
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// A finding's severity.
        /// </para>
        /// </summary>
        public Severity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// A URL that links to a page about the current finding in the security findings provider's
        /// solution.
        /// </para>
        /// </summary>
        public string SourceUrl
        {
            get { return this._sourceUrl; }
            set { this._sourceUrl = value; }
        }

        // Check to see if SourceUrl property is set
        internal bool IsSetSourceUrl()
        {
            return this._sourceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicators. 
        /// <para>
        /// Threat intel details related to a finding.
        /// </para>
        /// </summary>
        public List<ThreatIntelIndicator> ThreatIntelIndicators
        {
            get { return this._threatIntelIndicators; }
            set { this._threatIntelIndicators = value; }
        }

        // Check to see if ThreatIntelIndicators property is set
        internal bool IsSetThreatIntelIndicators()
        {
            return this._threatIntelIndicators != null && this._threatIntelIndicators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A finding's title.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// One or more finding types in the format of 'namespace/category/classifier' that classify
        /// a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are: Software and Configuration Checks | TTPs | Effects | Unusual
        /// Behaviors | Sensitive Data Identifications
        /// </para>
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the finding record was last updated
        /// by the security findings provider. 
        /// </para>
        /// </summary>
        public string UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null;
        }

        /// <summary>
        /// Gets and sets the property UserDefinedFields. 
        /// <para>
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> UserDefinedFields
        {
            get { return this._userDefinedFields; }
            set { this._userDefinedFields = value; }
        }

        // Check to see if UserDefinedFields property is set
        internal bool IsSetUserDefinedFields()
        {
            return this._userDefinedFields != null && this._userDefinedFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// Indicates the veracity of a finding. 
        /// </para>
        /// </summary>
        public VerificationState VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowState. 
        /// <para>
        /// The workflow state of a finding. 
        /// </para>
        /// </summary>
        public WorkflowState WorkflowState
        {
            get { return this._workflowState; }
            set { this._workflowState = value; }
        }

        // Check to see if WorkflowState property is set
        internal bool IsSetWorkflowState()
        {
            return this._workflowState != null;
        }

    }
}
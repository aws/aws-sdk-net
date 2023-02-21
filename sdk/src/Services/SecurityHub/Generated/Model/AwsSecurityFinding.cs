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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides a consistent format for Security Hub findings. <code>AwsSecurityFinding</code>
    /// format allows you to share findings between Amazon Web Services security services
    /// and third-party solutions.
    /// 
    ///  <note> 
    /// <para>
    /// A finding is a potential security issue generated either by Amazon Web Services services
    /// or by the integrated third-party solutions and standards checks.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AwsSecurityFinding
    {
        private Action _action;
        private string _awsAccountId;
        private string _companyName;
        private Compliance _compliance;
        private int? _confidence;
        private string _createdAt;
        private int? _criticality;
        private string _description;
        private FindingProviderFields _findingProviderFields;
        private string _firstObservedAt;
        private string _generatorId;
        private string _id;
        private string _lastObservedAt;
        private List<Malware> _malware = new List<Malware>();
        private Network _network;
        private List<NetworkPathComponent> _networkPath = new List<NetworkPathComponent>();
        private Note _note;
        private PatchSummary _patchSummary;
        private ProcessDetails _process;
        private string _productArn;
        private Dictionary<string, string> _productFields = new Dictionary<string, string>();
        private string _productName;
        private RecordState _recordState;
        private string _region;
        private List<RelatedFinding> _relatedFindings = new List<RelatedFinding>();
        private Remediation _remediation;
        private List<Resource> _resources = new List<Resource>();
        private bool? _sample;
        private string _schemaVersion;
        private Severity _severity;
        private string _sourceUrl;
        private List<ThreatIntelIndicator> _threatIntelIndicators = new List<ThreatIntelIndicator>();
        private List<Threat> _threats = new List<Threat>();
        private string _title;
        private List<string> _types = new List<string>();
        private string _updatedAt;
        private Dictionary<string, string> _userDefinedFields = new Dictionary<string, string>();
        private VerificationState _verificationState;
        private List<Vulnerability> _vulnerabilities = new List<Vulnerability>();
        private Workflow _workflow;
        private WorkflowState _workflowState;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Provides details about an action that affects or that was taken on a resource.
        /// </para>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that a finding is generated in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the company for the product that generated the finding.
        /// </para>
        ///  
        /// <para>
        /// Security Hub populates this attribute automatically for each finding. You cannot update
        /// this attribute with <code>BatchImportFindings</code> or <code>BatchUpdateFindings</code>.
        /// The exception to this is a custom integration.
        /// </para>
        ///  
        /// <para>
        /// When you use the Security Hub console or API to filter findings by company name, you
        /// use this attribute.
        /// </para>
        /// </summary>
        public string CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null;
        }

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// This data type is exclusive to findings that are generated as the result of a check
        /// run against a specific rule in a supported security standard, such as CIS Amazon Web
        /// Services Foundations. Contains security standard-related finding details.
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
        /// identifies the behavior or issue that it was intended to identify.
        /// </para>
        ///  
        /// <para>
        /// Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent
        /// confidence and 100 means 100 percent confidence.
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
        /// Indicates when the security-findings provider created the potential security issue
        /// that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The level of importance assigned to the resources associated with the finding.
        /// </para>
        ///  
        /// <para>
        /// A score of 0 means that the underlying resources have no criticality, and a score
        /// of 100 is reserved for the most critical resources.
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
        ///  <note> 
        /// <para>
        /// In this release, <code>Description</code> is a required property.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FindingProviderFields. 
        /// <para>
        /// In a <code>BatchImportFindings</code> request, finding providers use <code>FindingProviderFields</code>
        /// to provide and update their own values for confidence, criticality, related findings,
        /// severity, and types.
        /// </para>
        /// </summary>
        public FindingProviderFields FindingProviderFields
        {
            get { return this._findingProviderFields; }
            set { this._findingProviderFields = value; }
        }

        // Check to see if FindingProviderFields property is set
        internal bool IsSetFindingProviderFields()
        {
            return this._findingProviderFields != null;
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// Indicates when the security-findings provider first observed the potential security
        /// issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
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
        /// The identifier for the solution-specific component (a discrete unit of logic) that
        /// generated a finding. In various security-findings providers' solutions, this generator
        /// can be called a rule, a check, a detector, a plugin, etc. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Indicates when the security-findings provider most recently observed the potential
        /// security issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
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
        /// Gets and sets the property NetworkPath. 
        /// <para>
        /// Provides information about a network path that is relevant to a finding. Each entry
        /// under <code>NetworkPath</code> represents a component of that path.
        /// </para>
        /// </summary>
        public List<NetworkPathComponent> NetworkPath
        {
            get { return this._networkPath; }
            set { this._networkPath = value; }
        }

        // Check to see if NetworkPath property is set
        internal bool IsSetNetworkPath()
        {
            return this._networkPath != null && this._networkPath.Count > 0; 
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
        /// Gets and sets the property PatchSummary. 
        /// <para>
        /// Provides an overview of the patch compliance status for an instance against a selected
        /// compliance standard.
        /// </para>
        /// </summary>
        public PatchSummary PatchSummary
        {
            get { return this._patchSummary; }
            set { this._patchSummary = value; }
        }

        // Check to see if PatchSummary property is set
        internal bool IsSetPatchSummary()
        {
            return this._patchSummary != null;
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
        /// The ARN generated by Security Hub that uniquely identifies a product that generates
        /// findings. This can be the ARN for a third-party product that is integrated with Security
        /// Hub, or the ARN for a custom integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A data type where security-findings providers can include additional solution-specific
        /// details that aren't part of the defined <code>AwsSecurityFinding</code> format.
        /// </para>
        ///  
        /// <para>
        /// Can contain up to 50 key-value pairs. For each key-value pair, the key can contain
        /// up to 128 characters, and the value can contain up to 2048 characters.
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
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product that generated the finding.
        /// </para>
        ///  
        /// <para>
        /// Security Hub populates this attribute automatically for each finding. You cannot update
        /// this attribute with <code>BatchImportFindings</code> or <code>BatchUpdateFindings</code>.
        /// The exception to this is a custom integration.
        /// </para>
        ///  
        /// <para>
        /// When you use the Security Hub console or API to filter findings by product name, you
        /// use this attribute.
        /// </para>
        /// </summary>
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region from which the finding was generated.
        /// </para>
        ///  
        /// <para>
        /// Security Hub populates this attribute automatically for each finding. You cannot update
        /// it using <code>BatchImportFindings</code> or <code>BatchUpdateFindings</code>.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
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
        /// A data type that describes the remediation options for a finding.
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
        /// A set of resource data types that describe the resources that the finding refers to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Sample. 
        /// <para>
        /// Indicates whether the finding is a sample finding.
        /// </para>
        /// </summary>
        public bool Sample
        {
            get { return this._sample.GetValueOrDefault(); }
            set { this._sample = value; }
        }

        // Check to see if Sample property is set
        internal bool IsSetSample()
        {
            return this._sample.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version that a finding is formatted for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A URL that links to a page about the current finding in the security-findings provider's
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
        /// Threat intelligence details related to a finding.
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
        /// Gets and sets the property Threats. 
        /// <para>
        /// Details about the threat detected in a security finding and the file paths that were
        /// affected by the threat. 
        /// </para>
        /// </summary>
        public List<Threat> Threats
        {
            get { return this._threats; }
            set { this._threats = value; }
        }

        // Check to see if Threats property is set
        internal bool IsSetThreats()
        {
            return this._threats != null && this._threats.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A finding's title.
        /// </para>
        ///  <note> 
        /// <para>
        /// In this release, <code>Title</code> is a required property.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// One or more finding types in the format of <code>namespace/category/classifier</code>
        /// that classify a finding.
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
        /// Indicates when the security-findings provider last updated the finding record.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Vulnerabilities. 
        /// <para>
        /// Provides a list of vulnerabilities associated with the findings.
        /// </para>
        /// </summary>
        public List<Vulnerability> Vulnerabilities
        {
            get { return this._vulnerabilities; }
            set { this._vulnerabilities = value; }
        }

        // Check to see if Vulnerabilities property is set
        internal bool IsSetVulnerabilities()
        {
            return this._vulnerabilities != null && this._vulnerabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Workflow. 
        /// <para>
        /// Provides information about the status of the investigation into a finding.
        /// </para>
        /// </summary>
        public Workflow Workflow
        {
            get { return this._workflow; }
            set { this._workflow = value; }
        }

        // Check to see if Workflow property is set
        internal bool IsSetWorkflow()
        {
            return this._workflow != null;
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
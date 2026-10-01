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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides a consistent format for Security Hub CSPM findings. <c>AwsSecurityFinding</c>
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
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Provides details about an action that affects or that was taken on a resource.
        /// </para>
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that a finding is generated in.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: 12.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountName. 
        /// <para>
        /// The name of the Amazon Web Services account from which a finding was generated. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 50. 
        /// </para>
        /// </summary>
        public string AwsAccountName { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountName property is set.
        /// </summary>
        internal bool IsSetAwsAccountName() => this.AwsAccountName != null;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the company for the product that generated the finding.
        /// </para>
        ///  
        /// <para>
        /// Security Hub CSPM populates this attribute automatically for each finding. You cannot
        /// update this attribute with <c>BatchImportFindings</c> or <c>BatchUpdateFindings</c>.
        /// The exception to this is a custom integration.
        /// </para>
        ///  
        /// <para>
        /// When you use the Security Hub CSPM console or API to filter findings by company name,
        /// you use this attribute.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 128. 
        /// </para>
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// This data type is exclusive to findings that are generated as the result of a check
        /// run against a specific rule in a supported security standard, such as CIS Amazon Web
        /// Services Foundations. Contains security standard-related finding details.
        /// </para>
        /// </summary>
        public Compliance Compliance { get; set; }

        /// <summary>
        /// Checks to see if the Compliance property is set.
        /// </summary>
        internal bool IsSetCompliance() => this.Compliance != null;

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
        public int? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the security findings provider created the potential security issue
        /// that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

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
        public int? Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A finding's description. <c>Description</c> is a required property.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 1024.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Detection. 
        /// <para>
        ///  Provides details about an Amazon GuardDuty Extended Threat Detection attack sequence.
        /// GuardDuty generates an attack sequence finding when multiple events align to a potentially
        /// suspicious activity. To receive GuardDuty attack sequence findings in Security Hub
        /// CSPM, you must have GuardDuty enabled. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
        /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>. 
        /// </para>
        /// </summary>
        public Detection Detection { get; set; }

        /// <summary>
        /// Checks to see if the Detection property is set.
        /// </summary>
        internal bool IsSetDetection() => this.Detection != null;

        /// <summary>
        /// Gets and sets the property FindingProviderFields. 
        /// <para>
        /// In a <c>BatchImportFindings</c> request, finding providers use <c>FindingProviderFields</c>
        /// to provide and update their own values for confidence, criticality, related findings,
        /// severity, and types.
        /// </para>
        /// </summary>
        public FindingProviderFields FindingProviderFields { get; set; }

        /// <summary>
        /// Checks to see if the FindingProviderFields property is set.
        /// </summary>
        internal bool IsSetFindingProviderFields() => this.FindingProviderFields != null;

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// Indicates when the security findings provider first observed the potential security
        /// issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string FirstObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstObservedAt property is set.
        /// </summary>
        internal bool IsSetFirstObservedAt() => this.FirstObservedAt != null;

        /// <summary>
        /// Gets and sets the property GeneratorDetails. 
        /// <para>
        /// Provides metadata for the Amazon CodeGuru detector associated with a finding. This
        /// field pertains to findings that relate to Lambda functions. Amazon Inspector identifies
        /// policy violations and vulnerabilities in Lambda function code based on internal detectors
        /// developed in collaboration with Amazon CodeGuru. Security Hub CSPM receives those
        /// findings. 
        /// </para>
        /// </summary>
        public GeneratorDetails GeneratorDetails { get; set; }

        /// <summary>
        /// Checks to see if the GeneratorDetails property is set.
        /// </summary>
        internal bool IsSetGeneratorDetails() => this.GeneratorDetails != null;

        /// <summary>
        /// Gets and sets the property GeneratorId. 
        /// <para>
        /// The identifier for the solution-specific component (a discrete unit of logic) that
        /// generated a finding. In various security findings providers' solutions, this generator
        /// can be called a rule, a check, a detector, a plugin, or something else.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 512.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GeneratorId { get; set; }

        /// <summary>
        /// Checks to see if the GeneratorId property is set.
        /// </summary>
        internal bool IsSetGeneratorId() => this.GeneratorId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The security findings provider-specific identifier for a finding.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 512.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// Indicates when the security findings provider most recently observed a change in the
        /// resource that is involved in the finding.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastObservedAt property is set.
        /// </summary>
        internal bool IsSetLastObservedAt() => this.LastObservedAt != null;

        /// <summary>
        /// Gets and sets the property Malware. 
        /// <para>
        /// A list of malware related to a finding.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 5 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Malware> Malware { get; set; } = AWSConfigs.InitializeCollections ? new List<Malware>() : null;

        /// <summary>
        /// Checks to see if the Malware property is set.
        /// </summary>
        internal bool IsSetMalware() => this.Malware != null && (this.Malware.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The details of network-related information about a finding.
        /// </para>
        /// </summary>
        public Network Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property NetworkPath. 
        /// <para>
        /// Provides information about a network path that is relevant to a finding. Each entry
        /// under <c>NetworkPath</c> represents a component of that path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkPathComponent> NetworkPath { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkPathComponent>() : null;

        /// <summary>
        /// Checks to see if the NetworkPath property is set.
        /// </summary>
        internal bool IsSetNetworkPath() => this.NetworkPath != null && (this.NetworkPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A user-defined note added to a finding.
        /// </para>
        /// </summary>
        public Note Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property PatchSummary. 
        /// <para>
        /// Provides an overview of the patch compliance status for an instance against a selected
        /// compliance standard.
        /// </para>
        /// </summary>
        public PatchSummary PatchSummary { get; set; }

        /// <summary>
        /// Checks to see if the PatchSummary property is set.
        /// </summary>
        internal bool IsSetPatchSummary() => this.PatchSummary != null;

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// The details of process-related information about a finding.
        /// </para>
        /// </summary>
        public ProcessDetails Process { get; set; }

        /// <summary>
        /// Checks to see if the Process property is set.
        /// </summary>
        internal bool IsSetProcess() => this.Process != null;

        /// <summary>
        /// Gets and sets the property ProcessedAt. 
        /// <para>
        /// A timestamp that indicates when Security Hub CSPM received a finding and begins to
        /// process it.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ProcessedAt { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedAt property is set.
        /// </summary>
        internal bool IsSetProcessedAt() => this.ProcessedAt != null;

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN generated by Security Hub CSPM that uniquely identifies a product that generates
        /// findings. This can be the ARN for a third-party product that is integrated with Security
        /// Hub CSPM, or the ARN for a custom integration.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 12. Maximum length of 2048.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductArn property is set.
        /// </summary>
        internal bool IsSetProductArn() => this.ProductArn != null;

        /// <summary>
        /// Gets and sets the property ProductFields. 
        /// <para>
        /// A data type where security findings providers can include additional solution-specific
        /// details that aren't part of the defined <c>AwsSecurityFinding</c> format.
        /// </para>
        ///  
        /// <para>
        /// Can contain up to 50 key-value pairs. For each key-value pair, the key can contain
        /// up to 128 characters, and the value can contain up to 2048 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ProductFields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ProductFields property is set.
        /// </summary>
        internal bool IsSetProductFields() => this.ProductFields != null && (this.ProductFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product that generated the finding.
        /// </para>
        ///  
        /// <para>
        /// Security Hub CSPM populates this attribute automatically for each finding. You cannot
        /// update this attribute with <c>BatchImportFindings</c> or <c>BatchUpdateFindings</c>.
        /// The exception to this is a custom integration.
        /// </para>
        ///  
        /// <para>
        /// When you use the Security Hub CSPM console or API to filter findings by product name,
        /// you use this attribute.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 128.
        /// </para>
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The record state of a finding.
        /// </para>
        /// </summary>
        public RecordState RecordState { get; set; }

        /// <summary>
        /// Checks to see if the RecordState property is set.
        /// </summary>
        internal bool IsSetRecordState() => this.RecordState != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region from which the finding was generated.
        /// </para>
        ///  
        /// <para>
        /// Security Hub CSPM populates this attribute automatically for each finding. You cannot
        /// update it using <c>BatchImportFindings</c> or <c>BatchUpdateFindings</c>.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 16. 
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RelatedFindings. 
        /// <para>
        /// A list of related findings.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Minimum number of 1 item. Maximum number of 10 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedFinding> RelatedFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedFinding>() : null;

        /// <summary>
        /// Checks to see if the RelatedFindings property is set.
        /// </summary>
        internal bool IsSetRelatedFindings() => this.RelatedFindings != null && (this.RelatedFindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// A data type that describes the remediation options for a finding.
        /// </para>
        /// </summary>
        public Remediation Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// A set of resource data types that describe the resources that the finding refers to.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Minimum number of 1 item. Maximum number of 32 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Resource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// Indicates whether the finding is a sample finding.
        /// </para>
        /// </summary>
        public bool? Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample.HasValue;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version that a finding is formatted for. The value is <c>2018-10-08</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// A finding's severity.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// A URL that links to a page about the current finding in the security findings provider's
        /// solution.
        /// </para>
        /// </summary>
        public string SourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceUrl property is set.
        /// </summary>
        internal bool IsSetSourceUrl() => this.SourceUrl != null;

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicators. 
        /// <para>
        /// Threat intelligence details related to a finding.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Minimum number of 1 item. Maximum number of 5 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThreatIntelIndicator> ThreatIntelIndicators { get; set; } = AWSConfigs.InitializeCollections ? new List<ThreatIntelIndicator>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicators property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicators() => this.ThreatIntelIndicators != null && (this.ThreatIntelIndicators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Threats. 
        /// <para>
        /// Details about the threat detected in a security finding and the file paths that were
        /// affected by the threat. 
        /// </para>
        ///  
        /// <para>
        /// Array Members: Minimum number of 1 item. Maximum number of 32 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Threat> Threats { get; set; } = AWSConfigs.InitializeCollections ? new List<Threat>() : null;

        /// <summary>
        /// Checks to see if the Threats property is set.
        /// </summary>
        internal bool IsSetThreats() => this.Threats != null && (this.Threats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A finding's title. <c>Title</c> is a required property.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// One or more finding types in the format of <c>namespace/category/classifier</c> that
        /// classify a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are: Software and Configuration Checks | TTPs | Effects | Unusual
        /// Behaviors | Sensitive Data Identifications
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 50 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Types property is set.
        /// </summary>
        internal bool IsSetTypes() => this.Types != null && (this.Types.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Indicates when the security findings provider last updated the finding record.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt != null;

        /// <summary>
        /// Gets and sets the property UserDefinedFields. 
        /// <para>
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding.
        /// </para>
        ///  
        /// <para>
        /// Can contain up to 50 key-value pairs. For each key-value pair, the key can contain
        /// up to 128 characters, and the value can contain up to 1024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> UserDefinedFields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the UserDefinedFields property is set.
        /// </summary>
        internal bool IsSetUserDefinedFields() => this.UserDefinedFields != null && (this.UserDefinedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// Indicates the veracity of a finding. 
        /// </para>
        /// </summary>
        public VerificationState VerificationState { get; set; }

        /// <summary>
        /// Checks to see if the VerificationState property is set.
        /// </summary>
        internal bool IsSetVerificationState() => this.VerificationState != null;

        /// <summary>
        /// Gets and sets the property Vulnerabilities. 
        /// <para>
        /// Provides a list of vulnerabilities associated with the findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Vulnerability> Vulnerabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<Vulnerability>() : null;

        /// <summary>
        /// Checks to see if the Vulnerabilities property is set.
        /// </summary>
        internal bool IsSetVulnerabilities() => this.Vulnerabilities != null && (this.Vulnerabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Workflow. 
        /// <para>
        /// Provides information about the status of the investigation into a finding.
        /// </para>
        /// </summary>
        public Workflow Workflow { get; set; }

        /// <summary>
        /// Checks to see if the Workflow property is set.
        /// </summary>
        internal bool IsSetWorkflow() => this.Workflow != null;

        /// <summary>
        /// Gets and sets the property WorkflowState. 
        /// <para>
        /// The workflow state of a finding. 
        /// </para>
        /// </summary>
        public WorkflowState WorkflowState { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowState property is set.
        /// </summary>
        internal bool IsSetWorkflowState() => this.WorkflowState != null;
    }
}

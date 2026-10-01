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
    /// A collection of filters that are applied to all active findings aggregated by Security
    /// Hub CSPM.
    /// 
    ///  
    /// <para>
    /// You can filter by up to ten finding attributes. For each attribute, you can provide
    /// up to 20 filter values.
    /// </para>
    /// </summary>
    public partial class AwsSecurityFindingFilters
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID in which a finding is generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> AwsAccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null && (this.AwsAccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccountName. 
        /// <para>
        /// The name of the Amazon Web Services account in which a finding is generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> AwsAccountName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the AwsAccountName property is set.
        /// </summary>
        internal bool IsSetAwsAccountName() => this.AwsAccountName != null && (this.AwsAccountName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the findings provider (company) that owns the solution (product) that
        /// generates findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> CompanyName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null && (this.CompanyName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceAssociatedStandardsId. 
        /// <para>
        ///  The unique identifier of a standard in which a control is enabled. This field consists
        /// of the resource portion of the Amazon Resource Name (ARN) returned for a standard
        /// in the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_DescribeStandards.html">DescribeStandards</a>
        /// API response. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceAssociatedStandardsId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ComplianceAssociatedStandardsId property is set.
        /// </summary>
        internal bool IsSetComplianceAssociatedStandardsId() => this.ComplianceAssociatedStandardsId != null && (this.ComplianceAssociatedStandardsId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceSecurityControlId. 
        /// <para>
        ///  The unique identifier of a control across standards. Values for this field typically
        /// consist of an Amazon Web Services service and a number, such as APIGateway.5. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ComplianceSecurityControlId property is set.
        /// </summary>
        internal bool IsSetComplianceSecurityControlId() => this.ComplianceSecurityControlId != null && (this.ComplianceSecurityControlId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceSecurityControlParametersName. 
        /// <para>
        ///  The name of a security control parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlParametersName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ComplianceSecurityControlParametersName property is set.
        /// </summary>
        internal bool IsSetComplianceSecurityControlParametersName() => this.ComplianceSecurityControlParametersName != null && (this.ComplianceSecurityControlParametersName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceSecurityControlParametersValue. 
        /// <para>
        ///  The current value of a security control parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlParametersValue { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ComplianceSecurityControlParametersValue property is set.
        /// </summary>
        internal bool IsSetComplianceSecurityControlParametersValue() => this.ComplianceSecurityControlParametersValue != null && (this.ComplianceSecurityControlParametersValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Exclusive to findings that are generated as the result of a check run against a specific
        /// rule in a supported standard, such as CIS Amazon Web Services Foundations. Contains
        /// security standard-related finding details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null && (this.ComplianceStatus.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> Confidence { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null && (this.Confidence.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when the security findings provider created the potential
        /// security issue that a finding reflects.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> CreatedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null && (this.CreatedAt.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> Criticality { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality != null && (this.Criticality.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A finding's description.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Description { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null && (this.Description.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsConfidence. 
        /// <para>
        /// The finding provider value for the finding confidence. Confidence is defined as the
        /// likelihood that a finding accurately identifies the behavior or issue that it was
        /// intended to identify.
        /// </para>
        ///  
        /// <para>
        /// Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent
        /// confidence and 100 means 100 percent confidence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> FindingProviderFieldsConfidence { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsConfidence property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsConfidence() => this.FindingProviderFieldsConfidence != null && (this.FindingProviderFieldsConfidence.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsCriticality. 
        /// <para>
        /// The finding provider value for the level of importance assigned to the resources associated
        /// with the findings.
        /// </para>
        ///  
        /// <para>
        /// A score of 0 means that the underlying resources have no criticality, and a score
        /// of 100 is reserved for the most critical resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> FindingProviderFieldsCriticality { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsCriticality property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsCriticality() => this.FindingProviderFieldsCriticality != null && (this.FindingProviderFieldsCriticality.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsRelatedFindingsId. 
        /// <para>
        /// The finding identifier of a related finding that is identified by the finding provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsRelatedFindingsId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsRelatedFindingsId property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsRelatedFindingsId() => this.FindingProviderFieldsRelatedFindingsId != null && (this.FindingProviderFieldsRelatedFindingsId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsRelatedFindingsProductArn. 
        /// <para>
        /// The ARN of the solution that generated a related finding that is identified by the
        /// finding provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsRelatedFindingsProductArn { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsRelatedFindingsProductArn property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsRelatedFindingsProductArn() => this.FindingProviderFieldsRelatedFindingsProductArn != null && (this.FindingProviderFieldsRelatedFindingsProductArn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsSeverityLabel. 
        /// <para>
        /// The finding provider value for the severity label.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsSeverityLabel { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsSeverityLabel property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsSeverityLabel() => this.FindingProviderFieldsSeverityLabel != null && (this.FindingProviderFieldsSeverityLabel.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsSeverityOriginal. 
        /// <para>
        /// The finding provider's original value for the severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsSeverityOriginal { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsSeverityOriginal property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsSeverityOriginal() => this.FindingProviderFieldsSeverityOriginal != null && (this.FindingProviderFieldsSeverityOriginal.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsTypes. 
        /// <para>
        /// One or more finding types that the finding provider assigned to the finding. Uses
        /// the format of <c>namespace/category/classifier</c> that classify a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are: Software and Configuration Checks | TTPs | Effects | Unusual
        /// Behaviors | Sensitive Data Identifications
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingProviderFieldsTypes property is set.
        /// </summary>
        internal bool IsSetFindingProviderFieldsTypes() => this.FindingProviderFieldsTypes != null && (this.FindingProviderFieldsTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// A timestamp that indicates when the security findings provider first observed the
        /// potential security issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> FirstObservedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the FirstObservedAt property is set.
        /// </summary>
        internal bool IsSetFirstObservedAt() => this.FirstObservedAt != null && (this.FirstObservedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GeneratorId. 
        /// <para>
        /// The identifier for the solution-specific component (a discrete unit of logic) that
        /// generated a finding. In various security findings providers' solutions, this generator
        /// can be called a rule, a check, a detector, a plugin, etc.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> GeneratorId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the GeneratorId property is set.
        /// </summary>
        internal bool IsSetGeneratorId() => this.GeneratorId != null && (this.GeneratorId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The security findings provider-specific identifier for a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Id { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null && (this.Id.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// A keyword for a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("The Keyword property is deprecated.")]
        public List<KeywordFilter> Keyword { get; set; } = AWSConfigs.InitializeCollections ? new List<KeywordFilter>() : null;

        /// <summary>
        /// Checks to see if the Keyword property is set.
        /// </summary>
        internal bool IsSetKeyword() => this.Keyword != null && (this.Keyword.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// A timestamp that indicates when the security findings provider most recently observed
        /// a change in the resource that is involved in the finding.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> LastObservedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the LastObservedAt property is set.
        /// </summary>
        internal bool IsSetLastObservedAt() => this.LastObservedAt != null && (this.LastObservedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MalwareName. 
        /// <para>
        /// The name of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwareName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the MalwareName property is set.
        /// </summary>
        internal bool IsSetMalwareName() => this.MalwareName != null && (this.MalwareName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MalwarePath. 
        /// <para>
        /// The filesystem path of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwarePath { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the MalwarePath property is set.
        /// </summary>
        internal bool IsSetMalwarePath() => this.MalwarePath != null && (this.MalwarePath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MalwareState. 
        /// <para>
        /// The state of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwareState { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the MalwareState property is set.
        /// </summary>
        internal bool IsSetMalwareState() => this.MalwareState != null && (this.MalwareState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MalwareType. 
        /// <para>
        /// The type of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwareType { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the MalwareType property is set.
        /// </summary>
        internal bool IsSetMalwareType() => this.MalwareType != null && (this.MalwareType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkDestinationDomain. 
        /// <para>
        /// The destination domain of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkDestinationDomain { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkDestinationDomain property is set.
        /// </summary>
        internal bool IsSetNetworkDestinationDomain() => this.NetworkDestinationDomain != null && (this.NetworkDestinationDomain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkDestinationIpV4. 
        /// <para>
        /// The destination IPv4 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkDestinationIpV4 { get; set; } = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkDestinationIpV4 property is set.
        /// </summary>
        internal bool IsSetNetworkDestinationIpV4() => this.NetworkDestinationIpV4 != null && (this.NetworkDestinationIpV4.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkDestinationIpV6. 
        /// <para>
        /// The destination IPv6 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkDestinationIpV6 { get; set; } = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkDestinationIpV6 property is set.
        /// </summary>
        internal bool IsSetNetworkDestinationIpV6() => this.NetworkDestinationIpV6 != null && (this.NetworkDestinationIpV6.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkDestinationPort. 
        /// <para>
        /// The destination port of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> NetworkDestinationPort { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkDestinationPort property is set.
        /// </summary>
        internal bool IsSetNetworkDestinationPort() => this.NetworkDestinationPort != null && (this.NetworkDestinationPort.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkDirection. 
        /// <para>
        /// Indicates the direction of network traffic associated with a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkDirection { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkDirection property is set.
        /// </summary>
        internal bool IsSetNetworkDirection() => this.NetworkDirection != null && (this.NetworkDirection.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkProtocol. 
        /// <para>
        /// The protocol of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkProtocol { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkProtocol property is set.
        /// </summary>
        internal bool IsSetNetworkProtocol() => this.NetworkProtocol != null && (this.NetworkProtocol.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkSourceDomain. 
        /// <para>
        /// The source domain of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkSourceDomain { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkSourceDomain property is set.
        /// </summary>
        internal bool IsSetNetworkSourceDomain() => this.NetworkSourceDomain != null && (this.NetworkSourceDomain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkSourceIpV4. 
        /// <para>
        /// The source IPv4 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkSourceIpV4 { get; set; } = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkSourceIpV4 property is set.
        /// </summary>
        internal bool IsSetNetworkSourceIpV4() => this.NetworkSourceIpV4 != null && (this.NetworkSourceIpV4.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkSourceIpV6. 
        /// <para>
        /// The source IPv6 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkSourceIpV6 { get; set; } = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkSourceIpV6 property is set.
        /// </summary>
        internal bool IsSetNetworkSourceIpV6() => this.NetworkSourceIpV6 != null && (this.NetworkSourceIpV6.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkSourceMac. 
        /// <para>
        /// The source media access control (MAC) address of network-related information about
        /// a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkSourceMac { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkSourceMac property is set.
        /// </summary>
        internal bool IsSetNetworkSourceMac() => this.NetworkSourceMac != null && (this.NetworkSourceMac.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkSourcePort. 
        /// <para>
        /// The source port of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> NetworkSourcePort { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the NetworkSourcePort property is set.
        /// </summary>
        internal bool IsSetNetworkSourcePort() => this.NetworkSourcePort != null && (this.NetworkSourcePort.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoteText. 
        /// <para>
        /// The text of a note.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NoteText { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NoteText property is set.
        /// </summary>
        internal bool IsSetNoteText() => this.NoteText != null && (this.NoteText.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoteUpdatedAt. 
        /// <para>
        /// The timestamp of when the note was updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> NoteUpdatedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the NoteUpdatedAt property is set.
        /// </summary>
        internal bool IsSetNoteUpdatedAt() => this.NoteUpdatedAt != null && (this.NoteUpdatedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoteUpdatedBy. 
        /// <para>
        /// The principal that created a note.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NoteUpdatedBy { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the NoteUpdatedBy property is set.
        /// </summary>
        internal bool IsSetNoteUpdatedBy() => this.NoteUpdatedBy != null && (this.NoteUpdatedBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessLaunchedAt. 
        /// <para>
        /// A timestamp that identifies when the process was launched.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ProcessLaunchedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the ProcessLaunchedAt property is set.
        /// </summary>
        internal bool IsSetProcessLaunchedAt() => this.ProcessLaunchedAt != null && (this.ProcessLaunchedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessName. 
        /// <para>
        /// The name of the process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProcessName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ProcessName property is set.
        /// </summary>
        internal bool IsSetProcessName() => this.ProcessName != null && (this.ProcessName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessParentPid. 
        /// <para>
        /// The parent process ID. This field accepts positive integers between <c>O</c> and <c>2147483647</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> ProcessParentPid { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the ProcessParentPid property is set.
        /// </summary>
        internal bool IsSetProcessParentPid() => this.ProcessParentPid != null && (this.ProcessParentPid.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessPath. 
        /// <para>
        /// The path to the process executable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProcessPath { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ProcessPath property is set.
        /// </summary>
        internal bool IsSetProcessPath() => this.ProcessPath != null && (this.ProcessPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessPid. 
        /// <para>
        /// The process ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> ProcessPid { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the ProcessPid property is set.
        /// </summary>
        internal bool IsSetProcessPid() => this.ProcessPid != null && (this.ProcessPid.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessTerminatedAt. 
        /// <para>
        /// A timestamp that identifies when the process was terminated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ProcessTerminatedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the ProcessTerminatedAt property is set.
        /// </summary>
        internal bool IsSetProcessTerminatedAt() => this.ProcessTerminatedAt != null && (this.ProcessTerminatedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN generated by Security Hub CSPM that uniquely identifies a third-party company
        /// (security findings provider) after this provider's product (solution that generates
        /// findings) is registered with Security Hub CSPM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProductArn { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ProductArn property is set.
        /// </summary>
        internal bool IsSetProductArn() => this.ProductArn != null && (this.ProductArn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductFields. 
        /// <para>
        /// A data type where security findings providers can include additional solution-specific
        /// details that aren't part of the defined <c>AwsSecurityFinding</c> format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> ProductFields { get; set; } = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;

        /// <summary>
        /// Checks to see if the ProductFields property is set.
        /// </summary>
        internal bool IsSetProductFields() => this.ProductFields != null && (this.ProductFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the solution (product) that generates findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProductName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null && (this.ProductName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationText. 
        /// <para>
        /// The recommendation of what to do about the issue described in a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RecommendationText { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the RecommendationText property is set.
        /// </summary>
        internal bool IsSetRecommendationText() => this.RecommendationText != null && (this.RecommendationText.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The updated record state for the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RecordState { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the RecordState property is set.
        /// </summary>
        internal bool IsSetRecordState() => this.RecordState != null && (this.RecordState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region from which the finding was generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Region { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null && (this.Region.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedFindingsId. 
        /// <para>
        /// The solution-generated identifier for a related finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RelatedFindingsId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the RelatedFindingsId property is set.
        /// </summary>
        internal bool IsSetRelatedFindingsId() => this.RelatedFindingsId != null && (this.RelatedFindingsId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedFindingsProductArn. 
        /// <para>
        /// The ARN of the solution that generated a related finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RelatedFindingsProductArn { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the RelatedFindingsProductArn property is set.
        /// </summary>
        internal bool IsSetRelatedFindingsProductArn() => this.RelatedFindingsProductArn != null && (this.RelatedFindingsProductArn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceApplicationArn. 
        /// <para>
        ///  The ARN of the application that is related to a finding. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceApplicationArn { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceApplicationArn property is set.
        /// </summary>
        internal bool IsSetResourceApplicationArn() => this.ResourceApplicationArn != null && (this.ResourceApplicationArn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceApplicationName. 
        /// <para>
        ///  The name of the application that is related to a finding. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceApplicationName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceApplicationName property is set.
        /// </summary>
        internal bool IsSetResourceApplicationName() => this.ResourceApplicationName != null && (this.ResourceApplicationName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIamInstanceProfileArn. 
        /// <para>
        /// The IAM profile ARN of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceIamInstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceIamInstanceProfileArn() => this.ResourceAwsEc2InstanceIamInstanceProfileArn != null && (this.ResourceAwsEc2InstanceIamInstanceProfileArn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceImageId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceImageId property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceImageId() => this.ResourceAwsEc2InstanceImageId != null && (this.ResourceAwsEc2InstanceImageId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIpV4Addresses. 
        /// <para>
        /// The IPv4 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> ResourceAwsEc2InstanceIpV4Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceIpV4Addresses property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceIpV4Addresses() => this.ResourceAwsEc2InstanceIpV4Addresses != null && (this.ResourceAwsEc2InstanceIpV4Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIpV6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> ResourceAwsEc2InstanceIpV6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceIpV6Addresses property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceIpV6Addresses() => this.ResourceAwsEc2InstanceIpV6Addresses != null && (this.ResourceAwsEc2InstanceIpV6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceKeyName. 
        /// <para>
        /// The key name associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceKeyName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceKeyName property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceKeyName() => this.ResourceAwsEc2InstanceKeyName != null && (this.ResourceAwsEc2InstanceKeyName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceLaunchedAt. 
        /// <para>
        /// The date and time the instance was launched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ResourceAwsEc2InstanceLaunchedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceLaunchedAt property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceLaunchedAt() => this.ResourceAwsEc2InstanceLaunchedAt != null && (this.ResourceAwsEc2InstanceLaunchedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceSubnetId. 
        /// <para>
        /// The identifier of the subnet that the instance was launched in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceSubnetId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceSubnetId property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceSubnetId() => this.ResourceAwsEc2InstanceSubnetId != null && (this.ResourceAwsEc2InstanceSubnetId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceType. 
        /// <para>
        /// The instance type of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceType { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceType property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceType() => this.ResourceAwsEc2InstanceType != null && (this.ResourceAwsEc2InstanceType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceVpcId. 
        /// <para>
        /// The identifier of the VPC that the instance was launched in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceVpcId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsEc2InstanceVpcId property is set.
        /// </summary>
        internal bool IsSetResourceAwsEc2InstanceVpcId() => this.ResourceAwsEc2InstanceVpcId != null && (this.ResourceAwsEc2InstanceVpcId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyCreatedAt. 
        /// <para>
        /// The creation date/time of the IAM access key related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ResourceAwsIamAccessKeyCreatedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsIamAccessKeyCreatedAt property is set.
        /// </summary>
        internal bool IsSetResourceAwsIamAccessKeyCreatedAt() => this.ResourceAwsIamAccessKeyCreatedAt != null && (this.ResourceAwsIamAccessKeyCreatedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyPrincipalName. 
        /// <para>
        /// The name of the principal that is associated with an IAM access key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsIamAccessKeyPrincipalName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsIamAccessKeyPrincipalName property is set.
        /// </summary>
        internal bool IsSetResourceAwsIamAccessKeyPrincipalName() => this.ResourceAwsIamAccessKeyPrincipalName != null && (this.ResourceAwsIamAccessKeyPrincipalName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyStatus. 
        /// <para>
        /// The status of the IAM access key related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsIamAccessKeyStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsIamAccessKeyStatus property is set.
        /// </summary>
        internal bool IsSetResourceAwsIamAccessKeyStatus() => this.ResourceAwsIamAccessKeyStatus != null && (this.ResourceAwsIamAccessKeyStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyUserName. 
        /// <para>
        /// The user associated with the IAM access key related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use ResourceAwsIamAccessKeyPrincipalName.")]
        public List<StringFilter> ResourceAwsIamAccessKeyUserName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsIamAccessKeyUserName property is set.
        /// </summary>
        internal bool IsSetResourceAwsIamAccessKeyUserName() => this.ResourceAwsIamAccessKeyUserName != null && (this.ResourceAwsIamAccessKeyUserName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsIamUserUserName. 
        /// <para>
        /// The name of an IAM user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsIamUserUserName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsIamUserUserName property is set.
        /// </summary>
        internal bool IsSetResourceAwsIamUserUserName() => this.ResourceAwsIamUserUserName != null && (this.ResourceAwsIamUserUserName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsS3BucketOwnerId. 
        /// <para>
        /// The canonical user ID of the owner of the S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsS3BucketOwnerId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsS3BucketOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceAwsS3BucketOwnerId() => this.ResourceAwsS3BucketOwnerId != null && (this.ResourceAwsS3BucketOwnerId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceAwsS3BucketOwnerName. 
        /// <para>
        /// The display name of the owner of the S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsS3BucketOwnerName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceAwsS3BucketOwnerName property is set.
        /// </summary>
        internal bool IsSetResourceAwsS3BucketOwnerName() => this.ResourceAwsS3BucketOwnerName != null && (this.ResourceAwsS3BucketOwnerName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceContainerImageId. 
        /// <para>
        /// The identifier of the image related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceContainerImageId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceContainerImageId property is set.
        /// </summary>
        internal bool IsSetResourceContainerImageId() => this.ResourceContainerImageId != null && (this.ResourceContainerImageId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceContainerImageName. 
        /// <para>
        /// The name of the image related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceContainerImageName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceContainerImageName property is set.
        /// </summary>
        internal bool IsSetResourceContainerImageName() => this.ResourceContainerImageName != null && (this.ResourceContainerImageName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceContainerLaunchedAt. 
        /// <para>
        /// A timestamp that identifies when the container was started.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ResourceContainerLaunchedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceContainerLaunchedAt property is set.
        /// </summary>
        internal bool IsSetResourceContainerLaunchedAt() => this.ResourceContainerLaunchedAt != null && (this.ResourceContainerLaunchedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceContainerName. 
        /// <para>
        /// The name of the container related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceContainerName { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceContainerName property is set.
        /// </summary>
        internal bool IsSetResourceContainerName() => this.ResourceContainerName != null && (this.ResourceContainerName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceDetailsOther. 
        /// <para>
        /// The details of a resource that doesn't have a specific subfield for the resource type
        /// defined.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> ResourceDetailsOther { get; set; } = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceDetailsOther property is set.
        /// </summary>
        internal bool IsSetResourceDetailsOther() => this.ResourceDetailsOther != null && (this.ResourceDetailsOther.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The canonical identifier for the given resource type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null && (this.ResourceId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccountId. 
        /// <para>
        /// The unique identifier of the account that owns the resource that the finding applies
        /// to, for example, Azure Subscription Id or Amazon Web Services Account Id
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceOwnerAccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccountId() => this.ResourceOwnerAccountId != null && (this.ResourceOwnerAccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceOwnerOrgId. 
        /// <para>
        /// The unique identifier of the organization that owns the resource that the finding
        /// applies to, for example, Azure Tenant Id
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceOwnerOrgId { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceOwnerOrgId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerOrgId() => this.ResourceOwnerOrgId != null && (this.ResourceOwnerOrgId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourcePartition. 
        /// <para>
        /// The canonical Amazon Web Services partition name that the Region is assigned to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourcePartition { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourcePartition property is set.
        /// </summary>
        internal bool IsSetResourcePartition() => this.ResourcePartition != null && (this.ResourcePartition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceProvider. 
        /// <para>
        /// The cloud provider that the resource belongs to. Valid values are <c>AWS</c> and <c>Azure</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceProvider { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceProvider property is set.
        /// </summary>
        internal bool IsSetResourceProvider() => this.ResourceProvider != null && (this.ResourceProvider.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The canonical Amazon Web Services external Region name where this resource is located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceRegion { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null && (this.ResourceRegion.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// A list of Amazon Web Services tags associated with a resource at the time the finding
        /// was processed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the type of the resource that details are provided for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceType { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null && (this.ResourceType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// Indicates whether or not sample findings are included in the filter results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BooleanFilter> Sample { get; set; } = AWSConfigs.InitializeCollections ? new List<BooleanFilter>() : null;

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample != null && (this.Sample.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SeverityLabel. 
        /// <para>
        /// The label of a finding's severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> SeverityLabel { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the SeverityLabel property is set.
        /// </summary>
        internal bool IsSetSeverityLabel() => this.SeverityLabel != null && (this.SeverityLabel.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SeverityNormalized. 
        /// <para>
        /// The normalized severity of a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use SeverityLabel or FindingProviderFieldsSeverityLabel.")]
        public List<NumberFilter> SeverityNormalized { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the SeverityNormalized property is set.
        /// </summary>
        internal bool IsSetSeverityNormalized() => this.SeverityNormalized != null && (this.SeverityNormalized.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SeverityProduct. 
        /// <para>
        /// The native severity as defined by the security findings provider's solution that generated
        /// the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use FindingProviderSeverityOriginal.")]
        public List<NumberFilter> SeverityProduct { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;

        /// <summary>
        /// Checks to see if the SeverityProduct property is set.
        /// </summary>
        internal bool IsSetSeverityProduct() => this.SeverityProduct != null && (this.SeverityProduct.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// A URL that links to a page about the current finding in the security findings provider's
        /// solution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> SourceUrl { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the SourceUrl property is set.
        /// </summary>
        internal bool IsSetSourceUrl() => this.SourceUrl != null && (this.SourceUrl.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorCategory. 
        /// <para>
        /// The category of a threat intelligence indicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorCategory { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicatorCategory property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicatorCategory() => this.ThreatIntelIndicatorCategory != null && (this.ThreatIntelIndicatorCategory.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorLastObservedAt. 
        /// <para>
        /// A timestamp that identifies the last observation of a threat intelligence indicator.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ThreatIntelIndicatorLastObservedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicatorLastObservedAt property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicatorLastObservedAt() => this.ThreatIntelIndicatorLastObservedAt != null && (this.ThreatIntelIndicatorLastObservedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorSource. 
        /// <para>
        /// The source of the threat intelligence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorSource { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicatorSource property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicatorSource() => this.ThreatIntelIndicatorSource != null && (this.ThreatIntelIndicatorSource.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorSourceUrl. 
        /// <para>
        /// The URL for more details from the source of the threat intelligence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorSourceUrl { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicatorSourceUrl property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicatorSourceUrl() => this.ThreatIntelIndicatorSourceUrl != null && (this.ThreatIntelIndicatorSourceUrl.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorType. 
        /// <para>
        /// The type of a threat intelligence indicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorType { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicatorType property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicatorType() => this.ThreatIntelIndicatorType != null && (this.ThreatIntelIndicatorType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorValue. 
        /// <para>
        /// The value of a threat intelligence indicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorValue { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ThreatIntelIndicatorValue property is set.
        /// </summary>
        internal bool IsSetThreatIntelIndicatorValue() => this.ThreatIntelIndicatorValue != null && (this.ThreatIntelIndicatorValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A finding's title.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Title { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null && (this.Title.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A finding type in the format of <c>namespace/category/classifier</c> that classifies
        /// a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Type { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null && (this.Type.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// A timestamp that indicates when the security findings provider last updated the finding
        /// record.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> UpdatedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt != null && (this.UpdatedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserDefinedFields. 
        /// <para>
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> UserDefinedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;

        /// <summary>
        /// Checks to see if the UserDefinedFields property is set.
        /// </summary>
        internal bool IsSetUserDefinedFields() => this.UserDefinedFields != null && (this.UserDefinedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// The veracity of a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> VerificationState { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the VerificationState property is set.
        /// </summary>
        internal bool IsSetVerificationState() => this.VerificationState != null && (this.VerificationState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VulnerabilitiesExploitAvailable. 
        /// <para>
        ///  Indicates whether a software vulnerability in your environment has a known exploit.
        /// You can filter findings by this field only if you use Security Hub CSPM and Amazon
        /// Inspector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> VulnerabilitiesExploitAvailable { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the VulnerabilitiesExploitAvailable property is set.
        /// </summary>
        internal bool IsSetVulnerabilitiesExploitAvailable() => this.VulnerabilitiesExploitAvailable != null && (this.VulnerabilitiesExploitAvailable.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VulnerabilitiesFixAvailable. 
        /// <para>
        ///  Indicates whether a vulnerability is fixed in a newer version of the affected software
        /// packages. You can filter findings by this field only if you use Security Hub CSPM
        /// and Amazon Inspector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> VulnerabilitiesFixAvailable { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the VulnerabilitiesFixAvailable property is set.
        /// </summary>
        internal bool IsSetVulnerabilitiesFixAvailable() => this.VulnerabilitiesFixAvailable != null && (this.VulnerabilitiesFixAvailable.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowState. 
        /// <para>
        /// The workflow state of a finding.
        /// </para>
        ///  
        /// <para>
        /// Note that this field is deprecated. To search for a finding based on its workflow
        /// status, use <c>WorkflowStatus</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> WorkflowState { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the WorkflowState property is set.
        /// </summary>
        internal bool IsSetWorkflowState() => this.WorkflowState != null && (this.WorkflowState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The status of the investigation into a finding. Allowed values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c> - The initial state of a finding, before it is reviewed.
        /// </para>
        ///  
        /// <para>
        /// Security Hub CSPM also resets the workflow status from <c>NOTIFIED</c> or <c>RESOLVED</c>
        /// to <c>NEW</c> in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RecordState</c> changes from <c>ARCHIVED</c> to <c>ACTIVE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Compliance.Status</c> changes from <c>PASSED</c> to either <c>WARNING</c>, <c>FAILED</c>,
        /// or <c>NOT_AVAILABLE</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NOTIFIED</c> - Indicates that the resource owner has been notified about the security
        /// issue. Used when the initial reviewer is not the resource owner, and needs intervention
        /// from the resource owner.
        /// </para>
        ///  
        /// <para>
        /// If one of the following occurs, the workflow status is changed automatically from
        /// <c>NOTIFIED</c> to <c>NEW</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RecordState</c> changes from <c>ARCHIVED</c> to <c>ACTIVE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Compliance.Status</c> changes from <c>PASSED</c> to <c>FAILED</c>, <c>WARNING</c>,
        /// or <c>NOT_AVAILABLE</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SUPPRESSED</c> - Indicates that you reviewed the finding and don't believe that
        /// any action is needed.
        /// </para>
        ///  
        /// <para>
        /// The workflow status of a <c>SUPPRESSED</c> finding does not change if <c>RecordState</c>
        /// changes from <c>ARCHIVED</c> to <c>ACTIVE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOLVED</c> - The finding was reviewed and remediated and is now considered resolved.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The finding remains <c>RESOLVED</c> unless one of the following occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RecordState</c> changes from <c>ARCHIVED</c> to <c>ACTIVE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Compliance.Status</c> changes from <c>PASSED</c> to <c>FAILED</c>, <c>WARNING</c>,
        /// or <c>NOT_AVAILABLE</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In those cases, the workflow status is automatically reset to <c>NEW</c>.
        /// </para>
        ///  
        /// <para>
        /// For findings from controls, if <c>Compliance.Status</c> is <c>PASSED</c>, then Security
        /// Hub CSPM automatically sets the workflow status to <c>RESOLVED</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> WorkflowStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the WorkflowStatus property is set.
        /// </summary>
        internal bool IsSetWorkflowStatus() => this.WorkflowStatus != null && (this.WorkflowStatus.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

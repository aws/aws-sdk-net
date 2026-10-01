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
    /// The criteria that determine which findings a rule applies to.
    /// </summary>
    public partial class AutomationRulesFindingFilters
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID in which a finding was generated.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 100 items. 
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
        /// The name of the Amazon Web Services account in which a finding was generated. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The name of the company for the product that generated the finding. For control-based
        /// findings, the company is Amazon Web Services. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// The unique identifier of a standard in which a control is enabled. This field consists
        /// of the resource portion of the Amazon Resource Name (ARN) returned for a standard
        /// in the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_DescribeStandards.html">DescribeStandards</a>
        /// API response.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The security control ID for which a finding was generated. Security control IDs are
        /// the same across standards.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        ///  The result of a security check. This field is only used for findings generated from
        /// controls. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// The likelihood that a finding accurately identifies the behavior or issue that it
        /// was intended to identify. <c>Confidence</c> is scored on a 0–100 basis using a ratio
        /// scale. A value of <c>0</c> means 0 percent confidence, and a value of <c>100</c> means
        /// 100 percent confidence. For example, a data exfiltration detection based on a statistical
        /// deviation of network traffic has low confidence because an actual exfiltration hasn't
        /// been verified. For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/asff-top-level-attributes.html#asff-confidence">Confidence</a>
        /// in the <i>Security Hub CSPM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  A timestamp that indicates when this finding record was created. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The level of importance that is assigned to the resources that are associated with
        /// a finding. <c>Criticality</c> is scored on a 0–100 basis, using a ratio scale that
        /// supports only full integers. A score of <c>0</c> means that the underlying resources
        /// have no criticality, and a score of <c>100</c> is reserved for the most critical resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/asff-top-level-attributes.html#asff-criticality">Criticality</a>
        /// in the <i>Security Hub CSPM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  A finding's description. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        ///  A timestamp that indicates when the potential security issue captured by a finding
        /// was first observed by the security findings product. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The identifier for the solution-specific component that generated a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 100 items. 
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
        ///  The product-specific identifier for a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        ///  A timestamp that indicates when the security findings provider most recently observed
        /// a change in the resource that is involved in the finding. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property NoteText. 
        /// <para>
        ///  The text of a user-defined note that's added to a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The timestamp of when the note was updated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The principal that created a note. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property ProductArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for a third-party product that generated a finding
        /// in Security Hub CSPM. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property ProductName. 
        /// <para>
        ///  Provides the name of the product that generated the finding. For control-based findings,
        /// the product name is Security Hub CSPM. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property RecordState. 
        /// <para>
        ///  Provides the current state of a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property RelatedFindingsId. 
        /// <para>
        ///  The product-generated identifier for a related finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The ARN for the product that generated a related finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The Amazon Resource Name (ARN) of the application that is related to a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property ResourceDetailsOther. 
        /// <para>
        ///  Custom fields and values about the resource that a finding pertains to. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The identifier for the given resource type. For Amazon Web Services resources that
        /// are identified by Amazon Resource Names (ARNs), this is the ARN. For Amazon Web Services
        /// resources that lack ARNs, this is the identifier as defined by the Amazon Web Services
        /// service that created the resource. For non-Amazon Web Services resources, this is
        /// a unique identifier that is associated with the resource. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 100 items. 
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
        ///  The partition in which the resource that the finding pertains to is located. A partition
        /// is a group of Amazon Web Services Regions. Each Amazon Web Services account is scoped
        /// to one partition. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The Amazon Web Services Region where the resource that a finding pertains to is located.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  A list of Amazon Web Services tags associated with a resource at the time the finding
        /// was processed. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  The type of resource that the finding pertains to. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property SeverityLabel. 
        /// <para>
        ///  The severity value of the finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property SourceUrl. 
        /// <para>
        ///  Provides a URL that links to a page about the current finding in the finding product.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property Title. 
        /// <para>
        ///  A finding's title. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 100 items. 
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
        ///  One or more finding types in the format of namespace/category/classifier that classify
        /// a finding. For a list of namespaces, classifiers, and categories, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-findings-format-type-taxonomy.html">Types
        /// taxonomy for ASFF</a> in the <i>Security Hub CSPM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  A timestamp that indicates when the finding record was most recently updated. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  A list of user-defined name and value string pairs added to a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        ///  Provides the veracity of a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
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
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        ///  Provides information about the status of the investigation into a finding. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
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

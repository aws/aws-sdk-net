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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The criteria that determine which findings a rule applies to.
    /// </summary>
    public partial class AutomationRulesFindingFilters
    {
        private List<StringFilter> _awsAccountId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _awsAccountName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _companyName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceAssociatedStandardsId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceSecurityControlId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceStatus = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _confidence = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<DateFilter> _createdAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<NumberFilter> _criticality = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _description = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _firstObservedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _generatorId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _id = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _lastObservedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _noteText = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _noteUpdatedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _noteUpdatedBy = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _productArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _productName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _recordState = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _relatedFindingsId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _relatedFindingsProductArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceApplicationArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceApplicationName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<MapFilter> _resourceDetailsOther = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _resourceId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourcePartition = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceRegion = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<MapFilter> _resourceTags = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _resourceType = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _severityLabel = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _sourceUrl = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _title = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _type = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _updatedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<MapFilter> _userDefinedFields = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _verificationState = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _workflowStatus = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null && (this._awsAccountId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> AwsAccountName
        {
            get { return this._awsAccountName; }
            set { this._awsAccountName = value; }
        }

        // Check to see if AwsAccountName property is set
        internal bool IsSetAwsAccountName()
        {
            return this._awsAccountName != null && (this._awsAccountName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null && (this._companyName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceAssociatedStandardsId
        {
            get { return this._complianceAssociatedStandardsId; }
            set { this._complianceAssociatedStandardsId = value; }
        }

        // Check to see if ComplianceAssociatedStandardsId property is set
        internal bool IsSetComplianceAssociatedStandardsId()
        {
            return this._complianceAssociatedStandardsId != null && (this._complianceAssociatedStandardsId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlId
        {
            get { return this._complianceSecurityControlId; }
            set { this._complianceSecurityControlId = value; }
        }

        // Check to see if ComplianceSecurityControlId property is set
        internal bool IsSetComplianceSecurityControlId()
        {
            return this._complianceSecurityControlId != null && (this._complianceSecurityControlId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null && (this._complianceStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The likelihood that a finding accurately identifies the behavior or issue that it
        /// was intended to identify. <c>Confidence</c> is scored on a 0–100 basis using a ratio
        /// scale. A value of <c>0</c> means 0 percent confidence, and a value of <c>100</c> means
        /// 100 percent confidence. For example, a data exfiltration detection based on a statistical
        /// deviation of network traffic has low confidence because an actual exfiltration hasn't
        /// been verified. For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/asff-top-level-attributes.html#asff-confidence">Confidence</a>
        /// in the <i>Security Hub User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence != null && (this._confidence.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  A timestamp that indicates when this finding record was created. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null && (this._createdAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        ///  The level of importance that is assigned to the resources that are associated with
        /// a finding. <c>Criticality</c> is scored on a 0–100 basis, using a ratio scale that
        /// supports only full integers. A score of <c>0</c> means that the underlying resources
        /// have no criticality, and a score of <c>100</c> is reserved for the most critical resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/asff-top-level-attributes.html#asff-criticality">Criticality</a>
        /// in the <i>Security Hub User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> Criticality
        {
            get { return this._criticality; }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality != null && (this._criticality.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null && (this._description.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        ///  A timestamp that indicates when the potential security issue captured by a finding
        /// was first observed by the security findings product. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> FirstObservedAt
        {
            get { return this._firstObservedAt; }
            set { this._firstObservedAt = value; }
        }

        // Check to see if FirstObservedAt property is set
        internal bool IsSetFirstObservedAt()
        {
            return this._firstObservedAt != null && (this._firstObservedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> GeneratorId
        {
            get { return this._generatorId; }
            set { this._generatorId = value; }
        }

        // Check to see if GeneratorId property is set
        internal bool IsSetGeneratorId()
        {
            return this._generatorId != null && (this._generatorId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null && (this._id.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        ///  A timestamp that indicates when the security findings provider most recently observed
        /// a change in the resource that is involved in the finding. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> LastObservedAt
        {
            get { return this._lastObservedAt; }
            set { this._lastObservedAt = value; }
        }

        // Check to see if LastObservedAt property is set
        internal bool IsSetLastObservedAt()
        {
            return this._lastObservedAt != null && (this._lastObservedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NoteText
        {
            get { return this._noteText; }
            set { this._noteText = value; }
        }

        // Check to see if NoteText property is set
        internal bool IsSetNoteText()
        {
            return this._noteText != null && (this._noteText.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NoteUpdatedAt. 
        /// <para>
        ///  The timestamp of when the note was updated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> NoteUpdatedAt
        {
            get { return this._noteUpdatedAt; }
            set { this._noteUpdatedAt = value; }
        }

        // Check to see if NoteUpdatedAt property is set
        internal bool IsSetNoteUpdatedAt()
        {
            return this._noteUpdatedAt != null && (this._noteUpdatedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NoteUpdatedBy
        {
            get { return this._noteUpdatedBy; }
            set { this._noteUpdatedBy = value; }
        }

        // Check to see if NoteUpdatedBy property is set
        internal bool IsSetNoteUpdatedBy()
        {
            return this._noteUpdatedBy != null && (this._noteUpdatedBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for a third-party product that generated a finding
        /// in Security Hub. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProductArn
        {
            get { return this._productArn; }
            set { this._productArn = value; }
        }

        // Check to see if ProductArn property is set
        internal bool IsSetProductArn()
        {
            return this._productArn != null && (this._productArn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        ///  Provides the name of the product that generated the finding. For control-based findings,
        /// the product name is Security Hub. 
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null && (this._productName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RecordState
        {
            get { return this._recordState; }
            set { this._recordState = value; }
        }

        // Check to see if RecordState property is set
        internal bool IsSetRecordState()
        {
            return this._recordState != null && (this._recordState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RelatedFindingsId
        {
            get { return this._relatedFindingsId; }
            set { this._relatedFindingsId = value; }
        }

        // Check to see if RelatedFindingsId property is set
        internal bool IsSetRelatedFindingsId()
        {
            return this._relatedFindingsId != null && (this._relatedFindingsId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RelatedFindingsProductArn
        {
            get { return this._relatedFindingsProductArn; }
            set { this._relatedFindingsProductArn = value; }
        }

        // Check to see if RelatedFindingsProductArn property is set
        internal bool IsSetRelatedFindingsProductArn()
        {
            return this._relatedFindingsProductArn != null && (this._relatedFindingsProductArn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceApplicationArn
        {
            get { return this._resourceApplicationArn; }
            set { this._resourceApplicationArn = value; }
        }

        // Check to see if ResourceApplicationArn property is set
        internal bool IsSetResourceApplicationArn()
        {
            return this._resourceApplicationArn != null && (this._resourceApplicationArn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceApplicationName
        {
            get { return this._resourceApplicationName; }
            set { this._resourceApplicationName = value; }
        }

        // Check to see if ResourceApplicationName property is set
        internal bool IsSetResourceApplicationName()
        {
            return this._resourceApplicationName != null && (this._resourceApplicationName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> ResourceDetailsOther
        {
            get { return this._resourceDetailsOther; }
            set { this._resourceDetailsOther = value; }
        }

        // Check to see if ResourceDetailsOther property is set
        internal bool IsSetResourceDetailsOther()
        {
            return this._resourceDetailsOther != null && (this._resourceDetailsOther.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null && (this._resourceId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourcePartition
        {
            get { return this._resourcePartition; }
            set { this._resourcePartition = value; }
        }

        // Check to see if ResourcePartition property is set
        internal bool IsSetResourcePartition()
        {
            return this._resourcePartition != null && (this._resourcePartition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null && (this._resourceRegion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null && (this._resourceType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> SeverityLabel
        {
            get { return this._severityLabel; }
            set { this._severityLabel = value; }
        }

        // Check to see if SeverityLabel property is set
        internal bool IsSetSeverityLabel()
        {
            return this._severityLabel != null && (this._severityLabel.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> SourceUrl
        {
            get { return this._sourceUrl; }
            set { this._sourceUrl = value; }
        }

        // Check to see if SourceUrl property is set
        internal bool IsSetSourceUrl()
        {
            return this._sourceUrl != null && (this._sourceUrl.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null && (this._title.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  One or more finding types in the format of namespace/category/classifier that classify
        /// a finding. For a list of namespaces, classifiers, and categories, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-findings-format-type-taxonomy.html">Types
        /// taxonomy for ASFF</a> in the <i>Security Hub User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null && (this._type.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  A timestamp that indicates when the finding record was most recently updated. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        ///  
        /// <para>
        ///  Array Members: Minimum number of 1 item. Maximum number of 20 items. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null && (this._updatedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> UserDefinedFields
        {
            get { return this._userDefinedFields; }
            set { this._userDefinedFields = value; }
        }

        // Check to see if UserDefinedFields property is set
        internal bool IsSetUserDefinedFields()
        {
            return this._userDefinedFields != null && (this._userDefinedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null && (this._verificationState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> WorkflowStatus
        {
            get { return this._workflowStatus; }
            set { this._workflowStatus = value; }
        }

        // Check to see if WorkflowStatus property is set
        internal bool IsSetWorkflowStatus()
        {
            return this._workflowStatus != null && (this._workflowStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
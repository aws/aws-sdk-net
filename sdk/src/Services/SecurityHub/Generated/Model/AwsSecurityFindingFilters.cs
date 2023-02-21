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
    /// A collection of attributes that are applied to all active Security Hub-aggregated
    /// findings and that result in a subset of findings that are included in this insight.
    /// 
    ///  
    /// <para>
    /// You can filter by up to 10 finding attributes. For each attribute, you can provide
    /// up to 20 filter values.
    /// </para>
    /// </summary>
    public partial class AwsSecurityFindingFilters
    {
        private List<StringFilter> _awsAccountId = new List<StringFilter>();
        private List<StringFilter> _companyName = new List<StringFilter>();
        private List<StringFilter> _complianceAssociatedStandardsId = new List<StringFilter>();
        private List<StringFilter> _complianceSecurityControlId = new List<StringFilter>();
        private List<StringFilter> _complianceStatus = new List<StringFilter>();
        private List<NumberFilter> _confidence = new List<NumberFilter>();
        private List<DateFilter> _createdAt = new List<DateFilter>();
        private List<NumberFilter> _criticality = new List<NumberFilter>();
        private List<StringFilter> _description = new List<StringFilter>();
        private List<NumberFilter> _findingProviderFieldsConfidence = new List<NumberFilter>();
        private List<NumberFilter> _findingProviderFieldsCriticality = new List<NumberFilter>();
        private List<StringFilter> _findingProviderFieldsRelatedFindingsId = new List<StringFilter>();
        private List<StringFilter> _findingProviderFieldsRelatedFindingsProductArn = new List<StringFilter>();
        private List<StringFilter> _findingProviderFieldsSeverityLabel = new List<StringFilter>();
        private List<StringFilter> _findingProviderFieldsSeverityOriginal = new List<StringFilter>();
        private List<StringFilter> _findingProviderFieldsTypes = new List<StringFilter>();
        private List<DateFilter> _firstObservedAt = new List<DateFilter>();
        private List<StringFilter> _generatorId = new List<StringFilter>();
        private List<StringFilter> _id = new List<StringFilter>();
        private List<KeywordFilter> _keyword = new List<KeywordFilter>();
        private List<DateFilter> _lastObservedAt = new List<DateFilter>();
        private List<StringFilter> _malwareName = new List<StringFilter>();
        private List<StringFilter> _malwarePath = new List<StringFilter>();
        private List<StringFilter> _malwareState = new List<StringFilter>();
        private List<StringFilter> _malwareType = new List<StringFilter>();
        private List<StringFilter> _networkDestinationDomain = new List<StringFilter>();
        private List<IpFilter> _networkDestinationIpV4 = new List<IpFilter>();
        private List<IpFilter> _networkDestinationIpV6 = new List<IpFilter>();
        private List<NumberFilter> _networkDestinationPort = new List<NumberFilter>();
        private List<StringFilter> _networkDirection = new List<StringFilter>();
        private List<StringFilter> _networkProtocol = new List<StringFilter>();
        private List<StringFilter> _networkSourceDomain = new List<StringFilter>();
        private List<IpFilter> _networkSourceIpV4 = new List<IpFilter>();
        private List<IpFilter> _networkSourceIpV6 = new List<IpFilter>();
        private List<StringFilter> _networkSourceMac = new List<StringFilter>();
        private List<NumberFilter> _networkSourcePort = new List<NumberFilter>();
        private List<StringFilter> _noteText = new List<StringFilter>();
        private List<DateFilter> _noteUpdatedAt = new List<DateFilter>();
        private List<StringFilter> _noteUpdatedBy = new List<StringFilter>();
        private List<DateFilter> _processLaunchedAt = new List<DateFilter>();
        private List<StringFilter> _processName = new List<StringFilter>();
        private List<NumberFilter> _processParentPid = new List<NumberFilter>();
        private List<StringFilter> _processPath = new List<StringFilter>();
        private List<NumberFilter> _processPid = new List<NumberFilter>();
        private List<DateFilter> _processTerminatedAt = new List<DateFilter>();
        private List<StringFilter> _productArn = new List<StringFilter>();
        private List<MapFilter> _productFields = new List<MapFilter>();
        private List<StringFilter> _productName = new List<StringFilter>();
        private List<StringFilter> _recommendationText = new List<StringFilter>();
        private List<StringFilter> _recordState = new List<StringFilter>();
        private List<StringFilter> _region = new List<StringFilter>();
        private List<StringFilter> _relatedFindingsId = new List<StringFilter>();
        private List<StringFilter> _relatedFindingsProductArn = new List<StringFilter>();
        private List<StringFilter> _resourceAwsEc2InstanceIamInstanceProfileArn = new List<StringFilter>();
        private List<StringFilter> _resourceAwsEc2InstanceImageId = new List<StringFilter>();
        private List<IpFilter> _resourceAwsEc2InstanceIpV4Addresses = new List<IpFilter>();
        private List<IpFilter> _resourceAwsEc2InstanceIpV6Addresses = new List<IpFilter>();
        private List<StringFilter> _resourceAwsEc2InstanceKeyName = new List<StringFilter>();
        private List<DateFilter> _resourceAwsEc2InstanceLaunchedAt = new List<DateFilter>();
        private List<StringFilter> _resourceAwsEc2InstanceSubnetId = new List<StringFilter>();
        private List<StringFilter> _resourceAwsEc2InstanceType = new List<StringFilter>();
        private List<StringFilter> _resourceAwsEc2InstanceVpcId = new List<StringFilter>();
        private List<DateFilter> _resourceAwsIamAccessKeyCreatedAt = new List<DateFilter>();
        private List<StringFilter> _resourceAwsIamAccessKeyPrincipalName = new List<StringFilter>();
        private List<StringFilter> _resourceAwsIamAccessKeyStatus = new List<StringFilter>();
        private List<StringFilter> _resourceAwsIamAccessKeyUserName = new List<StringFilter>();
        private List<StringFilter> _resourceAwsIamUserUserName = new List<StringFilter>();
        private List<StringFilter> _resourceAwsS3BucketOwnerId = new List<StringFilter>();
        private List<StringFilter> _resourceAwsS3BucketOwnerName = new List<StringFilter>();
        private List<StringFilter> _resourceContainerImageId = new List<StringFilter>();
        private List<StringFilter> _resourceContainerImageName = new List<StringFilter>();
        private List<DateFilter> _resourceContainerLaunchedAt = new List<DateFilter>();
        private List<StringFilter> _resourceContainerName = new List<StringFilter>();
        private List<MapFilter> _resourceDetailsOther = new List<MapFilter>();
        private List<StringFilter> _resourceId = new List<StringFilter>();
        private List<StringFilter> _resourcePartition = new List<StringFilter>();
        private List<StringFilter> _resourceRegion = new List<StringFilter>();
        private List<MapFilter> _resourceTags = new List<MapFilter>();
        private List<StringFilter> _resourceType = new List<StringFilter>();
        private List<BooleanFilter> _sample = new List<BooleanFilter>();
        private List<StringFilter> _severityLabel = new List<StringFilter>();
        private List<NumberFilter> _severityNormalized = new List<NumberFilter>();
        private List<NumberFilter> _severityProduct = new List<NumberFilter>();
        private List<StringFilter> _sourceUrl = new List<StringFilter>();
        private List<StringFilter> _threatIntelIndicatorCategory = new List<StringFilter>();
        private List<DateFilter> _threatIntelIndicatorLastObservedAt = new List<DateFilter>();
        private List<StringFilter> _threatIntelIndicatorSource = new List<StringFilter>();
        private List<StringFilter> _threatIntelIndicatorSourceUrl = new List<StringFilter>();
        private List<StringFilter> _threatIntelIndicatorType = new List<StringFilter>();
        private List<StringFilter> _threatIntelIndicatorValue = new List<StringFilter>();
        private List<StringFilter> _title = new List<StringFilter>();
        private List<StringFilter> _type = new List<StringFilter>();
        private List<DateFilter> _updatedAt = new List<DateFilter>();
        private List<MapFilter> _userDefinedFields = new List<MapFilter>();
        private List<StringFilter> _verificationState = new List<StringFilter>();
        private List<StringFilter> _workflowState = new List<StringFilter>();
        private List<StringFilter> _workflowStatus = new List<StringFilter>();

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that a finding is generated in.
        /// </para>
        /// </summary>
        public List<StringFilter> AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null && this._awsAccountId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the findings provider (company) that owns the solution (product) that
        /// generates findings.
        /// </para>
        /// </summary>
        public List<StringFilter> CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null && this._companyName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceAssociatedStandardsId. 
        /// <para>
        ///  The unique identifier of a standard in which a control is enabled. This field consists
        /// of the resource portion of the Amazon Resource Name (ARN) returned for a standard
        /// in the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_DescribeStandards.html">DescribeStandards</a>
        /// API response. 
        /// </para>
        /// </summary>
        public List<StringFilter> ComplianceAssociatedStandardsId
        {
            get { return this._complianceAssociatedStandardsId; }
            set { this._complianceAssociatedStandardsId = value; }
        }

        // Check to see if ComplianceAssociatedStandardsId property is set
        internal bool IsSetComplianceAssociatedStandardsId()
        {
            return this._complianceAssociatedStandardsId != null && this._complianceAssociatedStandardsId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceSecurityControlId. 
        /// <para>
        ///  The unique identifier of a control across standards. Values for this field typically
        /// consist of an Amazon Web Service and a number, such as APIGateway.5. 
        /// </para>
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlId
        {
            get { return this._complianceSecurityControlId; }
            set { this._complianceSecurityControlId = value; }
        }

        // Check to see if ComplianceSecurityControlId property is set
        internal bool IsSetComplianceSecurityControlId()
        {
            return this._complianceSecurityControlId != null && this._complianceSecurityControlId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Exclusive to findings that are generated as the result of a check run against a specific
        /// rule in a supported standard, such as CIS Amazon Web Services Foundations. Contains
        /// security standard-related finding details.
        /// </para>
        /// </summary>
        public List<StringFilter> ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null && this._complianceStatus.Count > 0; 
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
        public List<NumberFilter> Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence != null && this._confidence.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the security-findings provider
        /// captured the potential security issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null && this._createdAt.Count > 0; 
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
        public List<NumberFilter> Criticality
        {
            get { return this._criticality; }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality != null && this._criticality.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A finding's description.
        /// </para>
        /// </summary>
        public List<StringFilter> Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null && this._description.Count > 0; 
        }

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
        /// </summary>
        public List<NumberFilter> FindingProviderFieldsConfidence
        {
            get { return this._findingProviderFieldsConfidence; }
            set { this._findingProviderFieldsConfidence = value; }
        }

        // Check to see if FindingProviderFieldsConfidence property is set
        internal bool IsSetFindingProviderFieldsConfidence()
        {
            return this._findingProviderFieldsConfidence != null && this._findingProviderFieldsConfidence.Count > 0; 
        }

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
        /// </summary>
        public List<NumberFilter> FindingProviderFieldsCriticality
        {
            get { return this._findingProviderFieldsCriticality; }
            set { this._findingProviderFieldsCriticality = value; }
        }

        // Check to see if FindingProviderFieldsCriticality property is set
        internal bool IsSetFindingProviderFieldsCriticality()
        {
            return this._findingProviderFieldsCriticality != null && this._findingProviderFieldsCriticality.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsRelatedFindingsId. 
        /// <para>
        /// The finding identifier of a related finding that is identified by the finding provider.
        /// </para>
        /// </summary>
        public List<StringFilter> FindingProviderFieldsRelatedFindingsId
        {
            get { return this._findingProviderFieldsRelatedFindingsId; }
            set { this._findingProviderFieldsRelatedFindingsId = value; }
        }

        // Check to see if FindingProviderFieldsRelatedFindingsId property is set
        internal bool IsSetFindingProviderFieldsRelatedFindingsId()
        {
            return this._findingProviderFieldsRelatedFindingsId != null && this._findingProviderFieldsRelatedFindingsId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsRelatedFindingsProductArn. 
        /// <para>
        /// The ARN of the solution that generated a related finding that is identified by the
        /// finding provider.
        /// </para>
        /// </summary>
        public List<StringFilter> FindingProviderFieldsRelatedFindingsProductArn
        {
            get { return this._findingProviderFieldsRelatedFindingsProductArn; }
            set { this._findingProviderFieldsRelatedFindingsProductArn = value; }
        }

        // Check to see if FindingProviderFieldsRelatedFindingsProductArn property is set
        internal bool IsSetFindingProviderFieldsRelatedFindingsProductArn()
        {
            return this._findingProviderFieldsRelatedFindingsProductArn != null && this._findingProviderFieldsRelatedFindingsProductArn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsSeverityLabel. 
        /// <para>
        /// The finding provider value for the severity label.
        /// </para>
        /// </summary>
        public List<StringFilter> FindingProviderFieldsSeverityLabel
        {
            get { return this._findingProviderFieldsSeverityLabel; }
            set { this._findingProviderFieldsSeverityLabel = value; }
        }

        // Check to see if FindingProviderFieldsSeverityLabel property is set
        internal bool IsSetFindingProviderFieldsSeverityLabel()
        {
            return this._findingProviderFieldsSeverityLabel != null && this._findingProviderFieldsSeverityLabel.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsSeverityOriginal. 
        /// <para>
        /// The finding provider's original value for the severity.
        /// </para>
        /// </summary>
        public List<StringFilter> FindingProviderFieldsSeverityOriginal
        {
            get { return this._findingProviderFieldsSeverityOriginal; }
            set { this._findingProviderFieldsSeverityOriginal = value; }
        }

        // Check to see if FindingProviderFieldsSeverityOriginal property is set
        internal bool IsSetFindingProviderFieldsSeverityOriginal()
        {
            return this._findingProviderFieldsSeverityOriginal != null && this._findingProviderFieldsSeverityOriginal.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsTypes. 
        /// <para>
        /// One or more finding types that the finding provider assigned to the finding. Uses
        /// the format of <code>namespace/category/classifier</code> that classify a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are: Software and Configuration Checks | TTPs | Effects | Unusual
        /// Behaviors | Sensitive Data Identifications
        /// </para>
        /// </summary>
        public List<StringFilter> FindingProviderFieldsTypes
        {
            get { return this._findingProviderFieldsTypes; }
            set { this._findingProviderFieldsTypes = value; }
        }

        // Check to see if FindingProviderFieldsTypes property is set
        internal bool IsSetFindingProviderFieldsTypes()
        {
            return this._findingProviderFieldsTypes != null && this._findingProviderFieldsTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the security-findings provider
        /// first observed the potential security issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> FirstObservedAt
        {
            get { return this._firstObservedAt; }
            set { this._firstObservedAt = value; }
        }

        // Check to see if FirstObservedAt property is set
        internal bool IsSetFirstObservedAt()
        {
            return this._firstObservedAt != null && this._firstObservedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GeneratorId. 
        /// <para>
        /// The identifier for the solution-specific component (a discrete unit of logic) that
        /// generated a finding. In various security-findings providers' solutions, this generator
        /// can be called a rule, a check, a detector, a plugin, etc.
        /// </para>
        /// </summary>
        public List<StringFilter> GeneratorId
        {
            get { return this._generatorId; }
            set { this._generatorId = value; }
        }

        // Check to see if GeneratorId property is set
        internal bool IsSetGeneratorId()
        {
            return this._generatorId != null && this._generatorId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The security findings provider-specific identifier for a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null && this._id.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// A keyword for a finding.
        /// </para>
        /// </summary>
        [Obsolete("The Keyword property is deprecated.")]
        public List<KeywordFilter> Keyword
        {
            get { return this._keyword; }
            set { this._keyword = value; }
        }

        // Check to see if Keyword property is set
        internal bool IsSetKeyword()
        {
            return this._keyword != null && this._keyword.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the security-findings provider
        /// most recently observed the potential security issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> LastObservedAt
        {
            get { return this._lastObservedAt; }
            set { this._lastObservedAt = value; }
        }

        // Check to see if LastObservedAt property is set
        internal bool IsSetLastObservedAt()
        {
            return this._lastObservedAt != null && this._lastObservedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MalwareName. 
        /// <para>
        /// The name of the malware that was observed.
        /// </para>
        /// </summary>
        public List<StringFilter> MalwareName
        {
            get { return this._malwareName; }
            set { this._malwareName = value; }
        }

        // Check to see if MalwareName property is set
        internal bool IsSetMalwareName()
        {
            return this._malwareName != null && this._malwareName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MalwarePath. 
        /// <para>
        /// The filesystem path of the malware that was observed.
        /// </para>
        /// </summary>
        public List<StringFilter> MalwarePath
        {
            get { return this._malwarePath; }
            set { this._malwarePath = value; }
        }

        // Check to see if MalwarePath property is set
        internal bool IsSetMalwarePath()
        {
            return this._malwarePath != null && this._malwarePath.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MalwareState. 
        /// <para>
        /// The state of the malware that was observed.
        /// </para>
        /// </summary>
        public List<StringFilter> MalwareState
        {
            get { return this._malwareState; }
            set { this._malwareState = value; }
        }

        // Check to see if MalwareState property is set
        internal bool IsSetMalwareState()
        {
            return this._malwareState != null && this._malwareState.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MalwareType. 
        /// <para>
        /// The type of the malware that was observed.
        /// </para>
        /// </summary>
        public List<StringFilter> MalwareType
        {
            get { return this._malwareType; }
            set { this._malwareType = value; }
        }

        // Check to see if MalwareType property is set
        internal bool IsSetMalwareType()
        {
            return this._malwareType != null && this._malwareType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationDomain. 
        /// <para>
        /// The destination domain of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> NetworkDestinationDomain
        {
            get { return this._networkDestinationDomain; }
            set { this._networkDestinationDomain = value; }
        }

        // Check to see if NetworkDestinationDomain property is set
        internal bool IsSetNetworkDestinationDomain()
        {
            return this._networkDestinationDomain != null && this._networkDestinationDomain.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationIpV4. 
        /// <para>
        /// The destination IPv4 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<IpFilter> NetworkDestinationIpV4
        {
            get { return this._networkDestinationIpV4; }
            set { this._networkDestinationIpV4 = value; }
        }

        // Check to see if NetworkDestinationIpV4 property is set
        internal bool IsSetNetworkDestinationIpV4()
        {
            return this._networkDestinationIpV4 != null && this._networkDestinationIpV4.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationIpV6. 
        /// <para>
        /// The destination IPv6 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<IpFilter> NetworkDestinationIpV6
        {
            get { return this._networkDestinationIpV6; }
            set { this._networkDestinationIpV6 = value; }
        }

        // Check to see if NetworkDestinationIpV6 property is set
        internal bool IsSetNetworkDestinationIpV6()
        {
            return this._networkDestinationIpV6 != null && this._networkDestinationIpV6.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationPort. 
        /// <para>
        /// The destination port of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<NumberFilter> NetworkDestinationPort
        {
            get { return this._networkDestinationPort; }
            set { this._networkDestinationPort = value; }
        }

        // Check to see if NetworkDestinationPort property is set
        internal bool IsSetNetworkDestinationPort()
        {
            return this._networkDestinationPort != null && this._networkDestinationPort.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkDirection. 
        /// <para>
        /// Indicates the direction of network traffic associated with a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> NetworkDirection
        {
            get { return this._networkDirection; }
            set { this._networkDirection = value; }
        }

        // Check to see if NetworkDirection property is set
        internal bool IsSetNetworkDirection()
        {
            return this._networkDirection != null && this._networkDirection.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkProtocol. 
        /// <para>
        /// The protocol of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> NetworkProtocol
        {
            get { return this._networkProtocol; }
            set { this._networkProtocol = value; }
        }

        // Check to see if NetworkProtocol property is set
        internal bool IsSetNetworkProtocol()
        {
            return this._networkProtocol != null && this._networkProtocol.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceDomain. 
        /// <para>
        /// The source domain of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> NetworkSourceDomain
        {
            get { return this._networkSourceDomain; }
            set { this._networkSourceDomain = value; }
        }

        // Check to see if NetworkSourceDomain property is set
        internal bool IsSetNetworkSourceDomain()
        {
            return this._networkSourceDomain != null && this._networkSourceDomain.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceIpV4. 
        /// <para>
        /// The source IPv4 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<IpFilter> NetworkSourceIpV4
        {
            get { return this._networkSourceIpV4; }
            set { this._networkSourceIpV4 = value; }
        }

        // Check to see if NetworkSourceIpV4 property is set
        internal bool IsSetNetworkSourceIpV4()
        {
            return this._networkSourceIpV4 != null && this._networkSourceIpV4.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceIpV6. 
        /// <para>
        /// The source IPv6 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<IpFilter> NetworkSourceIpV6
        {
            get { return this._networkSourceIpV6; }
            set { this._networkSourceIpV6 = value; }
        }

        // Check to see if NetworkSourceIpV6 property is set
        internal bool IsSetNetworkSourceIpV6()
        {
            return this._networkSourceIpV6 != null && this._networkSourceIpV6.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceMac. 
        /// <para>
        /// The source media access control (MAC) address of network-related information about
        /// a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> NetworkSourceMac
        {
            get { return this._networkSourceMac; }
            set { this._networkSourceMac = value; }
        }

        // Check to see if NetworkSourceMac property is set
        internal bool IsSetNetworkSourceMac()
        {
            return this._networkSourceMac != null && this._networkSourceMac.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourcePort. 
        /// <para>
        /// The source port of network-related information about a finding.
        /// </para>
        /// </summary>
        public List<NumberFilter> NetworkSourcePort
        {
            get { return this._networkSourcePort; }
            set { this._networkSourcePort = value; }
        }

        // Check to see if NetworkSourcePort property is set
        internal bool IsSetNetworkSourcePort()
        {
            return this._networkSourcePort != null && this._networkSourcePort.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NoteText. 
        /// <para>
        /// The text of a note.
        /// </para>
        /// </summary>
        public List<StringFilter> NoteText
        {
            get { return this._noteText; }
            set { this._noteText = value; }
        }

        // Check to see if NoteText property is set
        internal bool IsSetNoteText()
        {
            return this._noteText != null && this._noteText.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NoteUpdatedAt. 
        /// <para>
        /// The timestamp of when the note was updated.
        /// </para>
        /// </summary>
        public List<DateFilter> NoteUpdatedAt
        {
            get { return this._noteUpdatedAt; }
            set { this._noteUpdatedAt = value; }
        }

        // Check to see if NoteUpdatedAt property is set
        internal bool IsSetNoteUpdatedAt()
        {
            return this._noteUpdatedAt != null && this._noteUpdatedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NoteUpdatedBy. 
        /// <para>
        /// The principal that created a note.
        /// </para>
        /// </summary>
        public List<StringFilter> NoteUpdatedBy
        {
            get { return this._noteUpdatedBy; }
            set { this._noteUpdatedBy = value; }
        }

        // Check to see if NoteUpdatedBy property is set
        internal bool IsSetNoteUpdatedBy()
        {
            return this._noteUpdatedBy != null && this._noteUpdatedBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessLaunchedAt. 
        /// <para>
        /// A timestamp that identifies when the process was launched.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> ProcessLaunchedAt
        {
            get { return this._processLaunchedAt; }
            set { this._processLaunchedAt = value; }
        }

        // Check to see if ProcessLaunchedAt property is set
        internal bool IsSetProcessLaunchedAt()
        {
            return this._processLaunchedAt != null && this._processLaunchedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessName. 
        /// <para>
        /// The name of the process.
        /// </para>
        /// </summary>
        public List<StringFilter> ProcessName
        {
            get { return this._processName; }
            set { this._processName = value; }
        }

        // Check to see if ProcessName property is set
        internal bool IsSetProcessName()
        {
            return this._processName != null && this._processName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessParentPid. 
        /// <para>
        /// The parent process ID.
        /// </para>
        /// </summary>
        public List<NumberFilter> ProcessParentPid
        {
            get { return this._processParentPid; }
            set { this._processParentPid = value; }
        }

        // Check to see if ProcessParentPid property is set
        internal bool IsSetProcessParentPid()
        {
            return this._processParentPid != null && this._processParentPid.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessPath. 
        /// <para>
        /// The path to the process executable.
        /// </para>
        /// </summary>
        public List<StringFilter> ProcessPath
        {
            get { return this._processPath; }
            set { this._processPath = value; }
        }

        // Check to see if ProcessPath property is set
        internal bool IsSetProcessPath()
        {
            return this._processPath != null && this._processPath.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessPid. 
        /// <para>
        /// The process ID.
        /// </para>
        /// </summary>
        public List<NumberFilter> ProcessPid
        {
            get { return this._processPid; }
            set { this._processPid = value; }
        }

        // Check to see if ProcessPid property is set
        internal bool IsSetProcessPid()
        {
            return this._processPid != null && this._processPid.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessTerminatedAt. 
        /// <para>
        /// A timestamp that identifies when the process was terminated.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> ProcessTerminatedAt
        {
            get { return this._processTerminatedAt; }
            set { this._processTerminatedAt = value; }
        }

        // Check to see if ProcessTerminatedAt property is set
        internal bool IsSetProcessTerminatedAt()
        {
            return this._processTerminatedAt != null && this._processTerminatedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN generated by Security Hub that uniquely identifies a third-party company (security
        /// findings provider) after this provider's product (solution that generates findings)
        /// is registered with Security Hub.
        /// </para>
        /// </summary>
        public List<StringFilter> ProductArn
        {
            get { return this._productArn; }
            set { this._productArn = value; }
        }

        // Check to see if ProductArn property is set
        internal bool IsSetProductArn()
        {
            return this._productArn != null && this._productArn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductFields. 
        /// <para>
        /// A data type where security-findings providers can include additional solution-specific
        /// details that aren't part of the defined <code>AwsSecurityFinding</code> format.
        /// </para>
        /// </summary>
        public List<MapFilter> ProductFields
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
        /// The name of the solution (product) that generates findings.
        /// </para>
        /// </summary>
        public List<StringFilter> ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null && this._productName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationText. 
        /// <para>
        /// The recommendation of what to do about the issue described in a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> RecommendationText
        {
            get { return this._recommendationText; }
            set { this._recommendationText = value; }
        }

        // Check to see if RecommendationText property is set
        internal bool IsSetRecommendationText()
        {
            return this._recommendationText != null && this._recommendationText.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The updated record state for the finding.
        /// </para>
        /// </summary>
        public List<StringFilter> RecordState
        {
            get { return this._recordState; }
            set { this._recordState = value; }
        }

        // Check to see if RecordState property is set
        internal bool IsSetRecordState()
        {
            return this._recordState != null && this._recordState.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region from which the finding was generated.
        /// </para>
        /// </summary>
        public List<StringFilter> Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null && this._region.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RelatedFindingsId. 
        /// <para>
        /// The solution-generated identifier for a related finding.
        /// </para>
        /// </summary>
        public List<StringFilter> RelatedFindingsId
        {
            get { return this._relatedFindingsId; }
            set { this._relatedFindingsId = value; }
        }

        // Check to see if RelatedFindingsId property is set
        internal bool IsSetRelatedFindingsId()
        {
            return this._relatedFindingsId != null && this._relatedFindingsId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RelatedFindingsProductArn. 
        /// <para>
        /// The ARN of the solution that generated a related finding.
        /// </para>
        /// </summary>
        public List<StringFilter> RelatedFindingsProductArn
        {
            get { return this._relatedFindingsProductArn; }
            set { this._relatedFindingsProductArn = value; }
        }

        // Check to see if RelatedFindingsProductArn property is set
        internal bool IsSetRelatedFindingsProductArn()
        {
            return this._relatedFindingsProductArn != null && this._relatedFindingsProductArn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIamInstanceProfileArn. 
        /// <para>
        /// The IAM profile ARN of the instance.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceIamInstanceProfileArn
        {
            get { return this._resourceAwsEc2InstanceIamInstanceProfileArn; }
            set { this._resourceAwsEc2InstanceIamInstanceProfileArn = value; }
        }

        // Check to see if ResourceAwsEc2InstanceIamInstanceProfileArn property is set
        internal bool IsSetResourceAwsEc2InstanceIamInstanceProfileArn()
        {
            return this._resourceAwsEc2InstanceIamInstanceProfileArn != null && this._resourceAwsEc2InstanceIamInstanceProfileArn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID of the instance.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceImageId
        {
            get { return this._resourceAwsEc2InstanceImageId; }
            set { this._resourceAwsEc2InstanceImageId = value; }
        }

        // Check to see if ResourceAwsEc2InstanceImageId property is set
        internal bool IsSetResourceAwsEc2InstanceImageId()
        {
            return this._resourceAwsEc2InstanceImageId != null && this._resourceAwsEc2InstanceImageId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIpV4Addresses. 
        /// <para>
        /// The IPv4 addresses associated with the instance.
        /// </para>
        /// </summary>
        public List<IpFilter> ResourceAwsEc2InstanceIpV4Addresses
        {
            get { return this._resourceAwsEc2InstanceIpV4Addresses; }
            set { this._resourceAwsEc2InstanceIpV4Addresses = value; }
        }

        // Check to see if ResourceAwsEc2InstanceIpV4Addresses property is set
        internal bool IsSetResourceAwsEc2InstanceIpV4Addresses()
        {
            return this._resourceAwsEc2InstanceIpV4Addresses != null && this._resourceAwsEc2InstanceIpV4Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIpV6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the instance.
        /// </para>
        /// </summary>
        public List<IpFilter> ResourceAwsEc2InstanceIpV6Addresses
        {
            get { return this._resourceAwsEc2InstanceIpV6Addresses; }
            set { this._resourceAwsEc2InstanceIpV6Addresses = value; }
        }

        // Check to see if ResourceAwsEc2InstanceIpV6Addresses property is set
        internal bool IsSetResourceAwsEc2InstanceIpV6Addresses()
        {
            return this._resourceAwsEc2InstanceIpV6Addresses != null && this._resourceAwsEc2InstanceIpV6Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceKeyName. 
        /// <para>
        /// The key name associated with the instance.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceKeyName
        {
            get { return this._resourceAwsEc2InstanceKeyName; }
            set { this._resourceAwsEc2InstanceKeyName = value; }
        }

        // Check to see if ResourceAwsEc2InstanceKeyName property is set
        internal bool IsSetResourceAwsEc2InstanceKeyName()
        {
            return this._resourceAwsEc2InstanceKeyName != null && this._resourceAwsEc2InstanceKeyName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceLaunchedAt. 
        /// <para>
        /// The date and time the instance was launched.
        /// </para>
        /// </summary>
        public List<DateFilter> ResourceAwsEc2InstanceLaunchedAt
        {
            get { return this._resourceAwsEc2InstanceLaunchedAt; }
            set { this._resourceAwsEc2InstanceLaunchedAt = value; }
        }

        // Check to see if ResourceAwsEc2InstanceLaunchedAt property is set
        internal bool IsSetResourceAwsEc2InstanceLaunchedAt()
        {
            return this._resourceAwsEc2InstanceLaunchedAt != null && this._resourceAwsEc2InstanceLaunchedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceSubnetId. 
        /// <para>
        /// The identifier of the subnet that the instance was launched in.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceSubnetId
        {
            get { return this._resourceAwsEc2InstanceSubnetId; }
            set { this._resourceAwsEc2InstanceSubnetId = value; }
        }

        // Check to see if ResourceAwsEc2InstanceSubnetId property is set
        internal bool IsSetResourceAwsEc2InstanceSubnetId()
        {
            return this._resourceAwsEc2InstanceSubnetId != null && this._resourceAwsEc2InstanceSubnetId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceType. 
        /// <para>
        /// The instance type of the instance.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceType
        {
            get { return this._resourceAwsEc2InstanceType; }
            set { this._resourceAwsEc2InstanceType = value; }
        }

        // Check to see if ResourceAwsEc2InstanceType property is set
        internal bool IsSetResourceAwsEc2InstanceType()
        {
            return this._resourceAwsEc2InstanceType != null && this._resourceAwsEc2InstanceType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceVpcId. 
        /// <para>
        /// The identifier of the VPC that the instance was launched in.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceVpcId
        {
            get { return this._resourceAwsEc2InstanceVpcId; }
            set { this._resourceAwsEc2InstanceVpcId = value; }
        }

        // Check to see if ResourceAwsEc2InstanceVpcId property is set
        internal bool IsSetResourceAwsEc2InstanceVpcId()
        {
            return this._resourceAwsEc2InstanceVpcId != null && this._resourceAwsEc2InstanceVpcId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyCreatedAt. 
        /// <para>
        /// The creation date/time of the IAM access key related to a finding.
        /// </para>
        /// </summary>
        public List<DateFilter> ResourceAwsIamAccessKeyCreatedAt
        {
            get { return this._resourceAwsIamAccessKeyCreatedAt; }
            set { this._resourceAwsIamAccessKeyCreatedAt = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyCreatedAt property is set
        internal bool IsSetResourceAwsIamAccessKeyCreatedAt()
        {
            return this._resourceAwsIamAccessKeyCreatedAt != null && this._resourceAwsIamAccessKeyCreatedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyPrincipalName. 
        /// <para>
        /// The name of the principal that is associated with an IAM access key.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsIamAccessKeyPrincipalName
        {
            get { return this._resourceAwsIamAccessKeyPrincipalName; }
            set { this._resourceAwsIamAccessKeyPrincipalName = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyPrincipalName property is set
        internal bool IsSetResourceAwsIamAccessKeyPrincipalName()
        {
            return this._resourceAwsIamAccessKeyPrincipalName != null && this._resourceAwsIamAccessKeyPrincipalName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyStatus. 
        /// <para>
        /// The status of the IAM access key related to a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsIamAccessKeyStatus
        {
            get { return this._resourceAwsIamAccessKeyStatus; }
            set { this._resourceAwsIamAccessKeyStatus = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyStatus property is set
        internal bool IsSetResourceAwsIamAccessKeyStatus()
        {
            return this._resourceAwsIamAccessKeyStatus != null && this._resourceAwsIamAccessKeyStatus.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyUserName. 
        /// <para>
        /// The user associated with the IAM access key related to a finding.
        /// </para>
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use ResourceAwsIamAccessKeyPrincipalName.")]
        public List<StringFilter> ResourceAwsIamAccessKeyUserName
        {
            get { return this._resourceAwsIamAccessKeyUserName; }
            set { this._resourceAwsIamAccessKeyUserName = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyUserName property is set
        internal bool IsSetResourceAwsIamAccessKeyUserName()
        {
            return this._resourceAwsIamAccessKeyUserName != null && this._resourceAwsIamAccessKeyUserName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamUserUserName. 
        /// <para>
        /// The name of an IAM user.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsIamUserUserName
        {
            get { return this._resourceAwsIamUserUserName; }
            set { this._resourceAwsIamUserUserName = value; }
        }

        // Check to see if ResourceAwsIamUserUserName property is set
        internal bool IsSetResourceAwsIamUserUserName()
        {
            return this._resourceAwsIamUserUserName != null && this._resourceAwsIamUserUserName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsS3BucketOwnerId. 
        /// <para>
        /// The canonical user ID of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsS3BucketOwnerId
        {
            get { return this._resourceAwsS3BucketOwnerId; }
            set { this._resourceAwsS3BucketOwnerId = value; }
        }

        // Check to see if ResourceAwsS3BucketOwnerId property is set
        internal bool IsSetResourceAwsS3BucketOwnerId()
        {
            return this._resourceAwsS3BucketOwnerId != null && this._resourceAwsS3BucketOwnerId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsS3BucketOwnerName. 
        /// <para>
        /// The display name of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceAwsS3BucketOwnerName
        {
            get { return this._resourceAwsS3BucketOwnerName; }
            set { this._resourceAwsS3BucketOwnerName = value; }
        }

        // Check to see if ResourceAwsS3BucketOwnerName property is set
        internal bool IsSetResourceAwsS3BucketOwnerName()
        {
            return this._resourceAwsS3BucketOwnerName != null && this._resourceAwsS3BucketOwnerName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerImageId. 
        /// <para>
        /// The identifier of the image related to a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceContainerImageId
        {
            get { return this._resourceContainerImageId; }
            set { this._resourceContainerImageId = value; }
        }

        // Check to see if ResourceContainerImageId property is set
        internal bool IsSetResourceContainerImageId()
        {
            return this._resourceContainerImageId != null && this._resourceContainerImageId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerImageName. 
        /// <para>
        /// The name of the image related to a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceContainerImageName
        {
            get { return this._resourceContainerImageName; }
            set { this._resourceContainerImageName = value; }
        }

        // Check to see if ResourceContainerImageName property is set
        internal bool IsSetResourceContainerImageName()
        {
            return this._resourceContainerImageName != null && this._resourceContainerImageName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerLaunchedAt. 
        /// <para>
        /// A timestamp that identifies when the container was started.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> ResourceContainerLaunchedAt
        {
            get { return this._resourceContainerLaunchedAt; }
            set { this._resourceContainerLaunchedAt = value; }
        }

        // Check to see if ResourceContainerLaunchedAt property is set
        internal bool IsSetResourceContainerLaunchedAt()
        {
            return this._resourceContainerLaunchedAt != null && this._resourceContainerLaunchedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerName. 
        /// <para>
        /// The name of the container related to a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceContainerName
        {
            get { return this._resourceContainerName; }
            set { this._resourceContainerName = value; }
        }

        // Check to see if ResourceContainerName property is set
        internal bool IsSetResourceContainerName()
        {
            return this._resourceContainerName != null && this._resourceContainerName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceDetailsOther. 
        /// <para>
        /// The details of a resource that doesn't have a specific subfield for the resource type
        /// defined.
        /// </para>
        /// </summary>
        public List<MapFilter> ResourceDetailsOther
        {
            get { return this._resourceDetailsOther; }
            set { this._resourceDetailsOther = value; }
        }

        // Check to see if ResourceDetailsOther property is set
        internal bool IsSetResourceDetailsOther()
        {
            return this._resourceDetailsOther != null && this._resourceDetailsOther.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The canonical identifier for the given resource type.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null && this._resourceId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourcePartition. 
        /// <para>
        /// The canonical Amazon Web Services partition name that the Region is assigned to.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourcePartition
        {
            get { return this._resourcePartition; }
            set { this._resourcePartition = value; }
        }

        // Check to see if ResourcePartition property is set
        internal bool IsSetResourcePartition()
        {
            return this._resourcePartition != null && this._resourcePartition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The canonical Amazon Web Services external Region name where this resource is located.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null && this._resourceRegion.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// A list of Amazon Web Services tags associated with a resource at the time the finding
        /// was processed.
        /// </para>
        /// </summary>
        public List<MapFilter> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the type of the resource that details are provided for.
        /// </para>
        /// </summary>
        public List<StringFilter> ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null && this._resourceType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// Indicates whether or not sample findings are included in the filter results.
        /// </para>
        /// </summary>
        public List<BooleanFilter> Sample
        {
            get { return this._sample; }
            set { this._sample = value; }
        }

        // Check to see if Sample property is set
        internal bool IsSetSample()
        {
            return this._sample != null && this._sample.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SeverityLabel. 
        /// <para>
        /// The label of a finding's severity.
        /// </para>
        /// </summary>
        public List<StringFilter> SeverityLabel
        {
            get { return this._severityLabel; }
            set { this._severityLabel = value; }
        }

        // Check to see if SeverityLabel property is set
        internal bool IsSetSeverityLabel()
        {
            return this._severityLabel != null && this._severityLabel.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SeverityNormalized. 
        /// <para>
        /// The normalized severity of a finding.
        /// </para>
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use SeverityLabel or FindingProviderFieldsSeverityLabel.")]
        public List<NumberFilter> SeverityNormalized
        {
            get { return this._severityNormalized; }
            set { this._severityNormalized = value; }
        }

        // Check to see if SeverityNormalized property is set
        internal bool IsSetSeverityNormalized()
        {
            return this._severityNormalized != null && this._severityNormalized.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SeverityProduct. 
        /// <para>
        /// The native severity as defined by the security-findings provider's solution that generated
        /// the finding.
        /// </para>
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use FindingProviderSeverityOriginal.")]
        public List<NumberFilter> SeverityProduct
        {
            get { return this._severityProduct; }
            set { this._severityProduct = value; }
        }

        // Check to see if SeverityProduct property is set
        internal bool IsSetSeverityProduct()
        {
            return this._severityProduct != null && this._severityProduct.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// A URL that links to a page about the current finding in the security-findings provider's
        /// solution.
        /// </para>
        /// </summary>
        public List<StringFilter> SourceUrl
        {
            get { return this._sourceUrl; }
            set { this._sourceUrl = value; }
        }

        // Check to see if SourceUrl property is set
        internal bool IsSetSourceUrl()
        {
            return this._sourceUrl != null && this._sourceUrl.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorCategory. 
        /// <para>
        /// The category of a threat intelligence indicator.
        /// </para>
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorCategory
        {
            get { return this._threatIntelIndicatorCategory; }
            set { this._threatIntelIndicatorCategory = value; }
        }

        // Check to see if ThreatIntelIndicatorCategory property is set
        internal bool IsSetThreatIntelIndicatorCategory()
        {
            return this._threatIntelIndicatorCategory != null && this._threatIntelIndicatorCategory.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorLastObservedAt. 
        /// <para>
        /// A timestamp that identifies the last observation of a threat intelligence indicator.
        /// </para>
        /// </summary>
        public List<DateFilter> ThreatIntelIndicatorLastObservedAt
        {
            get { return this._threatIntelIndicatorLastObservedAt; }
            set { this._threatIntelIndicatorLastObservedAt = value; }
        }

        // Check to see if ThreatIntelIndicatorLastObservedAt property is set
        internal bool IsSetThreatIntelIndicatorLastObservedAt()
        {
            return this._threatIntelIndicatorLastObservedAt != null && this._threatIntelIndicatorLastObservedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorSource. 
        /// <para>
        /// The source of the threat intelligence.
        /// </para>
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorSource
        {
            get { return this._threatIntelIndicatorSource; }
            set { this._threatIntelIndicatorSource = value; }
        }

        // Check to see if ThreatIntelIndicatorSource property is set
        internal bool IsSetThreatIntelIndicatorSource()
        {
            return this._threatIntelIndicatorSource != null && this._threatIntelIndicatorSource.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorSourceUrl. 
        /// <para>
        /// The URL for more details from the source of the threat intelligence.
        /// </para>
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorSourceUrl
        {
            get { return this._threatIntelIndicatorSourceUrl; }
            set { this._threatIntelIndicatorSourceUrl = value; }
        }

        // Check to see if ThreatIntelIndicatorSourceUrl property is set
        internal bool IsSetThreatIntelIndicatorSourceUrl()
        {
            return this._threatIntelIndicatorSourceUrl != null && this._threatIntelIndicatorSourceUrl.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorType. 
        /// <para>
        /// The type of a threat intelligence indicator.
        /// </para>
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorType
        {
            get { return this._threatIntelIndicatorType; }
            set { this._threatIntelIndicatorType = value; }
        }

        // Check to see if ThreatIntelIndicatorType property is set
        internal bool IsSetThreatIntelIndicatorType()
        {
            return this._threatIntelIndicatorType != null && this._threatIntelIndicatorType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorValue. 
        /// <para>
        /// The value of a threat intelligence indicator.
        /// </para>
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorValue
        {
            get { return this._threatIntelIndicatorValue; }
            set { this._threatIntelIndicatorValue = value; }
        }

        // Check to see if ThreatIntelIndicatorValue property is set
        internal bool IsSetThreatIntelIndicatorValue()
        {
            return this._threatIntelIndicatorValue != null && this._threatIntelIndicatorValue.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A finding's title.
        /// </para>
        /// </summary>
        public List<StringFilter> Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null && this._title.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A finding type in the format of <code>namespace/category/classifier</code> that classifies
        /// a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null && this._type.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// An ISO8601-formatted timestamp that indicates when the security-findings provider
        /// last updated the finding record. 
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        /// </summary>
        public List<DateFilter> UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null && this._updatedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserDefinedFields. 
        /// <para>
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding. 
        /// </para>
        /// </summary>
        public List<MapFilter> UserDefinedFields
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
        /// The veracity of a finding.
        /// </para>
        /// </summary>
        public List<StringFilter> VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null && this._verificationState.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowState. 
        /// <para>
        /// The workflow state of a finding.
        /// </para>
        ///  
        /// <para>
        /// Note that this field is deprecated. To search for a finding based on its workflow
        /// status, use <code>WorkflowStatus</code>.
        /// </para>
        /// </summary>
        public List<StringFilter> WorkflowState
        {
            get { return this._workflowState; }
            set { this._workflowState = value; }
        }

        // Check to see if WorkflowState property is set
        internal bool IsSetWorkflowState()
        {
            return this._workflowState != null && this._workflowState.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The status of the investigation into a finding. Allowed values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW</code> - The initial state of a finding, before it is reviewed.
        /// </para>
        ///  
        /// <para>
        /// Security Hub also resets the workflow status from <code>NOTIFIED</code> or <code>RESOLVED</code>
        /// to <code>NEW</code> in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RecordState</code> changes from <code>ARCHIVED</code> to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Compliance.Status</code> changes from <code>PASSED</code> to either <code>WARNING</code>,
        /// <code>FAILED</code>, or <code>NOT_AVAILABLE</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>NOTIFIED</code> - Indicates that the resource owner has been notified about
        /// the security issue. Used when the initial reviewer is not the resource owner, and
        /// needs intervention from the resource owner.
        /// </para>
        ///  
        /// <para>
        /// If one of the following occurs, the workflow status is changed automatically from
        /// <code>NOTIFIED</code> to <code>NEW</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RecordState</code> changes from <code>ARCHIVED</code> to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Compliance.Status</code> changes from <code>PASSED</code> to <code>FAILED</code>,
        /// <code>WARNING</code>, or <code>NOT_AVAILABLE</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>SUPPRESSED</code> - Indicates that you reviewed the finding and do not believe
        /// that any action is needed.
        /// </para>
        ///  
        /// <para>
        /// The workflow status of a <code>SUPPRESSED</code> finding does not change if <code>RecordState</code>
        /// changes from <code>ARCHIVED</code> to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESOLVED</code> - The finding was reviewed and remediated and is now considered
        /// resolved. 
        /// </para>
        ///  
        /// <para>
        /// The finding remains <code>RESOLVED</code> unless one of the following occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RecordState</code> changes from <code>ARCHIVED</code> to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Compliance.Status</code> changes from <code>PASSED</code> to <code>FAILED</code>,
        /// <code>WARNING</code>, or <code>NOT_AVAILABLE</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In those cases, the workflow status is automatically reset to <code>NEW</code>.
        /// </para>
        ///  
        /// <para>
        /// For findings from controls, if <code>Compliance.Status</code> is <code>PASSED</code>,
        /// then Security Hub automatically sets the workflow status to <code>RESOLVED</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<StringFilter> WorkflowStatus
        {
            get { return this._workflowStatus; }
            set { this._workflowStatus = value; }
        }

        // Check to see if WorkflowStatus property is set
        internal bool IsSetWorkflowStatus()
        {
            return this._workflowStatus != null && this._workflowStatus.Count > 0; 
        }

    }
}
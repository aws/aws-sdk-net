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
    /// A collection of filters that are applied to all active findings aggregated by Security
    /// Hub.
    /// 
    ///  
    /// <para>
    /// You can filter by up to ten finding attributes. For each attribute, you can provide
    /// up to 20 filter values.
    /// </para>
    /// </summary>
    public partial class AwsSecurityFindingFilters
    {
        private List<StringFilter> _awsAccountId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _awsAccountName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _companyName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceAssociatedStandardsId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceSecurityControlId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceSecurityControlParametersName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceSecurityControlParametersValue = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _complianceStatus = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _confidence = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<DateFilter> _createdAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<NumberFilter> _criticality = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _description = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _findingProviderFieldsConfidence = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<NumberFilter> _findingProviderFieldsCriticality = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _findingProviderFieldsRelatedFindingsId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _findingProviderFieldsRelatedFindingsProductArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _findingProviderFieldsSeverityLabel = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _findingProviderFieldsSeverityOriginal = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _findingProviderFieldsTypes = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _firstObservedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _generatorId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _id = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<KeywordFilter> _keyword = AWSConfigs.InitializeCollections ? new List<KeywordFilter>() : null;
        private List<DateFilter> _lastObservedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _malwareName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _malwarePath = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _malwareState = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _malwareType = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _networkDestinationDomain = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<IpFilter> _networkDestinationIpV4 = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;
        private List<IpFilter> _networkDestinationIpV6 = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;
        private List<NumberFilter> _networkDestinationPort = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _networkDirection = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _networkProtocol = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _networkSourceDomain = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<IpFilter> _networkSourceIpV4 = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;
        private List<IpFilter> _networkSourceIpV6 = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;
        private List<StringFilter> _networkSourceMac = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _networkSourcePort = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _noteText = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _noteUpdatedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _noteUpdatedBy = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _processLaunchedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _processName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _processParentPid = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _processPath = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _processPid = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<DateFilter> _processTerminatedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _productArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<MapFilter> _productFields = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _productName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _recommendationText = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _recordState = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _region = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _relatedFindingsId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _relatedFindingsProductArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceApplicationArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceApplicationName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsEc2InstanceIamInstanceProfileArn = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsEc2InstanceImageId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<IpFilter> _resourceAwsEc2InstanceIpV4Addresses = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;
        private List<IpFilter> _resourceAwsEc2InstanceIpV6Addresses = AWSConfigs.InitializeCollections ? new List<IpFilter>() : null;
        private List<StringFilter> _resourceAwsEc2InstanceKeyName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _resourceAwsEc2InstanceLaunchedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _resourceAwsEc2InstanceSubnetId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsEc2InstanceType = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsEc2InstanceVpcId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _resourceAwsIamAccessKeyCreatedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _resourceAwsIamAccessKeyPrincipalName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsIamAccessKeyStatus = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsIamAccessKeyUserName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsIamUserUserName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsS3BucketOwnerId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceAwsS3BucketOwnerName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceContainerImageId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceContainerImageName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _resourceContainerLaunchedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _resourceContainerName = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<MapFilter> _resourceDetailsOther = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _resourceId = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourcePartition = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceRegion = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<MapFilter> _resourceTags = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _resourceType = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<BooleanFilter> _sample = AWSConfigs.InitializeCollections ? new List<BooleanFilter>() : null;
        private List<StringFilter> _severityLabel = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _severityNormalized = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<NumberFilter> _severityProduct = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<StringFilter> _sourceUrl = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _threatIntelIndicatorCategory = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _threatIntelIndicatorLastObservedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _threatIntelIndicatorSource = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _threatIntelIndicatorSourceUrl = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _threatIntelIndicatorType = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _threatIntelIndicatorValue = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _title = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _type = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<DateFilter> _updatedAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<MapFilter> _userDefinedFields = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _verificationState = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _vulnerabilitiesExploitAvailable = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _vulnerabilitiesFixAvailable = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _workflowState = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _workflowStatus = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID in which a finding is generated.
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
        /// The name of the Amazon Web Services account in which a finding is generated.
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
        /// The name of the findings provider (company) that owns the solution (product) that
        /// generates findings.
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
        ///  The unique identifier of a standard in which a control is enabled. This field consists
        /// of the resource portion of the Amazon Resource Name (ARN) returned for a standard
        /// in the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_DescribeStandards.html">DescribeStandards</a>
        /// API response. 
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
        ///  The unique identifier of a control across standards. Values for this field typically
        /// consist of an Amazon Web Services service and a number, such as APIGateway.5. 
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
        /// Gets and sets the property ComplianceSecurityControlParametersName. 
        /// <para>
        ///  The name of a security control parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlParametersName
        {
            get { return this._complianceSecurityControlParametersName; }
            set { this._complianceSecurityControlParametersName = value; }
        }

        // Check to see if ComplianceSecurityControlParametersName property is set
        internal bool IsSetComplianceSecurityControlParametersName()
        {
            return this._complianceSecurityControlParametersName != null && (this._complianceSecurityControlParametersName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComplianceSecurityControlParametersValue. 
        /// <para>
        ///  The current value of a security control parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ComplianceSecurityControlParametersValue
        {
            get { return this._complianceSecurityControlParametersValue; }
            set { this._complianceSecurityControlParametersValue = value; }
        }

        // Check to see if ComplianceSecurityControlParametersValue property is set
        internal bool IsSetComplianceSecurityControlParametersValue()
        {
            return this._complianceSecurityControlParametersValue != null && (this._complianceSecurityControlParametersValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Exclusive to findings that are generated as the result of a check run against a specific
        /// rule in a supported standard, such as CIS Amazon Web Services Foundations. Contains
        /// security standard-related finding details.
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
        /// A finding's confidence. Confidence is defined as the likelihood that a finding accurately
        /// identifies the behavior or issue that it was intended to identify.
        /// </para>
        ///  
        /// <para>
        /// Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent
        /// confidence and 100 means 100 percent confidence.
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
        /// A timestamp that indicates when the security findings provider created the potential
        /// security issue that a finding reflects.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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
        /// The level of importance assigned to the resources associated with the finding.
        /// </para>
        ///  
        /// <para>
        /// A score of 0 means that the underlying resources have no criticality, and a score
        /// of 100 is reserved for the most critical resources.
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
        /// A finding's description.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> FindingProviderFieldsConfidence
        {
            get { return this._findingProviderFieldsConfidence; }
            set { this._findingProviderFieldsConfidence = value; }
        }

        // Check to see if FindingProviderFieldsConfidence property is set
        internal bool IsSetFindingProviderFieldsConfidence()
        {
            return this._findingProviderFieldsConfidence != null && (this._findingProviderFieldsConfidence.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> FindingProviderFieldsCriticality
        {
            get { return this._findingProviderFieldsCriticality; }
            set { this._findingProviderFieldsCriticality = value; }
        }

        // Check to see if FindingProviderFieldsCriticality property is set
        internal bool IsSetFindingProviderFieldsCriticality()
        {
            return this._findingProviderFieldsCriticality != null && (this._findingProviderFieldsCriticality.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsRelatedFindingsId. 
        /// <para>
        /// The finding identifier of a related finding that is identified by the finding provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsRelatedFindingsId
        {
            get { return this._findingProviderFieldsRelatedFindingsId; }
            set { this._findingProviderFieldsRelatedFindingsId = value; }
        }

        // Check to see if FindingProviderFieldsRelatedFindingsId property is set
        internal bool IsSetFindingProviderFieldsRelatedFindingsId()
        {
            return this._findingProviderFieldsRelatedFindingsId != null && (this._findingProviderFieldsRelatedFindingsId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsRelatedFindingsProductArn. 
        /// <para>
        /// The ARN of the solution that generated a related finding that is identified by the
        /// finding provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsRelatedFindingsProductArn
        {
            get { return this._findingProviderFieldsRelatedFindingsProductArn; }
            set { this._findingProviderFieldsRelatedFindingsProductArn = value; }
        }

        // Check to see if FindingProviderFieldsRelatedFindingsProductArn property is set
        internal bool IsSetFindingProviderFieldsRelatedFindingsProductArn()
        {
            return this._findingProviderFieldsRelatedFindingsProductArn != null && (this._findingProviderFieldsRelatedFindingsProductArn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsSeverityLabel. 
        /// <para>
        /// The finding provider value for the severity label.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsSeverityLabel
        {
            get { return this._findingProviderFieldsSeverityLabel; }
            set { this._findingProviderFieldsSeverityLabel = value; }
        }

        // Check to see if FindingProviderFieldsSeverityLabel property is set
        internal bool IsSetFindingProviderFieldsSeverityLabel()
        {
            return this._findingProviderFieldsSeverityLabel != null && (this._findingProviderFieldsSeverityLabel.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingProviderFieldsSeverityOriginal. 
        /// <para>
        /// The finding provider's original value for the severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsSeverityOriginal
        {
            get { return this._findingProviderFieldsSeverityOriginal; }
            set { this._findingProviderFieldsSeverityOriginal = value; }
        }

        // Check to see if FindingProviderFieldsSeverityOriginal property is set
        internal bool IsSetFindingProviderFieldsSeverityOriginal()
        {
            return this._findingProviderFieldsSeverityOriginal != null && (this._findingProviderFieldsSeverityOriginal.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> FindingProviderFieldsTypes
        {
            get { return this._findingProviderFieldsTypes; }
            set { this._findingProviderFieldsTypes = value; }
        }

        // Check to see if FindingProviderFieldsTypes property is set
        internal bool IsSetFindingProviderFieldsTypes()
        {
            return this._findingProviderFieldsTypes != null && (this._findingProviderFieldsTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// A timestamp that indicates when the security findings provider first observed the
        /// potential security issue that a finding captured.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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
        /// The identifier for the solution-specific component (a discrete unit of logic) that
        /// generated a finding. In various security findings providers' solutions, this generator
        /// can be called a rule, a check, a detector, a plugin, etc.
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
        /// The security findings provider-specific identifier for a finding.
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
        /// Gets and sets the property Keyword. 
        /// <para>
        /// A keyword for a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._keyword != null && (this._keyword.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// A timestamp that indicates when the security findings provider most recently observed
        /// a change in the resource that is involved in the finding.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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
        /// Gets and sets the property MalwareName. 
        /// <para>
        /// The name of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwareName
        {
            get { return this._malwareName; }
            set { this._malwareName = value; }
        }

        // Check to see if MalwareName property is set
        internal bool IsSetMalwareName()
        {
            return this._malwareName != null && (this._malwareName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MalwarePath. 
        /// <para>
        /// The filesystem path of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwarePath
        {
            get { return this._malwarePath; }
            set { this._malwarePath = value; }
        }

        // Check to see if MalwarePath property is set
        internal bool IsSetMalwarePath()
        {
            return this._malwarePath != null && (this._malwarePath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MalwareState. 
        /// <para>
        /// The state of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwareState
        {
            get { return this._malwareState; }
            set { this._malwareState = value; }
        }

        // Check to see if MalwareState property is set
        internal bool IsSetMalwareState()
        {
            return this._malwareState != null && (this._malwareState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MalwareType. 
        /// <para>
        /// The type of the malware that was observed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> MalwareType
        {
            get { return this._malwareType; }
            set { this._malwareType = value; }
        }

        // Check to see if MalwareType property is set
        internal bool IsSetMalwareType()
        {
            return this._malwareType != null && (this._malwareType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationDomain. 
        /// <para>
        /// The destination domain of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkDestinationDomain
        {
            get { return this._networkDestinationDomain; }
            set { this._networkDestinationDomain = value; }
        }

        // Check to see if NetworkDestinationDomain property is set
        internal bool IsSetNetworkDestinationDomain()
        {
            return this._networkDestinationDomain != null && (this._networkDestinationDomain.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationIpV4. 
        /// <para>
        /// The destination IPv4 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkDestinationIpV4
        {
            get { return this._networkDestinationIpV4; }
            set { this._networkDestinationIpV4 = value; }
        }

        // Check to see if NetworkDestinationIpV4 property is set
        internal bool IsSetNetworkDestinationIpV4()
        {
            return this._networkDestinationIpV4 != null && (this._networkDestinationIpV4.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationIpV6. 
        /// <para>
        /// The destination IPv6 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkDestinationIpV6
        {
            get { return this._networkDestinationIpV6; }
            set { this._networkDestinationIpV6 = value; }
        }

        // Check to see if NetworkDestinationIpV6 property is set
        internal bool IsSetNetworkDestinationIpV6()
        {
            return this._networkDestinationIpV6 != null && (this._networkDestinationIpV6.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkDestinationPort. 
        /// <para>
        /// The destination port of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> NetworkDestinationPort
        {
            get { return this._networkDestinationPort; }
            set { this._networkDestinationPort = value; }
        }

        // Check to see if NetworkDestinationPort property is set
        internal bool IsSetNetworkDestinationPort()
        {
            return this._networkDestinationPort != null && (this._networkDestinationPort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkDirection. 
        /// <para>
        /// Indicates the direction of network traffic associated with a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkDirection
        {
            get { return this._networkDirection; }
            set { this._networkDirection = value; }
        }

        // Check to see if NetworkDirection property is set
        internal bool IsSetNetworkDirection()
        {
            return this._networkDirection != null && (this._networkDirection.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkProtocol. 
        /// <para>
        /// The protocol of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkProtocol
        {
            get { return this._networkProtocol; }
            set { this._networkProtocol = value; }
        }

        // Check to see if NetworkProtocol property is set
        internal bool IsSetNetworkProtocol()
        {
            return this._networkProtocol != null && (this._networkProtocol.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceDomain. 
        /// <para>
        /// The source domain of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkSourceDomain
        {
            get { return this._networkSourceDomain; }
            set { this._networkSourceDomain = value; }
        }

        // Check to see if NetworkSourceDomain property is set
        internal bool IsSetNetworkSourceDomain()
        {
            return this._networkSourceDomain != null && (this._networkSourceDomain.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceIpV4. 
        /// <para>
        /// The source IPv4 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkSourceIpV4
        {
            get { return this._networkSourceIpV4; }
            set { this._networkSourceIpV4 = value; }
        }

        // Check to see if NetworkSourceIpV4 property is set
        internal bool IsSetNetworkSourceIpV4()
        {
            return this._networkSourceIpV4 != null && (this._networkSourceIpV4.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceIpV6. 
        /// <para>
        /// The source IPv6 address of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> NetworkSourceIpV6
        {
            get { return this._networkSourceIpV6; }
            set { this._networkSourceIpV6 = value; }
        }

        // Check to see if NetworkSourceIpV6 property is set
        internal bool IsSetNetworkSourceIpV6()
        {
            return this._networkSourceIpV6 != null && (this._networkSourceIpV6.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourceMac. 
        /// <para>
        /// The source media access control (MAC) address of network-related information about
        /// a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> NetworkSourceMac
        {
            get { return this._networkSourceMac; }
            set { this._networkSourceMac = value; }
        }

        // Check to see if NetworkSourceMac property is set
        internal bool IsSetNetworkSourceMac()
        {
            return this._networkSourceMac != null && (this._networkSourceMac.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkSourcePort. 
        /// <para>
        /// The source port of network-related information about a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> NetworkSourcePort
        {
            get { return this._networkSourcePort; }
            set { this._networkSourcePort = value; }
        }

        // Check to see if NetworkSourcePort property is set
        internal bool IsSetNetworkSourcePort()
        {
            return this._networkSourcePort != null && (this._networkSourcePort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NoteText. 
        /// <para>
        /// The text of a note.
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
        /// The timestamp of when the note was updated.
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
        /// The principal that created a note.
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
        /// Gets and sets the property ProcessLaunchedAt. 
        /// <para>
        /// A timestamp that identifies when the process was launched.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ProcessLaunchedAt
        {
            get { return this._processLaunchedAt; }
            set { this._processLaunchedAt = value; }
        }

        // Check to see if ProcessLaunchedAt property is set
        internal bool IsSetProcessLaunchedAt()
        {
            return this._processLaunchedAt != null && (this._processLaunchedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessName. 
        /// <para>
        /// The name of the process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProcessName
        {
            get { return this._processName; }
            set { this._processName = value; }
        }

        // Check to see if ProcessName property is set
        internal bool IsSetProcessName()
        {
            return this._processName != null && (this._processName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessParentPid. 
        /// <para>
        /// The parent process ID. This field accepts positive integers between <c>O</c> and <c>2147483647</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> ProcessParentPid
        {
            get { return this._processParentPid; }
            set { this._processParentPid = value; }
        }

        // Check to see if ProcessParentPid property is set
        internal bool IsSetProcessParentPid()
        {
            return this._processParentPid != null && (this._processParentPid.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessPath. 
        /// <para>
        /// The path to the process executable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ProcessPath
        {
            get { return this._processPath; }
            set { this._processPath = value; }
        }

        // Check to see if ProcessPath property is set
        internal bool IsSetProcessPath()
        {
            return this._processPath != null && (this._processPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessPid. 
        /// <para>
        /// The process ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumberFilter> ProcessPid
        {
            get { return this._processPid; }
            set { this._processPid = value; }
        }

        // Check to see if ProcessPid property is set
        internal bool IsSetProcessPid()
        {
            return this._processPid != null && (this._processPid.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessTerminatedAt. 
        /// <para>
        /// A timestamp that identifies when the process was terminated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ProcessTerminatedAt
        {
            get { return this._processTerminatedAt; }
            set { this._processTerminatedAt = value; }
        }

        // Check to see if ProcessTerminatedAt property is set
        internal bool IsSetProcessTerminatedAt()
        {
            return this._processTerminatedAt != null && (this._processTerminatedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN generated by Security Hub that uniquely identifies a third-party company (security
        /// findings provider) after this provider's product (solution that generates findings)
        /// is registered with Security Hub.
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
        /// Gets and sets the property ProductFields. 
        /// <para>
        /// A data type where security findings providers can include additional solution-specific
        /// details that aren't part of the defined <c>AwsSecurityFinding</c> format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MapFilter> ProductFields
        {
            get { return this._productFields; }
            set { this._productFields = value; }
        }

        // Check to see if ProductFields property is set
        internal bool IsSetProductFields()
        {
            return this._productFields != null && (this._productFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the solution (product) that generates findings.
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
        /// Gets and sets the property RecommendationText. 
        /// <para>
        /// The recommendation of what to do about the issue described in a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> RecommendationText
        {
            get { return this._recommendationText; }
            set { this._recommendationText = value; }
        }

        // Check to see if RecommendationText property is set
        internal bool IsSetRecommendationText()
        {
            return this._recommendationText != null && (this._recommendationText.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The updated record state for the finding.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region from which the finding was generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null && (this._region.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelatedFindingsId. 
        /// <para>
        /// The solution-generated identifier for a related finding.
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
        /// The ARN of the solution that generated a related finding.
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
        ///  The ARN of the application that is related to a finding. 
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
        /// Gets and sets the property ResourceAwsEc2InstanceIamInstanceProfileArn. 
        /// <para>
        /// The IAM profile ARN of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceIamInstanceProfileArn
        {
            get { return this._resourceAwsEc2InstanceIamInstanceProfileArn; }
            set { this._resourceAwsEc2InstanceIamInstanceProfileArn = value; }
        }

        // Check to see if ResourceAwsEc2InstanceIamInstanceProfileArn property is set
        internal bool IsSetResourceAwsEc2InstanceIamInstanceProfileArn()
        {
            return this._resourceAwsEc2InstanceIamInstanceProfileArn != null && (this._resourceAwsEc2InstanceIamInstanceProfileArn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceImageId
        {
            get { return this._resourceAwsEc2InstanceImageId; }
            set { this._resourceAwsEc2InstanceImageId = value; }
        }

        // Check to see if ResourceAwsEc2InstanceImageId property is set
        internal bool IsSetResourceAwsEc2InstanceImageId()
        {
            return this._resourceAwsEc2InstanceImageId != null && (this._resourceAwsEc2InstanceImageId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIpV4Addresses. 
        /// <para>
        /// The IPv4 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> ResourceAwsEc2InstanceIpV4Addresses
        {
            get { return this._resourceAwsEc2InstanceIpV4Addresses; }
            set { this._resourceAwsEc2InstanceIpV4Addresses = value; }
        }

        // Check to see if ResourceAwsEc2InstanceIpV4Addresses property is set
        internal bool IsSetResourceAwsEc2InstanceIpV4Addresses()
        {
            return this._resourceAwsEc2InstanceIpV4Addresses != null && (this._resourceAwsEc2InstanceIpV4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceIpV6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpFilter> ResourceAwsEc2InstanceIpV6Addresses
        {
            get { return this._resourceAwsEc2InstanceIpV6Addresses; }
            set { this._resourceAwsEc2InstanceIpV6Addresses = value; }
        }

        // Check to see if ResourceAwsEc2InstanceIpV6Addresses property is set
        internal bool IsSetResourceAwsEc2InstanceIpV6Addresses()
        {
            return this._resourceAwsEc2InstanceIpV6Addresses != null && (this._resourceAwsEc2InstanceIpV6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceKeyName. 
        /// <para>
        /// The key name associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceKeyName
        {
            get { return this._resourceAwsEc2InstanceKeyName; }
            set { this._resourceAwsEc2InstanceKeyName = value; }
        }

        // Check to see if ResourceAwsEc2InstanceKeyName property is set
        internal bool IsSetResourceAwsEc2InstanceKeyName()
        {
            return this._resourceAwsEc2InstanceKeyName != null && (this._resourceAwsEc2InstanceKeyName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceLaunchedAt. 
        /// <para>
        /// The date and time the instance was launched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ResourceAwsEc2InstanceLaunchedAt
        {
            get { return this._resourceAwsEc2InstanceLaunchedAt; }
            set { this._resourceAwsEc2InstanceLaunchedAt = value; }
        }

        // Check to see if ResourceAwsEc2InstanceLaunchedAt property is set
        internal bool IsSetResourceAwsEc2InstanceLaunchedAt()
        {
            return this._resourceAwsEc2InstanceLaunchedAt != null && (this._resourceAwsEc2InstanceLaunchedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceSubnetId. 
        /// <para>
        /// The identifier of the subnet that the instance was launched in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceSubnetId
        {
            get { return this._resourceAwsEc2InstanceSubnetId; }
            set { this._resourceAwsEc2InstanceSubnetId = value; }
        }

        // Check to see if ResourceAwsEc2InstanceSubnetId property is set
        internal bool IsSetResourceAwsEc2InstanceSubnetId()
        {
            return this._resourceAwsEc2InstanceSubnetId != null && (this._resourceAwsEc2InstanceSubnetId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceType. 
        /// <para>
        /// The instance type of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceType
        {
            get { return this._resourceAwsEc2InstanceType; }
            set { this._resourceAwsEc2InstanceType = value; }
        }

        // Check to see if ResourceAwsEc2InstanceType property is set
        internal bool IsSetResourceAwsEc2InstanceType()
        {
            return this._resourceAwsEc2InstanceType != null && (this._resourceAwsEc2InstanceType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsEc2InstanceVpcId. 
        /// <para>
        /// The identifier of the VPC that the instance was launched in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsEc2InstanceVpcId
        {
            get { return this._resourceAwsEc2InstanceVpcId; }
            set { this._resourceAwsEc2InstanceVpcId = value; }
        }

        // Check to see if ResourceAwsEc2InstanceVpcId property is set
        internal bool IsSetResourceAwsEc2InstanceVpcId()
        {
            return this._resourceAwsEc2InstanceVpcId != null && (this._resourceAwsEc2InstanceVpcId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyCreatedAt. 
        /// <para>
        /// The creation date/time of the IAM access key related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ResourceAwsIamAccessKeyCreatedAt
        {
            get { return this._resourceAwsIamAccessKeyCreatedAt; }
            set { this._resourceAwsIamAccessKeyCreatedAt = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyCreatedAt property is set
        internal bool IsSetResourceAwsIamAccessKeyCreatedAt()
        {
            return this._resourceAwsIamAccessKeyCreatedAt != null && (this._resourceAwsIamAccessKeyCreatedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyPrincipalName. 
        /// <para>
        /// The name of the principal that is associated with an IAM access key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsIamAccessKeyPrincipalName
        {
            get { return this._resourceAwsIamAccessKeyPrincipalName; }
            set { this._resourceAwsIamAccessKeyPrincipalName = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyPrincipalName property is set
        internal bool IsSetResourceAwsIamAccessKeyPrincipalName()
        {
            return this._resourceAwsIamAccessKeyPrincipalName != null && (this._resourceAwsIamAccessKeyPrincipalName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyStatus. 
        /// <para>
        /// The status of the IAM access key related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsIamAccessKeyStatus
        {
            get { return this._resourceAwsIamAccessKeyStatus; }
            set { this._resourceAwsIamAccessKeyStatus = value; }
        }

        // Check to see if ResourceAwsIamAccessKeyStatus property is set
        internal bool IsSetResourceAwsIamAccessKeyStatus()
        {
            return this._resourceAwsIamAccessKeyStatus != null && (this._resourceAwsIamAccessKeyStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamAccessKeyUserName. 
        /// <para>
        /// The user associated with the IAM access key related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._resourceAwsIamAccessKeyUserName != null && (this._resourceAwsIamAccessKeyUserName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsIamUserUserName. 
        /// <para>
        /// The name of an IAM user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsIamUserUserName
        {
            get { return this._resourceAwsIamUserUserName; }
            set { this._resourceAwsIamUserUserName = value; }
        }

        // Check to see if ResourceAwsIamUserUserName property is set
        internal bool IsSetResourceAwsIamUserUserName()
        {
            return this._resourceAwsIamUserUserName != null && (this._resourceAwsIamUserUserName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsS3BucketOwnerId. 
        /// <para>
        /// The canonical user ID of the owner of the S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsS3BucketOwnerId
        {
            get { return this._resourceAwsS3BucketOwnerId; }
            set { this._resourceAwsS3BucketOwnerId = value; }
        }

        // Check to see if ResourceAwsS3BucketOwnerId property is set
        internal bool IsSetResourceAwsS3BucketOwnerId()
        {
            return this._resourceAwsS3BucketOwnerId != null && (this._resourceAwsS3BucketOwnerId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceAwsS3BucketOwnerName. 
        /// <para>
        /// The display name of the owner of the S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceAwsS3BucketOwnerName
        {
            get { return this._resourceAwsS3BucketOwnerName; }
            set { this._resourceAwsS3BucketOwnerName = value; }
        }

        // Check to see if ResourceAwsS3BucketOwnerName property is set
        internal bool IsSetResourceAwsS3BucketOwnerName()
        {
            return this._resourceAwsS3BucketOwnerName != null && (this._resourceAwsS3BucketOwnerName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerImageId. 
        /// <para>
        /// The identifier of the image related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceContainerImageId
        {
            get { return this._resourceContainerImageId; }
            set { this._resourceContainerImageId = value; }
        }

        // Check to see if ResourceContainerImageId property is set
        internal bool IsSetResourceContainerImageId()
        {
            return this._resourceContainerImageId != null && (this._resourceContainerImageId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerImageName. 
        /// <para>
        /// The name of the image related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceContainerImageName
        {
            get { return this._resourceContainerImageName; }
            set { this._resourceContainerImageName = value; }
        }

        // Check to see if ResourceContainerImageName property is set
        internal bool IsSetResourceContainerImageName()
        {
            return this._resourceContainerImageName != null && (this._resourceContainerImageName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerLaunchedAt. 
        /// <para>
        /// A timestamp that identifies when the container was started.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ResourceContainerLaunchedAt
        {
            get { return this._resourceContainerLaunchedAt; }
            set { this._resourceContainerLaunchedAt = value; }
        }

        // Check to see if ResourceContainerLaunchedAt property is set
        internal bool IsSetResourceContainerLaunchedAt()
        {
            return this._resourceContainerLaunchedAt != null && (this._resourceContainerLaunchedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceContainerName. 
        /// <para>
        /// The name of the container related to a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ResourceContainerName
        {
            get { return this._resourceContainerName; }
            set { this._resourceContainerName = value; }
        }

        // Check to see if ResourceContainerName property is set
        internal bool IsSetResourceContainerName()
        {
            return this._resourceContainerName != null && (this._resourceContainerName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceDetailsOther. 
        /// <para>
        /// The details of a resource that doesn't have a specific subfield for the resource type
        /// defined.
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
        /// The canonical identifier for the given resource type.
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
        /// The canonical Amazon Web Services partition name that the Region is assigned to.
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
        /// The canonical Amazon Web Services external Region name where this resource is located.
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
        /// A list of Amazon Web Services tags associated with a resource at the time the finding
        /// was processed.
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
        /// Specifies the type of the resource that details are provided for.
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
        /// Gets and sets the property Sample. 
        /// <para>
        /// Indicates whether or not sample findings are included in the filter results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BooleanFilter> Sample
        {
            get { return this._sample; }
            set { this._sample = value; }
        }

        // Check to see if Sample property is set
        internal bool IsSetSample()
        {
            return this._sample != null && (this._sample.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SeverityLabel. 
        /// <para>
        /// The label of a finding's severity.
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
        /// Gets and sets the property SeverityNormalized. 
        /// <para>
        /// The normalized severity of a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._severityNormalized != null && (this._severityNormalized.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SeverityProduct. 
        /// <para>
        /// The native severity as defined by the security findings provider's solution that generated
        /// the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._severityProduct != null && (this._severityProduct.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// A URL that links to a page about the current finding in the security findings provider's
        /// solution.
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
        /// Gets and sets the property ThreatIntelIndicatorCategory. 
        /// <para>
        /// The category of a threat intelligence indicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorCategory
        {
            get { return this._threatIntelIndicatorCategory; }
            set { this._threatIntelIndicatorCategory = value; }
        }

        // Check to see if ThreatIntelIndicatorCategory property is set
        internal bool IsSetThreatIntelIndicatorCategory()
        {
            return this._threatIntelIndicatorCategory != null && (this._threatIntelIndicatorCategory.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorLastObservedAt. 
        /// <para>
        /// A timestamp that identifies the last observation of a threat intelligence indicator.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateFilter> ThreatIntelIndicatorLastObservedAt
        {
            get { return this._threatIntelIndicatorLastObservedAt; }
            set { this._threatIntelIndicatorLastObservedAt = value; }
        }

        // Check to see if ThreatIntelIndicatorLastObservedAt property is set
        internal bool IsSetThreatIntelIndicatorLastObservedAt()
        {
            return this._threatIntelIndicatorLastObservedAt != null && (this._threatIntelIndicatorLastObservedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorSource. 
        /// <para>
        /// The source of the threat intelligence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorSource
        {
            get { return this._threatIntelIndicatorSource; }
            set { this._threatIntelIndicatorSource = value; }
        }

        // Check to see if ThreatIntelIndicatorSource property is set
        internal bool IsSetThreatIntelIndicatorSource()
        {
            return this._threatIntelIndicatorSource != null && (this._threatIntelIndicatorSource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorSourceUrl. 
        /// <para>
        /// The URL for more details from the source of the threat intelligence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorSourceUrl
        {
            get { return this._threatIntelIndicatorSourceUrl; }
            set { this._threatIntelIndicatorSourceUrl = value; }
        }

        // Check to see if ThreatIntelIndicatorSourceUrl property is set
        internal bool IsSetThreatIntelIndicatorSourceUrl()
        {
            return this._threatIntelIndicatorSourceUrl != null && (this._threatIntelIndicatorSourceUrl.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorType. 
        /// <para>
        /// The type of a threat intelligence indicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorType
        {
            get { return this._threatIntelIndicatorType; }
            set { this._threatIntelIndicatorType = value; }
        }

        // Check to see if ThreatIntelIndicatorType property is set
        internal bool IsSetThreatIntelIndicatorType()
        {
            return this._threatIntelIndicatorType != null && (this._threatIntelIndicatorType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatIntelIndicatorValue. 
        /// <para>
        /// The value of a threat intelligence indicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> ThreatIntelIndicatorValue
        {
            get { return this._threatIntelIndicatorValue; }
            set { this._threatIntelIndicatorValue = value; }
        }

        // Check to see if ThreatIntelIndicatorValue property is set
        internal bool IsSetThreatIntelIndicatorValue()
        {
            return this._threatIntelIndicatorValue != null && (this._threatIntelIndicatorValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A finding's title.
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
        /// A finding type in the format of <c>namespace/category/classifier</c> that classifies
        /// a finding.
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
        /// A timestamp that indicates when the security findings provider last updated the finding
        /// record.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding. 
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
        /// The veracity of a finding.
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
        /// Gets and sets the property VulnerabilitiesExploitAvailable. 
        /// <para>
        ///  Indicates whether a software vulnerability in your environment has a known exploit.
        /// You can filter findings by this field only if you use Security Hub and Amazon Inspector.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> VulnerabilitiesExploitAvailable
        {
            get { return this._vulnerabilitiesExploitAvailable; }
            set { this._vulnerabilitiesExploitAvailable = value; }
        }

        // Check to see if VulnerabilitiesExploitAvailable property is set
        internal bool IsSetVulnerabilitiesExploitAvailable()
        {
            return this._vulnerabilitiesExploitAvailable != null && (this._vulnerabilitiesExploitAvailable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VulnerabilitiesFixAvailable. 
        /// <para>
        ///  Indicates whether a vulnerability is fixed in a newer version of the affected software
        /// packages. You can filter findings by this field only if you use Security Hub and Amazon
        /// Inspector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> VulnerabilitiesFixAvailable
        {
            get { return this._vulnerabilitiesFixAvailable; }
            set { this._vulnerabilitiesFixAvailable = value; }
        }

        // Check to see if VulnerabilitiesFixAvailable property is set
        internal bool IsSetVulnerabilitiesFixAvailable()
        {
            return this._vulnerabilitiesFixAvailable != null && (this._vulnerabilitiesFixAvailable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringFilter> WorkflowState
        {
            get { return this._workflowState; }
            set { this._workflowState = value; }
        }

        // Check to see if WorkflowState property is set
        internal bool IsSetWorkflowState()
        {
            return this._workflowState != null && (this._workflowState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Security Hub also resets the workflow status from <c>NOTIFIED</c> or <c>RESOLVED</c>
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
        /// Hub automatically sets the workflow status to <c>RESOLVED</c>.
        /// </para>
        ///  </li> </ul>
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
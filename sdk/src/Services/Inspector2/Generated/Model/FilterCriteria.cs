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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details on the criteria used to define the filter.
    /// </summary>
    public partial class FilterCriteria
    {
        private List<StringFilter> _awsAccountId = new List<StringFilter>();
        private List<StringFilter> _componentId = new List<StringFilter>();
        private List<StringFilter> _componentType = new List<StringFilter>();
        private List<StringFilter> _ec2InstanceImageId = new List<StringFilter>();
        private List<StringFilter> _ec2InstanceSubnetId = new List<StringFilter>();
        private List<StringFilter> _ec2InstanceVpcId = new List<StringFilter>();
        private List<StringFilter> _ecrImageArchitecture = new List<StringFilter>();
        private List<StringFilter> _ecrImageHash = new List<StringFilter>();
        private List<DateFilter> _ecrImagePushedAt = new List<DateFilter>();
        private List<StringFilter> _ecrImageRegistry = new List<StringFilter>();
        private List<StringFilter> _ecrImageRepositoryName = new List<StringFilter>();
        private List<StringFilter> _ecrImageTags = new List<StringFilter>();
        private List<StringFilter> _exploitAvailable = new List<StringFilter>();
        private List<StringFilter> _findingArn = new List<StringFilter>();
        private List<StringFilter> _findingStatus = new List<StringFilter>();
        private List<StringFilter> _findingType = new List<StringFilter>();
        private List<DateFilter> _firstObservedAt = new List<DateFilter>();
        private List<StringFilter> _fixAvailable = new List<StringFilter>();
        private List<NumberFilter> _inspectorScore = new List<NumberFilter>();
        private List<StringFilter> _lambdaFunctionExecutionRoleArn = new List<StringFilter>();
        private List<DateFilter> _lambdaFunctionLastModifiedAt = new List<DateFilter>();
        private List<StringFilter> _lambdaFunctionLayers = new List<StringFilter>();
        private List<StringFilter> _lambdaFunctionName = new List<StringFilter>();
        private List<StringFilter> _lambdaFunctionRuntime = new List<StringFilter>();
        private List<DateFilter> _lastObservedAt = new List<DateFilter>();
        private List<StringFilter> _networkProtocol = new List<StringFilter>();
        private List<PortRangeFilter> _portRange = new List<PortRangeFilter>();
        private List<StringFilter> _relatedVulnerabilities = new List<StringFilter>();
        private List<StringFilter> _resourceId = new List<StringFilter>();
        private List<MapFilter> _resourceTags = new List<MapFilter>();
        private List<StringFilter> _resourceType = new List<StringFilter>();
        private List<StringFilter> _severity = new List<StringFilter>();
        private List<StringFilter> _title = new List<StringFilter>();
        private List<DateFilter> _updatedAt = new List<DateFilter>();
        private List<StringFilter> _vendorSeverity = new List<StringFilter>();
        private List<StringFilter> _vulnerabilityId = new List<StringFilter>();
        private List<StringFilter> _vulnerabilitySource = new List<StringFilter>();
        private List<PackageFilter> _vulnerablePackages = new List<PackageFilter>();

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Details of the Amazon Web Services account IDs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// Details of the component IDs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null && this._componentId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// Details of the component types used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ComponentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        // Check to see if ComponentType property is set
        internal bool IsSetComponentType()
        {
            return this._componentType != null && this._componentType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceImageId. 
        /// <para>
        /// Details of the Amazon EC2 instance image IDs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Ec2InstanceImageId
        {
            get { return this._ec2InstanceImageId; }
            set { this._ec2InstanceImageId = value; }
        }

        // Check to see if Ec2InstanceImageId property is set
        internal bool IsSetEc2InstanceImageId()
        {
            return this._ec2InstanceImageId != null && this._ec2InstanceImageId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceSubnetId. 
        /// <para>
        /// Details of the Amazon EC2 instance subnet IDs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Ec2InstanceSubnetId
        {
            get { return this._ec2InstanceSubnetId; }
            set { this._ec2InstanceSubnetId = value; }
        }

        // Check to see if Ec2InstanceSubnetId property is set
        internal bool IsSetEc2InstanceSubnetId()
        {
            return this._ec2InstanceSubnetId != null && this._ec2InstanceSubnetId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceVpcId. 
        /// <para>
        /// Details of the Amazon EC2 instance VPC IDs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Ec2InstanceVpcId
        {
            get { return this._ec2InstanceVpcId; }
            set { this._ec2InstanceVpcId = value; }
        }

        // Check to see if Ec2InstanceVpcId property is set
        internal bool IsSetEc2InstanceVpcId()
        {
            return this._ec2InstanceVpcId != null && this._ec2InstanceVpcId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EcrImageArchitecture. 
        /// <para>
        /// Details of the Amazon ECR image architecture types used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> EcrImageArchitecture
        {
            get { return this._ecrImageArchitecture; }
            set { this._ecrImageArchitecture = value; }
        }

        // Check to see if EcrImageArchitecture property is set
        internal bool IsSetEcrImageArchitecture()
        {
            return this._ecrImageArchitecture != null && this._ecrImageArchitecture.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EcrImageHash. 
        /// <para>
        /// Details of the Amazon ECR image hashes used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> EcrImageHash
        {
            get { return this._ecrImageHash; }
            set { this._ecrImageHash = value; }
        }

        // Check to see if EcrImageHash property is set
        internal bool IsSetEcrImageHash()
        {
            return this._ecrImageHash != null && this._ecrImageHash.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EcrImagePushedAt. 
        /// <para>
        /// Details on the Amazon ECR image push date and time used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<DateFilter> EcrImagePushedAt
        {
            get { return this._ecrImagePushedAt; }
            set { this._ecrImagePushedAt = value; }
        }

        // Check to see if EcrImagePushedAt property is set
        internal bool IsSetEcrImagePushedAt()
        {
            return this._ecrImagePushedAt != null && this._ecrImagePushedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EcrImageRegistry. 
        /// <para>
        /// Details on the Amazon ECR registry used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> EcrImageRegistry
        {
            get { return this._ecrImageRegistry; }
            set { this._ecrImageRegistry = value; }
        }

        // Check to see if EcrImageRegistry property is set
        internal bool IsSetEcrImageRegistry()
        {
            return this._ecrImageRegistry != null && this._ecrImageRegistry.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EcrImageRepositoryName. 
        /// <para>
        /// Details on the name of the Amazon ECR repository used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> EcrImageRepositoryName
        {
            get { return this._ecrImageRepositoryName; }
            set { this._ecrImageRepositoryName = value; }
        }

        // Check to see if EcrImageRepositoryName property is set
        internal bool IsSetEcrImageRepositoryName()
        {
            return this._ecrImageRepositoryName != null && this._ecrImageRepositoryName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EcrImageTags. 
        /// <para>
        /// The tags attached to the Amazon ECR container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> EcrImageTags
        {
            get { return this._ecrImageTags; }
            set { this._ecrImageTags = value; }
        }

        // Check to see if EcrImageTags property is set
        internal bool IsSetEcrImageTags()
        {
            return this._ecrImageTags != null && this._ecrImageTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExploitAvailable. 
        /// <para>
        /// Filters the list of AWS Lambda findings by the availability of exploits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ExploitAvailable
        {
            get { return this._exploitAvailable; }
            set { this._exploitAvailable = value; }
        }

        // Check to see if ExploitAvailable property is set
        internal bool IsSetExploitAvailable()
        {
            return this._exploitAvailable != null && this._exploitAvailable.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// Details on the finding ARNs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> FindingArn
        {
            get { return this._findingArn; }
            set { this._findingArn = value; }
        }

        // Check to see if FindingArn property is set
        internal bool IsSetFindingArn()
        {
            return this._findingArn != null && this._findingArn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingStatus. 
        /// <para>
        /// Details on the finding status types used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> FindingStatus
        {
            get { return this._findingStatus; }
            set { this._findingStatus = value; }
        }

        // Check to see if FindingStatus property is set
        internal bool IsSetFindingStatus()
        {
            return this._findingStatus != null && this._findingStatus.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// Details on the finding types used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> FindingType
        {
            get { return this._findingType; }
            set { this._findingType = value; }
        }

        // Check to see if FindingType property is set
        internal bool IsSetFindingType()
        {
            return this._findingType != null && this._findingType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// Details on the date and time a finding was first seen used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property FixAvailable. 
        /// <para>
        /// Details on whether a fix is available through a version update. This value can be
        /// <code>YES</code>, <code>NO</code>, or <code>PARTIAL</code>. A <code>PARTIAL</code>
        /// fix means that some, but not all, of the packages identified in the finding have fixes
        /// available through updated versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> FixAvailable
        {
            get { return this._fixAvailable; }
            set { this._fixAvailable = value; }
        }

        // Check to see if FixAvailable property is set
        internal bool IsSetFixAvailable()
        {
            return this._fixAvailable != null && this._fixAvailable.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InspectorScore. 
        /// <para>
        /// The Amazon Inspector score to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<NumberFilter> InspectorScore
        {
            get { return this._inspectorScore; }
            set { this._inspectorScore = value; }
        }

        // Check to see if InspectorScore property is set
        internal bool IsSetInspectorScore()
        {
            return this._inspectorScore != null && this._inspectorScore.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionExecutionRoleArn. 
        /// <para>
        /// Filters the list of AWS Lambda functions by execution role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> LambdaFunctionExecutionRoleArn
        {
            get { return this._lambdaFunctionExecutionRoleArn; }
            set { this._lambdaFunctionExecutionRoleArn = value; }
        }

        // Check to see if LambdaFunctionExecutionRoleArn property is set
        internal bool IsSetLambdaFunctionExecutionRoleArn()
        {
            return this._lambdaFunctionExecutionRoleArn != null && this._lambdaFunctionExecutionRoleArn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionLastModifiedAt. 
        /// <para>
        /// Filters the list of AWS Lambda functions by the date and time that a user last updated
        /// the configuration, in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601 format</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<DateFilter> LambdaFunctionLastModifiedAt
        {
            get { return this._lambdaFunctionLastModifiedAt; }
            set { this._lambdaFunctionLastModifiedAt = value; }
        }

        // Check to see if LambdaFunctionLastModifiedAt property is set
        internal bool IsSetLambdaFunctionLastModifiedAt()
        {
            return this._lambdaFunctionLastModifiedAt != null && this._lambdaFunctionLastModifiedAt.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionLayers. 
        /// <para>
        /// Filters the list of AWS Lambda functions by the function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">
        /// layers</a>. A Lambda function can have up to five layers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> LambdaFunctionLayers
        {
            get { return this._lambdaFunctionLayers; }
            set { this._lambdaFunctionLayers = value; }
        }

        // Check to see if LambdaFunctionLayers property is set
        internal bool IsSetLambdaFunctionLayers()
        {
            return this._lambdaFunctionLayers != null && this._lambdaFunctionLayers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionName. 
        /// <para>
        /// Filters the list of AWS Lambda functions by the name of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> LambdaFunctionName
        {
            get { return this._lambdaFunctionName; }
            set { this._lambdaFunctionName = value; }
        }

        // Check to see if LambdaFunctionName property is set
        internal bool IsSetLambdaFunctionName()
        {
            return this._lambdaFunctionName != null && this._lambdaFunctionName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionRuntime. 
        /// <para>
        /// Filters the list of AWS Lambda functions by the runtime environment for the Lambda
        /// function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> LambdaFunctionRuntime
        {
            get { return this._lambdaFunctionRuntime; }
            set { this._lambdaFunctionRuntime = value; }
        }

        // Check to see if LambdaFunctionRuntime property is set
        internal bool IsSetLambdaFunctionRuntime()
        {
            return this._lambdaFunctionRuntime != null && this._lambdaFunctionRuntime.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// Details on the date and time a finding was last seen used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property NetworkProtocol. 
        /// <para>
        /// Details on the ingress source addresses used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property PortRange. 
        /// <para>
        /// Details on the port ranges used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PortRangeFilter> PortRange
        {
            get { return this._portRange; }
            set { this._portRange = value; }
        }

        // Check to see if PortRange property is set
        internal bool IsSetPortRange()
        {
            return this._portRange != null && this._portRange.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RelatedVulnerabilities. 
        /// <para>
        /// Details on the related vulnerabilities used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> RelatedVulnerabilities
        {
            get { return this._relatedVulnerabilities; }
            set { this._relatedVulnerabilities = value; }
        }

        // Check to see if RelatedVulnerabilities property is set
        internal bool IsSetRelatedVulnerabilities()
        {
            return this._relatedVulnerabilities != null && this._relatedVulnerabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Details on the resource IDs used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// Details on the resource tags used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Details on the resource types used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// Details on the severity used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null && this._severity.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Details on the finding title used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Details on the date and time a finding was last updated at used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property VendorSeverity. 
        /// <para>
        /// Details on the vendor severity used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> VendorSeverity
        {
            get { return this._vendorSeverity; }
            set { this._vendorSeverity = value; }
        }

        // Check to see if VendorSeverity property is set
        internal bool IsSetVendorSeverity()
        {
            return this._vendorSeverity != null && this._vendorSeverity.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VulnerabilityId. 
        /// <para>
        /// Details on the vulnerability ID used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> VulnerabilityId
        {
            get { return this._vulnerabilityId; }
            set { this._vulnerabilityId = value; }
        }

        // Check to see if VulnerabilityId property is set
        internal bool IsSetVulnerabilityId()
        {
            return this._vulnerabilityId != null && this._vulnerabilityId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VulnerabilitySource. 
        /// <para>
        /// Details on the vulnerability type used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> VulnerabilitySource
        {
            get { return this._vulnerabilitySource; }
            set { this._vulnerabilitySource = value; }
        }

        // Check to see if VulnerabilitySource property is set
        internal bool IsSetVulnerabilitySource()
        {
            return this._vulnerabilitySource != null && this._vulnerabilitySource.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VulnerablePackages. 
        /// <para>
        /// Details on the vulnerable packages used to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PackageFilter> VulnerablePackages
        {
            get { return this._vulnerablePackages; }
            set { this._vulnerablePackages = value; }
        }

        // Check to see if VulnerablePackages property is set
        internal bool IsSetVulnerablePackages()
        {
            return this._vulnerablePackages != null && this._vulnerablePackages.Count > 0; 
        }

    }
}
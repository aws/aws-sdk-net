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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A structure that identifies filter criteria for <c>GetCoverageStatistics</c>.
    /// </summary>
    public partial class CoverageFilterCriteria
    {
        private List<CoverageStringFilter> _accountId = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageMapFilter> _ec2InstanceTags = AWSConfigs.InitializeCollections ? new List<CoverageMapFilter>() : null;
        private List<CoverageStringFilter> _ecrImageTags = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _ecrRepositoryName = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageDateFilter> _imagePulledAt = AWSConfigs.InitializeCollections ? new List<CoverageDateFilter>() : null;
        private List<CoverageStringFilter> _lambdaFunctionName = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _lambdaFunctionRuntime = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageMapFilter> _lambdaFunctionTags = AWSConfigs.InitializeCollections ? new List<CoverageMapFilter>() : null;
        private List<CoverageDateFilter> _lastScannedAt = AWSConfigs.InitializeCollections ? new List<CoverageDateFilter>() : null;
        private List<CoverageStringFilter> _resourceId = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _resourceType = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _scanMode = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _scanStatusCode = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _scanStatusReason = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;
        private List<CoverageStringFilter> _scanType = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// An array of Amazon Web Services account IDs to return coverage statistics for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null && (this._accountId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceTags. 
        /// <para>
        /// The Amazon EC2 instance tags to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageMapFilter> Ec2InstanceTags
        {
            get { return this._ec2InstanceTags; }
            set { this._ec2InstanceTags = value; }
        }

        // Check to see if Ec2InstanceTags property is set
        internal bool IsSetEc2InstanceTags()
        {
            return this._ec2InstanceTags != null && (this._ec2InstanceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EcrImageTags. 
        /// <para>
        /// The Amazon ECR image tags to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> EcrImageTags
        {
            get { return this._ecrImageTags; }
            set { this._ecrImageTags = value; }
        }

        // Check to see if EcrImageTags property is set
        internal bool IsSetEcrImageTags()
        {
            return this._ecrImageTags != null && (this._ecrImageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EcrRepositoryName. 
        /// <para>
        /// The Amazon ECR repository name to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> EcrRepositoryName
        {
            get { return this._ecrRepositoryName; }
            set { this._ecrRepositoryName = value; }
        }

        // Check to see if EcrRepositoryName property is set
        internal bool IsSetEcrRepositoryName()
        {
            return this._ecrRepositoryName != null && (this._ecrRepositoryName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImagePulledAt. 
        /// <para>
        /// The date an image was last pulled at.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageDateFilter> ImagePulledAt
        {
            get { return this._imagePulledAt; }
            set { this._imagePulledAt = value; }
        }

        // Check to see if ImagePulledAt property is set
        internal bool IsSetImagePulledAt()
        {
            return this._imagePulledAt != null && (this._imagePulledAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionName. 
        /// <para>
        /// Returns coverage statistics for Amazon Web Services Lambda functions filtered by function
        /// names.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> LambdaFunctionName
        {
            get { return this._lambdaFunctionName; }
            set { this._lambdaFunctionName = value; }
        }

        // Check to see if LambdaFunctionName property is set
        internal bool IsSetLambdaFunctionName()
        {
            return this._lambdaFunctionName != null && (this._lambdaFunctionName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionRuntime. 
        /// <para>
        /// Returns coverage statistics for Amazon Web Services Lambda functions filtered by runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> LambdaFunctionRuntime
        {
            get { return this._lambdaFunctionRuntime; }
            set { this._lambdaFunctionRuntime = value; }
        }

        // Check to see if LambdaFunctionRuntime property is set
        internal bool IsSetLambdaFunctionRuntime()
        {
            return this._lambdaFunctionRuntime != null && (this._lambdaFunctionRuntime.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionTags. 
        /// <para>
        /// Returns coverage statistics for Amazon Web Services Lambda functions filtered by tag.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageMapFilter> LambdaFunctionTags
        {
            get { return this._lambdaFunctionTags; }
            set { this._lambdaFunctionTags = value; }
        }

        // Check to see if LambdaFunctionTags property is set
        internal bool IsSetLambdaFunctionTags()
        {
            return this._lambdaFunctionTags != null && (this._lambdaFunctionTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastScannedAt. 
        /// <para>
        /// Filters Amazon Web Services resources based on whether Amazon Inspector has checked
        /// them for vulnerabilities within the specified time range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageDateFilter> LastScannedAt
        {
            get { return this._lastScannedAt; }
            set { this._lastScannedAt = value; }
        }

        // Check to see if LastScannedAt property is set
        internal bool IsSetLastScannedAt()
        {
            return this._lastScannedAt != null && (this._lastScannedAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// An array of Amazon Web Services resource IDs to return coverage statistics for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> ResourceId
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// An array of Amazon Web Services resource types to return coverage statistics for.
        /// The values can be <c>AWS_EC2_INSTANCE</c>, <c>AWS_LAMBDA_FUNCTION</c>, <c>AWS_ECR_CONTAINER_IMAGE</c>,
        /// <c>AWS_ECR_REPOSITORY</c> or <c>AWS_ACCOUNT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> ResourceType
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
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The filter to search for Amazon EC2 instance coverage by scan mode. Valid values are
        /// <c>EC2_SSM_AGENT_BASED</c> and <c>EC2_HYBRID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null && (this._scanMode.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanStatusCode. 
        /// <para>
        /// The scan status code to filter on. Valid values are: <c>ValidationException</c>, <c>InternalServerException</c>,
        /// <c>ResourceNotFoundException</c>, <c>BadRequestException</c>, and <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> ScanStatusCode
        {
            get { return this._scanStatusCode; }
            set { this._scanStatusCode = value; }
        }

        // Check to see if ScanStatusCode property is set
        internal bool IsSetScanStatusCode()
        {
            return this._scanStatusCode != null && (this._scanStatusCode.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanStatusReason. 
        /// <para>
        /// The scan status reason to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> ScanStatusReason
        {
            get { return this._scanStatusReason; }
            set { this._scanStatusReason = value; }
        }

        // Check to see if ScanStatusReason property is set
        internal bool IsSetScanStatusReason()
        {
            return this._scanStatusReason != null && (this._scanStatusReason.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// An array of Amazon Inspector scan types to return coverage statistics for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CoverageStringFilter> ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null && (this._scanType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
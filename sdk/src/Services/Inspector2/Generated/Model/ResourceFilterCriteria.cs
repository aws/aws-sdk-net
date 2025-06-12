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
    /// The resource filter criteria for a Software bill of materials (SBOM) report.
    /// </summary>
    public partial class ResourceFilterCriteria
    {
        private List<ResourceStringFilter> _accountId = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;
        private List<ResourceMapFilter> _ec2InstanceTags = AWSConfigs.InitializeCollections ? new List<ResourceMapFilter>() : null;
        private List<ResourceStringFilter> _ecrImageTags = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;
        private List<ResourceStringFilter> _ecrRepositoryName = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;
        private List<ResourceStringFilter> _lambdaFunctionName = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;
        private List<ResourceMapFilter> _lambdaFunctionTags = AWSConfigs.InitializeCollections ? new List<ResourceMapFilter>() : null;
        private List<ResourceStringFilter> _resourceId = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;
        private List<ResourceStringFilter> _resourceType = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account IDs used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceStringFilter> AccountId
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
        /// The EC2 instance tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceMapFilter> Ec2InstanceTags
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
        /// The ECR image tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceStringFilter> EcrImageTags
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
        /// The ECR repository names used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceStringFilter> EcrRepositoryName
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
        /// Gets and sets the property LambdaFunctionName. 
        /// <para>
        /// The Amazon Web Services Lambda function name used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceStringFilter> LambdaFunctionName
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
        /// Gets and sets the property LambdaFunctionTags. 
        /// <para>
        /// The Amazon Web Services Lambda function tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceMapFilter> LambdaFunctionTags
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource IDs used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceStringFilter> ResourceId
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
        /// The resource types used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceStringFilter> ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null && (this._resourceType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
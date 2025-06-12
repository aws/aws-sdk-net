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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the GetLifecyclePolicyPreview operation.
    /// </summary>
    public partial class GetLifecyclePolicyPreviewResponse : AmazonWebServiceResponse
    {
        private string _lifecyclePolicyText;
        private string _nextToken;
        private List<LifecyclePolicyPreviewResult> _previewResults = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyPreviewResult>() : null;
        private string _registryId;
        private string _repositoryName;
        private LifecyclePolicyPreviewStatus _status;
        private LifecyclePolicyPreviewSummary _summary;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyText. 
        /// <para>
        /// The JSON lifecycle policy text.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=30720)]
        public string LifecyclePolicyText
        {
            get { return this._lifecyclePolicyText; }
            set { this._lifecyclePolicyText = value; }
        }

        // Check to see if LifecyclePolicyText property is set
        internal bool IsSetLifecyclePolicyText()
        {
            return this._lifecyclePolicyText != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>GetLifecyclePolicyPreview</c>
        /// request. When the results of a <c>GetLifecyclePolicyPreview</c> request exceed <c>maxResults</c>,
        /// this value can be used to retrieve the next page of results. This value is <c>null</c>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PreviewResults. 
        /// <para>
        /// The results of the lifecycle policy preview request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecyclePolicyPreviewResult> PreviewResults
        {
            get { return this._previewResults; }
            set { this._previewResults = value; }
        }

        // Check to see if PreviewResults property is set
        internal bool IsSetPreviewResults()
        {
            return this._previewResults != null && (this._previewResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the lifecycle policy preview request.
        /// </para>
        /// </summary>
        public LifecyclePolicyPreviewStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The list of images that is returned as a result of the action.
        /// </para>
        /// </summary>
        public LifecyclePolicyPreviewSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}
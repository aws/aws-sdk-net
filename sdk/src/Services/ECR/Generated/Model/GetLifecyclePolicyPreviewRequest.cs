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
    /// Container for the parameters to the GetLifecyclePolicyPreview operation.
    /// Retrieves the results of the lifecycle policy preview request for the specified repository.
    /// </summary>
    public partial class GetLifecyclePolicyPreviewRequest : AmazonECRRequest
    {
        private LifecyclePolicyPreviewFilter _filter;
        private List<ImageIdentifier> _imageIds = AWSConfigs.InitializeCollections ? new List<ImageIdentifier>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// An optional parameter that filters results based on image tag status and all tags,
        /// if tagged.
        /// </para>
        /// </summary>
        public LifecyclePolicyPreviewFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The list of imageIDs to be included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ImageIdentifier> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && (this._imageIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results returned by <c>GetLifecyclePolicyPreviewRequest</c>
        /// in&#x2028; paginated output. When this parameter is used, <c>GetLifecyclePolicyPreviewRequest</c>
        /// only returns&#x2028; <c>maxResults</c> results in a single page along with a <c>nextToken</c>&#x2028;
        /// response element. The remaining results of the initial request can be seen by sending&#x2028;
        /// another <c>GetLifecyclePolicyPreviewRequest</c> request with the returned <c>nextToken</c>&#x2028;
        /// value. This value can be between 1 and 100. If this&#x2028; parameter is not used,
        /// then <c>GetLifecyclePolicyPreviewRequest</c> returns up to&#x2028;100 results and
        /// a <c>nextToken</c> value, if&#x2028; applicable. This option cannot be used when you
        /// specify images with <c>imageIds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated&#x2028; <c>GetLifecyclePolicyPreviewRequest</c>
        /// request where <c>maxResults</c> was used and the&#x2028; results exceeded the value
        /// of that parameter. Pagination continues from the end of the&#x2028; previous results
        /// that returned the <c>nextToken</c> value. This value is&#x2028; <c>null</c> when there
        /// are no more results to return. This option cannot be used when you specify images
        /// with <c>imageIds</c>.
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repository. If you do not specify a registry, the default registry is assumed.
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
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=256)]
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

    }
}
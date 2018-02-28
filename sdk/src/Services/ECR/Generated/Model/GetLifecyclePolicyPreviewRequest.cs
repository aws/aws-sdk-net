/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the GetLifecyclePolicyPreview operation.
    /// Retrieves the results of the specified lifecycle policy preview request.
    /// </summary>
    public partial class GetLifecyclePolicyPreviewRequest : AmazonECRRequest
    {
        private LifecyclePolicyPreviewFilter _filter;
        private List<ImageIdentifier> _imageIds = new List<ImageIdentifier>();
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
        /// </summary>
        public List<ImageIdentifier> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && this._imageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results returned by <code>GetLifecyclePolicyPreviewRequest</code>
        /// in&#x2028; paginated output. When this parameter is used, <code>GetLifecyclePolicyPreviewRequest</code>
        /// only returns&#x2028; <code>maxResults</code> results in a single page along with a
        /// <code>nextToken</code>&#x2028; response element. The remaining results of the initial
        /// request can be seen by sending&#x2028; another <code>GetLifecyclePolicyPreviewRequest</code>
        /// request with the returned <code>nextToken</code>&#x2028; value. This value can be
        /// between 1 and 100. If this&#x2028; parameter is not used, then <code>GetLifecyclePolicyPreviewRequest</code>
        /// returns up to&#x2028; 100 results and a <code>nextToken</code> value, if&#x2028; applicable.
        /// This option cannot be used when you specify images with <code>imageIds</code>.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The <code>nextToken</code> value returned from a previous paginated&#x2028; <code>GetLifecyclePolicyPreviewRequest</code>
        /// request where <code>maxResults</code> was used and the&#x2028; results exceeded the
        /// value of that parameter. Pagination continues from the end of the&#x2028; previous
        /// results that returned the <code>nextToken</code> value. This value is&#x2028; <code>null</code>
        /// when there are no more results to return. This option cannot be used when you specify
        /// images with <code>imageIds</code>.
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
        /// The AWS account ID associated with the registry that contains the repository. If you
        /// do not specify a registry, the default registry is assumed.
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
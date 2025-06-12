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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
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
namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeImages operation.
    /// Returns metadata that's related to the images in a repository in a public registry.
    /// 
    ///  <note> 
    /// <para>
    /// Beginning with Docker version 1.9, the Docker client compresses image layers before
    /// pushing them to a V2 Docker registry. The output of the <c>docker images</c> command
    /// shows the uncompressed image size. Therefore, it might return a larger image size
    /// than the image sizes that are returned by <a>DescribeImages</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonECRPublicRequest
    {
        private List<ImageIdentifier> _imageIds = AWSConfigs.InitializeCollections ? new List<ImageIdentifier>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The list of image IDs for the requested repository.
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
        /// The maximum number of repository results that's returned by <c>DescribeImages</c>
        /// in paginated output. When this parameter is used, <c>DescribeImages</c> only returns
        /// <c>maxResults</c> results in a single page along with a <c>nextToken</c> response
        /// element. You can see the remaining results of the initial request by sending another
        /// <c>DescribeImages</c> request with the returned <c>nextToken</c> value. This value
        /// can be between 1 and 1000. If this parameter isn't used, then <c>DescribeImages</c>
        /// returns up to 100 results and a <c>nextToken</c> value, if applicable. If you specify
        /// images with <c>imageIds</c>, you can't use this option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The <c>nextToken</c> value that's returned from a previous paginated <c>DescribeImages</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. If there are no more results to return, this value is
        /// <c>null</c>. If you specify images with <c>imageIds</c>, you can't use this option.
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
        /// The Amazon Web Services account ID that's associated with the public registry that
        /// contains the repository where images are described. If you do not specify a registry,
        /// the default public registry is assumed.
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
        /// The repository that contains the images to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=205)]
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
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeImages operation. Returns metadata about
    /// the images in a repository. <note> <para> Starting with Docker version 1.9, the Docker
    /// client compresses image layers before pushing them to a V2 Docker registry. The output
    /// of the <c>docker images</c> command shows the uncompressed image size. Therefore,
    /// Docker might return a larger image than the image shown in the Amazon Web Services
    /// Management Console. </para> </note> <important> <para> The new version of Amazon ECR
    /// <i>Basic Scanning</i> doesn't use the <a>ImageDetail$imageScanFindingsSummary</a>
    /// and <a>ImageDetail$imageScanStatus</a> attributes from the API response to return
    /// scan results. Use the <a>DescribeImageScanFindings</a> API instead. For more information
    /// about Amazon Web Services native basic scanning, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/image-scanning.html">
    /// Scan images for software vulnerabilities in Amazon ECR</a>. </para> </important>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filter key and value with which to filter your <c>DescribeImages</c> results.
        /// </para>
        /// </summary>
        public DescribeImagesFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The list of image IDs for the requested repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ImageIdentifier> ImageIds { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageIdentifier>() : null;

        /// <summary>
        /// Checks to see if the ImageIds property is set.
        /// </summary>
        internal bool IsSetImageIds() => this.ImageIds != null && (this.ImageIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results returned by <c>DescribeImages</c> in paginated
        /// output. When this parameter is used, <c>DescribeImages</c> only returns <c>maxResults</c>
        /// results in a single page along with a <c>nextToken</c> response element. The remaining
        /// results of the initial request can be seen by sending another <c>DescribeImages</c>
        /// request with the returned <c>nextToken</c> value. This value can be between 1 and
        /// 1000. If this parameter is not used, then <c>DescribeImages</c> returns up to 100
        /// results and a <c>nextToken</c> value, if applicable. This option cannot be used when
        /// you specify images with <c>imageIds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated <c>DescribeImages</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return. This option cannot be used when you specify images with <c>imageIds</c>.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repository in which to describe images. If you do not specify a registry, the default
        /// registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository that contains the images to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}

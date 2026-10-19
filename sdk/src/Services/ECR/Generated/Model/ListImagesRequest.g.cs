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
    /// Container for the parameters to the ListImages operation. Lists all the image IDs
    /// for the specified repository. <para> You can filter images based on whether or not
    /// they are tagged by using the <c>tagStatus</c> filter and specifying either <c>TAGGED</c>,
    /// <c>UNTAGGED</c> or <c>ANY</c>. For example, you can filter your results to return
    /// only <c>UNTAGGED</c> images and then pipe that result to a <a>BatchDeleteImage</a>
    /// operation to delete them. Or, you can filter your results to return only <c>TAGGED</c>
    /// images to list all of the tags in your repository. </para>
    /// </summary>
    public partial class ListImagesRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filter key and value with which to filter your <c>ListImages</c> results.
        /// </para>
        /// </summary>
        public ListImagesFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of image results returned by <c>ListImages</c> in paginated output.
        /// When this parameter is used, <c>ListImages</c> only returns <c>maxResults</c> results
        /// in a single page along with a <c>nextToken</c> response element. The remaining results
        /// of the initial request can be seen by sending another <c>ListImages</c> request with
        /// the returned <c>nextToken</c> value. This value can be between 1 and 1000. If this
        /// parameter is not used, then <c>ListImages</c> returns up to 100 results and a <c>nextToken</c>
        /// value, if applicable.
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>ListImages</c> request
        /// where <c>maxResults</c> was used and the results exceeded the value of that parameter.
        /// Pagination continues from the end of the previous results that returned the <c>nextToken</c>
        /// value. This value is <c>null</c> when there are no more results to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// repository in which to list images. If you do not specify a registry, the default
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
        /// The repository with image IDs to be listed.
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

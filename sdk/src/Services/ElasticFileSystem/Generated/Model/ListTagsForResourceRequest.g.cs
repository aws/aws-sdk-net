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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation. Lists all tags
    /// for a top-level EFS resource. You must provide the ID of the resource that you want
    /// to retrieve the tags for. <para> This operation requires permissions for the <c>elasticfilesystem:DescribeAccessPoints</c>
    /// action. </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonElasticFileSystemRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) Specifies the maximum number of tag objects to return in the response.
        /// The default value is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// (Optional) You can use <c>NextToken</c> in a subsequent request to fetch the next
        /// page of access point descriptions if the response payload was paginated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Specifies the EFS resource you want to retrieve tags for. You can retrieve tags for
        /// EFS file systems and access points using this API endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}

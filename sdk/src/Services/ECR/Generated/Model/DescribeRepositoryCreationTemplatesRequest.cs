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
    /// Container for the parameters to the DescribeRepositoryCreationTemplates operation.
    /// Returns details about the repository creation templates in a registry. The <c>prefixes</c>
    /// request parameter can be used to return the details for a specific repository creation
    /// template.
    /// </summary>
    public partial class DescribeRepositoryCreationTemplatesRequest : AmazonECRRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _prefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results returned by <c>DescribeRepositoryCreationTemplatesRequest</c>
        /// in paginated output. When this parameter is used, <c>DescribeRepositoryCreationTemplatesRequest</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>DescribeRepositoryCreationTemplatesRequest</c> request with the returned
        /// <c>nextToken</c> value. This value can be between 1 and 1000. If this parameter is
        /// not used, then <c>DescribeRepositoryCreationTemplatesRequest</c> returns up to 100
        /// results and a <c>nextToken</c> value, if applicable.
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>DescribeRepositoryCreationTemplates</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Prefixes. 
        /// <para>
        /// The repository namespace prefixes associated with the repository creation templates
        /// to describe. If this value is not specified, all repository creation templates are
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Prefixes
        {
            get { return this._prefixes; }
            set { this._prefixes = value; }
        }

        // Check to see if Prefixes property is set
        internal bool IsSetPrefixes()
        {
            return this._prefixes != null && (this._prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFileCaches operation. Returns the description
    /// of a specific Amazon File Cache resource, if a <c>FileCacheIds</c> value is provided
    /// for that cache. Otherwise, it returns descriptions of all caches owned by your Amazon
    /// Web Services account in the Amazon Web Services Region of the endpoint that you're
    /// calling. <para> When retrieving all cache descriptions, you can optionally specify
    /// the <c>MaxResults</c> parameter to limit the number of descriptions in a response.
    /// If more cache descriptions remain, the operation returns a <c>NextToken</c> value
    /// in the response. In this case, send a later request with the <c>NextToken</c> request
    /// parameter set to the value of <c>NextToken</c> from the last response. </para> <para>
    /// This operation is used in an iterative process to retrieve a list of your cache descriptions.
    /// <c>DescribeFileCaches</c> is called first without a <c>NextToken</c>value. Then the
    /// operation continues to be called with the <c>NextToken</c> parameter set to the value
    /// of the last <c>NextToken</c> value until a response has no <c>NextToken</c>. </para>
    /// <para> When using this operation, keep the following in mind: </para> <ul> <li> <para>
    /// The implementation might return fewer than <c>MaxResults</c> cache descriptions while
    /// still including a <c>NextToken</c> value. </para> </li> <li> <para> The order of caches
    /// returned in the response of one <c>DescribeFileCaches</c> call and the order of caches
    /// returned across the responses of a multicall iteration is unspecified. </para> </li>
    /// </ul>
    /// </summary>
    public partial class DescribeFileCachesRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property FileCacheIds. 
        /// <para>
        /// IDs of the caches whose descriptions you want to retrieve (String).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> FileCacheIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FileCacheIds property is set.
        /// </summary>
        internal bool IsSetFileCacheIds() => this.FileCacheIds != null && (this.FileCacheIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

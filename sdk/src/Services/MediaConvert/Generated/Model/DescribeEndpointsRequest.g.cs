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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEndpoints operation. Send a request with
    /// an empty body to the regional API endpoint to get your account API endpoint. Note
    /// that DescribeEndpoints is no longer required. We recommend that you send your requests
    /// directly to the regional endpoint instead.
    /// </summary>
    [Obsolete("DescribeEndpoints and account specific endpoints are no longer required. We recommend that you send your requests directly to the regional endpoint instead.")]
    public partial class DescribeEndpointsRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. Optional. Max number of endpoints, up to twenty,
        /// that will be returned at one time.
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. Optional field, defaults to DEFAULT. Specify DEFAULT
        /// for this operation to return your endpoints if any exist, or to create an endpoint
        /// for you and return it if one doesn't already exist. Specify GET_ONLY to return your
        /// endpoints if any exist, or an empty list if none exist.
        /// </summary>
        public DescribeEndpointsMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NextToken. Use this string, provided with the response
        /// to a previous request, to request the next batch of endpoints.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

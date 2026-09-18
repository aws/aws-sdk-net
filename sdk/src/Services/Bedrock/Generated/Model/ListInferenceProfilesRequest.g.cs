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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListInferenceProfiles operation. Returns a list
    /// of inference profiles that you can use. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
    /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
    /// Amazon Bedrock User Guide.
    /// </summary>
    public partial class ListInferenceProfilesRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
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
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TypeEquals. 
        /// <para>
        /// Filters for inference profiles that match the type you specify.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYSTEM_DEFINED</c> – The inference profile is defined by Amazon Bedrock. You can
        /// route inference requests across regions with these inference profiles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLICATION</c> – The inference profile was created by a user. This type of inference
        /// profile can track metrics and costs when invoking the model in it. The inference profile
        /// may route requests to one or multiple regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InferenceProfileType TypeEquals { get; set; }

        /// <summary>
        /// Checks to see if the TypeEquals property is set.
        /// </summary>
        internal bool IsSetTypeEquals() => this.TypeEquals != null;
    }
}

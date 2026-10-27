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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListTestExecutionResultItems operation. Gets a
    /// list of test execution result items.
    /// </summary>
    public partial class ListTestExecutionResultItemsRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of test execution result items to return in each page. If there
        /// are fewer results than the max page size, only the actual number of results are returned.
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
        /// If the response from the <c>ListTestExecutionResultItems</c> operation contains more
        /// results than specified in the <c>maxResults</c> parameter, a token is returned in
        /// the response. Use that token in the <c>nextToken</c> parameter to return the next
        /// page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResultFilterBy. 
        /// <para>
        /// The filter for the list of results from the test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestExecutionResultFilterBy ResultFilterBy { get; set; }

        /// <summary>
        /// Checks to see if the ResultFilterBy property is set.
        /// </summary>
        internal bool IsSetResultFilterBy() => this.ResultFilterBy != null;

        /// <summary>
        /// Gets and sets the property TestExecutionId. 
        /// <para>
        /// The unique identifier of the test execution to list the result items.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string TestExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the TestExecutionId property is set.
        /// </summary>
        internal bool IsSetTestExecutionId() => this.TestExecutionId != null;
    }
}

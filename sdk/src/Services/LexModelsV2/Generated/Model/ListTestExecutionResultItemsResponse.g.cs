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
    /// This is the response object from the ListTestExecutionResultItems operation.
    /// </summary>
    public partial class ListTestExecutionResultItemsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more results to return in a response to the
        /// <c>ListTestExecutionResultItems</c> operation. If the <c>nextToken</c> field is present,
        /// you send the contents as the <c>nextToken</c> parameter of a <c>ListTestExecutionResultItems</c>
        /// operation request to get the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TestExecutionResults. 
        /// <para>
        /// The list of results from the test execution.
        /// </para>
        /// </summary>
        public TestExecutionResultItems TestExecutionResults { get; set; }

        /// <summary>
        /// Checks to see if the TestExecutionResults property is set.
        /// </summary>
        internal bool IsSetTestExecutionResults() => this.TestExecutionResults != null;
    }
}

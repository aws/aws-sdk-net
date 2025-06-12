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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the DescribeTestCases operation.
    /// </summary>
    public partial class DescribeTestCasesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TestCase> _testCases = AWSConfigs.InitializeCollections ? new List<TestCase>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  During a previous call, the maximum number of items that can be returned is the value
        /// specified in <c>maxResults</c>. If there more items in the list, then a unique string
        /// called a <i>nextToken</i> is returned. To get the next batch of items in the list,
        /// call this operation again, adding the next token to the call. To get all of the items
        /// in the list, keep calling this operation with each subsequent next token that is returned,
        /// until no more next tokens are returned. 
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
        /// Gets and sets the property TestCases. 
        /// <para>
        ///  The returned list of test cases. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TestCase> TestCases
        {
            get { return this._testCases; }
            set { this._testCases = value; }
        }

        // Check to see if TestCases property is set
        internal bool IsSetTestCases()
        {
            return this._testCases != null && (this._testCases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Container for the parameters to the ListTestRuns operation.
    /// Lists test runs.
    /// </summary>
    public partial class ListTestRunsRequest : AmazonAppTestRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _testRunIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _testSuiteId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of test runs to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token from the previous request to retrieve the next page of test run results.
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
        /// Gets and sets the property TestRunIds. 
        /// <para>
        /// The test run IDs of the test runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TestRunIds
        {
            get { return this._testRunIds; }
            set { this._testRunIds = value; }
        }

        // Check to see if TestRunIds property is set
        internal bool IsSetTestRunIds()
        {
            return this._testRunIds != null && (this._testRunIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TestSuiteId. 
        /// <para>
        /// The test suite ID of the test runs.
        /// </para>
        /// </summary>
        public string TestSuiteId
        {
            get { return this._testSuiteId; }
            set { this._testSuiteId = value; }
        }

        // Check to see if TestSuiteId property is set
        internal bool IsSetTestSuiteId()
        {
            return this._testSuiteId != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// This is the response object from the ListTestSetRecords operation.
    /// </summary>
    public partial class ListTestSetRecordsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TestSetTurnRecord> _testSetRecords = AWSConfigs.InitializeCollections ? new List<TestSetTurnRecord>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more records to return in a response to the
        /// ListTestSetRecords operation. If the nextToken field is present, you send the contents
        /// as the nextToken parameter of a ListTestSetRecords operation request to get the next
        /// page of records.
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
        /// Gets and sets the property TestSetRecords. 
        /// <para>
        /// The list of records from the test set.
        /// </para>
        /// </summary>
        public List<TestSetTurnRecord> TestSetRecords
        {
            get { return this._testSetRecords; }
            set { this._testSetRecords = value; }
        }

        // Check to see if TestSetRecords property is set
        internal bool IsSetTestSetRecords()
        {
            return this._testSetRecords != null && (this._testSetRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
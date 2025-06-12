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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchExecuteStatement operation.
    /// This operation allows you to perform batch reads or writes on data stored in DynamoDB,
    /// using PartiQL. Each read statement in a <c>BatchExecuteStatement</c> must specify
    /// an equality condition on all key attributes. This enforces that each <c>SELECT</c>
    /// statement in a batch returns at most a single item. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ql-reference.multiplestatements.batching.html">Running
    /// batch operations with PartiQL for DynamoDB </a>.
    /// 
    ///  <note> 
    /// <para>
    /// The entire batch must consist of either read statements or write statements, you cannot
    /// mix both in one batch.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// A HTTP 200 response does not mean that all statements in the BatchExecuteStatement
    /// succeeded. Error details for individual statements can be found under the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_BatchStatementResponse.html#DDB-Type-BatchStatementResponse-Error">Error</a>
    /// field of the <c>BatchStatementResponse</c> for each statement.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class BatchExecuteStatementRequest : AmazonDynamoDBRequest
    {
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private List<BatchStatementRequest> _statements = AWSConfigs.InitializeCollections ? new List<BatchStatementRequest>() : null;

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this._returnConsumedCapacity; }
            set { this._returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this._returnConsumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property Statements. 
        /// <para>
        /// The list of PartiQL statements representing the batch to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<BatchStatementRequest> Statements
        {
            get { return this._statements; }
            set { this._statements = value; }
        }

        // Check to see if Statements property is set
        internal bool IsSetStatements()
        {
            return this._statements != null && (this._statements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
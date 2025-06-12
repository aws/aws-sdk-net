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
    /// Container for the parameters to the ExecuteTransaction operation.
    /// This operation allows you to perform transactional reads or writes on data stored
    /// in DynamoDB, using PartiQL.
    /// 
    ///  <note> 
    /// <para>
    /// The entire transaction must consist of either read statements or write statements,
    /// you cannot mix both in one transaction. The EXISTS function is an exception and can
    /// be used to check the condition of specific attributes of the item in a similar manner
    /// to <c>ConditionCheck</c> in the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/transaction-apis.html#transaction-apis-txwriteitems">TransactWriteItems</a>
    /// API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ExecuteTransactionRequest : AmazonDynamoDBRequest
    {
        private string _clientRequestToken;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private List<ParameterizedStatement> _transactStatements = AWSConfigs.InitializeCollections ? new List<ParameterizedStatement>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Set this value to get remaining results, if <c>NextToken</c> was returned in the statement
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity. 
        /// <para>
        /// Determines the level of detail about either provisioned or on-demand throughput consumption
        /// that is returned in the response. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_TransactGetItems.html">TransactGetItems</a>
        /// and <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_TransactWriteItems.html">TransactWriteItems</a>.
        /// </para>
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
        /// Gets and sets the property TransactStatements. 
        /// <para>
        /// The list of PartiQL statements representing the transaction to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<ParameterizedStatement> TransactStatements
        {
            get { return this._transactStatements; }
            set { this._transactStatements = value; }
        }

        // Check to see if TransactStatements property is set
        internal bool IsSetTransactStatements()
        {
            return this._transactStatements != null && (this._transactStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
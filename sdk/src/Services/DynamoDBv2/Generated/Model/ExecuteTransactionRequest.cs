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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteTransaction operation.
    /// This operation allows you to perform transactional reads or writes on data stored
    /// in DynamoDB, using PartiQL.
    /// </summary>
    public partial class ExecuteTransactionRequest : AmazonDynamoDBRequest
    {
        private string _clientRequestToken;
        private List<ParameterizedStatement> _transactStatements = new List<ParameterizedStatement>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  Set this value to get remaining results, if <code>NextToken</code> was returned in
        /// the statement response. 
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
        /// Gets and sets the property TransactStatements. 
        /// <para>
        ///  The list of PartiQL statements representing the transaction to run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<ParameterizedStatement> TransactStatements
        {
            get { return this._transactStatements; }
            set { this._transactStatements = value; }
        }

        // Check to see if TransactStatements property is set
        internal bool IsSetTransactStatements()
        {
            return this._transactStatements != null && this._transactStatements.Count > 0; 
        }

    }
}
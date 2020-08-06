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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Specifies a request to execute a statement.
    /// </summary>
    public partial class ExecuteStatementRequest
    {
        private List<ValueHolder> _parameters = new List<ValueHolder>();
        private string _statement;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the parameters for the parameterized statement in the request.
        /// </para>
        /// </summary>
        public List<ValueHolder> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// Specifies the statement of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100000)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// Specifies the transaction ID of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}
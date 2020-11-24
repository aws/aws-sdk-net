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
    /// Container for the parameters to the BatchExecuteStatement operation.
    /// This operation allows you to perform batch reads and writes on data stored in DynamoDB,
    /// using PartiQL.
    /// </summary>
    public partial class BatchExecuteStatementRequest : AmazonDynamoDBRequest
    {
        private List<BatchStatementRequest> _statements = new List<BatchStatementRequest>();

        /// <summary>
        /// Gets and sets the property Statements. 
        /// <para>
        ///  The list of PartiQL statements representing the batch to run. 
        /// </para>
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
            return this._statements != null && this._statements.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchExecuteStatement operation.
    /// Runs a batch SQL statement over an array of data.
    /// 
    ///  
    /// <para>
    /// You can run bulk update and insert operations for multiple records using a DML statement
    /// with different parameter sets. Bulk operations can provide a significant performance
    /// improvement over individual insert and update operations.
    /// </para>
    ///  <important> 
    /// <para>
    /// If a call isn't part of a transaction because it doesn't include the <code>transactionID</code>
    /// parameter, changes that result from the call are committed automatically.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class BatchExecuteStatementRequest : AmazonRDSDataServiceRequest
    {
        private string _database;
        private List<List<SqlParameter>> _parameterSets = new List<List<SqlParameter>>();
        private string _resourceArn;
        private string _schema;
        private string _secretArn;
        private string _sql;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterSets. 
        /// <para>
        /// The parameter set for the batch operation.
        /// </para>
        ///  
        /// <para>
        /// The SQL statement is executed as many times as the number of parameter sets provided.
        /// To execute a SQL statement with no parameters, use one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify one or more empty parameter sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>ExecuteStatement</code> operation instead of the <code>BatchExecuteStatement</code>
        /// operation.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Array parameters are not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public List<List<SqlParameter>> ParameterSets
        {
            get { return this._parameterSets; }
            set { this._parameterSets = value; }
        }

        // Check to see if ParameterSets property is set
        internal bool IsSetParameterSets()
        {
            return this._parameterSets != null && this._parameterSets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora Serverless DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=100)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The name of the database schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=100)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property Sql. 
        /// <para>
        /// The SQL statement to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65536)]
        public string Sql
        {
            get { return this._sql; }
            set { this._sql = value; }
        }

        // Check to see if Sql property is set
        internal bool IsSetSql()
        {
            return this._sql != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The identifier of a transaction that was started by using the <code>BeginTransaction</code>
        /// operation. Specify the transaction ID of the transaction that you want to include
        /// the SQL statement in.
        /// </para>
        ///  
        /// <para>
        /// If the SQL statement is not part of a transaction, don't set this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=192)]
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
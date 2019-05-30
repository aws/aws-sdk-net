/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteStatement operation.
    /// Runs a SQL statement against a database.
    /// 
    ///         <important>                
    /// <para>
    /// If a call isn't part of a transaction because it doesn't include the             
    ///       <code>transactionID</code> parameter, changes that result from the call are
    ///                committed automatically.
    /// </para>
    ///             </important>        
    /// <para>
    /// The response size limit is 1 MB or 1,000 records. If the call returns more than 1
    /// MB of response data or over 1,000 records, the call is terminated.
    /// </para>
    /// </summary>
    public partial class ExecuteStatementRequest : AmazonRDSDataServiceRequest
    {
        private bool? _continueAfterTimeout;
        private string _database;
        private bool? _includeResultMetadata;
        private List<SqlParameter> _parameters = new List<SqlParameter>();
        private string _resourceArn;
        private string _schema;
        private string _secretArn;
        private string _sql;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property ContinueAfterTimeout. 
        /// <para>
        /// A value that indicates whether to continue running the statement after           
        ///  the call times out. By default, the statement stops running when the call       
        ///      times out.
        /// </para>
        ///         <important>            
        /// <para>
        /// For DDL statements, we recommend continuing to run the statement after           
        ///     the call times out. When a DDL statement terminates before it is finished    
        ///            running, it can result in errors and possibly corrupted data structures.
        /// </para>
        ///         </important>
        /// </summary>
        public bool ContinueAfterTimeout
        {
            get { return this._continueAfterTimeout.GetValueOrDefault(); }
            set { this._continueAfterTimeout = value; }
        }

        // Check to see if ContinueAfterTimeout property is set
        internal bool IsSetContinueAfterTimeout()
        {
            return this._continueAfterTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property IncludeResultMetadata. 
        /// <para>
        /// A value that indicates whether to include metadata in the results.
        /// </para>
        /// </summary>
        public bool IncludeResultMetadata
        {
            get { return this._includeResultMetadata.GetValueOrDefault(); }
            set { this._includeResultMetadata = value; }
        }

        // Check to see if IncludeResultMetadata property is set
        internal bool IsSetIncludeResultMetadata()
        {
            return this._includeResultMetadata.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the SQL statement.
        /// </para>
        /// </summary>
        public List<SqlParameter> Parameters
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora Serverless DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
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
        [AWSProperty(Max=64)]
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
        [AWSProperty(Required=true, Max=100)]
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
        [AWSProperty(Required=true, Max=65536)]
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
        /// The identifier of a transaction that was started by using the                <code>BeginTransaction</code>
        /// operation. Specify the transaction ID of the            transaction that you want
        /// to include the SQL statement in.
        /// </para>
        ///         
        /// <para>
        /// If the SQL statement is not part of a transaction, don't set this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=192)]
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
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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteStatement operation.
    /// Runs a SQL statement against a database.
    /// 
    ///  <note> 
    /// <para>
    /// If a call isn't part of a transaction because it doesn't include the <c>transactionID</c>
    /// parameter, changes that result from the call are committed automatically.
    /// </para>
    ///  
    /// <para>
    /// If the binary response data from the database is more than 1 MB, the call is terminated.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ExecuteStatementRequest : AmazonRDSDataServiceRequest
    {
        private bool? _continueAfterTimeout;
        private string _database;
        private RecordsFormatType _formatRecordsAs;
        private bool? _includeResultMetadata;
        private List<SqlParameter> _parameters = AWSConfigs.InitializeCollections ? new List<SqlParameter>() : null;
        private string _resourceArn;
        private ResultSetOptions _resultSetOptions;
        private string _schema;
        private string _secretArn;
        private string _sql;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property ContinueAfterTimeout. 
        /// <para>
        /// A value that indicates whether to continue running the statement after the call times
        /// out. By default, the statement stops running when the call times out.
        /// </para>
        ///  <note> 
        /// <para>
        /// For DDL statements, we recommend continuing to run the statement after the call times
        /// out. When a DDL statement terminates before it is finished running, it can result
        /// in errors and possibly corrupted data structures.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ContinueAfterTimeout
        {
            get { return this._continueAfterTimeout; }
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
        /// Gets and sets the property FormatRecordsAs. 
        /// <para>
        /// A value that indicates whether to format the result set as a single JSON string. This
        /// parameter only applies to <c>SELECT</c> statements and is ignored for other types
        /// of statements. Allowed values are <c>NONE</c> and <c>JSON</c>. The default value is
        /// <c>NONE</c>. The result is returned in the <c>formattedRecords</c> field.
        /// </para>
        ///  
        /// <para>
        /// For usage information about the JSON format for result sets, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// the Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public RecordsFormatType FormatRecordsAs
        {
            get { return this._formatRecordsAs; }
            set { this._formatRecordsAs = value; }
        }

        // Check to see if FormatRecordsAs property is set
        internal bool IsSetFormatRecordsAs()
        {
            return this._formatRecordsAs != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeResultMetadata. 
        /// <para>
        /// A value that indicates whether to include metadata in the results.
        /// </para>
        /// </summary>
        public bool? IncludeResultMetadata
        {
            get { return this._includeResultMetadata; }
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
        ///  <note> 
        /// <para>
        /// Array parameters are not supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SqlParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ResultSetOptions. 
        /// <para>
        /// Options that control how the result set is returned.
        /// </para>
        /// </summary>
        public ResultSetOptions ResultSetOptions
        {
            get { return this._resultSetOptions; }
            set { this._resultSetOptions = value; }
        }

        // Check to see if ResultSetOptions property is set
        internal bool IsSetResultSetOptions()
        {
            return this._resultSetOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The name of the database schema.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, the <c>schema</c> parameter isn't supported.
        /// </para>
        ///  </note>
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
        /// The ARN of the secret that enables access to the DB cluster. Enter the database user
        /// name and password for the credentials in the secret.
        /// </para>
        ///  
        /// <para>
        /// For information about creating the secret, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/create_database_secret.html">Create
        /// a database secret</a>.
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
        /// The identifier of a transaction that was started by using the <c>BeginTransaction</c>
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
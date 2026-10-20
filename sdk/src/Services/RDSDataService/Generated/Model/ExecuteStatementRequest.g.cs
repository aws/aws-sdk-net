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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ExecuteStatement operation. Runs a SQL statement
    /// against a database. <note> <para> If a call isn't part of a transaction because it
    /// doesn't include the <c>transactionID</c> parameter, changes that result from the call
    /// are committed automatically. </para> <para> If the binary response data from the database
    /// is more than 1 MB, the call is terminated. </para> </note>
    /// </summary>
    public partial class ExecuteStatementRequest : AmazonRDSDataServiceRequest
    {
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
        public bool? ContinueAfterTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ContinueAfterTimeout property is set.
        /// </summary>
        internal bool IsSetContinueAfterTimeout() => this.ContinueAfterTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

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
        public RecordsFormatType FormatRecordsAs { get; set; }

        /// <summary>
        /// Checks to see if the FormatRecordsAs property is set.
        /// </summary>
        internal bool IsSetFormatRecordsAs() => this.FormatRecordsAs != null;

        /// <summary>
        /// Gets and sets the property IncludeResultMetadata. 
        /// <para>
        /// A value that indicates whether to include metadata in the results.
        /// </para>
        /// </summary>
        public bool? IncludeResultMetadata { get; set; }

        /// <summary>
        /// Checks to see if the IncludeResultMetadata property is set.
        /// </summary>
        internal bool IsSetIncludeResultMetadata() => this.IncludeResultMetadata.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SqlParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<SqlParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora Serverless DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 570)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResultSetOptions. 
        /// <para>
        /// Options that control how the result set is returned.
        /// </para>
        /// </summary>
        public ResultSetOptions ResultSetOptions { get; set; }

        /// <summary>
        /// Checks to see if the ResultSetOptions property is set.
        /// </summary>
        internal bool IsSetResultSetOptions() => this.ResultSetOptions != null;

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
        [AWSProperty(Max = 64)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

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
        ///  <note> 
        /// <para>
        /// When you use the CLI on Linux to reference a secret created in the RDS console, the
        /// ARN might include special characters like <c>rds!cluster</c>. If you enclose the ARN
        /// in double quotes, the <c>!</c> character might trigger a shell expansion error, such
        /// as <c>-bash: !cluster: event not found</c>. To avoid this, escape the exclamation
        /// mark (\!) in the ARN or enclose the entire ARN in single quotes (') instead of double
        /// quotes.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, disable shell history expansion by running <c>set +H</c> before you
        /// execute the command.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 570)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property Sql. 
        /// <para>
        /// The SQL statement to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 65536)]
        public string Sql { get; set; }

        /// <summary>
        /// Checks to see if the Sql property is set.
        /// </summary>
        internal bool IsSetSql() => this.Sql != null;

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
        [AWSProperty(Max = 192)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}

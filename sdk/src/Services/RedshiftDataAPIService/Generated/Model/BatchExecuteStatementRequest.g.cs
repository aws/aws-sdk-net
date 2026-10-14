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

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchExecuteStatement operation. Runs one or more
    /// SQL statements, which can be data manipulation language (DML) or data definition language
    /// (DDL). Depending on the authorization method, use one of the following combinations
    /// of request parameters: <ul> <li> <para> Secrets Manager - when connecting to a cluster,
    /// provide the <c>secret-arn</c> of a secret stored in Secrets Manager which has <c>username</c>
    /// and <c>password</c>. The specified secret contains credentials to connect to the <c>database</c>
    /// you specify. When you are connecting to a cluster, you also supply the database name,
    /// If you provide a cluster identifier (<c>dbClusterIdentifier</c>), it must match the
    /// cluster identifier stored in the secret. When you are connecting to a serverless workgroup,
    /// you also supply the database name. </para> </li> <li> <para> Temporary credentials
    /// - when connecting to your data warehouse, choose one of the following options: </para>
    /// <ul> <li> <para> When connecting to a serverless workgroup, specify the workgroup
    /// name and database name. The database user name is derived from the IAM identity. For
    /// example, <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>.
    /// Also, permission to call the <c>redshift-serverless:GetCredentials</c> operation is
    /// required. </para> </li> <li> <para> When connecting to a cluster as an IAM identity,
    /// specify the cluster identifier and the database name. The database user name is derived
    /// from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c> has the
    /// database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift:GetClusterCredentialsWithIAM</c>
    /// operation is required. </para> </li> <li> <para> When connecting to a cluster as a
    /// database user, specify the cluster identifier, the database name, and the database
    /// user name. Also, permission to call the <c>redshift:GetClusterCredentials</c> operation
    /// is required. </para> </li> </ul> </li> </ul> <para> For more information about the
    /// Amazon Redshift Data API and CLI usage examples, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using
    /// the Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. </para>
    /// </summary>
    public partial class BatchExecuteStatementRequest : AmazonRedshiftDataAPIServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. This parameter is required when connecting to a cluster and
        /// authenticating using either Secrets Manager or temporary credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. This parameter is required when authenticating using either
        /// Secrets Manager or temporary credentials. 
        /// </para>
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. This parameter is required when connecting to a cluster as
        /// a database user and authenticating using temporary credentials. 
        /// </para>
        /// </summary>
        public string DbUser { get; set; }

        /// <summary>
        /// Checks to see if the DbUser property is set.
        /// </summary>
        internal bool IsSetDbUser() => this.DbUser != null;

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// Determines how the SQL statements in the batch are run. If set to <c>TRANSACTION</c>
        /// (the default), all SQL statements are run as a single transaction and they are committed
        /// or rolled back together. If set to <c>AUTO_COMMIT</c>, each SQL statement is committed
        /// individually, and a failure of one statement does not affect the others.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionMode property is set.
        /// </summary>
        internal bool IsSetExecutionMode() => this.ExecutionMode != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the SQL statements. The parameters are available to all SQL statements
        /// in the batch. Each statement can reference any subset of the provided parameters.
        /// Each provided parameter must be referenced by at least one SQL statement in the batch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<SqlParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<SqlParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResultFormat. 
        /// <para>
        /// The data format of the result of the SQL statement. If no format is specified, the
        /// default is JSON.
        /// </para>
        /// </summary>
        public ResultFormatString ResultFormat { get; set; }

        /// <summary>
        /// Checks to see if the ResultFormat property is set.
        /// </summary>
        internal bool IsSetResultFormat() => this.ResultFormat != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. This parameter
        /// is required when authenticating using Secrets Manager. 
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session identifier of the query.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionKeepAliveSeconds. 
        /// <para>
        /// The number of seconds to keep the session alive after the query finishes. The maximum
        /// time a session can keep alive is 24 hours. After 24 hours, the session is forced closed
        /// and the query is terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 86400)]
        public int? SessionKeepAliveSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionKeepAliveSeconds property is set.
        /// </summary>
        internal bool IsSetSessionKeepAliveSeconds() => this.SessionKeepAliveSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Sqls. 
        /// <para>
        /// One or more SQL statements to run. The SQL statements run serially in the order of
        /// the array. Subsequent SQL statements don't start until the previous statement in the
        /// array completes. By default, the SQL statements are run as a single transaction. If
        /// any SQL statement fails, all work is rolled back. To change this behavior, see the
        /// <c>ExecutionMode</c> parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public List<string> Sqls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sqls property is set.
        /// </summary>
        internal bool IsSetSqls() => this.Sqls != null && (this.Sqls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statements. You can name the SQL statements when you create them
        /// to identify the query. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string StatementName { get; set; }

        /// <summary>
        /// Checks to see if the StatementName property is set.
        /// </summary>
        internal bool IsSetStatementName() => this.StatementName != null;

        /// <summary>
        /// Gets and sets the property WaitTimeSeconds. 
        /// <para>
        /// The number of seconds to wait for all SQL statements in the batch to complete execution
        /// before returning the response. If the SQL statements do not complete within the specified
        /// time, the response returns the current status. The maximum value is 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public int? WaitTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the WaitTimeSeconds property is set.
        /// </summary>
        internal bool IsSetWaitTimeSeconds() => this.WaitTimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property WithEvent. 
        /// <para>
        /// A value that indicates whether to send an event to the Amazon EventBridge event bus
        /// after the SQL statements run. 
        /// </para>
        /// </summary>
        public bool? WithEvent { get; set; }

        /// <summary>
        /// Checks to see if the WithEvent property is set.
        /// </summary>
        internal bool IsSetWithEvent() => this.WithEvent.HasValue;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN). This parameter is required
        /// when connecting to a serverless workgroup and authenticating using either Secrets
        /// Manager or temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}

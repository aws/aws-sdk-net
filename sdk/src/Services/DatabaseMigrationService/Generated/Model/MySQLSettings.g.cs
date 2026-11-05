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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines a MySQL endpoint.
    /// </summary>
    public partial class MySQLSettings
    {
        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// Specifies a script to run immediately after DMS connects to the endpoint. The migration
        /// task continues running regardless if the SQL statement succeeds or fails.
        /// </para>
        ///  
        /// <para>
        /// For this parameter, provide the code of the script itself, not the name of a file
        /// containing the script.
        /// </para>
        /// </summary>
        public string AfterConnectScript { get; set; }

        /// <summary>
        /// Checks to see if the AfterConnectScript property is set.
        /// </summary>
        internal bool IsSetAfterConnectScript() => this.AfterConnectScript != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// This attribute allows you to specify the authentication method as "iam auth".
        /// </para>
        /// </summary>
        public MySQLAuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property CleanSourceMetadataOnMismatch. 
        /// <para>
        /// Cleans and recreates table metadata information on the replication instance when a
        /// mismatch occurs. For example, in a situation where running an alter DDL on the table
        /// could result in different information about the table cached in the replication instance.
        /// 
        /// </para>
        /// </summary>
        public bool? CleanSourceMetadataOnMismatch { get; set; }

        /// <summary>
        /// Checks to see if the CleanSourceMetadataOnMismatch property is set.
        /// </summary>
        internal bool IsSetCleanSourceMetadataOnMismatch() => this.CleanSourceMetadataOnMismatch.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint. For a MySQL source or target endpoint, don't explicitly
        /// specify the database using the <c>DatabaseName</c> request parameter on either the
        /// <c>CreateEndpoint</c> or <c>ModifyEndpoint</c> API call. Specifying <c>DatabaseName</c>
        /// when you create or modify a MySQL endpoint replicates all the task tables to this
        /// single database. For MySQL endpoints, you specify the database only when you specify
        /// the schema in the table-mapping rules of the DMS task.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property EventsPollInterval. 
        /// <para>
        /// Specifies how often to check the binary log for new changes/events when the database
        /// is idle. The default is five seconds.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>eventsPollInterval=5;</c> 
        /// </para>
        ///  
        /// <para>
        /// In the example, DMS checks for changes in the binary logs every five seconds.
        /// </para>
        /// </summary>
        public int? EventsPollInterval { get; set; }

        /// <summary>
        /// Checks to see if the EventsPollInterval property is set.
        /// </summary>
        internal bool IsSetEventsPollInterval() => this.EventsPollInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ExecuteTimeout. 
        /// <para>
        /// Sets the client statement timeout (in seconds) for a MySQL source endpoint.
        /// </para>
        /// </summary>
        public int? ExecuteTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ExecuteTimeout property is set.
        /// </summary>
        internal bool IsSetExecuteTimeout() => this.ExecuteTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// Specifies the maximum size (in KB) of any .csv file used to transfer data to a MySQL-compatible
        /// database.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>maxFileSize=512</c> 
        /// </para>
        /// </summary>
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxFileSize property is set.
        /// </summary>
        internal bool IsSetMaxFileSize() => this.MaxFileSize.HasValue;

        /// <summary>
        /// Gets and sets the property ParallelLoadThreads. 
        /// <para>
        /// Improves performance when loading data into the MySQL-compatible target database.
        /// Specifies how many threads to use to load the data into the MySQL-compatible target
        /// database. Setting a large number of threads can have an adverse effect on database
        /// performance, because a separate connection is required for each thread. The default
        /// is one.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>parallelLoadThreads=1</c> 
        /// </para>
        /// </summary>
        public int? ParallelLoadThreads { get; set; }

        /// <summary>
        /// Checks to see if the ParallelLoadThreads property is set.
        /// </summary>
        internal bool IsSetParallelLoadThreads() => this.ParallelLoadThreads.HasValue;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Endpoint connection password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the MySQL endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <c>SecretsManagerSecretId</c>. Or you can specify clear-text
        /// values for <c>UserName</c>, <c>Password</c>, <c>ServerName</c>, and <c>Port</c>. You
        /// can't specify both. For more information on creating this <c>SecretsManagerSecret</c>
        /// and the <c>SecretsManagerAccessRoleArn</c> and <c>SecretsManagerSecretId</c> required
        /// to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the <i>Database Migration
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerAccessRoleArn() => this.SecretsManagerAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the MySQL endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecretId() => this.SecretsManagerSecretId != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The host name of the endpoint database. 
        /// </para>
        ///  
        /// <para>
        /// For an Amazon RDS MySQL instance, this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBInstances.html">DescribeDBInstances</a>,
        /// in the <c> <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Endpoint.html">Endpoint</a>.Address</c>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// For an Aurora MySQL instance, this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBClusters.html">DescribeDBClusters</a>,
        /// in the <c>Endpoint</c> field.
        /// </para>
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property ServerTimezone. 
        /// <para>
        /// Specifies the time zone for the source MySQL database.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>serverTimezone=US/Pacific;</c> 
        /// </para>
        ///  
        /// <para>
        /// Note: Do not enclose time zones in single quotes.
        /// </para>
        /// </summary>
        public string ServerTimezone { get; set; }

        /// <summary>
        /// Checks to see if the ServerTimezone property is set.
        /// </summary>
        internal bool IsSetServerTimezone() => this.ServerTimezone != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role you can use to authenticate when connecting to your endpoint. Ensure
        /// to include <c>iam:PassRole</c> and <c>rds-db:connect</c> actions in permission policy.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property TargetDbType. 
        /// <para>
        /// Specifies where to migrate source tables on the target, either to a single database
        /// or multiple databases. If you specify <c>SPECIFIC_DATABASE</c>, specify the database
        /// name using the <c>DatabaseName</c> parameter of the <c>Endpoint</c> object.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>targetDbType=MULTIPLE_DATABASES</c> 
        /// </para>
        /// </summary>
        public TargetDbType TargetDbType { get; set; }

        /// <summary>
        /// Checks to see if the TargetDbType property is set.
        /// </summary>
        internal bool IsSetTargetDbType() => this.TargetDbType != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Endpoint connection user name.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}

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
    /// Container for the parameters to the ExecuteSql operation. Runs one or more SQL statements.
    /// <note> <para> This operation is deprecated. Please use the <c>BatchExecuteStatement</c>
    /// or <c>ExecuteStatement</c> operation. </para> </note>
    /// </summary>
    public partial class ExecuteSqlRequest : AmazonRDSDataServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AwsSecretStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret that enables access to the DB cluster.
        /// Enter the database user name and password for the credentials in the secret.
        /// </para>
        ///  
        /// <para>
        /// For information about creating the secret, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/create_database_secret.html">Create
        /// a database secret</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 570)]
        public string AwsSecretStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsSecretStoreArn property is set.
        /// </summary>
        internal bool IsSetAwsSecretStoreArn() => this.AwsSecretStoreArn != null;

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
        /// Gets and sets the property DbClusterOrInstanceArn. 
        /// <para>
        /// The ARN of the Aurora Serverless DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 570)]
        public string DbClusterOrInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterOrInstanceArn property is set.
        /// </summary>
        internal bool IsSetDbClusterOrInstanceArn() => this.DbClusterOrInstanceArn != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The name of the database schema.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property SqlStatements. 
        /// <para>
        /// One or more SQL statements to run on the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// You can separate SQL statements from each other with a semicolon (;). Any valid SQL
        /// statement is permitted, including data definition, data manipulation, and commit statements.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 65536)]
        public string SqlStatements { get; set; }

        /// <summary>
        /// Checks to see if the SqlStatements property is set.
        /// </summary>
        internal bool IsSetSqlStatements() => this.SqlStatements != null;
    }
}

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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteStatement operation.
    /// Runs an SQL statement, which can be data manipulation language (DML) or data definition
    /// language (DDL). This statement must be a single SQL statement. Depending on the authorization
    /// method, use one of the following combinations of request parameters: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
    /// cluster identifier that matches the cluster in the secret. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Temporary credentials - specify the cluster identifier, the database name, and the
    /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
    /// operation is required to use this method. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ExecuteStatementRequest : AmazonRedshiftDataAPIServiceRequest
    {
        private string _clusterIdentifier;
        private string _database;
        private string _dbUser;
        private List<SqlParameter> _parameters = new List<SqlParameter>();
        private string _secretArn;
        private string _sql;
        private string _statementName;
        private bool? _withEvent;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. This parameter is required when authenticating using either
        /// AWS Secrets Manager or temporary credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. This parameter is required when authenticating using temporary
        /// credentials.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. This parameter is required when authenticating using temporary
        /// credentials. 
        /// </para>
        /// </summary>
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the SQL statement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. This parameter
        /// is required when authenticating using AWS Secrets Manager. 
        /// </para>
        /// </summary>
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
        /// The SQL statement text to run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statement. You can name the SQL statement when you create it to
        /// identify the query. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatementName
        {
            get { return this._statementName; }
            set { this._statementName = value; }
        }

        // Check to see if StatementName property is set
        internal bool IsSetStatementName()
        {
            return this._statementName != null;
        }

        /// <summary>
        /// Gets and sets the property WithEvent. 
        /// <para>
        /// A value that indicates whether to send an event to the Amazon EventBridge event bus
        /// after the SQL statement runs. 
        /// </para>
        /// </summary>
        public bool WithEvent
        {
            get { return this._withEvent.GetValueOrDefault(); }
            set { this._withEvent = value; }
        }

        // Check to see if WithEvent property is set
        internal bool IsSetWithEvent()
        {
            return this._withEvent.HasValue; 
        }

    }
}
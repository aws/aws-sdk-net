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
    /// Container for the parameters to the ListTables operation.
    /// List the tables in a database. If neither <code>SchemaPattern</code> nor <code>TablePattern</code>
    /// are specified, then all tables in the database are returned. A token is returned to
    /// page through the table list. Depending on the authorization method, use one of the
    /// following combinations of request parameters: 
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
    public partial class ListTablesRequest : AmazonRedshiftDataAPIServiceRequest
    {
        private string _clusterIdentifier;
        private string _database;
        private string _dbUser;
        private int? _maxResults;
        private string _nextToken;
        private string _schemaPattern;
        private string _secretArn;
        private string _tablePattern;

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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tables to return in the response. If more tables exist than
        /// fit in one response, then <code>NextToken</code> is returned to page through the results.
        /// 
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaPattern. 
        /// <para>
        /// A pattern to filter results by schema name. Within a schema pattern, "%" means match
        /// any substring of 0 or more characters and "_" means match any one character. Only
        /// schema name entries matching the search pattern are returned. If <code>SchemaPattern</code>
        /// is not specified, then all tables that match <code>TablePattern</code> are returned.
        /// If neither <code>SchemaPattern</code> or <code>TablePattern</code> are specified,
        /// then all tables are returned. 
        /// </para>
        /// </summary>
        public string SchemaPattern
        {
            get { return this._schemaPattern; }
            set { this._schemaPattern = value; }
        }

        // Check to see if SchemaPattern property is set
        internal bool IsSetSchemaPattern()
        {
            return this._schemaPattern != null;
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
        /// Gets and sets the property TablePattern. 
        /// <para>
        /// A pattern to filter results by table name. Within a table pattern, "%" means match
        /// any substring of 0 or more characters and "_" means match any one character. Only
        /// table name entries matching the search pattern are returned. If <code>TablePattern</code>
        /// is not specified, then all tables that match <code>SchemaPattern</code>are returned.
        /// If neither <code>SchemaPattern</code> or <code>TablePattern</code> are specified,
        /// then all tables are returned. 
        /// </para>
        /// </summary>
        public string TablePattern
        {
            get { return this._tablePattern; }
            set { this._tablePattern = value; }
        }

        // Check to see if TablePattern property is set
        internal bool IsSetTablePattern()
        {
            return this._tablePattern != null;
        }

    }
}
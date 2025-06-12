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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// These are custom parameters to be used when the target is a Amazon Redshift cluster
    /// to invoke the Amazon Redshift Data API ExecuteStatement based on EventBridge events.
    /// </summary>
    public partial class RedshiftDataParameters
    {
        private string _database;
        private string _dbUser;
        private string _secretManagerArn;
        private string _sql;
        private List<string> _sqls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _statementName;
        private bool? _withEvent;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. Required when authenticating using temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// The database user name. Required when authenticating using temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property SecretManagerArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. Required when authenticating
        /// using Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string SecretManagerArn
        {
            get { return this._secretManagerArn; }
            set { this._secretManagerArn = value; }
        }

        // Check to see if SecretManagerArn property is set
        internal bool IsSetSecretManagerArn()
        {
            return this._secretManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Sql. 
        /// <para>
        /// The SQL statement text to run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100000)]
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
        /// Gets and sets the property Sqls. 
        /// <para>
        /// One or more SQL statements to run. The SQL statements are run as a single transaction.
        /// They run serially in the order of the array. Subsequent SQL statements don't start
        /// until the previous statement in the array completes. If any SQL statement fails, then
        /// because they are run as one transaction, all work is rolled back.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=40)]
        public List<string> Sqls
        {
            get { return this._sqls; }
            set { this._sqls = value; }
        }

        // Check to see if Sqls property is set
        internal bool IsSetSqls()
        {
            return this._sqls != null && (this._sqls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statement. You can name the SQL statement when you create it to
        /// identify the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Indicates whether to send an event back to EventBridge after the SQL statement runs.
        /// </para>
        /// </summary>
        public bool? WithEvent
        {
            get { return this._withEvent; }
            set { this._withEvent = value; }
        }

        // Check to see if WithEvent property is set
        internal bool IsSetWithEvent()
        {
            return this._withEvent.HasValue; 
        }

    }
}
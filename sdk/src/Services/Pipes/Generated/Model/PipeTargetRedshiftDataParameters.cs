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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// These are custom parameters to be used when the target is a Amazon Redshift cluster
    /// to invoke the Amazon Redshift Data API ExecuteStatement.
    /// </summary>
    public partial class PipeTargetRedshiftDataParameters
    {
        private string _database;
        private string _dbUser;
        private string _secretManagerArn;
        private List<string> _sqls = new List<string>();
        private string _statementName;
        private bool? _withEvent;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. Required when authenticating using temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
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
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// using SageMaker.
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
        /// Gets and sets the property Sqls. 
        /// <para>
        /// The SQL statement text to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Sqls
        {
            get { return this._sqls; }
            set { this._sqls = value; }
        }

        // Check to see if Sqls property is set
        internal bool IsSetSqls()
        {
            return this._sqls != null && this._sqls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statement. You can name the SQL statement when you create it to
        /// identify the query.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=500)]
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
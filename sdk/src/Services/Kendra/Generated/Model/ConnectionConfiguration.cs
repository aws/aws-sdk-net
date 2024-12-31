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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information that's required to connect to a database.
    /// </summary>
    public partial class ConnectionConfiguration
    {
        private string _databaseHost;
        private string _databaseName;
        private int? _databasePort;
        private string _secretArn;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property DatabaseHost. 
        /// <para>
        /// The name of the host for the database. Can be either a string (host.subdomain.domain.tld)
        /// or an IPv4 or IPv6 address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
        public string DatabaseHost
        {
            get { return this._databaseHost; }
            set { this._databaseHost = value; }
        }

        // Check to see if DatabaseHost property is set
        internal bool IsSetDatabaseHost()
        {
            return this._databaseHost != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database containing the document data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DatabasePort. 
        /// <para>
        /// The port that the database uses for connections.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? DatabasePort
        {
            get { return this._databasePort; }
            set { this._databasePort = value; }
        }

        // Check to see if DatabasePort property is set
        internal bool IsSetDatabasePort()
        {
            return this._databasePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that stores the credentials.
        /// The credentials should be a user-password pair. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-database.html">Using
        /// a Database Data Source</a>. For more information about Secrets Manager, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">
        /// What Is Secrets Manager</a> in the <i>Secrets Manager</i> user guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table that contains the document data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}
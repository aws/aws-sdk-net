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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information that's required to connect to a database.
    /// </summary>
    public partial class ConnectionConfiguration
    {
        /// <summary>
        /// Gets and sets the property DatabaseHost. 
        /// <para>
        /// The name of the host for the database. Can be either a string (host.subdomain.domain.tld)
        /// or an IPv4 or IPv6 address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string DatabaseHost { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseHost property is set.
        /// </summary>
        internal bool IsSetDatabaseHost() => this.DatabaseHost != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database containing the document data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DatabasePort. 
        /// <para>
        /// The port that the database uses for connections.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? DatabasePort { get; set; }

        /// <summary>
        /// Checks to see if the DatabasePort property is set.
        /// </summary>
        internal bool IsSetDatabasePort() => this.DatabasePort.HasValue;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that stores the credentials.
        /// The credentials should be a user-password pair. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-database.html">Using
        /// a Database Data Source</a>. For more information about Secrets Manager, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">
        /// What Is Secrets Manager</a> in the <i>Secrets Manager</i> user guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table that contains the document data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}

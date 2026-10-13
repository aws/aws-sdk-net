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
    /// Provides the configuration information to an <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-database.html">Amazon
    /// Kendra supported database</a>.
    /// </summary>
    public partial class DatabaseConfiguration
    {
        /// <summary>
        /// Gets and sets the property AclConfiguration. 
        /// <para>
        /// Information about the database column that provides information for user context filtering.
        /// </para>
        /// </summary>
        public AclConfiguration AclConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AclConfiguration property is set.
        /// </summary>
        internal bool IsSetAclConfiguration() => this.AclConfiguration != null;

        /// <summary>
        /// Gets and sets the property ColumnConfiguration. 
        /// <para>
        /// Information about where the index should get the document information from the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnConfiguration ColumnConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ColumnConfiguration property is set.
        /// </summary>
        internal bool IsSetColumnConfiguration() => this.ColumnConfiguration != null;

        /// <summary>
        /// Gets and sets the property ConnectionConfiguration. 
        /// <para>
        /// Configuration information that's required to connect to a database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionConfiguration ConnectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionConfiguration property is set.
        /// </summary>
        internal bool IsSetConnectionConfiguration() => this.ConnectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatabaseEngineType. 
        /// <para>
        /// The type of database engine that runs the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatabaseEngineType DatabaseEngineType { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseEngineType property is set.
        /// </summary>
        internal bool IsSetDatabaseEngineType() => this.DatabaseEngineType != null;

        /// <summary>
        /// Gets and sets the property SqlConfiguration. 
        /// <para>
        /// Provides information about how Amazon Kendra uses quote marks around SQL identifiers
        /// when querying a database data source.
        /// </para>
        /// </summary>
        public SqlConfiguration SqlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SqlConfiguration property is set.
        /// </summary>
        internal bool IsSetSqlConfiguration() => this.SqlConfiguration != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration.
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}

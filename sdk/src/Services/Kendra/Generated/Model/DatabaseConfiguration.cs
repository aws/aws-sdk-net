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
    /// Provides the configuration information to an <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-database.html">Amazon
    /// Kendra supported database</a>.
    /// </summary>
    public partial class DatabaseConfiguration
    {
        private AclConfiguration _aclConfiguration;
        private ColumnConfiguration _columnConfiguration;
        private ConnectionConfiguration _connectionConfiguration;
        private DatabaseEngineType _databaseEngineType;
        private SqlConfiguration _sqlConfiguration;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AclConfiguration. 
        /// <para>
        /// Information about the database column that provides information for user context filtering.
        /// </para>
        /// </summary>
        public AclConfiguration AclConfiguration
        {
            get { return this._aclConfiguration; }
            set { this._aclConfiguration = value; }
        }

        // Check to see if AclConfiguration property is set
        internal bool IsSetAclConfiguration()
        {
            return this._aclConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnConfiguration. 
        /// <para>
        /// Information about where the index should get the document information from the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnConfiguration ColumnConfiguration
        {
            get { return this._columnConfiguration; }
            set { this._columnConfiguration = value; }
        }

        // Check to see if ColumnConfiguration property is set
        internal bool IsSetColumnConfiguration()
        {
            return this._columnConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionConfiguration. 
        /// <para>
        /// Configuration information that's required to connect to a database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionConfiguration ConnectionConfiguration
        {
            get { return this._connectionConfiguration; }
            set { this._connectionConfiguration = value; }
        }

        // Check to see if ConnectionConfiguration property is set
        internal bool IsSetConnectionConfiguration()
        {
            return this._connectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseEngineType. 
        /// <para>
        /// The type of database engine that runs the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatabaseEngineType DatabaseEngineType
        {
            get { return this._databaseEngineType; }
            set { this._databaseEngineType = value; }
        }

        // Check to see if DatabaseEngineType property is set
        internal bool IsSetDatabaseEngineType()
        {
            return this._databaseEngineType != null;
        }

        /// <summary>
        /// Gets and sets the property SqlConfiguration. 
        /// <para>
        /// Provides information about how Amazon Kendra uses quote marks around SQL identifiers
        /// when querying a database data source.
        /// </para>
        /// </summary>
        public SqlConfiguration SqlConfiguration
        {
            get { return this._sqlConfiguration; }
            set { this._sqlConfiguration = value; }
        }

        // Check to see if SqlConfiguration property is set
        internal bool IsSetSqlConfiguration()
        {
            return this._sqlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration.
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}
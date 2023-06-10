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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the direct JDBC source connection.
    /// </summary>
    public partial class DirectJDBCSource
    {
        private string _connectionName;
        private JDBCConnectionType _connectionType;
        private string _database;
        private string _name;
        private string _redshiftTmpDir;
        private string _table;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The connection name of the JDBC source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The connection type of the JDBC source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JDBCConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database of the JDBC source connection.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the JDBC source connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftTmpDir. 
        /// <para>
        /// The temp directory of the JDBC Redshift source.
        /// </para>
        /// </summary>
        public string RedshiftTmpDir
        {
            get { return this._redshiftTmpDir; }
            set { this._redshiftTmpDir = value; }
        }

        // Check to see if RedshiftTmpDir property is set
        internal bool IsSetRedshiftTmpDir()
        {
            return this._redshiftTmpDir != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The table of the JDBC source connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}
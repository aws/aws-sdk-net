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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a connector to a JDBC data source.
    /// </summary>
    public partial class JDBCConnectorSource
    {
        private JDBCConnectorOptions _additionalOptions;
        private string _connectionName;
        private string _connectionTable;
        private string _connectionType;
        private string _connectorName;
        private string _name;
        private List<GlueSchema> _outputSchemas = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;
        private string _query;

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Additional connection options for the connector.
        /// </para>
        /// </summary>
        public JDBCConnectorOptions AdditionalOptions
        {
            get { return this._additionalOptions; }
            set { this._additionalOptions = value; }
        }

        // Check to see if AdditionalOptions property is set
        internal bool IsSetAdditionalOptions()
        {
            return this._additionalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection that is associated with the connector.
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
        /// Gets and sets the property ConnectionTable. 
        /// <para>
        /// The name of the table in the data source.
        /// </para>
        /// </summary>
        public string ConnectionTable
        {
            get { return this._connectionTable; }
            set { this._connectionTable = value; }
        }

        // Check to see if ConnectionTable property is set
        internal bool IsSetConnectionTable()
        {
            return this._connectionTable != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection, such as marketplace.jdbc or custom.jdbc, designating a connection
        /// to a JDBC data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionType
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
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The name of a connector that assists with accessing the data store in Glue Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorName
        {
            get { return this._connectorName; }
            set { this._connectorName = value; }
        }

        // Check to see if ConnectorName property is set
        internal bool IsSetConnectorName()
        {
            return this._connectorName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
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
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the custom JDBC source.
        /// </para>
        /// </summary>
        public List<GlueSchema> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && (this._outputSchemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The table or SQL query to get the data from. You can specify either <c>ConnectionTable</c>
        /// or <c>query</c>, but not both.
        /// </para>
        /// </summary>
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

    }
}
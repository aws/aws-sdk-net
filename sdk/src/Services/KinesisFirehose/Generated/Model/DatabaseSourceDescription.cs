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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The top level object for database source description. 
    /// 
    ///  
    /// <para>
    /// Amazon Data Firehose is in preview release and is subject to change.
    /// </para>
    /// </summary>
    public partial class DatabaseSourceDescription
    {
        private DatabaseColumnList _columns;
        private DatabaseList _databases;
        private DatabaseSourceAuthenticationConfiguration _databaseSourceAuthenticationConfiguration;
        private DatabaseSourceVPCConfiguration _databaseSourceVPCConfiguration;
        private string _endpoint;
        private int? _port;
        private List<DatabaseSnapshotInfo> _snapshotInfo = AWSConfigs.InitializeCollections ? new List<DatabaseSnapshotInfo>() : null;
        private string _snapshotWatermarkTable;
        private SSLMode _sslMode;
        private List<string> _surrogateKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DatabaseTableList _tables;
        private DatabaseType _type;

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        ///  The list of column patterns in source database endpoint for Firehose to read from.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseColumnList Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null;
        }

        /// <summary>
        /// Gets and sets the property Databases. 
        /// <para>
        ///  The list of database patterns in source database endpoint for Firehose to read from.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseList Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }

        // Check to see if Databases property is set
        internal bool IsSetDatabases()
        {
            return this._databases != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseSourceAuthenticationConfiguration. 
        /// <para>
        ///  The structure to configure the authentication methods for Firehose to connect to
        /// source database endpoint. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseSourceAuthenticationConfiguration DatabaseSourceAuthenticationConfiguration
        {
            get { return this._databaseSourceAuthenticationConfiguration; }
            set { this._databaseSourceAuthenticationConfiguration = value; }
        }

        // Check to see if DatabaseSourceAuthenticationConfiguration property is set
        internal bool IsSetDatabaseSourceAuthenticationConfiguration()
        {
            return this._databaseSourceAuthenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseSourceVPCConfiguration. 
        /// <para>
        ///  The details of the VPC Endpoint Service which Firehose uses to create a PrivateLink
        /// to the database. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseSourceVPCConfiguration DatabaseSourceVPCConfiguration
        {
            get { return this._databaseSourceVPCConfiguration; }
            set { this._databaseSourceVPCConfiguration = value; }
        }

        // Check to see if DatabaseSourceVPCConfiguration property is set
        internal bool IsSetDatabaseSourceVPCConfiguration()
        {
            return this._databaseSourceVPCConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        ///  The endpoint of the database server. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port of the database. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 3306 for MySQL database type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5432 for PostgreSQL database type
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotInfo. 
        /// <para>
        ///  The structure that describes the snapshot information of a table in source database
        /// endpoint that Firehose reads. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatabaseSnapshotInfo> SnapshotInfo
        {
            get { return this._snapshotInfo; }
            set { this._snapshotInfo = value; }
        }

        // Check to see if SnapshotInfo property is set
        internal bool IsSetSnapshotInfo()
        {
            return this._snapshotInfo != null && (this._snapshotInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnapshotWatermarkTable. 
        /// <para>
        ///  The fully qualified name of the table in source database endpoint that Firehose uses
        /// to track snapshot progress. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=129)]
        public string SnapshotWatermarkTable
        {
            get { return this._snapshotWatermarkTable; }
            set { this._snapshotWatermarkTable = value; }
        }

        // Check to see if SnapshotWatermarkTable property is set
        internal bool IsSetSnapshotWatermarkTable()
        {
            return this._snapshotWatermarkTable != null;
        }

        /// <summary>
        /// Gets and sets the property SSLMode. 
        /// <para>
        ///  The mode to enable or disable SSL when Firehose connects to the database endpoint.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public SSLMode SSLMode
        {
            get { return this._sslMode; }
            set { this._sslMode = value; }
        }

        // Check to see if SSLMode property is set
        internal bool IsSetSSLMode()
        {
            return this._sslMode != null;
        }

        /// <summary>
        /// Gets and sets the property SurrogateKeys. 
        /// <para>
        ///  The optional list of table and column names used as unique key columns when taking
        /// snapshot if the tables don’t have primary keys configured. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SurrogateKeys
        {
            get { return this._surrogateKeys; }
            set { this._surrogateKeys = value; }
        }

        // Check to see if SurrogateKeys property is set
        internal bool IsSetSurrogateKeys()
        {
            return this._surrogateKeys != null && (this._surrogateKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tables. 
        /// <para>
        ///  The list of table patterns in source database endpoint for Firehose to read from.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseTableList Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }

        // Check to see if Tables property is set
        internal bool IsSetTables()
        {
            return this._tables != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of database engine. This can be one of the following values. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// MySQL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PostgreSQL
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
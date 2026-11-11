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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The top level object for configuring streams with database as a source. 
    /// 
    ///  
    /// <para>
    /// Amazon Data Firehose is in preview release and is subject to change.
    /// </para>
    /// </summary>
    public partial class DatabaseSourceConfiguration
    {
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
        public DatabaseColumnList Columns { get; set; }

        /// <summary>
        /// Checks to see if the Columns property is set.
        /// </summary>
        internal bool IsSetColumns() => this.Columns != null;

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
        [AWSProperty(Required = true)]
        public DatabaseSourceAuthenticationConfiguration DatabaseSourceAuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseSourceAuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetDatabaseSourceAuthenticationConfiguration() => this.DatabaseSourceAuthenticationConfiguration != null;

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
        [AWSProperty(Required = true)]
        public DatabaseSourceVPCConfiguration DatabaseSourceVPCConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseSourceVPCConfiguration property is set.
        /// </summary>
        internal bool IsSetDatabaseSourceVPCConfiguration() => this.DatabaseSourceVPCConfiguration != null;

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
        [AWSProperty(Required = true)]
        public DatabaseList Databases { get; set; }

        /// <summary>
        /// Checks to see if the Databases property is set.
        /// </summary>
        internal bool IsSetDatabases() => this.Databases != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

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
        [AWSProperty(Required = true, Min = 0, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

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
        public SSLMode SSLMode { get; set; }

        /// <summary>
        /// Checks to see if the SSLMode property is set.
        /// </summary>
        internal bool IsSetSSLMode() => this.SSLMode != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 129)]
        public string SnapshotWatermarkTable { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotWatermarkTable property is set.
        /// </summary>
        internal bool IsSetSnapshotWatermarkTable() => this.SnapshotWatermarkTable != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SurrogateKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SurrogateKeys property is set.
        /// </summary>
        internal bool IsSetSurrogateKeys() => this.SurrogateKeys != null && (this.SurrogateKeys.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public DatabaseTableList Tables { get; set; }

        /// <summary>
        /// Checks to see if the Tables property is set.
        /// </summary>
        internal bool IsSetTables() => this.Tables != null;

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
        [AWSProperty(Required = true)]
        public DatabaseType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

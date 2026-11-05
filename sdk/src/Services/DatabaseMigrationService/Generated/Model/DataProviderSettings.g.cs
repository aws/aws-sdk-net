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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines a data provider.
    /// </summary>
    public partial class DataProviderSettings
    {
        /// <summary>
        /// Gets and sets the property DocDbSettings.
        /// </summary>
        public DocDbDataProviderSettings DocDbSettings { get; set; }

        /// <summary>
        /// Checks to see if the DocDbSettings property is set.
        /// </summary>
        internal bool IsSetDocDbSettings() => this.DocDbSettings != null;

        /// <summary>
        /// Gets and sets the property IbmDb2LuwSettings. 
        /// <para>
        /// Provides information that defines an IBM DB2 LUW data provider.
        /// </para>
        /// </summary>
        public IbmDb2LuwDataProviderSettings IbmDb2LuwSettings { get; set; }

        /// <summary>
        /// Checks to see if the IbmDb2LuwSettings property is set.
        /// </summary>
        internal bool IsSetIbmDb2LuwSettings() => this.IbmDb2LuwSettings != null;

        /// <summary>
        /// Gets and sets the property IbmDb2zOsSettings. 
        /// <para>
        /// Provides information that defines an IBM DB2 for z/OS data provider.
        /// </para>
        /// </summary>
        public IbmDb2zOsDataProviderSettings IbmDb2zOsSettings { get; set; }

        /// <summary>
        /// Checks to see if the IbmDb2zOsSettings property is set.
        /// </summary>
        internal bool IsSetIbmDb2zOsSettings() => this.IbmDb2zOsSettings != null;

        /// <summary>
        /// Gets and sets the property MariaDbSettings. 
        /// <para>
        /// Provides information that defines a MariaDB data provider.
        /// </para>
        /// </summary>
        public MariaDbDataProviderSettings MariaDbSettings { get; set; }

        /// <summary>
        /// Checks to see if the MariaDbSettings property is set.
        /// </summary>
        internal bool IsSetMariaDbSettings() => this.MariaDbSettings != null;

        /// <summary>
        /// Gets and sets the property MicrosoftSqlServerSettings.
        /// </summary>
        public MicrosoftSqlServerDataProviderSettings MicrosoftSqlServerSettings { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftSqlServerSettings property is set.
        /// </summary>
        internal bool IsSetMicrosoftSqlServerSettings() => this.MicrosoftSqlServerSettings != null;

        /// <summary>
        /// Gets and sets the property MongoDbSettings. 
        /// <para>
        /// Provides information that defines a MongoDB data provider.
        /// </para>
        /// </summary>
        public MongoDbDataProviderSettings MongoDbSettings { get; set; }

        /// <summary>
        /// Checks to see if the MongoDbSettings property is set.
        /// </summary>
        internal bool IsSetMongoDbSettings() => this.MongoDbSettings != null;

        /// <summary>
        /// Gets and sets the property MySqlSettings.
        /// </summary>
        public MySqlDataProviderSettings MySqlSettings { get; set; }

        /// <summary>
        /// Checks to see if the MySqlSettings property is set.
        /// </summary>
        internal bool IsSetMySqlSettings() => this.MySqlSettings != null;

        /// <summary>
        /// Gets and sets the property OracleSettings.
        /// </summary>
        public OracleDataProviderSettings OracleSettings { get; set; }

        /// <summary>
        /// Checks to see if the OracleSettings property is set.
        /// </summary>
        internal bool IsSetOracleSettings() => this.OracleSettings != null;

        /// <summary>
        /// Gets and sets the property PostgreSqlSettings.
        /// </summary>
        public PostgreSqlDataProviderSettings PostgreSqlSettings { get; set; }

        /// <summary>
        /// Checks to see if the PostgreSqlSettings property is set.
        /// </summary>
        internal bool IsSetPostgreSqlSettings() => this.PostgreSqlSettings != null;

        /// <summary>
        /// Gets and sets the property RedshiftSettings.
        /// </summary>
        public RedshiftDataProviderSettings RedshiftSettings { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftSettings property is set.
        /// </summary>
        internal bool IsSetRedshiftSettings() => this.RedshiftSettings != null;

        /// <summary>
        /// Gets and sets the property SybaseAseSettings.
        /// </summary>
        public SybaseAseDataProviderSettings SybaseAseSettings { get; set; }

        /// <summary>
        /// Checks to see if the SybaseAseSettings property is set.
        /// </summary>
        internal bool IsSetSybaseAseSettings() => this.SybaseAseSettings != null;
    }
}

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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
        private DocDbDataProviderSettings _docDbSettings;
        private IbmDb2LuwDataProviderSettings _ibmDb2LuwSettings;
        private IbmDb2zOsDataProviderSettings _ibmDb2zOsSettings;
        private MariaDbDataProviderSettings _mariaDbSettings;
        private MicrosoftSqlServerDataProviderSettings _microsoftSqlServerSettings;
        private MongoDbDataProviderSettings _mongoDbSettings;
        private MySqlDataProviderSettings _mySqlSettings;
        private OracleDataProviderSettings _oracleSettings;
        private PostgreSqlDataProviderSettings _postgreSqlSettings;
        private RedshiftDataProviderSettings _redshiftSettings;

        /// <summary>
        /// Gets and sets the property DocDbSettings.
        /// </summary>
        public DocDbDataProviderSettings DocDbSettings
        {
            get { return this._docDbSettings; }
            set { this._docDbSettings = value; }
        }

        // Check to see if DocDbSettings property is set
        internal bool IsSetDocDbSettings()
        {
            return this._docDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property IbmDb2LuwSettings. 
        /// <para>
        /// Provides information that defines an IBM DB2 LUW data provider.
        /// </para>
        /// </summary>
        public IbmDb2LuwDataProviderSettings IbmDb2LuwSettings
        {
            get { return this._ibmDb2LuwSettings; }
            set { this._ibmDb2LuwSettings = value; }
        }

        // Check to see if IbmDb2LuwSettings property is set
        internal bool IsSetIbmDb2LuwSettings()
        {
            return this._ibmDb2LuwSettings != null;
        }

        /// <summary>
        /// Gets and sets the property IbmDb2zOsSettings. 
        /// <para>
        /// Provides information that defines an IBM DB2 for z/OS data provider.
        /// </para>
        /// </summary>
        public IbmDb2zOsDataProviderSettings IbmDb2zOsSettings
        {
            get { return this._ibmDb2zOsSettings; }
            set { this._ibmDb2zOsSettings = value; }
        }

        // Check to see if IbmDb2zOsSettings property is set
        internal bool IsSetIbmDb2zOsSettings()
        {
            return this._ibmDb2zOsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MariaDbSettings. 
        /// <para>
        /// Provides information that defines a MariaDB data provider.
        /// </para>
        /// </summary>
        public MariaDbDataProviderSettings MariaDbSettings
        {
            get { return this._mariaDbSettings; }
            set { this._mariaDbSettings = value; }
        }

        // Check to see if MariaDbSettings property is set
        internal bool IsSetMariaDbSettings()
        {
            return this._mariaDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftSqlServerSettings.
        /// </summary>
        public MicrosoftSqlServerDataProviderSettings MicrosoftSqlServerSettings
        {
            get { return this._microsoftSqlServerSettings; }
            set { this._microsoftSqlServerSettings = value; }
        }

        // Check to see if MicrosoftSqlServerSettings property is set
        internal bool IsSetMicrosoftSqlServerSettings()
        {
            return this._microsoftSqlServerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MongoDbSettings. 
        /// <para>
        /// Provides information that defines a MongoDB data provider.
        /// </para>
        /// </summary>
        public MongoDbDataProviderSettings MongoDbSettings
        {
            get { return this._mongoDbSettings; }
            set { this._mongoDbSettings = value; }
        }

        // Check to see if MongoDbSettings property is set
        internal bool IsSetMongoDbSettings()
        {
            return this._mongoDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MySqlSettings.
        /// </summary>
        public MySqlDataProviderSettings MySqlSettings
        {
            get { return this._mySqlSettings; }
            set { this._mySqlSettings = value; }
        }

        // Check to see if MySqlSettings property is set
        internal bool IsSetMySqlSettings()
        {
            return this._mySqlSettings != null;
        }

        /// <summary>
        /// Gets and sets the property OracleSettings.
        /// </summary>
        public OracleDataProviderSettings OracleSettings
        {
            get { return this._oracleSettings; }
            set { this._oracleSettings = value; }
        }

        // Check to see if OracleSettings property is set
        internal bool IsSetOracleSettings()
        {
            return this._oracleSettings != null;
        }

        /// <summary>
        /// Gets and sets the property PostgreSqlSettings.
        /// </summary>
        public PostgreSqlDataProviderSettings PostgreSqlSettings
        {
            get { return this._postgreSqlSettings; }
            set { this._postgreSqlSettings = value; }
        }

        // Check to see if PostgreSqlSettings property is set
        internal bool IsSetPostgreSqlSettings()
        {
            return this._postgreSqlSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftSettings.
        /// </summary>
        public RedshiftDataProviderSettings RedshiftSettings
        {
            get { return this._redshiftSettings; }
            set { this._redshiftSettings = value; }
        }

        // Check to see if RedshiftSettings property is set
        internal bool IsSetRedshiftSettings()
        {
            return this._redshiftSettings != null;
        }

    }
}
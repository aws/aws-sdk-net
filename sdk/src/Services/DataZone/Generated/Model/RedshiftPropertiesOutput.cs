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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon Redshift properties.
    /// </summary>
    public partial class RedshiftPropertiesOutput
    {
        private RedshiftCredentials _credentials;
        private string _databaseName;
        private bool? _isProvisionedSecret;
        private string _jdbcIamUrl;
        private string _jdbcUrl;
        private RedshiftLineageSyncConfigurationOutput _lineageSync;
        private string _redshiftTempDir;
        private ConnectionStatus _status;
        private RedshiftStorageProperties _storage;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The Amazon Redshift credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RedshiftCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Amazon Redshift database name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsProvisionedSecret. 
        /// <para>
        /// Specifies whether Amaon Redshift properties has a provisioned secret.
        /// </para>
        /// </summary>
        public bool? IsProvisionedSecret
        {
            get { return this._isProvisionedSecret; }
            set { this._isProvisionedSecret = value; }
        }

        // Check to see if IsProvisionedSecret property is set
        internal bool IsSetIsProvisionedSecret()
        {
            return this._isProvisionedSecret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JdbcIamUrl. 
        /// <para>
        /// The jdbcIam URL of the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public string JdbcIamUrl
        {
            get { return this._jdbcIamUrl; }
            set { this._jdbcIamUrl = value; }
        }

        // Check to see if JdbcIamUrl property is set
        internal bool IsSetJdbcIamUrl()
        {
            return this._jdbcIamUrl != null;
        }

        /// <summary>
        /// Gets and sets the property JdbcUrl. 
        /// <para>
        /// The jdbcURL of the Amazon Redshift properties. 
        /// </para>
        /// </summary>
        public string JdbcUrl
        {
            get { return this._jdbcUrl; }
            set { this._jdbcUrl = value; }
        }

        // Check to see if JdbcUrl property is set
        internal bool IsSetJdbcUrl()
        {
            return this._jdbcUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage syn of the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public RedshiftLineageSyncConfigurationOutput LineageSync
        {
            get { return this._lineageSync; }
            set { this._lineageSync = value; }
        }

        // Check to see if LineageSync property is set
        internal bool IsSetLineageSync()
        {
            return this._lineageSync != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftTempDir. 
        /// <para>
        /// The redshiftTempDir of the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public string RedshiftTempDir
        {
            get { return this._redshiftTempDir; }
            set { this._redshiftTempDir = value; }
        }

        // Check to see if RedshiftTempDir property is set
        internal bool IsSetRedshiftTempDir()
        {
            return this._redshiftTempDir != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status in the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public ConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The storage in the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public RedshiftStorageProperties Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}
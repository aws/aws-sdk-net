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
    public partial class RedshiftPropertiesInput
    {
        private RedshiftCredentials _credentials;
        private string _databaseName;
        private string _host;
        private RedshiftLineageSyncConfigurationInput _lineageSync;
        private int? _port;
        private RedshiftStorageProperties _storage;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The Amaon Redshift credentials.
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
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property Host. 
        /// <para>
        /// The Amazon Redshift host.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage sync of the Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftLineageSyncConfigurationInput LineageSync
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The Amaon Redshift port.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Storage. 
        /// <para>
        /// The Amazon Redshift storage.
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
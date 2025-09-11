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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters for Snowflake.
    /// </summary>
    public partial class SnowflakeParameters
    {
        private AuthenticationType _authenticationType;
        private string _database;
        private string _databaseAccessControlRole;
        private string _host;
        private OAuthParameters _oAuthParameters;
        private string _warehouse;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type that you want to use for your connection. This parameter accepts
        /// OAuth and non-OAuth authentication types.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// Database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property DatabaseAccessControlRole. 
        /// <para>
        /// The database access control role.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DatabaseAccessControlRole
        {
            get { return this._databaseAccessControlRole; }
            set { this._databaseAccessControlRole = value; }
        }

        // Check to see if DatabaseAccessControlRole property is set
        internal bool IsSetDatabaseAccessControlRole()
        {
            return this._databaseAccessControlRole != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// Host.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property OAuthParameters. 
        /// <para>
        /// An object that contains information needed to create a data source connection between
        /// an QuickSight account and Snowflake.
        /// </para>
        /// </summary>
        public OAuthParameters OAuthParameters
        {
            get { return this._oAuthParameters; }
            set { this._oAuthParameters = value; }
        }

        // Check to see if OAuthParameters property is set
        internal bool IsSetOAuthParameters()
        {
            return this._oAuthParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Warehouse. 
        /// <para>
        /// Warehouse.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string Warehouse
        {
            get { return this._warehouse; }
            set { this._warehouse = value; }
        }

        // Check to see if Warehouse property is set
        internal bool IsSetWarehouse()
        {
            return this._warehouse != null;
        }

    }
}
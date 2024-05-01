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
    /// Describes a database in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class DatabaseShortInfoResponse
    {
        private string _databaseEngine;
        private string _databaseId;
        private string _databaseIpAddress;
        private string _databaseName;

        /// <summary>
        /// Gets and sets the property DatabaseEngine. 
        /// <para>
        /// The database engine of a database in a Fleet Advisor collector inventory, for example
        /// <c>PostgreSQL</c>.
        /// </para>
        /// </summary>
        public string DatabaseEngine
        {
            get { return this._databaseEngine; }
            set { this._databaseEngine = value; }
        }

        // Check to see if DatabaseEngine property is set
        internal bool IsSetDatabaseEngine()
        {
            return this._databaseEngine != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The ID of a database in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string DatabaseId
        {
            get { return this._databaseId; }
            set { this._databaseId = value; }
        }

        // Check to see if DatabaseId property is set
        internal bool IsSetDatabaseId()
        {
            return this._databaseId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseIpAddress. 
        /// <para>
        /// The IP address of a database in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string DatabaseIpAddress
        {
            get { return this._databaseIpAddress; }
            set { this._databaseIpAddress = value; }
        }

        // Check to see if DatabaseIpAddress property is set
        internal bool IsSetDatabaseIpAddress()
        {
            return this._databaseIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of a database in a Fleet Advisor collector inventory.
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

    }
}
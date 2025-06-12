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
    public partial class DatabaseResponse
    {
        private List<CollectorShortInfoResponse> _collectors = AWSConfigs.InitializeCollections ? new List<CollectorShortInfoResponse>() : null;
        private string _databaseId;
        private string _databaseName;
        private string _ipAddress;
        private long? _numberOfSchemas;
        private ServerShortInfoResponse _server;
        private DatabaseInstanceSoftwareDetailsResponse _softwareDetails;

        /// <summary>
        /// Gets and sets the property Collectors. 
        /// <para>
        /// A list of collectors associated with the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CollectorShortInfoResponse> Collectors
        {
            get { return this._collectors; }
            set { this._collectors = value; }
        }

        // Check to see if Collectors property is set
        internal bool IsSetCollectors()
        {
            return this._collectors != null && (this._collectors.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of a database in a Fleet Advisor collector inventory. 
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfSchemas. 
        /// <para>
        /// The number of schemas in a Fleet Advisor collector inventory database. 
        /// </para>
        /// </summary>
        public long? NumberOfSchemas
        {
            get { return this._numberOfSchemas; }
            set { this._numberOfSchemas = value; }
        }

        // Check to see if NumberOfSchemas property is set
        internal bool IsSetNumberOfSchemas()
        {
            return this._numberOfSchemas.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        /// The server name of a database in a Fleet Advisor collector inventory. 
        /// </para>
        /// </summary>
        public ServerShortInfoResponse Server
        {
            get { return this._server; }
            set { this._server = value; }
        }

        // Check to see if Server property is set
        internal bool IsSetServer()
        {
            return this._server != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareDetails. 
        /// <para>
        /// The software details of a database in a Fleet Advisor collector inventory, such as
        /// database engine and version.
        /// </para>
        /// </summary>
        public DatabaseInstanceSoftwareDetailsResponse SoftwareDetails
        {
            get { return this._softwareDetails; }
            set { this._softwareDetails = value; }
        }

        // Check to see if SoftwareDetails property is set
        internal bool IsSetSoftwareDetails()
        {
            return this._softwareDetails != null;
        }

    }
}
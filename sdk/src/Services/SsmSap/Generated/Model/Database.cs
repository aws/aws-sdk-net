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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// The SAP HANA database of the application registered with AWS Systems Manager for SAP.
    /// </summary>
    public partial class Database
    {
        private string _applicationId;
        private string _arn;
        private string _componentId;
        private List<string> _connectedComponentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ApplicationCredential> _credentials = AWSConfigs.InitializeCollections ? new List<ApplicationCredential>() : null;
        private string _databaseId;
        private string _databaseName;
        private DatabaseType _databaseType;
        private DateTime? _lastUpdated;
        private string _primaryHost;
        private int? _sqlPort;
        private DatabaseStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedComponentArns. 
        /// <para>
        /// The Amazon Resource Names of the connected AWS Systems Manager for SAP components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectedComponentArns
        {
            get { return this._connectedComponentArns; }
            set { this._connectedComponentArns = value; }
        }

        // Check to see if ConnectedComponentArns property is set
        internal bool IsSetConnectedComponentArns()
        {
            return this._connectedComponentArns != null && (this._connectedComponentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials of the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ApplicationCredential> Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null && (this._credentials.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The ID of the SAP HANA database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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
        /// The name of the database.
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
        /// Gets and sets the property DatabaseType. 
        /// <para>
        /// The type of the database.
        /// </para>
        /// </summary>
        public DatabaseType DatabaseType
        {
            get { return this._databaseType; }
            set { this._databaseType = value; }
        }

        // Check to see if DatabaseType property is set
        internal bool IsSetDatabaseType()
        {
            return this._databaseType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time at which the database was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryHost. 
        /// <para>
        /// The primary host of the database.
        /// </para>
        /// </summary>
        public string PrimaryHost
        {
            get { return this._primaryHost; }
            set { this._primaryHost = value; }
        }

        // Check to see if PrimaryHost property is set
        internal bool IsSetPrimaryHost()
        {
            return this._primaryHost != null;
        }

        /// <summary>
        /// Gets and sets the property SQLPort. 
        /// <para>
        /// The SQL port of the database.
        /// </para>
        /// </summary>
        public int? SQLPort
        {
            get { return this._sqlPort; }
            set { this._sqlPort = value; }
        }

        // Check to see if SQLPort property is set
        internal bool IsSetSQLPort()
        {
            return this._sqlPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the database.
        /// </para>
        /// </summary>
        public DatabaseStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The <c>Database</c> object represents a logical grouping of tables that might reside
    /// in a Hive metastore or an RDBMS.
    /// </summary>
    public partial class Database
    {
        private string _catalogId;
        private List<PrincipalPermissions> _createTableDefaultPermissions = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;
        private DateTime? _createTime;
        private string _description;
        private FederatedDatabase _federatedDatabase;
        private string _locationUri;
        private string _name;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DatabaseIdentifier _targetDatabase;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the database resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// Creates a set of default permissions on the table for principals. Used by Lake Formation.
        /// Not used in the normal course of Glue operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions
        {
            get { return this._createTableDefaultPermissions; }
            set { this._createTableDefaultPermissions = value; }
        }

        // Check to see if CreateTableDefaultPermissions property is set
        internal bool IsSetCreateTableDefaultPermissions()
        {
            return this._createTableDefaultPermissions != null && (this._createTableDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the metadata database was created in the catalog.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FederatedDatabase. 
        /// <para>
        /// A <c>FederatedDatabase</c> structure that references an entity outside the Glue Data
        /// Catalog.
        /// </para>
        /// </summary>
        public FederatedDatabase FederatedDatabase
        {
            get { return this._federatedDatabase; }
            set { this._federatedDatabase = value; }
        }

        // Check to see if FederatedDatabase property is set
        internal bool IsSetFederatedDatabase()
        {
            return this._federatedDatabase != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The location of the database (for example, an HDFS path).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the database. For Hive compatibility, this is folded to lowercase when
        /// it is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// These key-value pairs define parameters and properties of the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetDatabase. 
        /// <para>
        /// A <c>DatabaseIdentifier</c> structure that describes a target database for resource
        /// linking.
        /// </para>
        /// </summary>
        public DatabaseIdentifier TargetDatabase
        {
            get { return this._targetDatabase; }
            set { this._targetDatabase = value; }
        }

        // Check to see if TargetDatabase property is set
        internal bool IsSetTargetDatabase()
        {
            return this._targetDatabase != null;
        }

    }
}
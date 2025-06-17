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
    /// Container for the parameters to the CreateDataProvider operation.
    /// Creates a data provider using the provided settings. A data provider stores a data
    /// store type and location information about your database.
    /// </summary>
    public partial class CreateDataProviderRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _dataProviderName;
        private string _description;
        private string _engine;
        private DataProviderSettings _settings;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _virtual;

        /// <summary>
        /// Gets and sets the property DataProviderName. 
        /// <para>
        /// A user-friendly name for the data provider.
        /// </para>
        /// </summary>
        public string DataProviderName
        {
            get { return this._dataProviderName; }
            set { this._dataProviderName = value; }
        }

        // Check to see if DataProviderName property is set
        internal bool IsSetDataProviderName()
        {
            return this._dataProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-friendly description of the data provider.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The type of database engine for the data provider. Valid values include <c>"aurora"</c>,
        /// <c>"aurora-postgresql"</c>, <c>"mysql"</c>, <c>"oracle"</c>, <c>"postgres"</c>, <c>"sqlserver"</c>,
        /// <c>redshift</c>, <c>mariadb</c>, <c>mongodb</c>, <c>db2</c>, <c>db2-zos</c> and <c>docdb</c>.
        /// A value of <c>"aurora"</c> represents Amazon Aurora MySQL-Compatible Edition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings in JSON format for a data provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataProviderSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the data provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Virtual. 
        /// <para>
        /// Indicates whether the data provider is virtual.
        /// </para>
        /// </summary>
        public bool? Virtual
        {
            get { return this._virtual; }
            set { this._virtual = value; }
        }

        // Check to see if Virtual property is set
        internal bool IsSetVirtual()
        {
            return this._virtual.HasValue; 
        }

    }
}
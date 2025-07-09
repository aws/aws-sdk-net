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
    public partial class DataProvider
    {
        private string _dataProviderArn;
        private DateTime? _dataProviderCreationTime;
        private string _dataProviderName;
        private string _description;
        private string _engine;
        private DataProviderSettings _settings;
        private bool? _virtual;

        /// <summary>
        /// Gets and sets the property DataProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the data provider.
        /// </para>
        /// </summary>
        public string DataProviderArn
        {
            get { return this._dataProviderArn; }
            set { this._dataProviderArn = value; }
        }

        // Check to see if DataProviderArn property is set
        internal bool IsSetDataProviderArn()
        {
            return this._dataProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataProviderCreationTime. 
        /// <para>
        /// The time the data provider was created.
        /// </para>
        /// </summary>
        public DateTime? DataProviderCreationTime
        {
            get { return this._dataProviderCreationTime; }
            set { this._dataProviderCreationTime = value; }
        }

        // Check to see if DataProviderCreationTime property is set
        internal bool IsSetDataProviderCreationTime()
        {
            return this._dataProviderCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataProviderName. 
        /// <para>
        /// The name of the data provider.
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
        /// A description of the data provider. Descriptions can have up to 31 characters. A description
        /// can contain only ASCII letters, digits, and hyphens ('-'). Also, it can't end with
        /// a hyphen or contain two consecutive hyphens, and can only begin with a letter.
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
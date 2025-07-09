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
    /// Container for the parameters to the ModifyDataProvider operation.
    /// Modifies the specified data provider using the provided settings.
    /// 
    ///  <note> 
    /// <para>
    /// You must remove the data provider from all migration projects before you can modify
    /// it.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyDataProviderRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _dataProviderIdentifier;
        private string _dataProviderName;
        private string _description;
        private string _engine;
        private bool? _exactSettings;
        private DataProviderSettings _settings;
        private bool? _virtual;

        /// <summary>
        /// Gets and sets the property DataProviderIdentifier. 
        /// <para>
        /// The identifier of the data provider. Identifiers must begin with a letter and must
        /// contain only ASCII letters, digits, and hyphens. They can't end with a hyphen, or
        /// contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataProviderIdentifier
        {
            get { return this._dataProviderIdentifier; }
            set { this._dataProviderIdentifier = value; }
        }

        // Check to see if DataProviderIdentifier property is set
        internal bool IsSetDataProviderIdentifier()
        {
            return this._dataProviderIdentifier != null;
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
        /// Gets and sets the property ExactSettings. 
        /// <para>
        /// If this attribute is Y, the current call to <c>ModifyDataProvider</c> replaces all
        /// existing data provider settings with the exact settings that you specify in this call.
        /// If this attribute is N, the current call to <c>ModifyDataProvider</c> does two things:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It replaces any data provider settings that already exist with new values, for settings
        /// with the same names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It creates new data provider settings that you specify in the call, for settings with
        /// different names. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ExactSettings
        {
            get { return this._exactSettings; }
            set { this._exactSettings = value; }
        }

        // Check to see if ExactSettings property is set
        internal bool IsSetExactSettings()
        {
            return this._exactSettings.HasValue; 
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
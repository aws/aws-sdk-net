/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// This data type is used as a response element in the action <a>DescribeDBEngineVersions</a>.
    /// </summary>
    public partial class DBEngineVersion
    {
        private string _dbEngineDescription;
        private string _dbEngineVersionDescription;
        private string _dbParameterGroupFamily;
        private CharacterSet _defaultCharacterSet;
        private string _engine;
        private string _engineVersion;
        private List<string> _exportableLogTypes = new List<string>();
        private List<CharacterSet> _supportedCharacterSets = new List<CharacterSet>();
        private List<Timezone> _supportedTimezones = new List<Timezone>();
        private bool? _supportsLogExportsToCloudwatchLogs;
        private bool? _supportsReadReplica;
        private List<UpgradeTarget> _validUpgradeTarget = new List<UpgradeTarget>();

        /// <summary>
        /// Gets and sets the property DBEngineDescription. 
        /// <para>
        /// The description of the database engine.
        /// </para>
        /// </summary>
        public string DBEngineDescription
        {
            get { return this._dbEngineDescription; }
            set { this._dbEngineDescription = value; }
        }

        // Check to see if DBEngineDescription property is set
        internal bool IsSetDBEngineDescription()
        {
            return this._dbEngineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBEngineVersionDescription. 
        /// <para>
        /// The description of the database engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionDescription
        {
            get { return this._dbEngineVersionDescription; }
            set { this._dbEngineVersionDescription = value; }
        }

        // Check to see if DBEngineVersionDescription property is set
        internal bool IsSetDBEngineVersionDescription()
        {
            return this._dbEngineVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the DB parameter group family for the database engine.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this._dbParameterGroupFamily; }
            set { this._dbParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dbParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCharacterSet. 
        /// <para>
        ///  The default character set for new instances of this engine version, if the <code>CharacterSetName</code>
        /// parameter of the CreateDBInstance API is not specified. 
        /// </para>
        /// </summary>
        public CharacterSet DefaultCharacterSet
        {
            get { return this._defaultCharacterSet; }
            set { this._defaultCharacterSet = value; }
        }

        // Check to see if DefaultCharacterSet property is set
        internal bool IsSetDefaultCharacterSet()
        {
            return this._defaultCharacterSet != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExportableLogTypes. 
        /// <para>
        /// The types of logs that the database engine has available for export to CloudWatch
        /// Logs.
        /// </para>
        /// </summary>
        public List<string> ExportableLogTypes
        {
            get { return this._exportableLogTypes; }
            set { this._exportableLogTypes = value; }
        }

        // Check to see if ExportableLogTypes property is set
        internal bool IsSetExportableLogTypes()
        {
            return this._exportableLogTypes != null && this._exportableLogTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedCharacterSets. 
        /// <para>
        ///  A list of the character sets supported by this engine for the <code>CharacterSetName</code>
        /// parameter of the <code>CreateDBInstance</code> action. 
        /// </para>
        /// </summary>
        public List<CharacterSet> SupportedCharacterSets
        {
            get { return this._supportedCharacterSets; }
            set { this._supportedCharacterSets = value; }
        }

        // Check to see if SupportedCharacterSets property is set
        internal bool IsSetSupportedCharacterSets()
        {
            return this._supportedCharacterSets != null && this._supportedCharacterSets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedTimezones. 
        /// <para>
        /// A list of the time zones supported by this engine for the <code>Timezone</code> parameter
        /// of the <code>CreateDBInstance</code> action. 
        /// </para>
        /// </summary>
        public List<Timezone> SupportedTimezones
        {
            get { return this._supportedTimezones; }
            set { this._supportedTimezones = value; }
        }

        // Check to see if SupportedTimezones property is set
        internal bool IsSetSupportedTimezones()
        {
            return this._supportedTimezones != null && this._supportedTimezones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLogExportsToCloudwatchLogs. 
        /// <para>
        /// A value that indicates whether the engine version supports exporting the log types
        /// specified by ExportableLogTypes to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool SupportsLogExportsToCloudwatchLogs
        {
            get { return this._supportsLogExportsToCloudwatchLogs.GetValueOrDefault(); }
            set { this._supportsLogExportsToCloudwatchLogs = value; }
        }

        // Check to see if SupportsLogExportsToCloudwatchLogs property is set
        internal bool IsSetSupportsLogExportsToCloudwatchLogs()
        {
            return this._supportsLogExportsToCloudwatchLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsReadReplica. 
        /// <para>
        /// Indicates whether the database engine version supports read replicas.
        /// </para>
        /// </summary>
        public bool SupportsReadReplica
        {
            get { return this._supportsReadReplica.GetValueOrDefault(); }
            set { this._supportsReadReplica = value; }
        }

        // Check to see if SupportsReadReplica property is set
        internal bool IsSetSupportsReadReplica()
        {
            return this._supportsReadReplica.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUpgradeTarget. 
        /// <para>
        /// A list of engine versions that this database engine version can be upgraded to.
        /// </para>
        /// </summary>
        public List<UpgradeTarget> ValidUpgradeTarget
        {
            get { return this._validUpgradeTarget; }
            set { this._validUpgradeTarget = value; }
        }

        // Check to see if ValidUpgradeTarget property is set
        internal bool IsSetValidUpgradeTarget()
        {
            return this._validUpgradeTarget != null && this._validUpgradeTarget.Count > 0; 
        }

    }
}
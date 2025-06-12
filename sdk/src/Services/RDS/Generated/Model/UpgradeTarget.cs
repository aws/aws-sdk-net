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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The version of the database engine that a DB instance can be upgraded to.
    /// </summary>
    public partial class UpgradeTarget
    {
        private bool? _autoUpgrade;
        private string _description;
        private string _engine;
        private string _engineVersion;
        private bool? _isMajorVersionUpgrade;
        private List<string> _supportedEngineModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _supportsBabelfish;
        private bool? _supportsGlobalDatabases;
        private bool? _supportsIntegrations;
        private bool? _supportsLimitlessDatabase;
        private bool? _supportsLocalWriteForwarding;
        private bool? _supportsParallelQuery;

        /// <summary>
        /// Gets and sets the property AutoUpgrade. 
        /// <para>
        /// Indicates whether the target version is applied to any source DB instances that have
        /// <c>AutoMinorVersionUpgrade</c> set to true.
        /// </para>
        ///  
        /// <para>
        /// This parameter is dynamic, and is set by RDS.
        /// </para>
        /// </summary>
        public bool? AutoUpgrade
        {
            get { return this._autoUpgrade; }
            set { this._autoUpgrade = value; }
        }

        // Check to see if AutoUpgrade property is set
        internal bool IsSetAutoUpgrade()
        {
            return this._autoUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The version of the database engine that a DB instance can be upgraded to.
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
        /// The name of the upgrade target database engine.
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
        /// The version number of the upgrade target database engine.
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
        /// Gets and sets the property IsMajorVersionUpgrade. 
        /// <para>
        /// Indicates whether upgrading to the target version requires upgrading the major version
        /// of the database engine.
        /// </para>
        /// </summary>
        public bool? IsMajorVersionUpgrade
        {
            get { return this._isMajorVersionUpgrade; }
            set { this._isMajorVersionUpgrade = value; }
        }

        // Check to see if IsMajorVersionUpgrade property is set
        internal bool IsSetIsMajorVersionUpgrade()
        {
            return this._isMajorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedEngineModes. 
        /// <para>
        /// A list of the supported DB engine modes for the target engine version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineModes
        {
            get { return this._supportedEngineModes; }
            set { this._supportedEngineModes = value; }
        }

        // Check to see if SupportedEngineModes property is set
        internal bool IsSetSupportedEngineModes()
        {
            return this._supportedEngineModes != null && (this._supportedEngineModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsBabelfish. 
        /// <para>
        /// Indicates whether you can use Babelfish for Aurora PostgreSQL with the target engine
        /// version.
        /// </para>
        /// </summary>
        public bool? SupportsBabelfish
        {
            get { return this._supportsBabelfish; }
            set { this._supportsBabelfish = value; }
        }

        // Check to see if SupportsBabelfish property is set
        internal bool IsSetSupportsBabelfish()
        {
            return this._supportsBabelfish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// Indicates whether you can use Aurora global databases with the target engine version.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases
        {
            get { return this._supportsGlobalDatabases; }
            set { this._supportsGlobalDatabases = value; }
        }

        // Check to see if SupportsGlobalDatabases property is set
        internal bool IsSetSupportsGlobalDatabases()
        {
            return this._supportsGlobalDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsIntegrations. 
        /// <para>
        /// Indicates whether the DB engine version supports zero-ETL integrations with Amazon
        /// Redshift.
        /// </para>
        /// </summary>
        public bool? SupportsIntegrations
        {
            get { return this._supportsIntegrations; }
            set { this._supportsIntegrations = value; }
        }

        // Check to see if SupportsIntegrations property is set
        internal bool IsSetSupportsIntegrations()
        {
            return this._supportsIntegrations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLimitlessDatabase. 
        /// <para>
        /// Indicates whether the DB engine version supports Aurora Limitless Database.
        /// </para>
        /// </summary>
        public bool? SupportsLimitlessDatabase
        {
            get { return this._supportsLimitlessDatabase; }
            set { this._supportsLimitlessDatabase = value; }
        }

        // Check to see if SupportsLimitlessDatabase property is set
        internal bool IsSetSupportsLimitlessDatabase()
        {
            return this._supportsLimitlessDatabase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLocalWriteForwarding. 
        /// <para>
        /// Indicates whether the target engine version supports forwarding write operations from
        /// reader DB instances to the writer DB instance in the DB cluster. By default, write
        /// operations aren't allowed on reader DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? SupportsLocalWriteForwarding
        {
            get { return this._supportsLocalWriteForwarding; }
            set { this._supportsLocalWriteForwarding = value; }
        }

        // Check to see if SupportsLocalWriteForwarding property is set
        internal bool IsSetSupportsLocalWriteForwarding()
        {
            return this._supportsLocalWriteForwarding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsParallelQuery. 
        /// <para>
        /// Indicates whether you can use Aurora parallel query with the target engine version.
        /// </para>
        /// </summary>
        public bool? SupportsParallelQuery
        {
            get { return this._supportsParallelQuery; }
            set { this._supportsParallelQuery = value; }
        }

        // Check to see if SupportsParallelQuery property is set
        internal bool IsSetSupportsParallelQuery()
        {
            return this._supportsParallelQuery.HasValue; 
        }

    }
}
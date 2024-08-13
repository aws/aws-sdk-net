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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
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
        private bool? _supportsGlobalDatabases;

        /// <summary>
        /// Gets and sets the property AutoUpgrade. 
        /// <para>
        /// A value that indicates whether the target version is applied to any source DB instances
        /// that have AutoMinorVersionUpgrade set to true.
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
        /// A value that indicates whether a database engine is upgraded to a major version.
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
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// A value that indicates whether you can use Neptune global databases with the target
        /// engine version.
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

    }
}
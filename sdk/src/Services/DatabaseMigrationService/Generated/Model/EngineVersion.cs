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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about a replication instance version.
    /// </summary>
    public partial class EngineVersion
    {
        private DateTime? _autoUpgradeDate;
        private List<string> _availableUpgrades = new List<string>();
        private DateTime? _deprecationDate;
        private DateTime? _forceUpgradeDate;
        private DateTime? _launchDate;
        private string _lifecycle;
        private ReleaseStatusValues _releaseStatus;
        private string _version;

        /// <summary>
        /// Gets and sets the property AutoUpgradeDate. 
        /// <para>
        /// The date when the replication instance will be automatically upgraded. This setting
        /// only applies if the <code>auto-minor-version</code> setting is enabled.
        /// </para>
        /// </summary>
        public DateTime AutoUpgradeDate
        {
            get { return this._autoUpgradeDate.GetValueOrDefault(); }
            set { this._autoUpgradeDate = value; }
        }

        // Check to see if AutoUpgradeDate property is set
        internal bool IsSetAutoUpgradeDate()
        {
            return this._autoUpgradeDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableUpgrades. 
        /// <para>
        /// The list of valid replication instance versions that you can upgrade to.
        /// </para>
        /// </summary>
        public List<string> AvailableUpgrades
        {
            get { return this._availableUpgrades; }
            set { this._availableUpgrades = value; }
        }

        // Check to see if AvailableUpgrades property is set
        internal bool IsSetAvailableUpgrades()
        {
            return this._availableUpgrades != null && this._availableUpgrades.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// The date when the replication instance version will be deprecated and can no longer
        /// be requested.
        /// </para>
        /// </summary>
        public DateTime DeprecationDate
        {
            get { return this._deprecationDate.GetValueOrDefault(); }
            set { this._deprecationDate = value; }
        }

        // Check to see if DeprecationDate property is set
        internal bool IsSetDeprecationDate()
        {
            return this._deprecationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceUpgradeDate. 
        /// <para>
        /// The date when the replication instance will have a version upgrade forced.
        /// </para>
        /// </summary>
        public DateTime ForceUpgradeDate
        {
            get { return this._forceUpgradeDate.GetValueOrDefault(); }
            set { this._forceUpgradeDate = value; }
        }

        // Check to see if ForceUpgradeDate property is set
        internal bool IsSetForceUpgradeDate()
        {
            return this._forceUpgradeDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchDate. 
        /// <para>
        /// The date when the replication instance version became publicly available.
        /// </para>
        /// </summary>
        public DateTime LaunchDate
        {
            get { return this._launchDate.GetValueOrDefault(); }
            set { this._launchDate = value; }
        }

        // Check to see if LaunchDate property is set
        internal bool IsSetLaunchDate()
        {
            return this._launchDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the replication instance version. Valid values are <code>DEPRECATED</code>,
        /// <code>DEFAULT_VERSION</code>, and <code>ACTIVE</code>.
        /// </para>
        /// </summary>
        public string Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseStatus. 
        /// <para>
        /// The release status of the replication instance version.
        /// </para>
        /// </summary>
        public ReleaseStatusValues ReleaseStatus
        {
            get { return this._releaseStatus; }
            set { this._releaseStatus = value; }
        }

        // Check to see if ReleaseStatus property is set
        internal bool IsSetReleaseStatus()
        {
            return this._releaseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the replication instance.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}
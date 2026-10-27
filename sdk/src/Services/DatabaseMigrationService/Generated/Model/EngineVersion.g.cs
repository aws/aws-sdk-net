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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides information about a replication instance version.
    /// </summary>
    public partial class EngineVersion
    {
        /// <summary>
        /// Gets and sets the property AutoUpgradeDate. 
        /// <para>
        /// The date when the replication instance will be automatically upgraded. This setting
        /// only applies if the <c>auto-minor-version</c> setting is enabled.
        /// </para>
        /// </summary>
        public DateTime? AutoUpgradeDate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpgradeDate property is set.
        /// </summary>
        internal bool IsSetAutoUpgradeDate() => this.AutoUpgradeDate.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableUpgrades. 
        /// <para>
        /// The list of valid replication instance versions that you can upgrade to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailableUpgrades { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailableUpgrades property is set.
        /// </summary>
        internal bool IsSetAvailableUpgrades() => this.AvailableUpgrades != null && (this.AvailableUpgrades.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// The date when the replication instance version will be deprecated and can no longer
        /// be requested.
        /// </para>
        /// </summary>
        public DateTime? DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ForceUpgradeDate. 
        /// <para>
        /// The date when the replication instance will have a version upgrade forced.
        /// </para>
        /// </summary>
        public DateTime? ForceUpgradeDate { get; set; }

        /// <summary>
        /// Checks to see if the ForceUpgradeDate property is set.
        /// </summary>
        internal bool IsSetForceUpgradeDate() => this.ForceUpgradeDate.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchDate. 
        /// <para>
        /// The date when the replication instance version became publicly available.
        /// </para>
        /// </summary>
        public DateTime? LaunchDate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchDate property is set.
        /// </summary>
        internal bool IsSetLaunchDate() => this.LaunchDate.HasValue;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the replication instance version. Valid values are <c>DEPRECATED</c>,
        /// <c>DEFAULT_VERSION</c>, and <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        public string Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property ReleaseStatus. 
        /// <para>
        /// The release status of the replication instance version.
        /// </para>
        /// </summary>
        public ReleaseStatusValues ReleaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseStatus property is set.
        /// </summary>
        internal bool IsSetReleaseStatus() => this.ReleaseStatus != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the replication instance.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}

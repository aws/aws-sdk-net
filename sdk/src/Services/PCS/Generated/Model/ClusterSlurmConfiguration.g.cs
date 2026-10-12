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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// Additional options related to the Slurm scheduler.
    /// </summary>
    public partial class ClusterSlurmConfiguration
    {
        /// <summary>
        /// Gets and sets the property Accounting. 
        /// <para>
        /// The accounting configuration includes configurable settings for Slurm accounting.
        /// </para>
        /// </summary>
        public Accounting Accounting { get; set; }

        /// <summary>
        /// Checks to see if the Accounting property is set.
        /// </summary>
        internal bool IsSetAccounting() => this.Accounting != null;

        /// <summary>
        /// Gets and sets the property AuthKey. 
        /// <para>
        /// The shared Slurm key for authentication, also known as the <b>cluster secret</b>.
        /// </para>
        /// </summary>
        public SlurmAuthKey AuthKey { get; set; }

        /// <summary>
        /// Checks to see if the AuthKey property is set.
        /// </summary>
        internal bool IsSetAuthKey() => this.AuthKey != null;

        /// <summary>
        /// Gets and sets the property CgroupCustomSettings. 
        /// <para>
        /// Additional Cgroup-specific configuration that directly maps to Cgroup settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CgroupCustomSetting> CgroupCustomSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<CgroupCustomSetting>() : null;

        /// <summary>
        /// Checks to see if the CgroupCustomSettings property is set.
        /// </summary>
        internal bool IsSetCgroupCustomSettings() => this.CgroupCustomSettings != null && (this.CgroupCustomSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JwtAuth. 
        /// <para>
        /// The JWT authentication configuration for Slurm REST API access.
        /// </para>
        /// </summary>
        public JwtAuth JwtAuth { get; set; }

        /// <summary>
        /// Checks to see if the JwtAuth property is set.
        /// </summary>
        internal bool IsSetJwtAuth() => this.JwtAuth != null;

        /// <summary>
        /// Gets and sets the property ScaleDownIdleTimeInSeconds. 
        /// <para>
        /// The time (in seconds) before an idle node is scaled down.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>600</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000000)]
        public int? ScaleDownIdleTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ScaleDownIdleTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetScaleDownIdleTimeInSeconds() => this.ScaleDownIdleTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SlurmCustomSettings. 
        /// <para>
        /// Additional Slurm-specific configuration that directly maps to Slurm settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SlurmCustomSetting> SlurmCustomSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<SlurmCustomSetting>() : null;

        /// <summary>
        /// Checks to see if the SlurmCustomSettings property is set.
        /// </summary>
        internal bool IsSetSlurmCustomSettings() => this.SlurmCustomSettings != null && (this.SlurmCustomSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SlurmRest. 
        /// <para>
        /// The Slurm REST API configuration for the cluster.
        /// </para>
        /// </summary>
        public SlurmRest SlurmRest { get; set; }

        /// <summary>
        /// Checks to see if the SlurmRest property is set.
        /// </summary>
        internal bool IsSetSlurmRest() => this.SlurmRest != null;

        /// <summary>
        /// Gets and sets the property SlurmdbdCustomSettings. 
        /// <para>
        /// Additional SlurmDBD-specific configuration that directly maps to SlurmDBD settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SlurmdbdCustomSetting> SlurmdbdCustomSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<SlurmdbdCustomSetting>() : null;

        /// <summary>
        /// Checks to see if the SlurmdbdCustomSettings property is set.
        /// </summary>
        internal bool IsSetSlurmdbdCustomSettings() => this.SlurmdbdCustomSettings != null && (this.SlurmdbdCustomSettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

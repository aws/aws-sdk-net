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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for the Amazon File Cache resource.
    /// </summary>
    public partial class FileCacheLustreConfiguration
    {
        private FileCacheLustreDeploymentType _deploymentType;
        private LustreLogConfiguration _logConfiguration;
        private FileCacheLustreMetadataConfiguration _metadataConfiguration;
        private string _mountName;
        private int? _perUnitStorageThroughput;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the Amazon File Cache resource, which must be <c>CACHE_1</c>.
        /// </para>
        /// </summary>
        public FileCacheLustreDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The configuration for Lustre logging used to write the enabled logging events for
        /// your Amazon File Cache resource to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LustreLogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The configuration for a Lustre MDT (Metadata Target) storage volume.
        /// </para>
        /// </summary>
        public FileCacheLustreMetadataConfiguration MetadataConfiguration
        {
            get { return this._metadataConfiguration; }
            set { this._metadataConfiguration = value; }
        }

        // Check to see if MetadataConfiguration property is set
        internal bool IsSetMetadataConfiguration()
        {
            return this._metadataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MountName. 
        /// <para>
        /// You use the <c>MountName</c> value when mounting the cache. If you pass a cache ID
        /// to the <c>DescribeFileCaches</c> operation, it returns the the <c>MountName</c> value
        /// as part of the cache's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public string MountName
        {
            get { return this._mountName; }
            set { this._mountName = value; }
        }

        // Check to see if MountName property is set
        internal bool IsSetMountName()
        {
            return this._mountName != null;
        }

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// Per unit storage throughput represents the megabytes per second of read or write throughput
        /// per 1 tebibyte of storage provisioned. Cache throughput capacity is equal to Storage
        /// capacity (TiB) * PerUnitStorageThroughput (MB/s/TiB). The only supported value is
        /// <c>1000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1000)]
        public int? PerUnitStorageThroughput
        {
            get { return this._perUnitStorageThroughput; }
            set { this._perUnitStorageThroughput = value; }
        }

        // Check to see if PerUnitStorageThroughput property is set
        internal bool IsSetPerUnitStorageThroughput()
        {
            return this._perUnitStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime.
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}
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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The Amazon File Cache configuration for the cache that you are creating.
    /// </summary>
    public partial class CreateFileCacheLustreConfiguration
    {
        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the cache deployment type, which must be <c>CACHE_1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileCacheLustreDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The configuration for a Lustre MDT (Metadata Target) storage volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileCacheLustreMetadataConfiguration MetadataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MetadataConfiguration property is set.
        /// </summary>
        internal bool IsSetMetadataConfiguration() => this.MetadataConfiguration != null;

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// Provisions the amount of read and write throughput for each 1 tebibyte (TiB) of cache
        /// storage capacity, in MB/s/TiB. The only supported value is <c>1000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 1000)]
        public int? PerUnitStorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the PerUnitStorageThroughput property is set.
        /// </summary>
        internal bool IsSetPerUnitStorageThroughput() => this.PerUnitStorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime.
        /// </summary>
        [AWSProperty(Min = 7, Max = 7)]
        public string WeeklyMaintenanceStartTime { get; set; }

        /// <summary>
        /// Checks to see if the WeeklyMaintenanceStartTime property is set.
        /// </summary>
        internal bool IsSetWeeklyMaintenanceStartTime() => this.WeeklyMaintenanceStartTime != null;
    }
}

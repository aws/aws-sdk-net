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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCloudAutonomousVmCluster operation. Updates
    /// the properties of the specified Autonomous VM cluster.
    /// </summary>
    public partial class UpdateCloudAutonomousVmClusterRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The data storage size to allocate for Autonomous Databases in the Autonomous VM cluster,
        /// in terabytes (TB).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? AutonomousDataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetAutonomousDataStorageSizeInTBs() => this.AutonomousDataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the Autonomous VM cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 64)]
        public string CloudAutonomousVmClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CloudAutonomousVmClusterId property is set.
        /// </summary>
        internal bool IsSetCloudAutonomousVmClusterId() => this.CloudAutonomousVmClusterId != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCountPerNode. 
        /// <para>
        /// The number of CPU cores to enable per node in the Autonomous VM cluster. If you don't
        /// specify a value, the existing number of CPU cores per node is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CpuCoreCountPerNode { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCountPerNode property is set.
        /// </summary>
        internal bool IsSetCpuCoreCountPerNode() => this.CpuCoreCountPerNode.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-provided description of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new user-friendly name for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The scheduling details for the maintenance window. Patching and system updates take
        /// place during the maintenance window.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property TotalContainerDatabases. 
        /// <para>
        /// The total number of Autonomous Container Databases that can be created in the Autonomous
        /// VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the TotalContainerDatabases property is set.
        /// </summary>
        internal bool IsSetTotalContainerDatabases() => this.TotalContainerDatabases.HasValue;
    }
}

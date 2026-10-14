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
    /// Information about unallocated resources in the Cloud Exadata infrastructure.
    /// </summary>
    public partial class CloudExadataInfrastructureUnallocatedResources
    {
        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusters. 
        /// <para>
        /// A list of Autonomous VM clusters associated with this Cloud Exadata Infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudAutonomousVmClusterResourceDetails> CloudAutonomousVmClusters { get; set; } = AWSConfigs.InitializeCollections ? new List<CloudAutonomousVmClusterResourceDetails>() : null;

        /// <summary>
        /// Checks to see if the CloudAutonomousVmClusters property is set.
        /// </summary>
        internal bool IsSetCloudAutonomousVmClusters() => this.CloudAutonomousVmClusters != null && (this.CloudAutonomousVmClusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureDisplayName. 
        /// <para>
        /// The display name of the Cloud Exadata infrastructure.
        /// </para>
        /// </summary>
        public string CloudExadataInfrastructureDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureDisplayName property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureDisplayName() => this.CloudExadataInfrastructureDisplayName != null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Cloud Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property ExadataStorageInTBs. 
        /// <para>
        /// The amount of unallocated Exadata storage available, in terabytes (TB).
        /// </para>
        /// </summary>
        public double? ExadataStorageInTBs { get; set; }

        /// <summary>
        /// Checks to see if the ExadataStorageInTBs property is set.
        /// </summary>
        internal bool IsSetExadataStorageInTBs() => this.ExadataStorageInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property LocalStorageInGBs. 
        /// <para>
        /// The amount of unallocated local storage available, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? LocalStorageInGBs { get; set; }

        /// <summary>
        /// Checks to see if the LocalStorageInGBs property is set.
        /// </summary>
        internal bool IsSetLocalStorageInGBs() => this.LocalStorageInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryInGBs. 
        /// <para>
        /// The amount of unallocated memory available, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? MemoryInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemoryInGBs property is set.
        /// </summary>
        internal bool IsSetMemoryInGBs() => this.MemoryInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property Ocpus. 
        /// <para>
        /// The number of unallocated Oracle CPU Units (OCPUs) available.
        /// </para>
        /// </summary>
        public int? Ocpus { get; set; }

        /// <summary>
        /// Checks to see if the Ocpus property is set.
        /// </summary>
        internal bool IsSetOcpus() => this.Ocpus.HasValue;
    }
}

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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private List<CloudAutonomousVmClusterResourceDetails> _cloudAutonomousVmClusters = AWSConfigs.InitializeCollections ? new List<CloudAutonomousVmClusterResourceDetails>() : null;
        private string _cloudExadataInfrastructureDisplayName;
        private string _cloudExadataInfrastructureId;
        private double? _exadataStorageInTBs;
        private int? _localStorageInGBs;
        private int? _memoryInGBs;
        private int? _ocpus;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusters. 
        /// <para>
        /// A list of Autonomous VM clusters associated with this Cloud Exadata Infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudAutonomousVmClusterResourceDetails> CloudAutonomousVmClusters
        {
            get { return this._cloudAutonomousVmClusters; }
            set { this._cloudAutonomousVmClusters = value; }
        }

        // Check to see if CloudAutonomousVmClusters property is set
        internal bool IsSetCloudAutonomousVmClusters()
        {
            return this._cloudAutonomousVmClusters != null && (this._cloudAutonomousVmClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureDisplayName. 
        /// <para>
        /// The display name of the Cloud Exadata infrastructure.
        /// </para>
        /// </summary>
        public string CloudExadataInfrastructureDisplayName
        {
            get { return this._cloudExadataInfrastructureDisplayName; }
            set { this._cloudExadataInfrastructureDisplayName = value; }
        }

        // Check to see if CloudExadataInfrastructureDisplayName property is set
        internal bool IsSetCloudExadataInfrastructureDisplayName()
        {
            return this._cloudExadataInfrastructureDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Cloud Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
        public string CloudExadataInfrastructureId
        {
            get { return this._cloudExadataInfrastructureId; }
            set { this._cloudExadataInfrastructureId = value; }
        }

        // Check to see if CloudExadataInfrastructureId property is set
        internal bool IsSetCloudExadataInfrastructureId()
        {
            return this._cloudExadataInfrastructureId != null;
        }

        /// <summary>
        /// Gets and sets the property ExadataStorageInTBs. 
        /// <para>
        /// The amount of unallocated Exadata storage available, in terabytes (TB).
        /// </para>
        /// </summary>
        public double? ExadataStorageInTBs
        {
            get { return this._exadataStorageInTBs; }
            set { this._exadataStorageInTBs = value; }
        }

        // Check to see if ExadataStorageInTBs property is set
        internal bool IsSetExadataStorageInTBs()
        {
            return this._exadataStorageInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalStorageInGBs. 
        /// <para>
        /// The amount of unallocated local storage available, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? LocalStorageInGBs
        {
            get { return this._localStorageInGBs; }
            set { this._localStorageInGBs = value; }
        }

        // Check to see if LocalStorageInGBs property is set
        internal bool IsSetLocalStorageInGBs()
        {
            return this._localStorageInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryInGBs. 
        /// <para>
        /// The amount of unallocated memory available, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? MemoryInGBs
        {
            get { return this._memoryInGBs; }
            set { this._memoryInGBs = value; }
        }

        // Check to see if MemoryInGBs property is set
        internal bool IsSetMemoryInGBs()
        {
            return this._memoryInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocpus. 
        /// <para>
        /// The number of unallocated Oracle CPU Units (OCPUs) available.
        /// </para>
        /// </summary>
        public int? Ocpus
        {
            get { return this._ocpus; }
            set { this._ocpus = value; }
        }

        // Check to see if Ocpus property is set
        internal bool IsSetOcpus()
        {
            return this._ocpus.HasValue; 
        }

    }
}
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
    /// Container for the parameters to the UpdateCloudExadataInfrastructure operation. Updates
    /// the properties of an Exadata infrastructure resource.
    /// </summary>
    public partial class UpdateCloudExadataInfrastructureRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Exadata infrastructure to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The number of database servers for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? ComputeCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputeCount property is set.
        /// </summary>
        internal bool IsSetComputeCount() => this.ComputeCount.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new user-friendly name for the Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The maintenance window configuration for the Exadata Cloud infrastructure.
        /// </para>
        ///  
        /// <para>
        /// This allows you to define when maintenance operations such as patching and updates
        /// can be performed on the infrastructure.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property StorageCount. 
        /// <para>
        /// The number of storage servers to activate for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? StorageCount { get; set; }

        /// <summary>
        /// Checks to see if the StorageCount property is set.
        /// </summary>
        internal bool IsSetStorageCount() => this.StorageCount.HasValue;
    }
}

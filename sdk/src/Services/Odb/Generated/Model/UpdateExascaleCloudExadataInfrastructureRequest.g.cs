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
    /// Container for the parameters to the UpdateExascaleCloudExadataInfrastructure operation.
    /// Configures or updates the Exascale storage on an Exadata infrastructure. After you
    /// configure Exascale storage, you can create Exascale storage vaults on the infrastructure
    /// and VM clusters that use Exascale storage.
    /// </summary>
    public partial class UpdateExascaleCloudExadataInfrastructureRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier or Amazon Resource Name (ARN) of the Exadata infrastructure
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property TotalStorageSizeInGBs. 
        /// <para>
        /// The total amount of Exascale storage, in gigabytes (GB), to configure on the Exadata
        /// infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalStorageSizeInGBs() => this.TotalStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property TotalVmStorageSizeInGBs. 
        /// <para>
        /// The total amount of Exascale storage, in gigabytes (GB), to allocate for VM storage
        /// on the Exadata infrastructure. VM clusters that store their VM file systems or VM
        /// backups in Exascale storage use this capacity.
        /// </para>
        /// </summary>
        public int? TotalVmStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalVmStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalVmStorageSizeInGBs() => this.TotalVmStorageSizeInGBs.HasValue;
    }
}

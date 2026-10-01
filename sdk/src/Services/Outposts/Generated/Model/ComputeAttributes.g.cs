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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about compute hardware assets.
    /// </summary>
    public partial class ComputeAttributes
    {
        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        ///  The host ID of the Dedicated Host on the asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string HostId { get; set; }

        /// <summary>
        /// Checks to see if the HostId property is set.
        /// </summary>
        internal bool IsSetHostId() => this.HostId != null;

        /// <summary>
        /// Gets and sets the property InstanceFamilies. 
        /// <para>
        /// A list of the names of instance families that are currently associated with a given
        /// asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceFamilies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceFamilies property is set.
        /// </summary>
        internal bool IsSetInstanceFamilies() => this.InstanceFamilies != null && (this.InstanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceTypeCapacities. 
        /// <para>
        /// The instance type capacities configured for this asset. This can be changed through
        /// a capacity task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetInstanceTypeCapacity> InstanceTypeCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetInstanceTypeCapacity>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeCapacities property is set.
        /// </summary>
        internal bool IsSetInstanceTypeCapacities() => this.InstanceTypeCapacities != null && (this.InstanceTypeCapacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxVcpus. 
        /// <para>
        /// The maximum number of vCPUs possible for the specified asset.
        /// </para>
        /// </summary>
        public int? MaxVcpus { get; set; }

        /// <summary>
        /// Checks to see if the MaxVcpus property is set.
        /// </summary>
        internal bool IsSetMaxVcpus() => this.MaxVcpus.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACTIVE - The asset is available and can provide capacity for new compute resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ISOLATED - The asset is undergoing maintenance and can't provide capacity for new
        /// compute resources. Existing compute resources on the asset are not affected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETIRING - The underlying hardware for the asset is degraded. Capacity for new compute
        /// resources is reduced. Amazon Web Services sends notifications for resources that must
        /// be stopped before the asset can be replaced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTALLING - The asset is being installed and can't yet provide capacity for new compute
        /// resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComputeAssetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}

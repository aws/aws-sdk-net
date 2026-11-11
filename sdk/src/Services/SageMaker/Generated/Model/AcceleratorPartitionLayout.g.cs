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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A layout of accelerator partitions for a production variant. On NVIDIA GPUs, the partitions
    /// are Multi-Instance GPU (MIG) instances. SageMaker applies the layout to every accelerator
    /// on the variant's instance type. You can't change the layout of a running endpoint.
    /// To use a different layout, create a new endpoint.
    /// </summary>
    public partial class AcceleratorPartitionLayout
    {
        /// <summary>
        /// Gets and sets the property AcceleratorPartitionTypes. 
        /// <para>
        /// The list of partition profiles to carve on each accelerator that this layout applies
        /// to. On NVIDIA GPUs these are Multi-Instance GPU (MIG) profiles, for example <c>["mig-3g.40gb",
        /// "mig-4g.40gb"]</c>. The order of the profiles doesn't change how the accelerator is
        /// partitioned. However, when you update an endpoint, a layout with the same profiles
        /// in a different order counts as a different layout, and the update is rejected. Repeat
        /// a profile to request more than one partition of that size: for example, <c>["mig-3g.40gb",
        /// "mig-3g.40gb"]</c> requests two <c>mig-3g.40gb</c> partitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 32)]
        public List<string> AcceleratorPartitionTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AcceleratorPartitionTypes property is set.
        /// </summary>
        internal bool IsSetAcceleratorPartitionTypes() => this.AcceleratorPartitionTypes != null && (this.AcceleratorPartitionTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

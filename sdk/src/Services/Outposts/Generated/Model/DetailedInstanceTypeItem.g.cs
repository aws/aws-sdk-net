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
    /// Information about an instance type that can be ordered for an Outpost, including hardware
    /// specifications and supported form factors.
    /// </summary>
    public partial class DetailedInstanceTypeItem
    {
        /// <summary>
        /// Gets and sets the property FormFactorConfigs. 
        /// <para>
        /// The supported form factor and Outpost generation configurations for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormFactorConfig> FormFactorConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<FormFactorConfig>() : null;

        /// <summary>
        /// Checks to see if the FormFactorConfigs property is set.
        /// </summary>
        internal bool IsSetFormFactorConfigs() => this.FormFactorConfigs != null && (this.FormFactorConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MemoryInMib. 
        /// <para>
        /// The memory size of the instance type, in MiB.
        /// </para>
        /// </summary>
        public int? MemoryInMib { get; set; }

        /// <summary>
        /// Checks to see if the MemoryInMib property is set.
        /// </summary>
        internal bool IsSetMemoryInMib() => this.MemoryInMib.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance of the instance type.
        /// </para>
        /// </summary>
        public string NetworkPerformance { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformance property is set.
        /// </summary>
        internal bool IsSetNetworkPerformance() => this.NetworkPerformance != null;

        /// <summary>
        /// Gets and sets the property VCPUs. 
        /// <para>
        /// The number of default VCPUs in the instance type.
        /// </para>
        /// </summary>
        public int? VCPUs { get; set; }

        /// <summary>
        /// Checks to see if the VCPUs property is set.
        /// </summary>
        internal bool IsSetVCPUs() => this.VCPUs.HasValue;
    }
}

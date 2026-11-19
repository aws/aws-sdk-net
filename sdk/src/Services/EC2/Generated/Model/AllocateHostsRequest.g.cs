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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AllocateHosts operation. Allocates a Dedicated
    /// Host to your account. At a minimum, specify the supported instance type or instance
    /// family, the Availability Zone in which to allocate the host, and the number of hosts
    /// to allocate.
    /// </summary>
    public partial class AllocateHostsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AssetIds. 
        /// <para>
        /// The IDs of the Outpost hardware assets on which to allocate the Dedicated Hosts. Targeting
        /// specific hardware assets on an Outpost can help to minimize latency between your workloads.
        /// This parameter is supported only if you specify <b>OutpostArn</b>. If you are allocating
        /// the Dedicated Hosts in a Region, omit this parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify this parameter, you can omit <b>Quantity</b>. In this case, Amazon
        /// EC2 allocates a Dedicated Host on each specified hardware asset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify both <b>AssetIds</b> and <b>Quantity</b>, then the value for <b>Quantity</b>
        /// must be equal to the number of asset IDs specified.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssetIds property is set.
        /// </summary>
        internal bool IsSetAssetIds() => this.AssetIds != null && (this.AssetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoPlacement. 
        /// <para>
        /// Indicates whether the host accepts any untargeted instance launches that match its
        /// instance type configuration, or if it only accepts Host tenancy instance launches
        /// that specify its unique host ID. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/how-dedicated-hosts-work.html#dedicated-hosts-understanding">
        /// Understanding auto-placement and affinity</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>off</c> 
        /// </para>
        /// </summary>
        public AutoPlacement AutoPlacement { get; set; }

        /// <summary>
        /// Checks to see if the AutoPlacement property is set.
        /// </summary>
        internal bool IsSetAutoPlacement() => this.AutoPlacement != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to allocate the Dedicated Host.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// The CPU configuration options to apply to the Dedicated Host.
        /// </para>
        /// </summary>
        public HostCpuOptionsRequest CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property HostMaintenance. 
        /// <para>
        /// Indicates whether to enable or disable host maintenance for the Dedicated Host. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-maintenance.html">Host
        /// maintenance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HostMaintenance HostMaintenance { get; set; }

        /// <summary>
        /// Checks to see if the HostMaintenance property is set.
        /// </summary>
        internal bool IsSetHostMaintenance() => this.HostMaintenance != null;

        /// <summary>
        /// Gets and sets the property HostRecovery. 
        /// <para>
        /// Indicates whether to enable or disable host recovery for the Dedicated Host. Host
        /// recovery is disabled by default. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-recovery.html">
        /// Host recovery</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>off</c> 
        /// </para>
        /// </summary>
        public HostRecovery HostRecovery { get; set; }

        /// <summary>
        /// Checks to see if the HostRecovery property is set.
        /// </summary>
        internal bool IsSetHostRecovery() => this.HostRecovery != null;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// Specifies the instance family to be supported by the Dedicated Hosts. If you specify
        /// an instance family, the Dedicated Hosts support multiple instance types within that
        /// instance family.
        /// </para>
        ///  
        /// <para>
        /// If you want the Dedicated Hosts to support a specific instance type only, omit this
        /// parameter and specify <b>InstanceType</b> instead. You cannot specify <b>InstanceFamily</b>
        /// and <b>InstanceType</b> in the same request.
        /// </para>
        /// </summary>
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type to be supported by the Dedicated Hosts. If you specify
        /// an instance type, the Dedicated Hosts support instances of the specified instance
        /// type only.
        /// </para>
        ///  
        /// <para>
        /// If you want the Dedicated Hosts to support multiple instance types in a specific instance
        /// family, omit this parameter and specify <b>InstanceFamily</b> instead. You cannot
        /// specify <b>InstanceType</b> and <b>InstanceFamily</b> in the same request.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Outpost on which to allocate
        /// the Dedicated Host. If you specify <b>OutpostArn</b>, you can optionally specify <b>AssetIds</b>.
        /// </para>
        ///  
        /// <para>
        /// If you are allocating the Dedicated Host in a Region, omit this parameter.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of Dedicated Hosts to allocate to your account with these parameters. If
        /// you are allocating the Dedicated Hosts on an Outpost, and you specify <b>AssetIds</b>,
        /// you can omit this parameter. In this case, Amazon EC2 allocates a Dedicated Host on
        /// each specified hardware asset. If you specify both <b>AssetIds</b> and <b>Quantity</b>,
        /// then the value that you specify for <b>Quantity</b> must be equal to the number of
        /// asset IDs specified.
        /// </para>
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity.HasValue;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Dedicated Host during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

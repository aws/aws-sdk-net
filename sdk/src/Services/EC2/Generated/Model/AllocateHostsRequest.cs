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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the AllocateHosts operation.
    /// Allocates a Dedicated Host to your account. At a minimum, specify the supported instance
    /// type or instance family, the Availability Zone in which to allocate the host, and
    /// the number of hosts to allocate.
    /// </summary>
    public partial class AllocateHostsRequest : AmazonEC2Request
    {
        private List<string> _assetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AutoPlacement _autoPlacement;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _clientToken;
        private HostMaintenance _hostMaintenance;
        private HostRecovery _hostRecovery;
        private string _instanceFamily;
        private string _instanceType;
        private string _outpostArn;
        private int? _quantity;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssetIds
        {
            get { return this._assetIds; }
            set { this._assetIds = value; }
        }

        // Check to see if AssetIds property is set
        internal bool IsSetAssetIds()
        {
            return this._assetIds != null && (this._assetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public AutoPlacement AutoPlacement
        {
            get { return this._autoPlacement; }
            set { this._autoPlacement = value; }
        }

        // Check to see if AutoPlacement property is set
        internal bool IsSetAutoPlacement()
        {
            return this._autoPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to allocate the Dedicated Host.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property HostMaintenance. 
        /// <para>
        /// Indicates whether to enable or disable host maintenance for the Dedicated Host. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-maintenance.html">Host
        /// maintenance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HostMaintenance HostMaintenance
        {
            get { return this._hostMaintenance; }
            set { this._hostMaintenance = value; }
        }

        // Check to see if HostMaintenance property is set
        internal bool IsSetHostMaintenance()
        {
            return this._hostMaintenance != null;
        }

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
        public HostRecovery HostRecovery
        {
            get { return this._hostRecovery; }
            set { this._hostRecovery = value; }
        }

        // Check to see if HostRecovery property is set
        internal bool IsSetHostRecovery()
        {
            return this._hostRecovery != null;
        }

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
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

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
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

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
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

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
        public int? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Dedicated Host during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
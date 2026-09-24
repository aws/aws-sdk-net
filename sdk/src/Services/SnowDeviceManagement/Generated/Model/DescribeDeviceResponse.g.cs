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

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribeDevice operation.
    /// </summary>
    public partial class DescribeDeviceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedWithJob. 
        /// <para>
        /// The ID of the job used when ordering the device.
        /// </para>
        /// </summary>
        public string AssociatedWithJob { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedWithJob property is set.
        /// </summary>
        internal bool IsSetAssociatedWithJob() => this.AssociatedWithJob != null;

        /// <summary>
        /// Gets and sets the property DeviceCapacities. 
        /// <para>
        /// The hardware specifications of the device. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Capacity> DeviceCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<Capacity>() : null;

        /// <summary>
        /// Checks to see if the DeviceCapacities property is set.
        /// </summary>
        internal bool IsSetDeviceCapacities() => this.DeviceCapacities != null && (this.DeviceCapacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeviceState. 
        /// <para>
        /// The current state of the device.
        /// </para>
        /// </summary>
        public UnlockState DeviceState { get; set; }

        /// <summary>
        /// Checks to see if the DeviceState property is set.
        /// </summary>
        internal bool IsSetDeviceState() => this.DeviceState != null;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The type of Amazon Web Services Snow Family device.
        /// </para>
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;

        /// <summary>
        /// Gets and sets the property LastReachedOutAt. 
        /// <para>
        /// When the device last contacted the Amazon Web Services Cloud. Indicates that the device
        /// is online.
        /// </para>
        /// </summary>
        public DateTime? LastReachedOutAt { get; set; }

        /// <summary>
        /// Checks to see if the LastReachedOutAt property is set.
        /// </summary>
        internal bool IsSetLastReachedOutAt() => this.LastReachedOutAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the device last pushed an update to the Amazon Web Services Cloud. Indicates
        /// when the device cache was refreshed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedDeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        public string ManagedDeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDeviceArn property is set.
        /// </summary>
        internal bool IsSetManagedDeviceArn() => this.ManagedDeviceArn != null;

        /// <summary>
        /// Gets and sets the property ManagedDeviceId. 
        /// <para>
        /// The ID of the device that you checked the information for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ManagedDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDeviceId property is set.
        /// </summary>
        internal bool IsSetManagedDeviceId() => this.ManagedDeviceId != null;

        /// <summary>
        /// Gets and sets the property PhysicalNetworkInterfaces. 
        /// <para>
        /// The network interfaces available on the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhysicalNetworkInterface> PhysicalNetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<PhysicalNetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the PhysicalNetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetPhysicalNetworkInterfaces() => this.PhysicalNetworkInterfaces != null && (this.PhysicalNetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Software. 
        /// <para>
        /// The software installed on the device.
        /// </para>
        /// </summary>
        public SoftwareInformation Software { get; set; }

        /// <summary>
        /// Checks to see if the Software property is set.
        /// </summary>
        internal bool IsSetSoftware() => this.Software != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. You can use tags to categorize a
        /// resource in different ways, such as by purpose, owner, or environment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

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
    /// Describes an instance attribute.
    /// </summary>
    public partial class InstanceAttribute
    {
        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceBlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Indicates whether stop protection is enabled for the instance.
        /// </para>
        /// </summary>
        public bool? DisableApiStop { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiStop property is set.
        /// </summary>
        internal bool IsSetDisableApiStop() => this.DisableApiStop.HasValue;

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        /// Indicates whether termination protection is enabled. If the value is <c>true</c>,
        /// you can't terminate the instance using the Amazon EC2 console, command line tools,
        /// or API.
        /// </para>
        /// </summary>
        public bool? DisableApiTermination { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiTermination property is set.
        /// </summary>
        internal bool IsSetDisableApiTermination() => this.DisableApiTermination.HasValue;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instance is optimized for Amazon EBS I/O.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Indicates whether enhanced networking with ENA is enabled.
        /// </para>
        /// </summary>
        public bool? EnaSupport { get; set; }

        /// <summary>
        /// Checks to see if the EnaSupport property is set.
        /// </summary>
        internal bool IsSetEnaSupport() => this.EnaSupport.HasValue;

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// </para>
        /// </summary>
        public EnclaveOptions EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The security groups associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupIdentifier> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        /// Indicates whether an instance stops or terminates when you initiate shutdown from
        /// the instance (using the operating system command for system shutdown).
        /// </para>
        /// </summary>
        public string InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInitiatedShutdownBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInitiatedShutdownBehavior() => this.InstanceInitiatedShutdownBehavior != null;

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
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The kernel ID.
        /// </para>
        /// </summary>
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCode> ProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductCode>() : null;

        /// <summary>
        /// Checks to see if the ProductCodes property is set.
        /// </summary>
        internal bool IsSetProductCodes() => this.ProductCodes != null && (this.ProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk ID.
        /// </para>
        /// </summary>
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property RootDeviceName. 
        /// <para>
        /// The device name of the root device volume (for example, <c>/dev/sda1</c>).
        /// </para>
        /// </summary>
        public string RootDeviceName { get; set; }

        /// <summary>
        /// Checks to see if the RootDeviceName property is set.
        /// </summary>
        internal bool IsSetRootDeviceName() => this.RootDeviceName != null;

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checks are enabled.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// Checks to see if the SourceDestCheck property is set.
        /// </summary>
        internal bool IsSetSourceDestCheck() => this.SourceDestCheck.HasValue;

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Indicates whether enhanced networking with the Intel 82599 Virtual Function interface
        /// is enabled.
        /// </para>
        /// </summary>
        public string SriovNetSupport { get; set; }

        /// <summary>
        /// Checks to see if the SriovNetSupport property is set.
        /// </summary>
        internal bool IsSetSriovNetSupport() => this.SriovNetSupport != null;

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The user data.
        /// </para>
        /// </summary>
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}

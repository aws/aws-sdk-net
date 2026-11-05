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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccelerator operation. Update an accelerator
    /// to make changes, such as the following: <ul> <li> <para> Change the name of the accelerator.
    /// </para> </li> <li> <para> Disable the accelerator so that it no longer accepts or
    /// routes traffic, or so that you can delete it. </para> </li> <li> <para> Enable the
    /// accelerator, if it is disabled. </para> </li> <li> <para> Change the IP address type
    /// to dual-stack if it is IPv4, or change the IP address type to IPv4 if it's dual-stack.
    /// </para> </li> </ul> <para> Be aware that static IP addresses remain assigned to your
    /// accelerator for as long as it exists, even if you disable the accelerator and it no
    /// longer accepts or routes traffic. However, when you delete the accelerator, you lose
    /// the static IP addresses that are assigned to it, so you can no longer route traffic
    /// by using them. </para> <important> <para> Global Accelerator is a global service that
    /// supports endpoints in multiple Amazon Web Services Regions but you must specify the
    /// US West (Oregon) Region to create, update, or otherwise work with accelerators. That
    /// is, for example, specify <c>--region us-west-2</c> on Amazon Web Services CLI commands.
    /// </para> </important>
    /// </summary>
    public partial class UpdateAcceleratorRequest : AmazonGlobalAcceleratorRequest
    {
        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the accelerator to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string AcceleratorArn { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorArn property is set.
        /// </summary>
        internal bool IsSetAcceleratorArn() => this.AcceleratorArn != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether an accelerator is enabled. The value is true or false. The default
        /// value is true. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to true, the accelerator cannot be deleted. If set to false, the
        /// accelerator can be deleted.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that an accelerator supports. For a standard accelerator, the
        /// value can be IPV4 or DUAL_STACK.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The IP addresses for an accelerator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> IpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IpAddresses property is set.
        /// </summary>
        internal bool IsSetIpAddresses() => this.IpAddresses != null && (this.IpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the accelerator. The name can have a maximum of 64 characters, must contain
        /// only alphanumeric characters, periods (.), or hyphens (-), and must not begin or end
        /// with a hyphen or period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}

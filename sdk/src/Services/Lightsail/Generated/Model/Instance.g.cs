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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an instance (a virtual private server).
    /// </summary>
    public partial class Instance
    {
        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects representing the add-ons enabled on the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddOn> AddOns { get; set; } = AWSConfigs.InitializeCollections ? new List<AddOn>() : null;

        /// <summary>
        /// Checks to see if the AddOns property is set.
        /// </summary>
        internal bool IsSetAddOns() => this.AddOns != null && (this.AddOns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance (<c>arn:aws:lightsail:us-east-2:123456789101:Instance/244ad76f-8aad-4741-809f-12345EXAMPLE</c>).
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The blueprint ID (<c>amazon_linux_2023</c>).
        /// </para>
        /// </summary>
        public string BlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintId property is set.
        /// </summary>
        internal bool IsSetBlueprintId() => this.BlueprintId != null;

        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The friendly name of the blueprint (<c>Amazon Linux 2023</c>).
        /// </para>
        /// </summary>
        public string BlueprintName { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintName property is set.
        /// </summary>
        internal bool IsSetBlueprintName() => this.BlueprintName != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle for the instance (<c>micro_x_x</c>).
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the instance was created (<c>1479734909.17</c>) in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Hardware. 
        /// <para>
        /// The size of the vCPU and the amount of RAM for the instance.
        /// </para>
        /// </summary>
        public InstanceHardware Hardware { get; set; }

        /// <summary>
        /// Checks to see if the Hardware property is set.
        /// </summary>
        internal bool IsSetHardware() => this.Hardware != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the instance.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsStaticIp. 
        /// <para>
        /// A Boolean value indicating whether this instance has a static IP assigned to it.
        /// </para>
        /// </summary>
        public bool? IsStaticIp { get; set; }

        /// <summary>
        /// Checks to see if the IsStaticIp property is set.
        /// </summary>
        internal bool IsSetIsStaticIp() => this.IsStaticIp.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The region name and Availability Zone where the instance is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public InstanceMetadataOptions MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name the user gave the instance (<c>Amazon_Linux_2023-1</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Networking. 
        /// <para>
        /// Information about the public ports and monthly data transfer rates for the instance.
        /// </para>
        /// </summary>
        public InstanceNetworking Networking { get; set; }

        /// <summary>
        /// Checks to see if the Networking property is set.
        /// </summary>
        internal bool IsSetNetworking() => this.Networking != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address of the instance.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IP address of the instance.
        /// </para>
        /// </summary>
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpAddress property is set.
        /// </summary>
        internal bool IsSetPublicIpAddress() => this.PublicIpAddress != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource (usually <c>Instance</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SshKeyName. 
        /// <para>
        /// The name of the SSH key being used to connect to the instance (<c>LightsailDefaultKeyPair</c>).
        /// </para>
        /// </summary>
        public string SshKeyName { get; set; }

        /// <summary>
        /// Checks to see if the SshKeyName property is set.
        /// </summary>
        internal bool IsSetSshKeyName() => this.SshKeyName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status code and the state (<c>running</c>) for the instance.
        /// </para>
        /// </summary>
        public InstanceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about an instance or another resource in Lightsail. This code enables our support
        /// team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name for connecting to the instance (<c>ec2-user</c>).
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}

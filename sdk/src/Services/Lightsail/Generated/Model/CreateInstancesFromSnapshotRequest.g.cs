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
    /// Container for the parameters to the CreateInstancesFromSnapshot operation. Creates
    /// one or more new instances from a manual or automatic snapshot of an instance. <para>
    /// The <c>create instances from snapshot</c> operation supports tag-based access control
    /// via request tags and resource tags applied to the resource identified by <c>instance
    /// snapshot name</c>. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>. </para>
    /// </summary>
    public partial class CreateInstancesFromSnapshotRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects representing the add-ons to enable for the new instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddOnRequest> AddOns { get; set; } = AWSConfigs.InitializeCollections ? new List<AddOnRequest>() : null;

        /// <summary>
        /// Checks to see if the AddOns property is set.
        /// </summary>
        internal bool IsSetAddOns() => this.AddOns != null && (this.AddOns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttachedDiskMapping. 
        /// <para>
        /// An object containing information about one or more disk mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<DiskMap>> AttachedDiskMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<DiskMap>>() : null;

        /// <summary>
        /// Checks to see if the AttachedDiskMapping property is set.
        /// </summary>
        internal bool IsSetAttachedDiskMapping() => this.AttachedDiskMapping != null && (this.AttachedDiskMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where you want to create your instances. Use the following formatting:
        /// <c>us-east-2a</c> (case sensitive). You can get a list of Availability Zones by using
        /// the <a href="http://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetRegions.html">get
        /// regions</a> operation. Be sure to add the <c>include Availability Zones</c> parameter
        /// to your request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle of specification information for your virtual private server (or <i>instance</i>),
        /// including the pricing plan (<c>micro_x_x</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property InstanceNames. 
        /// <para>
        /// The names for your new instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> InstanceNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceNames property is set.
        /// </summary>
        internal bool IsSetInstanceNames() => this.InstanceNames != null && (this.InstanceNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceSnapshotName. 
        /// <para>
        /// The name of the instance snapshot on which you are basing your new instances. Use
        /// the get instance snapshots operation to return information about your existing snapshots.
        /// </para>
        ///  
        /// <para>
        /// Constraint:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <c>source instance name</c> parameter.
        /// The <c>instance snapshot name</c> and <c>source instance name</c> parameters are mutually
        /// exclusive.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string InstanceSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceSnapshotName property is set.
        /// </summary>
        internal bool IsSetInstanceSnapshotName() => this.InstanceSnapshotName != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the instance.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>dualstack</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property KeyPairName. 
        /// <para>
        /// The name for your key pair.
        /// </para>
        /// </summary>
        public string KeyPairName { get; set; }

        /// <summary>
        /// Checks to see if the KeyPairName property is set.
        /// </summary>
        internal bool IsSetKeyPairName() => this.KeyPairName != null;

        /// <summary>
        /// Gets and sets the property RestoreDate. 
        /// <para>
        /// The date of the automatic snapshot to use for the new instance. Use the <c>get auto
        /// snapshots</c> operation to identify the dates of the available automatic snapshots.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be specified in <c>YYYY-MM-DD</c> format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <c>use latest restorable auto snapshot</c>
        /// parameter. The <c>restore date</c> and <c>use latest restorable auto snapshot</c>
        /// parameters are mutually exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new instance from an automatic snapshot.
        /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RestoreDate { get; set; }

        /// <summary>
        /// Checks to see if the RestoreDate property is set.
        /// </summary>
        internal bool IsSetRestoreDate() => this.RestoreDate != null;

        /// <summary>
        /// Gets and sets the property SourceInstanceName. 
        /// <para>
        /// The name of the source instance from which the source automatic snapshot was created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <c>instance snapshot name</c> parameter.
        /// The <c>source instance name</c> and <c>instance snapshot name</c> parameters are mutually
        /// exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new instance from an automatic snapshot.
        /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceInstanceName property is set.
        /// </summary>
        internal bool IsSetSourceInstanceName() => this.SourceInstanceName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
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
        /// Gets and sets the property UseLatestRestorableAutoSnapshot. 
        /// <para>
        /// A Boolean value to indicate whether to use the latest available automatic snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <c>restore date</c> parameter.
        /// The <c>use latest restorable auto snapshot</c> and <c>restore date</c> parameters
        /// are mutually exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new instance from an automatic snapshot.
        /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? UseLatestRestorableAutoSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the UseLatestRestorableAutoSnapshot property is set.
        /// </summary>
        internal bool IsSetUseLatestRestorableAutoSnapshot() => this.UseLatestRestorableAutoSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// You can create a launch script that configures a server with additional user data.
        /// For example, <c>apt-get -y update</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on the machine image you choose, the command to get software on your instance
        /// varies. Amazon Linux and CentOS use <c>yum</c>, Debian and Ubuntu use <c>apt-get</c>,
        /// and FreeBSD uses <c>pkg</c>. For a complete list, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/compare-options-choose-lightsail-instance-image">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}

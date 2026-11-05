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
    /// Container for the parameters to the CreateDiskFromSnapshot operation. Creates a block
    /// storage disk from a manual or automatic snapshot of a disk. The resulting disk can
    /// be attached to an Amazon Lightsail instance in the same Availability Zone (<c>us-east-2a</c>).
    /// <para> The <c>create disk from snapshot</c> operation supports tag-based access control
    /// via request tags and resource tags applied to the resource identified by <c>disk snapshot
    /// name</c>. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>. </para>
    /// </summary>
    public partial class CreateDiskFromSnapshotRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects that represent the add-ons to enable for the new disk.
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where you want to create the disk (<c>us-east-2a</c>). Choose
        /// the same Availability Zone as the Lightsail instance where you want to create the
        /// disk.
        /// </para>
        ///  
        /// <para>
        /// Use the GetRegions operation to list the Availability Zones where Lightsail is currently
        /// available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique Lightsail disk name (<c>my-disk</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DiskName { get; set; }

        /// <summary>
        /// Checks to see if the DiskName property is set.
        /// </summary>
        internal bool IsSetDiskName() => this.DiskName != null;

        /// <summary>
        /// Gets and sets the property DiskSnapshotName. 
        /// <para>
        /// The name of the disk snapshot (<c>my-snapshot</c>) from which to create the new storage
        /// disk.
        /// </para>
        ///  
        /// <para>
        /// Constraint:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <c>source disk name</c> parameter.
        /// The <c>disk snapshot name</c> and <c>source disk name</c> parameters are mutually
        /// exclusive.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DiskSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the DiskSnapshotName property is set.
        /// </summary>
        internal bool IsSetDiskSnapshotName() => this.DiskSnapshotName != null;

        /// <summary>
        /// Gets and sets the property RestoreDate. 
        /// <para>
        /// The date of the automatic snapshot to use for the new disk. Use the <c>get auto snapshots</c>
        /// operation to identify the dates of the available automatic snapshots.
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
        /// Define this parameter only when creating a new disk from an automatic snapshot. For
        /// more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
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
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB (<c>32</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGb property is set.
        /// </summary>
        internal bool IsSetSizeInGb() => this.SizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property SourceDiskName. 
        /// <para>
        /// The name of the source disk from which the source automatic snapshot was created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <c>disk snapshot name</c> parameter.
        /// The <c>source disk name</c> and <c>disk snapshot name</c> parameters are mutually
        /// exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new disk from an automatic snapshot. For
        /// more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDiskName { get; set; }

        /// <summary>
        /// Checks to see if the SourceDiskName property is set.
        /// </summary>
        internal bool IsSetSourceDiskName() => this.SourceDiskName != null;

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
        /// Define this parameter only when creating a new disk from an automatic snapshot. For
        /// more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? UseLatestRestorableAutoSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the UseLatestRestorableAutoSnapshot property is set.
        /// </summary>
        internal bool IsSetUseLatestRestorableAutoSnapshot() => this.UseLatestRestorableAutoSnapshot.HasValue;
    }
}

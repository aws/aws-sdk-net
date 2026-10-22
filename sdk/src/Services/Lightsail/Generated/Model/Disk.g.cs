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
    /// Describes a block storage disk.
    /// </summary>
    public partial class Disk
    {
        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects representing the add-ons enabled on the disk.
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
        /// The Amazon Resource Name (ARN) of the disk.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The resources to which the disk is attached.
        /// </para>
        /// </summary>
        public string AttachedTo { get; set; }

        /// <summary>
        /// Checks to see if the AttachedTo property is set.
        /// </summary>
        internal bool IsSetAttachedTo() => this.AttachedTo != null;

        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// (Discontinued) The attachment state of the disk.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to November 14, 2017, this parameter returned <c>attached</c> for
        /// system disks in the API response. It is now discontinued, but still included in the
        /// response. Use <c>isAttached</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("In releases prior to November 14, 2017, this parameter returned attached for system disks in the API response. It is now deprecated, but still included in the response. Use isAttached instead.")]
        public string AttachmentState { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentState property is set.
        /// </summary>
        internal bool IsSetAttachmentState() => this.AttachmentState != null;

        /// <summary>
        /// Gets and sets the property AutoMountStatus. 
        /// <para>
        /// The status of automatically mounting a storage disk to a virtual computer.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public AutoMountStatus AutoMountStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoMountStatus property is set.
        /// </summary>
        internal bool IsSetAutoMountStatus() => this.AutoMountStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the disk was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property GbInUse. 
        /// <para>
        /// (Discontinued) The number of GB in use by the disk.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to November 14, 2017, this parameter was not included in the API
        /// response. It is now discontinued.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("In releases prior to November 14, 2017, this parameter was not included in the API response. It is now deprecated.")]
        public int? GbInUse { get; set; }

        /// <summary>
        /// Checks to see if the GbInUse property is set.
        /// </summary>
        internal bool IsSetGbInUse() => this.GbInUse.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The input/output operations per second (IOPS) of the disk.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property IsAttached. 
        /// <para>
        /// A Boolean value indicating whether the disk is attached.
        /// </para>
        /// </summary>
        public bool? IsAttached { get; set; }

        /// <summary>
        /// Checks to see if the IsAttached property is set.
        /// </summary>
        internal bool IsSetIsAttached() => this.IsAttached.HasValue;

        /// <summary>
        /// Gets and sets the property IsSystemDisk. 
        /// <para>
        /// A Boolean value indicating whether this disk is a system disk (has an operating system
        /// loaded on it).
        /// </para>
        /// </summary>
        public bool? IsSystemDisk { get; set; }

        /// <summary>
        /// Checks to see if the IsSystemDisk property is set.
        /// </summary>
        internal bool IsSetIsSystemDisk() => this.IsSystemDisk.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region and Availability Zone where the disk is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the disk.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The disk path.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (<c>Disk</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB.
        /// </para>
        /// </summary>
        public int? SizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGb property is set.
        /// </summary>
        internal bool IsSetSizeInGb() => this.SizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Describes the status of the disk.
        /// </para>
        /// </summary>
        public DiskState State { get; set; }

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
    }
}

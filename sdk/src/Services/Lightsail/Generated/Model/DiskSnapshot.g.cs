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
    /// Describes a block storage disk snapshot.
    /// </summary>
    public partial class DiskSnapshot
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the disk snapshot.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the disk snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FromDiskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source disk from which the disk snapshot was
        /// created.
        /// </para>
        /// </summary>
        public string FromDiskArn { get; set; }

        /// <summary>
        /// Checks to see if the FromDiskArn property is set.
        /// </summary>
        internal bool IsSetFromDiskArn() => this.FromDiskArn != null;

        /// <summary>
        /// Gets and sets the property FromDiskName. 
        /// <para>
        /// The unique name of the source disk from which the disk snapshot was created.
        /// </para>
        /// </summary>
        public string FromDiskName { get; set; }

        /// <summary>
        /// Checks to see if the FromDiskName property is set.
        /// </summary>
        internal bool IsSetFromDiskName() => this.FromDiskName != null;

        /// <summary>
        /// Gets and sets the property FromInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source instance from which the disk (system
        /// volume) snapshot was created.
        /// </para>
        /// </summary>
        public string FromInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the FromInstanceArn property is set.
        /// </summary>
        internal bool IsSetFromInstanceArn() => this.FromInstanceArn != null;

        /// <summary>
        /// Gets and sets the property FromInstanceName. 
        /// <para>
        /// The unique name of the source instance from which the disk (system volume) snapshot
        /// was created.
        /// </para>
        /// </summary>
        public string FromInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the FromInstanceName property is set.
        /// </summary>
        internal bool IsSetFromInstanceName() => this.FromInstanceName != null;

        /// <summary>
        /// Gets and sets the property IsFromAutoSnapshot. 
        /// <para>
        /// A Boolean value indicating whether the snapshot was created from an automatic snapshot.
        /// </para>
        /// </summary>
        public bool? IsFromAutoSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the IsFromAutoSnapshot property is set.
        /// </summary>
        internal bool IsSetIsFromAutoSnapshot() => this.IsFromAutoSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region and Availability Zone where the disk snapshot was created.
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
        /// The name of the disk snapshot (<c>my-disk-snapshot</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the snapshot.
        /// </para>
        /// </summary>
        public string Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (<c>DiskSnapshot</c>).
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
        /// The status of the disk snapshot operation.
        /// </para>
        /// </summary>
        public DiskSnapshotState State { get; set; }

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

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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
    /// Describes an instance snapshot.
    /// </summary>
    public partial class InstanceSnapshot
    {
        private string _arn;
        private DateTime? _createdAt;
        private List<Disk> _fromAttachedDisks = AWSConfigs.InitializeCollections ? new List<Disk>() : null;
        private string _fromBlueprintId;
        private string _fromBundleId;
        private string _fromInstanceArn;
        private string _fromInstanceName;
        private bool? _isFromAutoSnapshot;
        private ResourceLocation _location;
        private string _name;
        private string _progress;
        private ResourceType _resourceType;
        private int? _sizeInGb;
        private InstanceSnapshotState _state;
        private string _supportCode;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot (<c>arn:aws:lightsail:us-east-2:123456789101:InstanceSnapshot/d23b5706-3322-4d83-81e5-12345EXAMPLE</c>).
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the snapshot was created (<c>1479907467.024</c>).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromAttachedDisks. 
        /// <para>
        /// An array of disk objects containing information about all block storage disks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Disk> FromAttachedDisks
        {
            get { return this._fromAttachedDisks; }
            set { this._fromAttachedDisks = value; }
        }

        // Check to see if FromAttachedDisks property is set
        internal bool IsSetFromAttachedDisks()
        {
            return this._fromAttachedDisks != null && (this._fromAttachedDisks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FromBlueprintId. 
        /// <para>
        /// The blueprint ID from which you created the snapshot (<c>amazon_linux_2023</c>). A
        /// blueprint is a virtual private server (or <i>instance</i>) image used to create instances
        /// quickly.
        /// </para>
        /// </summary>
        public string FromBlueprintId
        {
            get { return this._fromBlueprintId; }
            set { this._fromBlueprintId = value; }
        }

        // Check to see if FromBlueprintId property is set
        internal bool IsSetFromBlueprintId()
        {
            return this._fromBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property FromBundleId. 
        /// <para>
        /// The bundle ID from which you created the snapshot (<c>micro_x_x</c>).
        /// </para>
        /// </summary>
        public string FromBundleId
        {
            get { return this._fromBundleId; }
            set { this._fromBundleId = value; }
        }

        // Check to see if FromBundleId property is set
        internal bool IsSetFromBundleId()
        {
            return this._fromBundleId != null;
        }

        /// <summary>
        /// Gets and sets the property FromInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance from which the snapshot was created
        /// (<c>arn:aws:lightsail:us-east-2:123456789101:Instance/64b8404c-ccb1-430b-8daf-12345EXAMPLE</c>).
        /// </para>
        /// </summary>
        public string FromInstanceArn
        {
            get { return this._fromInstanceArn; }
            set { this._fromInstanceArn = value; }
        }

        // Check to see if FromInstanceArn property is set
        internal bool IsSetFromInstanceArn()
        {
            return this._fromInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromInstanceName. 
        /// <para>
        /// The instance from which the snapshot was created.
        /// </para>
        /// </summary>
        public string FromInstanceName
        {
            get { return this._fromInstanceName; }
            set { this._fromInstanceName = value; }
        }

        // Check to see if FromInstanceName property is set
        internal bool IsSetFromInstanceName()
        {
            return this._fromInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property IsFromAutoSnapshot. 
        /// <para>
        /// A Boolean value indicating whether the snapshot was created from an automatic snapshot.
        /// </para>
        /// </summary>
        public bool? IsFromAutoSnapshot
        {
            get { return this._isFromAutoSnapshot; }
            set { this._isFromAutoSnapshot = value; }
        }

        // Check to see if IsFromAutoSnapshot property is set
        internal bool IsSetIsFromAutoSnapshot()
        {
            return this._isFromAutoSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The region name and Availability Zone where you created the snapshot.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the snapshot.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is populated only for disk snapshots, and is <c>null</c> for instance snapshots.
        /// </para>
        ///  </note>
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource (usually <c>InstanceSnapshot</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size in GB of the SSD.
        /// </para>
        /// </summary>
        public int? SizeInGb
        {
            get { return this._sizeInGb; }
            set { this._sizeInGb = value; }
        }

        // Check to see if SizeInGb property is set
        internal bool IsSetSizeInGb()
        {
            return this._sizeInGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state the snapshot is in.
        /// </para>
        /// </summary>
        public InstanceSnapshotState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about an instance or another resource in Lightsail. This code enables our support
        /// team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
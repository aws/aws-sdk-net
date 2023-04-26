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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a block storage disk.
    /// </summary>
    public partial class Disk
    {
        private List<AddOn> _addOns = new List<AddOn>();
        private string _arn;
        private string _attachedTo;
        private string _attachmentState;
        private AutoMountStatus _autoMountStatus;
        private DateTime? _createdAt;
        private int? _gbInUse;
        private int? _iops;
        private bool? _isAttached;
        private bool? _isSystemDisk;
        private ResourceLocation _location;
        private string _name;
        private string _path;
        private ResourceType _resourceType;
        private int? _sizeInGb;
        private DiskState _state;
        private string _supportCode;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects representing the add-ons enabled on the disk.
        /// </para>
        /// </summary>
        public List<AddOn> AddOns
        {
            get { return this._addOns; }
            set { this._addOns = value; }
        }

        // Check to see if AddOns property is set
        internal bool IsSetAddOns()
        {
            return this._addOns != null && this._addOns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the disk.
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
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The resources to which the disk is attached.
        /// </para>
        /// </summary>
        public string AttachedTo
        {
            get { return this._attachedTo; }
            set { this._attachedTo = value; }
        }

        // Check to see if AttachedTo property is set
        internal bool IsSetAttachedTo()
        {
            return this._attachedTo != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// (Deprecated) The attachment state of the disk.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to November 14, 2017, this parameter returned <code>attached</code>
        /// for system disks in the API response. It is now deprecated, but still included in
        /// the response. Use <code>isAttached</code> instead.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("In releases prior to November 14, 2017, this parameter returned attached for system disks in the API response. It is now deprecated, but still included in the response. Use isAttached instead.")]
        public string AttachmentState
        {
            get { return this._attachmentState; }
            set { this._attachmentState = value; }
        }

        // Check to see if AttachmentState property is set
        internal bool IsSetAttachmentState()
        {
            return this._attachmentState != null;
        }

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
        public AutoMountStatus AutoMountStatus
        {
            get { return this._autoMountStatus; }
            set { this._autoMountStatus = value; }
        }

        // Check to see if AutoMountStatus property is set
        internal bool IsSetAutoMountStatus()
        {
            return this._autoMountStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the disk was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GbInUse. 
        /// <para>
        /// (Deprecated) The number of GB in use by the disk.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to November 14, 2017, this parameter was not included in the API
        /// response. It is now deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("In releases prior to November 14, 2017, this parameter was not included in the API response. It is now deprecated.")]
        public int GbInUse
        {
            get { return this._gbInUse.GetValueOrDefault(); }
            set { this._gbInUse = value; }
        }

        // Check to see if GbInUse property is set
        internal bool IsSetGbInUse()
        {
            return this._gbInUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The input/output operations per second (IOPS) of the disk.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAttached. 
        /// <para>
        /// A Boolean value indicating whether the disk is attached.
        /// </para>
        /// </summary>
        public bool IsAttached
        {
            get { return this._isAttached.GetValueOrDefault(); }
            set { this._isAttached = value; }
        }

        // Check to see if IsAttached property is set
        internal bool IsSetIsAttached()
        {
            return this._isAttached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSystemDisk. 
        /// <para>
        /// A Boolean value indicating whether this disk is a system disk (has an operating system
        /// loaded on it).
        /// </para>
        /// </summary>
        public bool IsSystemDisk
        {
            get { return this._isSystemDisk.GetValueOrDefault(); }
            set { this._isSystemDisk = value; }
        }

        // Check to see if IsSystemDisk property is set
        internal bool IsSetIsSystemDisk()
        {
            return this._isSystemDisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region and Availability Zone where the disk is located.
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
        /// The unique name of the disk.
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The disk path.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (e.g., <code>Disk</code>).
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
        /// The size of the disk in GB.
        /// </para>
        /// </summary>
        public int SizeInGb
        {
            get { return this._sizeInGb.GetValueOrDefault(); }
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
        /// Describes the status of the disk.
        /// </para>
        /// </summary>
        public DiskState State
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
        /// in Lightsail, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
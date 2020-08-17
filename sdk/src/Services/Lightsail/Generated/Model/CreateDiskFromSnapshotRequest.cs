/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateDiskFromSnapshot operation.
    /// Creates a block storage disk from a manual or automatic snapshot of a disk. The resulting
    /// disk can be attached to an Amazon Lightsail instance in the same Availability Zone
    /// (e.g., <code>us-east-2a</code>).
    /// 
    ///  
    /// <para>
    /// The <code>create disk from snapshot</code> operation supports tag-based access control
    /// via request tags and resource tags applied to the resource identified by <code>disk
    /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateDiskFromSnapshotRequest : AmazonLightsailRequest
    {
        private List<AddOnRequest> _addOns = new List<AddOnRequest>();
        private string _availabilityZone;
        private string _diskName;
        private string _diskSnapshotName;
        private string _restoreDate;
        private int? _sizeInGb;
        private string _sourceDiskName;
        private List<Tag> _tags = new List<Tag>();
        private bool? _useLatestRestorableAutoSnapshot;

        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects that represent the add-ons to enable for the new disk.
        /// </para>
        /// </summary>
        public List<AddOnRequest> AddOns
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where you want to create the disk (e.g., <code>us-east-2a</code>).
        /// Choose the same Availability Zone as the Lightsail instance where you want to create
        /// the disk.
        /// </para>
        ///  
        /// <para>
        /// Use the GetRegions operation to list the Availability Zones where Lightsail is currently
        /// available.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique Lightsail disk name (e.g., <code>my-disk</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiskName
        {
            get { return this._diskName; }
            set { this._diskName = value; }
        }

        // Check to see if DiskName property is set
        internal bool IsSetDiskName()
        {
            return this._diskName != null;
        }

        /// <summary>
        /// Gets and sets the property DiskSnapshotName. 
        /// <para>
        /// The name of the disk snapshot (e.g., <code>my-snapshot</code>) from which to create
        /// the new storage disk.
        /// </para>
        ///  
        /// <para>
        /// Constraint:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <code>source disk name</code> parameter.
        /// The <code>disk snapshot name</code> and <code>source disk name</code> parameters are
        /// mutually exclusive.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DiskSnapshotName
        {
            get { return this._diskSnapshotName; }
            set { this._diskSnapshotName = value; }
        }

        // Check to see if DiskSnapshotName property is set
        internal bool IsSetDiskSnapshotName()
        {
            return this._diskSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreDate. 
        /// <para>
        /// The date of the automatic snapshot to use for the new disk. Use the <code>get auto
        /// snapshots</code> operation to identify the dates of the available automatic snapshots.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be specified in <code>YYYY-MM-DD</code> format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <code>use latest restorable auto
        /// snapshot</code> parameter. The <code>restore date</code> and <code>use latest restorable
        /// auto snapshot</code> parameters are mutually exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new disk from an automatic snapshot. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RestoreDate
        {
            get { return this._restoreDate; }
            set { this._restoreDate = value; }
        }

        // Check to see if RestoreDate property is set
        internal bool IsSetRestoreDate()
        {
            return this._restoreDate != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB (e.g., <code>32</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// This parameter cannot be defined together with the <code>disk snapshot name</code>
        /// parameter. The <code>source disk name</code> and <code>disk snapshot name</code> parameters
        /// are mutually exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new disk from an automatic snapshot. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDiskName
        {
            get { return this._sourceDiskName; }
            set { this._sourceDiskName = value; }
        }

        // Check to see if SourceDiskName property is set
        internal bool IsSetSourceDiskName()
        {
            return this._sourceDiskName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>TagResource</code> action to tag a resource after it's created.
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
        /// This parameter cannot be defined together with the <code>restore date</code> parameter.
        /// The <code>use latest restorable auto snapshot</code> and <code>restore date</code>
        /// parameters are mutually exclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Define this parameter only when creating a new disk from an automatic snapshot. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool UseLatestRestorableAutoSnapshot
        {
            get { return this._useLatestRestorableAutoSnapshot.GetValueOrDefault(); }
            set { this._useLatestRestorableAutoSnapshot = value; }
        }

        // Check to see if UseLatestRestorableAutoSnapshot property is set
        internal bool IsSetUseLatestRestorableAutoSnapshot()
        {
            return this._useLatestRestorableAutoSnapshot.HasValue; 
        }

    }
}
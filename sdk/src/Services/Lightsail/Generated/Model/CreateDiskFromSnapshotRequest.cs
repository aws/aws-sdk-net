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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDiskFromSnapshot operation.
    /// Creates a block storage disk from a disk snapshot that can be attached to a Lightsail
    /// instance in the same Availability Zone (e.g., <code>us-east-2a</code>). The disk is
    /// created in the regional endpoint that you send the HTTP request to. For more information,
    /// see <a href="https://lightsail.aws.amazon.com/ls/docs/overview/article/understanding-regions-and-availability-zones-in-amazon-lightsail">Regions
    /// and Availability Zones in Lightsail</a>.
    /// 
    ///  
    /// <para>
    /// The <code>create disk from snapshot</code> operation supports tag-based access control
    /// via request tags and resource tags applied to the resource identified by diskSnapshotName.
    /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateDiskFromSnapshotRequest : AmazonLightsailRequest
    {
        private string _availabilityZone;
        private string _diskName;
        private string _diskSnapshotName;
        private int? _sizeInGb;
        private List<Tag> _tags = new List<Tag>();

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
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB (e.g., <code>32</code>).
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// To tag a resource after it has been created, see the <code>tag resource</code> operation.
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
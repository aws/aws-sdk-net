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
    /// Container for the parameters to the CreateDisk operation.
    /// Creates a block storage disk that can be attached to an Amazon Lightsail instance
    /// in the same Availability Zone (e.g., <code>us-east-2a</code>).
    /// 
    ///  
    /// <para>
    /// The <code>create disk</code> operation supports tag-based access control via request
    /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateDiskRequest : AmazonLightsailRequest
    {
        private List<AddOnRequest> _addOns = new List<AddOnRequest>();
        private string _availabilityZone;
        private string _diskName;
        private int? _sizeInGb;
        private List<Tag> _tags = new List<Tag>();

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
        /// Use the same Availability Zone as the Lightsail instance to which you want to attach
        /// the disk.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>get regions</code> operation to list the Availability Zones where Lightsail
        /// is currently available.
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

    }
}
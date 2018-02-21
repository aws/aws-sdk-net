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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshot operation.
    /// Creates a snapshot of an EBS volume and stores it in Amazon S3. You can use snapshots
    /// for backups, to make copies of EBS volumes, and to save data before shutting down
    /// an instance.
    /// 
    ///  
    /// <para>
    /// When a snapshot is created, any AWS Marketplace product codes that are associated
    /// with the source volume are propagated to the snapshot.
    /// </para>
    ///  
    /// <para>
    /// You can take a snapshot of an attached volume that is in use. However, snapshots only
    /// capture data that has been written to your EBS volume at the time the snapshot command
    /// is issued; this may exclude any data that has been cached by any applications or the
    /// operating system. If you can pause any file systems on the volume long enough to take
    /// a snapshot, your snapshot should be complete. However, if you cannot pause all file
    /// writes to the volume, you should unmount the volume from within the instance, issue
    /// the snapshot command, and then remount the volume to ensure a consistent and complete
    /// snapshot. You may remount and use your volume while the snapshot status is <code>pending</code>.
    /// </para>
    ///  
    /// <para>
    /// To create a snapshot for EBS volumes that serve as root devices, you should stop the
    /// instance before taking the snapshot.
    /// </para>
    ///  
    /// <para>
    /// Snapshots that are taken from encrypted volumes are automatically encrypted. Volumes
    /// that are created from encrypted snapshots are also automatically encrypted. Your encrypted
    /// volumes and any associated snapshots always remain protected.
    /// </para>
    ///  
    /// <para>
    /// You can tag your snapshots during creation. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Amazon EC2 Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
    /// Elastic Block Store</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonEC2Request
    {
        private string _description;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _volumeId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateSnapshotRequest() { }

        /// <summary>
        /// Instantiates CreateSnapshotRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeId">The ID of the EBS volume.</param>
        /// <param name="description">A description for the snapshot.</param>
        public CreateSnapshotRequest(string volumeId, string description)
        {
            _volumeId = volumeId;
            _description = description;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the snapshot during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the EBS volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}
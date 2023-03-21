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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
    /// You can create snapshots of volumes in a Region and volumes on an Outpost. If you
    /// create a snapshot of a volume in a Region, the snapshot must be stored in the same
    /// Region as the volume. If you create a snapshot of a volume on an Outpost, the snapshot
    /// can be stored on the same Outpost as the volume, or in the Region for that Outpost.
    /// </para>
    ///  
    /// <para>
    /// When a snapshot is created, any Amazon Web Services Marketplace product codes that
    /// are associated with the source volume are propagated to the snapshot.
    /// </para>
    ///  
    /// <para>
    /// You can take a snapshot of an attached volume that is in use. However, snapshots only
    /// capture data that has been written to your Amazon EBS volume at the time the snapshot
    /// command is issued; this might exclude any data that has been cached by any applications
    /// or the operating system. If you can pause any file systems on the volume long enough
    /// to take a snapshot, your snapshot should be complete. However, if you cannot pause
    /// all file writes to the volume, you should unmount the volume from within the instance,
    /// issue the snapshot command, and then remount the volume to ensure a consistent and
    /// complete snapshot. You may remount and use your volume while the snapshot status is
    /// <code>pending</code>.
    /// </para>
    ///  
    /// <para>
    /// When you create a snapshot for an EBS volume that serves as a root device, we recommend
    /// that you stop the instance before taking the snapshot.
    /// </para>
    ///  
    /// <para>
    /// Snapshots that are taken from encrypted volumes are automatically encrypted. Volumes
    /// that are created from encrypted snapshots are also automatically encrypted. Your encrypted
    /// volumes and any associated snapshots always remain protected.
    /// </para>
    ///  
    /// <para>
    /// You can tag your snapshots during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
    /// Elastic Block Store</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonEC2Request
    {
        private string _description;
        private string _outpostArn;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _volumeId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateSnapshotRequest() { }

        /// <summary>
        /// Instantiates CreateSnapshotRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume.</param>
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost on which to create a local snapshot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a snapshot of a volume in a Region, omit this parameter. The snapshot is
        /// created in the same Region as the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a snapshot of a volume on an Outpost and store the snapshot in the Region,
        /// omit this parameter. The snapshot is created in the Region for the Outpost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a snapshot of a volume on an Outpost and store the snapshot on an Outpost,
        /// specify the ARN of the destination Outpost. The snapshot must be created on the same
        /// Outpost as the volume.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#create-snapshot">Create
        /// local snapshots from volumes on an Outpost</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
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
        /// The ID of the Amazon EBS volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
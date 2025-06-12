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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// The location of the source EBS volume determines where you can create the snapshot.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source volume is in a Region, you must create the snapshot in the same Region
    /// as the volume.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source volume is in a Local Zone, you can create the snapshot in the same Local
    /// Zone or in its parent Amazon Web Services Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source volume is on an Outpost, you can create the snapshot on the same Outpost
    /// or in its parent Amazon Web Services Region.
    /// </para>
    ///  </li> </ul> 
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
    /// <c>pending</c>.
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
    /// volumes and any associated snapshots always remain protected. For more information,
    /// see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonEC2Request
    {
        private string _description;
        private bool? _dryRun;
        private SnapshotLocationEnum _location;
        private string _outpostArn;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. <note> 
        /// <para>
        /// Only supported for volumes in Local Zones. If the source volume is not in a Local
        /// Zone, omit this parameter.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// To create a local snapshot in the same Local Zone as the source volume, specify <c>local</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a regional snapshot in the parent Region of the Local Zone, specify <c>regional</c>
        /// or omit this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default value: <c>regional</c> 
        /// </para>
        /// </summary>
        public SnapshotLocationEnum Location
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
        /// Gets and sets the property OutpostArn. <note> 
        /// <para>
        /// Only supported for volumes on Outposts. If the source volume is not on an Outpost,
        /// omit this parameter.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// To create the snapshot on the same Outpost as the source volume, specify the ARN of
        /// that Outpost. The snapshot must be created on the same Outpost as the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create the snapshot in the parent Region of the Outpost, omit this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#create-snapshot">Create
        /// local snapshots from volumes on an Outpost</a> in the <i>Amazon EBS User Guide</i>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
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
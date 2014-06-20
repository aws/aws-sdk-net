/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshot operation.
    /// <para>Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3. You can use snapshots for backups, to make copies of Amazon EBS
    /// volumes, and to save data before shutting down an instance.</para> <para>When a snapshot is created, any AWS Marketplace product codes that
    /// are associated with the source volume are propagated to the snapshot.</para> <para>You can take a snapshot of an attached volume that is in
    /// use. However, snapshots only capture data that has been written to your Amazon EBS volume at the time the snapshot command is issued; this
    /// may exclude any data that has been cached by any applications or the operating system. If you can pause any file writes to the volume long
    /// enough to take a snapshot, your snapshot should be complete. However, if you cannot pause all file writes to the volume, you should unmount
    /// the volume from within the instance, issue the snapshot command, and then remount the volume to ensure a consistent and complete snapshot.
    /// You may remount and use your volume while the snapshot status is <c>pending</c> .</para> <para>To create a snapshot for Amazon EBS volumes
    /// that serve as root devices, you should stop the instance before taking the snapshot.</para> <para>Snapshots that are taken from encrypted
    /// volumes are automatically encrypted. Volumes that are created from encrypted snapshots are also automatically encrypted. Your encrypted
    /// volumes and any associated snapshots always remain protected.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html" >Amazon Elastic Block Store</a> and <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html" >Amazon EBS Encryption</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateSnapshotRequest : EC2Request
    {    
        private string volumeIdField;
        private string descriptionField;

        /// <summary>
        /// The ID of the Amazon EBS volume of which to take a snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Amazon EBS volume of which to take a snapshot.
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume of which to
        /// take a snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateSnapshotRequest WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }

        /// <summary>
        /// Description of the Amazon EBS snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the Amazon EBS snapshot.
        /// </summary>
        /// <param name="description">Description of the Amazon EBS snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateSnapshotRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

    }
}

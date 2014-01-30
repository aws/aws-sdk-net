/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3. You can use snapshots for backups, to make copies of Amazon EBS
    /// volumes, and to save data before shutting down an instance.</para> <para>When a snapshot is created, any AWS Marketplace product codes that
    /// are associated with the source volume are propagated to the snapshot.</para> <para>You can take a snapshot of an attached volume that is in
    /// use. However, snapshots only capture data that has been written to your Amazon EBS volume at the time the snapshot command is issued; this
    /// may exclude any data that has been cached by any applications or the operating system. If you can pause any file writes to the volume long
    /// enough to take a snapshot, your snapshot should be complete. However, if you cannot pause all file writes to the volume, you should unmount
    /// the volume from within the instance, issue the snapshot command, and then remount the volume to ensure a consistent and complete snapshot.
    /// You may remount and use your volume while the snapshot status is <c>pending</c> .</para> <para>To create a snapshot for Amazon EBS volumes
    /// that serve as root devices, you should stop the instance before taking the snapshot.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html" >Creating an Amazon EBS Snapshot</a> in the <i>Amazon
    /// Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonEC2Request
    {
        private string volumeId;
        private string description;


        /// <summary>
        /// The ID of the Amazon EBS volume.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// A description for the snapshot.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

    }
}
    

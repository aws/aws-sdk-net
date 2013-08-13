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
    /// Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3.
    /// You can use snapshots for backups, to make identical copies of instance
    /// devices, and to save data before shutting down an instance.
    /// </summary>
    /// <remarks>
    /// When taking a snapshot of a file system, we recommend unmounting it
    /// first. This ensures the file system metadata is in a consistent state,
    /// that the 'mounted indicator' is cleared, and that all applications
    /// using that file system are stopped and in a consistent state. Some file
    /// systems, such as xfs, can freeze and unfreeze activity so a
    /// snapshot can be made without unmounting.
    ///
    /// For Linux/UNIX, enter the
    /// following command from the command line.
    ///
    /// umount -d /dev/sdh
    ///
    /// For Windows, open Disk Management, right-click the volume to unmount,
    /// and select Change Drive Letter and Path. Then, select the mount
    /// point to remove and click Remove.
    /// </remarks>
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

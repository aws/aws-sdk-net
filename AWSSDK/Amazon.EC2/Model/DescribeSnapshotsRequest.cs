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
    /// Returns information about Amazon EBS snapshots available to the user.
    /// </summary>
    /// <remarks>
    /// Information returned includes volume ID, status, start time, progress,
    /// owner ID, volume size, and description. Snapshots available to the user
    /// include public snapshots available for any user to launch, private
    /// snapshots owned by the user making the request, and private snapshots
    /// owned by other users for which the user granted explicit create
    /// volume permissions.
    ///
    /// The create volume permissions fall into 3 categories:
    ///
    /// public
    ///
    /// The owner of the snapshot granted create volume permissions for the
    /// snapshot to the all group. All users have create volume permissions
    /// for these snapshots.
    ///
    /// explicit
    ///
    /// The owner of the snapshot granted create volume permissions to a
    /// specific user.
    ///
    /// implicit
    ///
    /// A user has implicit create volume permissions for all snapshots he
    /// or she owns.
    ///
    /// The list of snapshots returned can be modified by specifying
    /// snapshot IDs, snapshot owners, or users with create volume permissions.
    ///
    /// If no options are specified, Amazon EC2 returns all snapshots for
    /// which the user has create volume permissions.
    ///
    /// If you specify one or more snapshot IDs, only snapshots that have
    /// the specified IDs are returned. If you specify an invalid snapshot ID,
    /// a fault is returned. If you specify a snapshot ID for which you do not
    /// have access, it will not be included in the returned results.
    ///
    /// If you specify one or more snapshot owners, only snapshots from the
    /// specified owners and for which you have access are returned. The
    /// results can include the AWS Account IDs of the specified owners,
    /// amazon for snapshots owned by Amazon or self for snapshots that you own.
    ///
    /// If you specify a list of restorable users, only users that
    /// have create snapshot permissions for the snapshots are returned.
    /// You can specify AWS Account IDs (if you own the snapshot(s)), self for
    /// snapshots for which you own or have explicit permissions, or all for
    /// public snapshots.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeSnapshotsRequest : EC2Request
    {    
        private List<string> snapshotIdField;
        private string ownerField;
        private string restorableByField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more snapshot IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public List<string> SnapshotId
        {
            get
            {
                if (this.snapshotIdField == null)
                {
                    this.snapshotIdField = new List<string>();
                }
                return this.snapshotIdField;
            }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets snapshot IDs.
        /// </summary>
        /// <param name="list">The ID of the Amazon EBS snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithSnapshotId(params string[] list)
        {
            foreach (string item in list)
            {
                SnapshotId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SnapshotId property is set
        /// </summary>
        /// <returns>true if SnapshotId property is set</returns>
        public bool IsSetSnapshotId()
        {
            return (SnapshotId.Count > 0);
        }

        /// <summary>
        /// Owner of the snapshots to return.
        /// Valid Values: self |amazon | AWS Account ID
        /// </summary>
        [XmlElementAttribute(ElementName = "Owner")]
        public string Owner
        {
            get { return this.ownerField; }
            set { this.ownerField = value; }
        }

        /// <summary>
        /// Sets the owner of the snapshots to return.
        /// </summary>
        /// <param name="owner">Returns snapshots owned by the specified
        /// owner. Valid Values: self | amazon | AWS Account ID</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithOwner(string owner)
        {
            this.ownerField = owner;
            return this;
        }

        /// <summary>
        /// Checks if Owner property is set
        /// </summary>
        /// <returns>true if Owner property is set</returns>
        public bool IsSetOwner()
        {
            return this.ownerField != null;
        }

        /// <summary>
        /// Account ID of a user that can create volumes from the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "RestorableBy")]
        public string RestorableBy
        {
            get { return this.restorableByField; }
            set { this.restorableByField = value; }
        }

        /// <summary>
        /// Sets the Account ID of a user that can create volumes from the snapshot.
        /// </summary>
        /// <param name="restorableBy">Account ID of a user that can create volumes
        /// from the snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithRestorableBy(string restorableBy)
        {
            this.restorableByField = restorableBy;
            return this;
        }

        /// <summary>
        /// Checks if RestorableBy property is set
        /// </summary>
        /// <returns>true if RestorableBy property is set</returns>
        public bool IsSetRestorableBy()
        {
            return this.restorableByField != null;
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Snapshots.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Snapshots.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Snapshots.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}

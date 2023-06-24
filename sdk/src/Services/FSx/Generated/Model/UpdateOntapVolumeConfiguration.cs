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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Used to specify changes to the ONTAP configuration for the volume you are updating.
    /// </summary>
    public partial class UpdateOntapVolumeConfiguration
    {
        private bool? _copyTagsToBackups;
        private string _junctionPath;
        private SecurityStyle _securityStyle;
        private int? _sizeInMegabytes;
        private string _snapshotPolicy;
        private bool? _storageEfficiencyEnabled;
        private TieringPolicy _tieringPolicy;

        /// <summary>
        /// Gets and sets the property CopyTagsToBackups. 
        /// <para>
        /// A boolean flag indicating whether tags for the volume should be copied to backups.
        /// This value defaults to false. If it's set to true, all tags for the volume are copied
        /// to all automatic and user-initiated backups where the user doesn't specify tags. If
        /// this value is true, and you specify one or more tags, only the specified tags are
        /// copied to backups. If you specify one or more tags when creating a user-initiated
        /// backup, no tags are copied from the volume, regardless of this value.
        /// </para>
        /// </summary>
        public bool CopyTagsToBackups
        {
            get { return this._copyTagsToBackups.GetValueOrDefault(); }
            set { this._copyTagsToBackups = value; }
        }

        // Check to see if CopyTagsToBackups property is set
        internal bool IsSetCopyTagsToBackups()
        {
            return this._copyTagsToBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JunctionPath. 
        /// <para>
        /// Specifies the location in the SVM's namespace where the volume is mounted. The <code>JunctionPath</code>
        /// must have a leading forward slash, such as <code>/vol3</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string JunctionPath
        {
            get { return this._junctionPath; }
            set { this._junctionPath = value; }
        }

        // Check to see if JunctionPath property is set
        internal bool IsSetJunctionPath()
        {
            return this._junctionPath != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityStyle. 
        /// <para>
        /// The security style for the volume, which can be <code>UNIX</code>. <code>NTFS</code>,
        /// or <code>MIXED</code>.
        /// </para>
        /// </summary>
        public SecurityStyle SecurityStyle
        {
            get { return this._securityStyle; }
            set { this._securityStyle = value; }
        }

        // Check to see if SecurityStyle property is set
        internal bool IsSetSecurityStyle()
        {
            return this._securityStyle != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInMegabytes. 
        /// <para>
        /// Specifies the size of the volume in megabytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int SizeInMegabytes
        {
            get { return this._sizeInMegabytes.GetValueOrDefault(); }
            set { this._sizeInMegabytes = value; }
        }

        // Check to see if SizeInMegabytes property is set
        internal bool IsSetSizeInMegabytes()
        {
            return this._sizeInMegabytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotPolicy. 
        /// <para>
        /// Specifies the snapshot policy for the volume. There are three built-in snapshot policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>default</code>: This is the default policy. A maximum of six hourly snapshots
        /// taken five minutes past the hour. A maximum of two daily snapshots taken Monday through
        /// Saturday at 10 minutes after midnight. A maximum of two weekly snapshots taken every
        /// Sunday at 15 minutes after midnight.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-1weekly</code>: This policy is the same as the <code>default</code>
        /// policy except that it only retains one snapshot from the weekly schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>none</code>: This policy does not take any snapshots. This policy can be assigned
        /// to volumes to prevent automatic snapshots from being taken.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide the name of a custom policy that you created with the ONTAP CLI
        /// or REST API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snapshots-ontap.html#snapshot-policies">Snapshot
        /// policies</a> in the <i>Amazon FSx for NetApp ONTAP User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SnapshotPolicy
        {
            get { return this._snapshotPolicy; }
            set { this._snapshotPolicy = value; }
        }

        // Check to see if SnapshotPolicy property is set
        internal bool IsSetSnapshotPolicy()
        {
            return this._snapshotPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property StorageEfficiencyEnabled. 
        /// <para>
        /// Default is <code>false</code>. Set to true to enable the deduplication, compression,
        /// and compaction storage efficiency features on the volume.
        /// </para>
        /// </summary>
        public bool StorageEfficiencyEnabled
        {
            get { return this._storageEfficiencyEnabled.GetValueOrDefault(); }
            set { this._storageEfficiencyEnabled = value; }
        }

        // Check to see if StorageEfficiencyEnabled property is set
        internal bool IsSetStorageEfficiencyEnabled()
        {
            return this._storageEfficiencyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TieringPolicy. 
        /// <para>
        /// Update the volume's data tiering policy.
        /// </para>
        /// </summary>
        public TieringPolicy TieringPolicy
        {
            get { return this._tieringPolicy; }
            set { this._tieringPolicy = value; }
        }

        // Check to see if TieringPolicy property is set
        internal bool IsSetTieringPolicy()
        {
            return this._tieringPolicy != null;
        }

    }
}
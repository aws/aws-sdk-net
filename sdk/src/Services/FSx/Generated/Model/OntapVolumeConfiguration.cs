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
    /// The configuration of an Amazon FSx for NetApp ONTAP volume.
    /// </summary>
    public partial class OntapVolumeConfiguration
    {
        private bool? _copyTagsToBackups;
        private FlexCacheEndpointType _flexCacheEndpointType;
        private string _junctionPath;
        private OntapVolumeType _ontapVolumeType;
        private SecurityStyle _securityStyle;
        private int? _sizeInMegabytes;
        private string _snapshotPolicy;
        private bool? _storageEfficiencyEnabled;
        private string _storageVirtualMachineId;
        private bool? _storageVirtualMachineRoot;
        private TieringPolicy _tieringPolicy;
        private string _uuid;

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
        /// Gets and sets the property FlexCacheEndpointType. 
        /// <para>
        /// Specifies the FlexCache endpoint type of the volume. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> specifies that the volume doesn't have a FlexCache configuration.
        /// <code>NONE</code> is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ORIGIN</code> specifies that the volume is the origin volume for a FlexCache
        /// volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CACHE</code> specifies that the volume is a FlexCache volume.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FlexCacheEndpointType FlexCacheEndpointType
        {
            get { return this._flexCacheEndpointType; }
            set { this._flexCacheEndpointType = value; }
        }

        // Check to see if FlexCacheEndpointType property is set
        internal bool IsSetFlexCacheEndpointType()
        {
            return this._flexCacheEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property JunctionPath. 
        /// <para>
        /// Specifies the directory that network-attached storage (NAS) clients use to mount the
        /// volume, along with the storage virtual machine (SVM) Domain Name System (DNS) name
        /// or IP address. You can create a <code>JunctionPath</code> directly below a parent
        /// volume junction or on a directory within a volume. A <code>JunctionPath</code> for
        /// a volume named <code>vol3</code> might be <code>/vol1/vol2/vol3</code>, or <code>/vol1/dir2/vol3</code>,
        /// or even <code>/dir1/dir2/vol3</code>.
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
        /// Gets and sets the property OntapVolumeType. 
        /// <para>
        /// Specifies the type of volume. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RW</code> specifies a read/write volume. <code>RW</code> is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DP</code> specifies a data-protection volume. You can protect data by replicating
        /// it to data-protection mirror copies. If a disaster occurs, you can use these data-protection
        /// mirror copies to recover data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LS</code> specifies a load-sharing mirror volume. A load-sharing mirror reduces
        /// the network traffic to a FlexVol volume by providing additional read-only access to
        /// clients.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OntapVolumeType OntapVolumeType
        {
            get { return this._ontapVolumeType; }
            set { this._ontapVolumeType = value; }
        }

        // Check to see if OntapVolumeType property is set
        internal bool IsSetOntapVolumeType()
        {
            return this._ontapVolumeType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityStyle. 
        /// <para>
        /// The security style for the volume, which can be <code>UNIX</code>, <code>NTFS</code>,
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
        /// The configured size of the volume, in megabytes (MBs).
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
        /// The volume's storage efficiency setting.
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
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// The ID of the volume's storage virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string StorageVirtualMachineId
        {
            get { return this._storageVirtualMachineId; }
            set { this._storageVirtualMachineId = value; }
        }

        // Check to see if StorageVirtualMachineId property is set
        internal bool IsSetStorageVirtualMachineId()
        {
            return this._storageVirtualMachineId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineRoot. 
        /// <para>
        /// A Boolean flag indicating whether this volume is the root volume for its storage virtual
        /// machine (SVM). Only one volume on an SVM can be the root volume. This value defaults
        /// to <code>false</code>. If this value is <code>true</code>, then this is the SVM root
        /// volume.
        /// </para>
        ///  
        /// <para>
        /// This flag is useful when you're deleting an SVM, because you must first delete all
        /// non-root volumes. This flag, when set to <code>false</code>, helps you identify which
        /// volumes to delete before you can delete the SVM.
        /// </para>
        /// </summary>
        public bool StorageVirtualMachineRoot
        {
            get { return this._storageVirtualMachineRoot.GetValueOrDefault(); }
            set { this._storageVirtualMachineRoot = value; }
        }

        // Check to see if StorageVirtualMachineRoot property is set
        internal bool IsSetStorageVirtualMachineRoot()
        {
            return this._storageVirtualMachineRoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TieringPolicy. 
        /// <para>
        /// The volume's <code>TieringPolicy</code> setting.
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

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The volume's universally unique identifier (UUID).
        /// </para>
        /// </summary>
        [AWSProperty(Max=36)]
        public string UUID
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uuid != null;
        }

    }
}
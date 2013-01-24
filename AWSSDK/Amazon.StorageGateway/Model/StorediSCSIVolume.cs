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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>Describes an iSCSI stored volume.</para>
    /// </summary>
    public class StorediSCSIVolume  
    {
        
        private string volumeARN;
        private string volumeId;
        private string volumeType;
        private string volumeStatus;
        private long? volumeSizeInBytes;
        private double? volumeProgress;
        private string volumeDiskId;
        private string sourceSnapshotId;
        private bool? preservedExistingData;
        private VolumeiSCSIAttributes volumeiSCSIAttributes;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the storage volume.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        /// <summary>
        /// Sets the VolumeARN property
        /// </summary>
        /// <param name="volumeARN">The value to set for the VolumeARN property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeARN(string volumeARN)
        {
            this.volumeARN = volumeARN;
            return this;
        }
            

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;       
        }

        /// <summary>
        /// The unique identifier of the volume, e.g. vol-AE4B946D.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>12 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        /// <summary>
        /// Sets the VolumeId property
        /// </summary>
        /// <param name="volumeId">The value to set for the VolumeId property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeId(string volumeId)
        {
            this.volumeId = volumeId;
            return this;
        }
            

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;       
        }

        /// <summary>
        /// One of the <a>VolumeType</a> enumeration values describing the type of the volume.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>STORED iSCSI, CACHED iSCSI</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeType
        {
            get { return this.volumeType; }
            set { this.volumeType = value; }
        }

        /// <summary>
        /// Sets the VolumeType property
        /// </summary>
        /// <param name="volumeType">The value to set for the VolumeType property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeType(string volumeType)
        {
            this.volumeType = volumeType;
            return this;
        }
            

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this.volumeType != null;       
        }

        /// <summary>
        /// One of the <a>VolumeStatus</a> values that indicates the state of the storage volume.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATING, AVAILABLE, RESTORING, BOOTSTRAPPING, IRRECOVERABLE, PASS THROUGH, RESTORE AND PASS THROUGH, DELETED, WORKING STORAGE NOT CONFIGURED, UPLOAD BUFFER NOT CONFIGURED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeStatus
        {
            get { return this.volumeStatus; }
            set { this.volumeStatus = value; }
        }

        /// <summary>
        /// Sets the VolumeStatus property
        /// </summary>
        /// <param name="volumeStatus">The value to set for the VolumeStatus property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeStatus(string volumeStatus)
        {
            this.volumeStatus = volumeStatus;
            return this;
        }
            

        // Check to see if VolumeStatus property is set
        internal bool IsSetVolumeStatus()
        {
            return this.volumeStatus != null;       
        }

        /// <summary>
        /// The size of the volume in bytes.
        ///  
        /// </summary>
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the VolumeSizeInBytes property
        /// </summary>
        /// <param name="volumeSizeInBytes">The value to set for the VolumeSizeInBytes property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeSizeInBytes(long volumeSizeInBytes)
        {
            this.volumeSizeInBytes = volumeSizeInBytes;
            return this;
        }
            

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;       
        }

        /// <summary>
        /// Represents the percentage complete if the volume is restoring or bootstrapping that represents the percent of data transferred. This field
        /// does not appear in the response if the stored volume is not restoring or bootstrapping.
        ///  
        /// </summary>
        public double VolumeProgress
        {
            get { return this.volumeProgress ?? default(double); }
            set { this.volumeProgress = value; }
        }

        /// <summary>
        /// Sets the VolumeProgress property
        /// </summary>
        /// <param name="volumeProgress">The value to set for the VolumeProgress property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeProgress(double volumeProgress)
        {
            this.volumeProgress = volumeProgress;
            return this;
        }
            

        // Check to see if VolumeProgress property is set
        internal bool IsSetVolumeProgress()
        {
            return this.volumeProgress.HasValue;       
        }

        /// <summary>
        /// The disk ID of the local disk that was specified in the <a>CreateStorediSCSIVolume</a> operation.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 300</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeDiskId
        {
            get { return this.volumeDiskId; }
            set { this.volumeDiskId = value; }
        }

        /// <summary>
        /// Sets the VolumeDiskId property
        /// </summary>
        /// <param name="volumeDiskId">The value to set for the VolumeDiskId property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeDiskId(string volumeDiskId)
        {
            this.volumeDiskId = volumeDiskId;
            return this;
        }
            

        // Check to see if VolumeDiskId property is set
        internal bool IsSetVolumeDiskId()
        {
            return this.volumeDiskId != null;       
        }

        /// <summary>
        /// If the stored volume was created from a snapshot, this field contains the snapshot ID used, e.g. snap-78e22663. Otherwise, this field is not
        /// included.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\Asnap-[0-9a-fA-F]{8}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceSnapshotId
        {
            get { return this.sourceSnapshotId; }
            set { this.sourceSnapshotId = value; }
        }

        /// <summary>
        /// Sets the SourceSnapshotId property
        /// </summary>
        /// <param name="sourceSnapshotId">The value to set for the SourceSnapshotId property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithSourceSnapshotId(string sourceSnapshotId)
        {
            this.sourceSnapshotId = sourceSnapshotId;
            return this;
        }
            

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this.sourceSnapshotId != null;       
        }

        /// <summary>
        /// Indicates if when the stored volume was created, existing data on the underlying local disk was preserved. <i>Valid Values</i>: true, false
        ///  
        /// </summary>
        public bool PreservedExistingData
        {
            get { return this.preservedExistingData ?? default(bool); }
            set { this.preservedExistingData = value; }
        }

        /// <summary>
        /// Sets the PreservedExistingData property
        /// </summary>
        /// <param name="preservedExistingData">The value to set for the PreservedExistingData property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithPreservedExistingData(bool preservedExistingData)
        {
            this.preservedExistingData = preservedExistingData;
            return this;
        }
            

        // Check to see if PreservedExistingData property is set
        internal bool IsSetPreservedExistingData()
        {
            return this.preservedExistingData.HasValue;       
        }

        /// <summary>
        /// An <a>VolumeiSCSIAttributes</a> object that represents a collection of iSCSI attributes for one stored volume.
        ///  
        /// </summary>
        public VolumeiSCSIAttributes VolumeiSCSIAttributes
        {
            get { return this.volumeiSCSIAttributes; }
            set { this.volumeiSCSIAttributes = value; }
        }

        /// <summary>
        /// Sets the VolumeiSCSIAttributes property
        /// </summary>
        /// <param name="volumeiSCSIAttributes">The value to set for the VolumeiSCSIAttributes property </param>
        /// <returns>this instance</returns>
        public StorediSCSIVolume WithVolumeiSCSIAttributes(VolumeiSCSIAttributes volumeiSCSIAttributes)
        {
            this.volumeiSCSIAttributes = volumeiSCSIAttributes;
            return this;
        }
            

        // Check to see if VolumeiSCSIAttributes property is set
        internal bool IsSetVolumeiSCSIAttributes()
        {
            return this.volumeiSCSIAttributes != null;       
        }
    }
}

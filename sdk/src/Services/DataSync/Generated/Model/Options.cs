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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Indicates how your transfer task is configured. These options include how DataSync
    /// handles files, objects, and their associated metadata during your transfer. You also
    /// can specify how to verify data integrity, set bandwidth limits for your task, among
    /// other options.
    /// 
    ///  
    /// <para>
    /// Each option has a default value. Unless you need to, you don't have to configure any
    /// of these options before starting your task.
    /// </para>
    /// </summary>
    public partial class Options
    {
        private Atime _atime;
        private long? _bytesPerSecond;
        private Gid _gid;
        private LogLevel _logLevel;
        private Mtime _mtime;
        private ObjectTags _objectTags;
        private OverwriteMode _overwriteMode;
        private PosixPermissions _posixPermissions;
        private PreserveDeletedFiles _preserveDeletedFiles;
        private PreserveDevices _preserveDevices;
        private SmbSecurityDescriptorCopyFlags _securityDescriptorCopyFlags;
        private TaskQueueing _taskQueueing;
        private TransferMode _transferMode;
        private Uid _uid;
        private VerifyMode _verifyMode;

        /// <summary>
        /// Gets and sets the property Atime. 
        /// <para>
        /// Specifies whether to preserve metadata indicating the last time a file was read or
        /// written to. If you set <c>Atime</c> to <c>BEST_EFFORT</c>, DataSync attempts to preserve
        /// the original <c>Atime</c> attribute on all source files (that is, the version before
        /// the <c>PREPARING</c> phase of the task execution).
        /// </para>
        ///  <note> 
        /// <para>
        /// The behavior of <c>Atime</c> isn't fully standard across platforms, so DataSync can
        /// only do this on a best-effort basis.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default value: <c>BEST_EFFORT</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>BEST_EFFORT</c>: Attempt to preserve the per-file <c>Atime</c> value (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: Ignore <c>Atime</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>Atime</c> is set to <c>BEST_EFFORT</c>, <c>Mtime</c> must be set to <c>PRESERVE</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If <c>Atime</c> is set to <c>NONE</c>, <c>Mtime</c> must also be <c>NONE</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        public Atime Atime
        {
            get { return this._atime; }
            set { this._atime = value; }
        }

        // Check to see if Atime property is set
        internal bool IsSetAtime()
        {
            return this._atime != null;
        }

        /// <summary>
        /// Gets and sets the property BytesPerSecond. 
        /// <para>
        /// Limits the bandwidth used by a DataSync task. For example, if you want DataSync to
        /// use a maximum of 1 MB, set this value to <c>1048576</c> (<c>=1024*1024</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1)]
        public long BytesPerSecond
        {
            get { return this._bytesPerSecond.GetValueOrDefault(); }
            set { this._bytesPerSecond = value; }
        }

        // Check to see if BytesPerSecond property is set
        internal bool IsSetBytesPerSecond()
        {
            return this._bytesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// Specifies the POSIX group ID (GID) of the file's owners.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>INT_VALUE</c>. This preserves the integer value of the ID.
        /// </para>
        ///  
        /// <para>
        ///  <c>INT_VALUE</c>: Preserve the integer value of user ID (UID) and GID (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: Ignore UID and GID.
        /// </para>
        /// </summary>
        public Gid Gid
        {
            get { return this._gid; }
            set { this._gid = value; }
        }

        // Check to see if Gid property is set
        internal bool IsSetGid()
        {
            return this._gid != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Specifies the type of logs that DataSync publishes to a Amazon CloudWatch Logs log
        /// group. To specify the log group, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateTask.html#DataSync-CreateTask-request-CloudWatchLogGroupArn">CloudWatchLogGroupArn</a>.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>LogLevel</c> to <c>OFF</c>, no logs are published. <c>BASIC</c> publishes
        /// logs on errors for individual files transferred. <c>TRANSFER</c> publishes logs for
        /// every file or object that is transferred and integrity checked.
        /// </para>
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Mtime. 
        /// <para>
        /// Specifies whether to preserve metadata indicating the last time that a file was written
        /// to before the <c>PREPARING</c> phase of your task execution. This option is required
        /// when you need to run the a task more than once.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>PRESERVE</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>PRESERVE</c>: Preserve original <c>Mtime</c> (recommended)
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: Ignore <c>Mtime</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>Mtime</c> is set to <c>PRESERVE</c>, <c>Atime</c> must be set to <c>BEST_EFFORT</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>Mtime</c> is set to <c>NONE</c>, <c>Atime</c> must also be set to <c>NONE</c>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public Mtime Mtime
        {
            get { return this._mtime; }
            set { this._mtime = value; }
        }

        // Check to see if Mtime property is set
        internal bool IsSetMtime()
        {
            return this._mtime != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectTags. 
        /// <para>
        /// Specifies whether object tags are preserved when transferring between object storage
        /// systems. If you want your DataSync task to ignore object tags, specify the <c>NONE</c>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>PRESERVE</c> 
        /// </para>
        /// </summary>
        public ObjectTags ObjectTags
        {
            get { return this._objectTags; }
            set { this._objectTags = value; }
        }

        // Check to see if ObjectTags property is set
        internal bool IsSetObjectTags()
        {
            return this._objectTags != null;
        }

        /// <summary>
        /// Gets and sets the property OverwriteMode. 
        /// <para>
        /// Specifies whether data at the destination location should be overwritten or preserved.
        /// If set to <c>NEVER</c>, a destination file for example will not be replaced by a source
        /// file (even if the destination file differs from the source file). If you modify files
        /// in the destination and you sync the files, you can use this value to protect against
        /// overwriting those changes. 
        /// </para>
        ///  
        /// <para>
        /// Some storage classes have specific behaviors that can affect your Amazon S3 storage
        /// cost. For detailed information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Considerations
        /// when working with Amazon S3 storage classes in DataSync</a>.
        /// </para>
        /// </summary>
        public OverwriteMode OverwriteMode
        {
            get { return this._overwriteMode; }
            set { this._overwriteMode = value; }
        }

        // Check to see if OverwriteMode property is set
        internal bool IsSetOverwriteMode()
        {
            return this._overwriteMode != null;
        }

        /// <summary>
        /// Gets and sets the property PosixPermissions. 
        /// <para>
        /// Specifies which users or groups can access a file for a specific purpose such as reading,
        /// writing, or execution of the file.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>PRESERVE</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>PRESERVE</c>: Preserve POSIX-style permissions (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: Ignore permissions. 
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync can preserve extant permissions of a source location.
        /// </para>
        ///  </note>
        /// </summary>
        public PosixPermissions PosixPermissions
        {
            get { return this._posixPermissions; }
            set { this._posixPermissions = value; }
        }

        // Check to see if PosixPermissions property is set
        internal bool IsSetPosixPermissions()
        {
            return this._posixPermissions != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveDeletedFiles. 
        /// <para>
        /// Specifies whether files in the destination location that don't exist in the source
        /// should be preserved. This option can affect your Amazon S3 storage cost. If your task
        /// deletes objects, you might incur minimum storage duration charges for certain storage
        /// classes. For detailed information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Considerations
        /// when working with Amazon S3 storage classes in DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>PRESERVE</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>PRESERVE</c>: Ignore such destination files (recommended). 
        /// </para>
        ///  
        /// <para>
        ///  <c>REMOVE</c>: Delete destination files that aren’t present in the source.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set this parameter to <c>REMOVE</c>, you can't set <c>TransferMode</c> to <c>ALL</c>.
        /// When you transfer all data, DataSync doesn't scan your destination location and doesn't
        /// know what to delete.
        /// </para>
        ///  </note>
        /// </summary>
        public PreserveDeletedFiles PreserveDeletedFiles
        {
            get { return this._preserveDeletedFiles; }
            set { this._preserveDeletedFiles = value; }
        }

        // Check to see if PreserveDeletedFiles property is set
        internal bool IsSetPreserveDeletedFiles()
        {
            return this._preserveDeletedFiles != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveDevices. 
        /// <para>
        /// Specifies whether DataSync should preserve the metadata of block and character devices
        /// in the source location and recreate the files with that device name and metadata on
        /// the destination. DataSync copies only the name and metadata of such devices.
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync can't copy the actual contents of these devices because they're nonterminal
        /// and don't return an end-of-file (EOF) marker.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default value: <c>NONE</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: Ignore special devices (recommended). 
        /// </para>
        ///  
        /// <para>
        ///  <c>PRESERVE</c>: Preserve character and block device metadata. This option currently
        /// isn't supported for Amazon EFS. 
        /// </para>
        /// </summary>
        public PreserveDevices PreserveDevices
        {
            get { return this._preserveDevices; }
            set { this._preserveDevices = value; }
        }

        // Check to see if PreserveDevices property is set
        internal bool IsSetPreserveDevices()
        {
            return this._preserveDevices != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityDescriptorCopyFlags. 
        /// <para>
        /// Specifies which components of the SMB security descriptor are copied from source to
        /// destination objects. 
        /// </para>
        ///  
        /// <para>
        /// This value is only used for transfers between SMB and Amazon FSx for Windows File
        /// Server locations or between two FSx for Windows File Server locations. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html">how
        /// DataSync handles metadata</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>OWNER_DACL</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>OWNER_DACL</c>: For each copied object, DataSync copies the following metadata:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The object owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NTFS discretionary access control lists (DACLs), which determine whether to grant
        /// access to an object.
        /// </para>
        ///  
        /// <para>
        /// DataSync won't copy NTFS system access control lists (SACLs) with this option.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>OWNER_DACL_SACL</c>: For each copied object, DataSync copies the following metadata:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The object owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NTFS discretionary access control lists (DACLs), which determine whether to grant
        /// access to an object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SACLs, which are used by administrators to log attempts to access a secured object.
        /// </para>
        ///  
        /// <para>
        /// Copying SACLs requires granting additional permissions to the Windows user that DataSync
        /// uses to access your SMB location. For information about choosing a user that ensures
        /// sufficient permissions to files, folders, and metadata, see <a href="create-smb-location.html#SMBuser">user</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>NONE</c>: None of the SMB security descriptor components are copied. Destination
        /// objects are owned by the user that was provided for accessing the destination location.
        /// DACLs and SACLs are set based on the destination server’s configuration. 
        /// </para>
        /// </summary>
        public SmbSecurityDescriptorCopyFlags SecurityDescriptorCopyFlags
        {
            get { return this._securityDescriptorCopyFlags; }
            set { this._securityDescriptorCopyFlags = value; }
        }

        // Check to see if SecurityDescriptorCopyFlags property is set
        internal bool IsSetSecurityDescriptorCopyFlags()
        {
            return this._securityDescriptorCopyFlags != null;
        }

        /// <summary>
        /// Gets and sets the property TaskQueueing. 
        /// <para>
        /// Specifies whether your transfer tasks should be put into a queue during certain scenarios
        /// when <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#running-multiple-tasks">running
        /// multiple tasks</a>. This is <c>ENABLED</c> by default.
        /// </para>
        /// </summary>
        public TaskQueueing TaskQueueing
        {
            get { return this._taskQueueing; }
            set { this._taskQueueing = value; }
        }

        // Check to see if TaskQueueing property is set
        internal bool IsSetTaskQueueing()
        {
            return this._taskQueueing != null;
        }

        /// <summary>
        /// Gets and sets the property TransferMode. 
        /// <para>
        /// Determines whether DataSync transfers only the data and metadata that differ between
        /// the source and the destination location or transfers all the content from the source
        /// (without comparing what's in the destination).
        /// </para>
        ///  
        /// <para>
        ///  <c>CHANGED</c>: DataSync copies only data or metadata that is new or different content
        /// from the source location to the destination location.
        /// </para>
        ///  
        /// <para>
        ///  <c>ALL</c>: DataSync copies all source location content to the destination (without
        /// comparing what's in the destination).
        /// </para>
        /// </summary>
        public TransferMode TransferMode
        {
            get { return this._transferMode; }
            set { this._transferMode = value; }
        }

        // Check to see if TransferMode property is set
        internal bool IsSetTransferMode()
        {
            return this._transferMode != null;
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// Specifies the POSIX user ID (UID) of the file's owner.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>INT_VALUE</c>. This preserves the integer value of the ID.
        /// </para>
        ///  
        /// <para>
        ///  <c>INT_VALUE</c>: Preserve the integer value of UID and group ID (GID) (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: Ignore UID and GID. 
        /// </para>
        /// </summary>
        public Uid Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property VerifyMode. 
        /// <para>
        /// Specifies how and when DataSync checks the integrity of your data during a transfer.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>POINT_IN_TIME_CONSISTENT</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>ONLY_FILES_TRANSFERRED</c> (recommended): DataSync calculates the checksum of
        /// transferred files and metadata at the source location. At the end of the transfer,
        /// DataSync then compares this checksum to the checksum calculated on those files at
        /// the destination.
        /// </para>
        ///  
        /// <para>
        /// We recommend this option when transferring to S3 Glacier Flexible Retrieval or S3
        /// Glacier Deep Archive storage classes. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>POINT_IN_TIME_CONSISTENT</c>: At the end of the transfer, DataSync scans the entire
        /// source and destination to verify that both locations are fully synchronized.
        /// </para>
        ///  
        /// <para>
        /// You can't use this option when transferring to S3 Glacier Flexible Retrieval or S3
        /// Glacier Deep Archive storage classes. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>NONE</c>: DataSync doesn't run additional verification at the end of the transfer.
        /// All data transmissions are still integrity-checked with checksum verification during
        /// the transfer.
        /// </para>
        /// </summary>
        public VerifyMode VerifyMode
        {
            get { return this._verifyMode; }
            set { this._verifyMode = value; }
        }

        // Check to see if VerifyMode property is set
        internal bool IsSetVerifyMode()
        {
            return this._verifyMode != null;
        }

    }
}
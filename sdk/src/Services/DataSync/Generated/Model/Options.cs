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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// option before calling <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_StartTaskExecution.html">StartTaskExecution</a>.
    /// </para>
    ///  
    /// <para>
    /// You also can override your task options for each task execution. For example, you
    /// might want to adjust the <c>LogLevel</c> for an individual execution.
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
        /// written to.
        /// </para>
        ///  <note> 
        /// <para>
        /// The behavior of <c>Atime</c> isn't fully standard across platforms, so DataSync can
        /// only do this on a best-effort basis.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>BEST_EFFORT</c> (default) - DataSync attempts to preserve the original <c>Atime</c>
        /// attribute on all source files (that is, the version before the <c>PREPARING</c> steps
        /// of the task execution). This option is recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - Ignores <c>Atime</c>.
        /// </para>
        ///  </li> </ul> <note> 
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
        ///  <note> 
        /// <para>
        /// Not applicable to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=-1)]
        public long? BytesPerSecond
        {
            get { return this._bytesPerSecond; }
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>INT_VALUE</c> (default) - Preserves the integer value of user ID (UID) and GID,
        /// which is recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - Ignores UID and GID.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/metadata-copied.html">Understanding
        /// how DataSync handles file and object metadata</a>.
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>BASIC</c> - Publishes logs with only basic information (such as transfer errors).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSFER</c> - Publishes logs for all files or objects that your DataSync task
        /// transfers and performs data-integrity checks on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OFF</c> - No logs are published.
        /// </para>
        ///  </li> </ul>
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
        /// to before the <c>PREPARING</c> step of your task execution. This option is required
        /// when you need to run the a task more than once.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRESERVE</c> (default) - Preserves original <c>Mtime</c>, which is recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - Ignores <c>Mtime</c>.
        /// </para>
        ///  </li> </ul> <note> 
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
        /// Specifies whether you want DataSync to <c>PRESERVE</c> object tags (default behavior)
        /// when transferring between object storage systems. If you want your DataSync task to
        /// ignore object tags, specify the <c>NONE</c> value.
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
        /// Specifies whether DataSync should modify or preserve data at the destination location.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALWAYS</c> (default) - DataSync modifies data in the destination location when
        /// source data (including metadata) has changed.
        /// </para>
        ///  
        /// <para>
        /// If DataSync overwrites objects, you might incur additional charges for certain Amazon
        /// S3 storage classes (for example, for retrieval or early deletion). For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 transfers</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEVER</c> - DataSync doesn't overwrite data in the destination location even if
        /// the source data has changed. You can use this option to protect against overwriting
        /// changes made to files or objects in the destination.
        /// </para>
        ///  </li> </ul>
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
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/metadata-copied.html">Understanding
        /// how DataSync handles file and object metadata</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRESERVE</c> (default) - Preserves POSIX-style permissions, which is recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - Ignores POSIX-style permissions. 
        /// </para>
        ///  </li> </ul> <note> 
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRESERVE</c> (default) - Ignores such destination files, which is recommended.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVE</c> - Deletes destination files that aren’t present in the source.
        /// </para>
        ///  </li> </ul> <note> 
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
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>NONE</c> (default) - Ignores special devices (recommended).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRESERVE</c> - Preserves character and block device metadata. This option currently
        /// isn't supported for Amazon EFS.
        /// </para>
        ///  </li> </ul>
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
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/metadata-copied.html">Understanding
        /// how DataSync handles file and object metadata</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OWNER_DACL</c> (default) - For each copied object, DataSync copies the following
        /// metadata:
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
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>OWNER_DACL_SACL</c> - For each copied object, DataSync copies the following metadata:
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
        /// uses to access your SMB location. For information about choosing a user with the right
        /// permissions, see required permissions for <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">SMB</a>,
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-windows-location-permissions">FSx
        /// for Windows File Server</a>, or <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-smb">FSx
        /// for ONTAP</a> (depending on the type of location in your transfer).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NONE</c> - None of the SMB security descriptor components are copied. Destination
        /// objects are owned by the user that was provided for accessing the destination location.
        /// DACLs and SACLs are set based on the destination server’s configuration. 
        /// </para>
        ///  </li> </ul>
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
        /// Specifies whether DataSync transfers only the data (including metadata) that differs
        /// between locations following an initial copy or transfers all data every time you run
        /// the task. If you're planning on recurring transfers, you might only want to transfer
        /// what's changed since your previous task execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHANGED</c> (default) - After your initial full transfer, DataSync copies only
        /// the data and metadata that differs between the source and destination location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - DataSync copies everything in the source to the destination without
        /// comparing differences between the locations.
        /// </para>
        ///  </li> </ul>
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>INT_VALUE</c> (default) - Preserves the integer value of UID and group ID (GID),
        /// which is recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - Ignores UID and GID. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
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
        /// Specifies if and how DataSync checks the integrity of your data at the end of your
        /// transfer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ONLY_FILES_TRANSFERRED</c> (recommended) - DataSync calculates the checksum of
        /// transferred data (including metadata) at the source location. At the end of the transfer,
        /// DataSync then compares this checksum to the checksum calculated on that data at the
        /// destination.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is the default option for <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// We recommend this option when transferring to S3 Glacier Flexible Retrieval or S3
        /// Glacier Deep Archive storage classes. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POINT_IN_TIME_CONSISTENT</c> - At the end of the transfer, DataSync checks the
        /// entire source and destination to verify that both locations are fully synchronized.
        /// </para>
        ///  <note> 
        /// <para>
        /// The is the default option for <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Basic
        /// mode tasks</a> and isn't currently supported with Enhanced mode tasks.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you use a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">manifest</a>,
        /// DataSync only scans and verifies what's listed in the manifest.
        /// </para>
        ///  
        /// <para>
        /// You can't use this option when transferring to S3 Glacier Flexible Retrieval or S3
        /// Glacier Deep Archive storage classes. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - DataSync performs data integrity checks only during your transfer.
        /// Unlike other options, there's no additional verification at the end of your transfer.
        /// </para>
        ///  </li> </ul>
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
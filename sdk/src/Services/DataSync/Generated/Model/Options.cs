/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Represents the options that are available to control the behavior of a <a>StartTaskExecution</a>
    /// operation. Behavior includes preserving metadata such as user ID (UID), group ID (GID),
    /// and file permissions, and also overwriting files in the destination, data integrity
    /// verification, and so on.
    /// 
    ///  
    /// <para>
    /// A task has a set of default options associated with it. If you don't specify an option
    /// in <a>StartTaskExecution</a>, the default value is used. You can override the defaults
    /// options on each task execution by specifying an overriding <code>Options</code> value
    /// to <a>StartTaskExecution</a>.
    /// </para>
    /// </summary>
    public partial class Options
    {
        private Atime _atime;
        private long? _bytesPerSecond;
        private Gid _gid;
        private Mtime _mtime;
        private PosixPermissions _posixPermissions;
        private PreserveDeletedFiles _preserveDeletedFiles;
        private PreserveDevices _preserveDevices;
        private Uid _uid;
        private VerifyMode _verifyMode;

        /// <summary>
        /// Gets and sets the property Atime. 
        /// <para>
        /// A file metadata value that shows the last time a file was accessed (that is, when
        /// the file was read or written to). If you set <code>Atime</code> to BEST_EFFORT, DataSync
        /// attempts to preserve the original <code>Atime</code> attribute on all source files
        /// (that is, the version before the PREPARING phase). However, <code>Atime</code>'s behavior
        /// is not fully standard across platforms, so AWS DataSync can only do this on a best-effort
        /// basis. 
        /// </para>
        ///  
        /// <para>
        /// Default value: BEST_EFFORT.
        /// </para>
        ///  
        /// <para>
        /// BEST_EFFORT: Attempt to preserve the per-file <code>Atime</code> value (recommended).
        /// </para>
        ///  
        /// <para>
        /// NONE: Ignore <code>Atime</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>Atime</code> is set to BEST_EFFORT, <code>Mtime</code> must be set to PRESERVE.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If <code>Atime</code> is set to NONE, <code>Mtime</code> must also be NONE. 
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
        /// A value that limits the bandwidth used by AWS DataSync. For example, if you want AWS
        /// DataSync to use a maximum of 1 MB, set this value to <code>1048576</code> (<code>=1024*1024</code>).
        /// </para>
        /// </summary>
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
        /// The group ID (GID) of the file's owners. 
        /// </para>
        ///  
        /// <para>
        /// Default value: INT_VALUE. This preserves the integer value of the ID.
        /// </para>
        ///  
        /// <para>
        /// INT_VALUE: Preserve the integer value of user ID (UID) and GID (recommended).
        /// </para>
        ///  
        /// <para>
        /// NONE: Ignore UID and GID. 
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
        /// Gets and sets the property Mtime. 
        /// <para>
        /// A value that indicates the last time that a file was modified (that is, a file was
        /// written to) before the PREPARING phase. 
        /// </para>
        ///  
        /// <para>
        /// Default value: PRESERVE. 
        /// </para>
        ///  
        /// <para>
        /// PRESERVE: Preserve original <code>Mtime</code> (recommended)
        /// </para>
        ///  
        /// <para>
        ///  NONE: Ignore <code>Mtime</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>Mtime</code> is set to PRESERVE, <code>Atime</code> must be set to BEST_EFFORT.
        /// </para>
        ///  
        /// <para>
        /// If <code>Mtime</code> is set to NONE, <code>Atime</code> must also be set to NONE.
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
        /// Gets and sets the property PosixPermissions. 
        /// <para>
        /// A value that determines which users or groups can access a file for a specific purpose
        /// such as reading, writing, or execution of the file. 
        /// </para>
        ///  
        /// <para>
        /// Default value: PRESERVE.
        /// </para>
        ///  
        /// <para>
        /// PRESERVE: Preserve POSIX-style permissions (recommended).
        /// </para>
        ///  
        /// <para>
        /// NONE: Ignore permissions. 
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DataSync can preserve extant permissions of a source location.
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
        /// A value that specifies whether files in the destination that don't exist in the source
        /// file system should be preserved. 
        /// </para>
        ///  
        /// <para>
        /// Default value: PRESERVE.
        /// </para>
        ///  
        /// <para>
        /// PRESERVE: Ignore such destination files (recommended). 
        /// </para>
        ///  
        /// <para>
        /// REMOVE: Delete destination files that aren’t present in the source.
        /// </para>
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
        /// A value that determines whether AWS DataSync should preserve the metadata of block
        /// and character devices in the source file system, and recreate the files with that
        /// device name and metadata on the destination.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DataSync can't sync the actual contents of such devices, because they are nonterminal
        /// and don't return an end-of-file (EOF) marker.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default value: NONE.
        /// </para>
        ///  
        /// <para>
        /// NONE: Ignore special devices (recommended). 
        /// </para>
        ///  
        /// <para>
        /// PRESERVE: Preserve character and block device metadata. This option isn't currently
        /// supported for Amazon EFS. 
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
        /// Gets and sets the property Uid. 
        /// <para>
        /// The user ID (UID) of the file's owner. 
        /// </para>
        ///  
        /// <para>
        /// Default value: INT_VALUE. This preserves the integer value of the ID.
        /// </para>
        ///  
        /// <para>
        /// INT_VALUE: Preserve the integer value of UID and group ID (GID) (recommended).
        /// </para>
        ///  
        /// <para>
        /// NONE: Ignore UID and GID. 
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
        /// A value that determines whether a data integrity verification should be performed
        /// at the end of a task execution after all data and metadata have been transferred.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default value: POINT_IN_TIME_CONSISTENT.
        /// </para>
        ///  
        /// <para>
        /// POINT_IN_TIME_CONSISTENT: Perform verification (recommended). 
        /// </para>
        ///  
        /// <para>
        /// NONE: Skip verification.
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
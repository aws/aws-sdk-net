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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Additional information about the suspicious activity.
    /// </summary>
    public partial class RuntimeContext
    {
        private string _addressFamily;
        private string _fileSystemType;
        private List<string> _flags = new List<string>();
        private int? _ianaProtocolNumber;
        private string _ldPreloadValue;
        private string _libraryPath;
        private List<string> _memoryRegions = new List<string>();
        private DateTime? _modifiedAt;
        private ProcessDetails _modifyingProcess;
        private string _moduleFilePath;
        private string _moduleName;
        private string _moduleSha256;
        private string _mountSource;
        private string _mountTarget;
        private string _releaseAgentPath;
        private string _runcBinaryPath;
        private string _scriptPath;
        private string _shellHistoryFilePath;
        private string _socketPath;
        private ProcessDetails _targetProcess;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// Represents the communication protocol associated with the address. For example, the
        /// address family <code>AF_INET</code> is used for IP version of 4 protocol.
        /// </para>
        /// </summary>
        public string AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemType. 
        /// <para>
        /// Represents the type of mounted fileSystem.
        /// </para>
        /// </summary>
        public string FileSystemType
        {
            get { return this._fileSystemType; }
            set { this._fileSystemType = value; }
        }

        // Check to see if FileSystemType property is set
        internal bool IsSetFileSystemType()
        {
            return this._fileSystemType != null;
        }

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Represents options that control the behavior of a runtime operation or action. For
        /// example, a filesystem mount operation may contain a read-only flag.
        /// </para>
        /// </summary>
        public List<string> Flags
        {
            get { return this._flags; }
            set { this._flags = value; }
        }

        // Check to see if Flags property is set
        internal bool IsSetFlags()
        {
            return this._flags != null && this._flags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IanaProtocolNumber. 
        /// <para>
        /// Specifies a particular protocol within the address family. Usually there is a single
        /// protocol in address families. For example, the address family <code>AF_INET</code>
        /// only has the IP protocol.
        /// </para>
        /// </summary>
        public int IanaProtocolNumber
        {
            get { return this._ianaProtocolNumber.GetValueOrDefault(); }
            set { this._ianaProtocolNumber = value; }
        }

        // Check to see if IanaProtocolNumber property is set
        internal bool IsSetIanaProtocolNumber()
        {
            return this._ianaProtocolNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LdPreloadValue. 
        /// <para>
        /// The value of the LD_PRELOAD environment variable.
        /// </para>
        /// </summary>
        public string LdPreloadValue
        {
            get { return this._ldPreloadValue; }
            set { this._ldPreloadValue = value; }
        }

        // Check to see if LdPreloadValue property is set
        internal bool IsSetLdPreloadValue()
        {
            return this._ldPreloadValue != null;
        }

        /// <summary>
        /// Gets and sets the property LibraryPath. 
        /// <para>
        /// The path to the new library that was loaded.
        /// </para>
        /// </summary>
        public string LibraryPath
        {
            get { return this._libraryPath; }
            set { this._libraryPath = value; }
        }

        // Check to see if LibraryPath property is set
        internal bool IsSetLibraryPath()
        {
            return this._libraryPath != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryRegions. 
        /// <para>
        /// Specifies the Region of a process's address space such as stack and heap.
        /// </para>
        /// </summary>
        public List<string> MemoryRegions
        {
            get { return this._memoryRegions; }
            set { this._memoryRegions = value; }
        }

        // Check to see if MemoryRegions property is set
        internal bool IsSetMemoryRegions()
        {
            return this._memoryRegions != null && this._memoryRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp at which the process modified the current process. The timestamp is
        /// in UTC date string format.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifyingProcess. 
        /// <para>
        /// Information about the process that modified the current process. This is available
        /// for multiple finding types.
        /// </para>
        /// </summary>
        public ProcessDetails ModifyingProcess
        {
            get { return this._modifyingProcess; }
            set { this._modifyingProcess = value; }
        }

        // Check to see if ModifyingProcess property is set
        internal bool IsSetModifyingProcess()
        {
            return this._modifyingProcess != null;
        }

        /// <summary>
        /// Gets and sets the property ModuleFilePath. 
        /// <para>
        /// The path to the module loaded into the kernel.
        /// </para>
        /// </summary>
        public string ModuleFilePath
        {
            get { return this._moduleFilePath; }
            set { this._moduleFilePath = value; }
        }

        // Check to see if ModuleFilePath property is set
        internal bool IsSetModuleFilePath()
        {
            return this._moduleFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property ModuleName. 
        /// <para>
        /// The name of the module loaded into the kernel.
        /// </para>
        /// </summary>
        public string ModuleName
        {
            get { return this._moduleName; }
            set { this._moduleName = value; }
        }

        // Check to see if ModuleName property is set
        internal bool IsSetModuleName()
        {
            return this._moduleName != null;
        }

        /// <summary>
        /// Gets and sets the property ModuleSha256. 
        /// <para>
        /// The <code>SHA256</code> hash of the module.
        /// </para>
        /// </summary>
        public string ModuleSha256
        {
            get { return this._moduleSha256; }
            set { this._moduleSha256 = value; }
        }

        // Check to see if ModuleSha256 property is set
        internal bool IsSetModuleSha256()
        {
            return this._moduleSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property MountSource. 
        /// <para>
        /// The path on the host that is mounted by the container.
        /// </para>
        /// </summary>
        public string MountSource
        {
            get { return this._mountSource; }
            set { this._mountSource = value; }
        }

        // Check to see if MountSource property is set
        internal bool IsSetMountSource()
        {
            return this._mountSource != null;
        }

        /// <summary>
        /// Gets and sets the property MountTarget. 
        /// <para>
        /// The path in the container that is mapped to the host directory.
        /// </para>
        /// </summary>
        public string MountTarget
        {
            get { return this._mountTarget; }
            set { this._mountTarget = value; }
        }

        // Check to see if MountTarget property is set
        internal bool IsSetMountTarget()
        {
            return this._mountTarget != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseAgentPath. 
        /// <para>
        /// The path in the container that modified the release agent file.
        /// </para>
        /// </summary>
        public string ReleaseAgentPath
        {
            get { return this._releaseAgentPath; }
            set { this._releaseAgentPath = value; }
        }

        // Check to see if ReleaseAgentPath property is set
        internal bool IsSetReleaseAgentPath()
        {
            return this._releaseAgentPath != null;
        }

        /// <summary>
        /// Gets and sets the property RuncBinaryPath. 
        /// <para>
        /// The path to the leveraged <code>runc</code> implementation.
        /// </para>
        /// </summary>
        public string RuncBinaryPath
        {
            get { return this._runcBinaryPath; }
            set { this._runcBinaryPath = value; }
        }

        // Check to see if RuncBinaryPath property is set
        internal bool IsSetRuncBinaryPath()
        {
            return this._runcBinaryPath != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptPath. 
        /// <para>
        /// The path to the script that was executed.
        /// </para>
        /// </summary>
        public string ScriptPath
        {
            get { return this._scriptPath; }
            set { this._scriptPath = value; }
        }

        // Check to see if ScriptPath property is set
        internal bool IsSetScriptPath()
        {
            return this._scriptPath != null;
        }

        /// <summary>
        /// Gets and sets the property ShellHistoryFilePath. 
        /// <para>
        /// The path to the modified shell history file.
        /// </para>
        /// </summary>
        public string ShellHistoryFilePath
        {
            get { return this._shellHistoryFilePath; }
            set { this._shellHistoryFilePath = value; }
        }

        // Check to see if ShellHistoryFilePath property is set
        internal bool IsSetShellHistoryFilePath()
        {
            return this._shellHistoryFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property SocketPath. 
        /// <para>
        /// The path to the docket socket that was accessed.
        /// </para>
        /// </summary>
        public string SocketPath
        {
            get { return this._socketPath; }
            set { this._socketPath = value; }
        }

        // Check to see if SocketPath property is set
        internal bool IsSetSocketPath()
        {
            return this._socketPath != null;
        }

        /// <summary>
        /// Gets and sets the property TargetProcess. 
        /// <para>
        /// Information about the process that had its memory overwritten by the current process.
        /// </para>
        /// </summary>
        public ProcessDetails TargetProcess
        {
            get { return this._targetProcess; }
            set { this._targetProcess = value; }
        }

        // Check to see if TargetProcess property is set
        internal bool IsSetTargetProcess()
        {
            return this._targetProcess != null;
        }

    }
}
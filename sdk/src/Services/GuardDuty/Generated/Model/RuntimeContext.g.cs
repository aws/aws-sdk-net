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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Additional information about the suspicious activity.
    /// </summary>
    public partial class RuntimeContext
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// Represents the communication protocol associated with the address. For example, the
        /// address family <c>AF_INET</c> is used for IP version of 4 protocol.
        /// </para>
        /// </summary>
        public string AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property CommandLineExample. 
        /// <para>
        /// Example of the command line involved in the suspicious activity.
        /// </para>
        /// </summary>
        public string CommandLineExample { get; set; }

        /// <summary>
        /// Checks to see if the CommandLineExample property is set.
        /// </summary>
        internal bool IsSetCommandLineExample() => this.CommandLineExample != null;

        /// <summary>
        /// Gets and sets the property FileOperation. 
        /// <para>
        /// Represents the type of file operation that triggered the finding, such as Write, Delete,
        /// Rename, Link, or Symlink.
        /// </para>
        /// </summary>
        public string FileOperation { get; set; }

        /// <summary>
        /// Checks to see if the FileOperation property is set.
        /// </summary>
        internal bool IsSetFileOperation() => this.FileOperation != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path of the sensitive file that was modified. Modification includes write, delete,
        /// rename, link, or symlink operations. This field is indexed for filtering.
        /// </para>
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property FileSystemType. 
        /// <para>
        /// Represents the type of mounted fileSystem.
        /// </para>
        /// </summary>
        public string FileSystemType { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemType property is set.
        /// </summary>
        internal bool IsSetFileSystemType() => this.FileSystemType != null;

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Represents options that control the behavior of a runtime operation or action. For
        /// example, a filesystem mount operation may contain a read-only flag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Flags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Flags property is set.
        /// </summary>
        internal bool IsSetFlags() => this.Flags != null && (this.Flags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IanaProtocolNumber. 
        /// <para>
        /// Specifies a particular protocol within the address family. Usually there is a single
        /// protocol in address families. For example, the address family <c>AF_INET</c> only
        /// has the IP protocol.
        /// </para>
        /// </summary>
        public int? IanaProtocolNumber { get; set; }

        /// <summary>
        /// Checks to see if the IanaProtocolNumber property is set.
        /// </summary>
        internal bool IsSetIanaProtocolNumber() => this.IanaProtocolNumber.HasValue;

        /// <summary>
        /// Gets and sets the property LdPreloadValue. 
        /// <para>
        /// The value of the LD_PRELOAD environment variable.
        /// </para>
        /// </summary>
        public string LdPreloadValue { get; set; }

        /// <summary>
        /// Checks to see if the LdPreloadValue property is set.
        /// </summary>
        internal bool IsSetLdPreloadValue() => this.LdPreloadValue != null;

        /// <summary>
        /// Gets and sets the property LibraryPath. 
        /// <para>
        /// The path to the new library that was loaded.
        /// </para>
        /// </summary>
        public string LibraryPath { get; set; }

        /// <summary>
        /// Checks to see if the LibraryPath property is set.
        /// </summary>
        internal bool IsSetLibraryPath() => this.LibraryPath != null;

        /// <summary>
        /// Gets and sets the property MemoryRegions. 
        /// <para>
        /// Specifies the Region of a process's address space such as stack and heap.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MemoryRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MemoryRegions property is set.
        /// </summary>
        internal bool IsSetMemoryRegions() => this.MemoryRegions != null && (this.MemoryRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp at which the process modified the current process. The timestamp is
        /// in UTC date string format.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModifyingProcess. 
        /// <para>
        /// Information about the process that modified the current process. This is available
        /// for multiple finding types.
        /// </para>
        /// </summary>
        public ProcessDetails ModifyingProcess { get; set; }

        /// <summary>
        /// Checks to see if the ModifyingProcess property is set.
        /// </summary>
        internal bool IsSetModifyingProcess() => this.ModifyingProcess != null;

        /// <summary>
        /// Gets and sets the property ModuleFilePath. 
        /// <para>
        /// The path to the module loaded into the kernel.
        /// </para>
        /// </summary>
        public string ModuleFilePath { get; set; }

        /// <summary>
        /// Checks to see if the ModuleFilePath property is set.
        /// </summary>
        internal bool IsSetModuleFilePath() => this.ModuleFilePath != null;

        /// <summary>
        /// Gets and sets the property ModuleName. 
        /// <para>
        /// The name of the module loaded into the kernel.
        /// </para>
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// Checks to see if the ModuleName property is set.
        /// </summary>
        internal bool IsSetModuleName() => this.ModuleName != null;

        /// <summary>
        /// Gets and sets the property ModuleSha256. 
        /// <para>
        /// The <c>SHA256</c> hash of the module.
        /// </para>
        /// </summary>
        public string ModuleSha256 { get; set; }

        /// <summary>
        /// Checks to see if the ModuleSha256 property is set.
        /// </summary>
        internal bool IsSetModuleSha256() => this.ModuleSha256 != null;

        /// <summary>
        /// Gets and sets the property MountSource. 
        /// <para>
        /// The path on the host that is mounted by the container.
        /// </para>
        /// </summary>
        public string MountSource { get; set; }

        /// <summary>
        /// Checks to see if the MountSource property is set.
        /// </summary>
        internal bool IsSetMountSource() => this.MountSource != null;

        /// <summary>
        /// Gets and sets the property MountTarget. 
        /// <para>
        /// The path in the container that is mapped to the host directory.
        /// </para>
        /// </summary>
        public string MountTarget { get; set; }

        /// <summary>
        /// Checks to see if the MountTarget property is set.
        /// </summary>
        internal bool IsSetMountTarget() => this.MountTarget != null;

        /// <summary>
        /// Gets and sets the property RelatedFilePaths. 
        /// <para>
        /// All file paths modified by the same process that triggered the finding, up to a maximum
        /// of 25 paths.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public List<string> RelatedFilePaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelatedFilePaths property is set.
        /// </summary>
        internal bool IsSetRelatedFilePaths() => this.RelatedFilePaths != null && (this.RelatedFilePaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReleaseAgentPath. 
        /// <para>
        /// The path in the container that modified the release agent file.
        /// </para>
        /// </summary>
        public string ReleaseAgentPath { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseAgentPath property is set.
        /// </summary>
        internal bool IsSetReleaseAgentPath() => this.ReleaseAgentPath != null;

        /// <summary>
        /// Gets and sets the property RuncBinaryPath. 
        /// <para>
        /// The path to the leveraged <c>runc</c> implementation.
        /// </para>
        /// </summary>
        public string RuncBinaryPath { get; set; }

        /// <summary>
        /// Checks to see if the RuncBinaryPath property is set.
        /// </summary>
        internal bool IsSetRuncBinaryPath() => this.RuncBinaryPath != null;

        /// <summary>
        /// Gets and sets the property ScriptPath. 
        /// <para>
        /// The path to the script that was executed.
        /// </para>
        /// </summary>
        public string ScriptPath { get; set; }

        /// <summary>
        /// Checks to see if the ScriptPath property is set.
        /// </summary>
        internal bool IsSetScriptPath() => this.ScriptPath != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Name of the security service that has been potentially disabled.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ShellHistoryFilePath. 
        /// <para>
        /// The path to the modified shell history file.
        /// </para>
        /// </summary>
        public string ShellHistoryFilePath { get; set; }

        /// <summary>
        /// Checks to see if the ShellHistoryFilePath property is set.
        /// </summary>
        internal bool IsSetShellHistoryFilePath() => this.ShellHistoryFilePath != null;

        /// <summary>
        /// Gets and sets the property SocketPath. 
        /// <para>
        /// The path to the docket socket that was accessed.
        /// </para>
        /// </summary>
        public string SocketPath { get; set; }

        /// <summary>
        /// Checks to see if the SocketPath property is set.
        /// </summary>
        internal bool IsSetSocketPath() => this.SocketPath != null;

        /// <summary>
        /// Gets and sets the property TargetProcess. 
        /// <para>
        /// Information about the process that had its memory overwritten by the current process.
        /// </para>
        /// </summary>
        public ProcessDetails TargetProcess { get; set; }

        /// <summary>
        /// Checks to see if the TargetProcess property is set.
        /// </summary>
        internal bool IsSetTargetProcess() => this.TargetProcess != null;

        /// <summary>
        /// Gets and sets the property ThreatFilePath. 
        /// <para>
        /// The suspicious file path for which the threat intelligence details were found.
        /// </para>
        /// </summary>
        public string ThreatFilePath { get; set; }

        /// <summary>
        /// Checks to see if the ThreatFilePath property is set.
        /// </summary>
        internal bool IsSetThreatFilePath() => this.ThreatFilePath != null;

        /// <summary>
        /// Gets and sets the property ToolCategory. 
        /// <para>
        /// Category that the tool belongs to. Some of the examples are Backdoor Tool, Pentest
        /// Tool, Network Scanner, and Network Sniffer.
        /// </para>
        /// </summary>
        public string ToolCategory { get; set; }

        /// <summary>
        /// Checks to see if the ToolCategory property is set.
        /// </summary>
        internal bool IsSetToolCategory() => this.ToolCategory != null;

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// Name of the potentially suspicious tool.
        /// </para>
        /// </summary>
        public string ToolName { get; set; }

        /// <summary>
        /// Checks to see if the ToolName property is set.
        /// </summary>
        internal bool IsSetToolName() => this.ToolName != null;
    }
}

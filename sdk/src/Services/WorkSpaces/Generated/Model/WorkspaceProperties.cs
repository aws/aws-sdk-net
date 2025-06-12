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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a WorkSpace.
    /// </summary>
    public partial class WorkspaceProperties
    {
        private Compute _computeTypeName;
        private GlobalAcceleratorForWorkSpace _globalAccelerator;
        private OperatingSystemName _operatingSystemName;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _rootVolumeSizeGib;
        private RunningMode _runningMode;
        private int? _runningModeAutoStopTimeoutInMinutes;
        private int? _userVolumeSizeGib;

        /// <summary>
        /// Gets and sets the property ComputeTypeName. 
        /// <para>
        /// The compute type. For more information, see <a href="http://aws.amazon.com/workspaces/details/#Amazon_WorkSpaces_Bundles">Amazon
        /// WorkSpaces Bundles</a>.
        /// </para>
        /// </summary>
        public Compute ComputeTypeName
        {
            get { return this._computeTypeName; }
            set { this._computeTypeName = value; }
        }

        // Check to see if ComputeTypeName property is set
        internal bool IsSetComputeTypeName()
        {
            return this._computeTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalAccelerator. 
        /// <para>
        /// Indicates the Global Accelerator properties.
        /// </para>
        /// </summary>
        public GlobalAcceleratorForWorkSpace GlobalAccelerator
        {
            get { return this._globalAccelerator; }
            set { this._globalAccelerator = value; }
        }

        // Check to see if GlobalAccelerator property is set
        internal bool IsSetGlobalAccelerator()
        {
            return this._globalAccelerator != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystemName. 
        /// <para>
        /// The name of the operating system.
        /// </para>
        /// </summary>
        public OperatingSystemName OperatingSystemName
        {
            get { return this._operatingSystemName; }
            set { this._operatingSystemName = value; }
        }

        // Check to see if OperatingSystemName property is set
        internal bool IsSetOperatingSystemName()
        {
            return this._operatingSystemName != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocol. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/amazon-workspaces-protocols.html">
        /// Protocols for Amazon WorkSpaces</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Only available for WorkSpaces created with PCoIP bundles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Protocols</c> property is case sensitive. Ensure you use <c>PCOIP</c> or <c>DCV</c>
        /// (formerly WSP).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unavailable for Windows 7 WorkSpaces and WorkSpaces using GPU-based bundles (Graphics,
        /// GraphicsPro, Graphics.g4dn, and GraphicsPro.g4dn).
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RootVolumeSizeGib. 
        /// <para>
        /// The size of the root volume. For important information about how to modify the size
        /// of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">Modify
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        public int? RootVolumeSizeGib
        {
            get { return this._rootVolumeSizeGib; }
            set { this._rootVolumeSizeGib = value; }
        }

        // Check to see if RootVolumeSizeGib property is set
        internal bool IsSetRootVolumeSizeGib()
        {
            return this._rootVolumeSizeGib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningMode. 
        /// <para>
        /// The running mode. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/running-mode.html">Manage
        /// the WorkSpace Running Mode</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>MANUAL</c> value is only supported by Amazon WorkSpaces Core. Contact your
        /// account team to be allow-listed to use this value. For more information, see <a href="http://aws.amazon.com/workspaces/core/">Amazon
        /// WorkSpaces Core</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Review your running mode to ensure you are using one that is optimal for your needs
        /// and budget. For more information on switching running modes, see <a href="http://aws.amazon.com/workspaces-family/workspaces/faqs/#:~:text=Can%20I%20switch%20between%20hourly%20and%20monthly%20billing%20on%20WorkSpaces%20Personal%3F">
        /// Can I switch between hourly and monthly billing?</a> 
        /// </para>
        /// </summary>
        public RunningMode RunningMode
        {
            get { return this._runningMode; }
            set { this._runningMode = value; }
        }

        // Check to see if RunningMode property is set
        internal bool IsSetRunningMode()
        {
            return this._runningMode != null;
        }

        /// <summary>
        /// Gets and sets the property RunningModeAutoStopTimeoutInMinutes. 
        /// <para>
        /// The time after a user logs off when WorkSpaces are automatically stopped. Configured
        /// in 60-minute intervals.
        /// </para>
        /// </summary>
        public int? RunningModeAutoStopTimeoutInMinutes
        {
            get { return this._runningModeAutoStopTimeoutInMinutes; }
            set { this._runningModeAutoStopTimeoutInMinutes = value; }
        }

        // Check to see if RunningModeAutoStopTimeoutInMinutes property is set
        internal bool IsSetRunningModeAutoStopTimeoutInMinutes()
        {
            return this._runningModeAutoStopTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserVolumeSizeGib. 
        /// <para>
        /// The size of the user storage. For important information about how to modify the size
        /// of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">Modify
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        public int? UserVolumeSizeGib
        {
            get { return this._userVolumeSizeGib; }
            set { this._userVolumeSizeGib = value; }
        }

        // Check to see if UserVolumeSizeGib property is set
        internal bool IsSetUserVolumeSizeGib()
        {
            return this._userVolumeSizeGib.HasValue; 
        }

    }
}
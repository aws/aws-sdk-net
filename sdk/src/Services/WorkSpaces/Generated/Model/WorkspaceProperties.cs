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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a WorkSpace.
    /// </summary>
    public partial class WorkspaceProperties
    {
        private Compute _computeTypeName;
        private List<string> _protocols = new List<string>();
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
        /// The <code>Protocols</code> property is case sensitive. Ensure you use <code>PCOIP</code>
        /// or <code>WSP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unavailable for Windows 7 WorkSpaces and WorkSpaces using GPU-based bundles (Graphics,
        /// GraphicsPro, Graphics.g4dn, and GraphicsPro.g4dn).
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RootVolumeSizeGib. 
        /// <para>
        /// The size of the root volume. For important information about how to modify the size
        /// of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">Modify
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        public int RootVolumeSizeGib
        {
            get { return this._rootVolumeSizeGib.GetValueOrDefault(); }
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
        /// The <code>MANUAL</code> value is only supported by Amazon WorkSpaces Core. Contact
        /// your account team to be allow-listed to use this value. For more information, see
        /// <a href="http://aws.amazon.com/workspaces/core/">Amazon WorkSpaces Core</a>.
        /// </para>
        ///  </note>
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
        public int RunningModeAutoStopTimeoutInMinutes
        {
            get { return this._runningModeAutoStopTimeoutInMinutes.GetValueOrDefault(); }
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
        public int UserVolumeSizeGib
        {
            get { return this._userVolumeSizeGib.GetValueOrDefault(); }
            set { this._userVolumeSizeGib = value; }
        }

        // Check to see if UserVolumeSizeGib property is set
        internal bool IsSetUserVolumeSizeGib()
        {
            return this._userVolumeSizeGib.HasValue; 
        }

    }
}
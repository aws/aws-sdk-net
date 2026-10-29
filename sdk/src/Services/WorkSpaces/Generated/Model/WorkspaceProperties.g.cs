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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a WorkSpace.
    /// </summary>
    public partial class WorkspaceProperties
    {
        /// <summary>
        /// Gets and sets the property ComputeTypeName. 
        /// <para>
        /// The compute type. For more information, see <a href="http://aws.amazon.com/workspaces/details/#Amazon_WorkSpaces_Bundles">Amazon
        /// WorkSpaces Bundles</a>.
        /// </para>
        /// </summary>
        public Compute ComputeTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeTypeName property is set.
        /// </summary>
        internal bool IsSetComputeTypeName() => this.ComputeTypeName != null;

        /// <summary>
        /// Gets and sets the property GlobalAccelerator. 
        /// <para>
        /// Indicates the Global Accelerator properties.
        /// </para>
        /// </summary>
        public GlobalAcceleratorForWorkSpace GlobalAccelerator { get; set; }

        /// <summary>
        /// Checks to see if the GlobalAccelerator property is set.
        /// </summary>
        internal bool IsSetGlobalAccelerator() => this.GlobalAccelerator != null;

        /// <summary>
        /// Gets and sets the property NestedVirtualizationEnabled. 
        /// <para>
        /// Specifies whether nested virtualization is enabled for the WorkSpace.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/nested-virtualization.html">Nested
        /// virtualization for Amazon WorkSpaces</a>.
        /// </para>
        /// </summary>
        public bool? NestedVirtualizationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the NestedVirtualizationEnabled property is set.
        /// </summary>
        internal bool IsSetNestedVirtualizationEnabled() => this.NestedVirtualizationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingSystemName. 
        /// <para>
        /// The name of the operating system.
        /// </para>
        /// </summary>
        public OperatingSystemName OperatingSystemName { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystemName property is set.
        /// </summary>
        internal bool IsSetOperatingSystemName() => this.OperatingSystemName != null;

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
        /// GraphicsPro, Graphics.g4dn, GraphicsPro.g4dn, Graphics.g6, and Graphics.g7).
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RootVolumeSizeGib. 
        /// <para>
        /// The size of the root volume. For important information about how to modify the size
        /// of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">Modify
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        public int? RootVolumeSizeGib { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeSizeGib property is set.
        /// </summary>
        internal bool IsSetRootVolumeSizeGib() => this.RootVolumeSizeGib.HasValue;

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
        public RunningMode RunningMode { get; set; }

        /// <summary>
        /// Checks to see if the RunningMode property is set.
        /// </summary>
        internal bool IsSetRunningMode() => this.RunningMode != null;

        /// <summary>
        /// Gets and sets the property RunningModeAutoStopTimeoutInMinutes. 
        /// <para>
        /// The time after a user logs off when WorkSpaces are automatically stopped. Configured
        /// in 60-minute intervals.
        /// </para>
        /// </summary>
        public int? RunningModeAutoStopTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the RunningModeAutoStopTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetRunningModeAutoStopTimeoutInMinutes() => this.RunningModeAutoStopTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property UserVolumeSizeGib. 
        /// <para>
        /// The size of the user storage. For important information about how to modify the size
        /// of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">Modify
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        public int? UserVolumeSizeGib { get; set; }

        /// <summary>
        /// Checks to see if the UserVolumeSizeGib property is set.
        /// </summary>
        internal bool IsSetUserVolumeSizeGib() => this.UserVolumeSizeGib.HasValue;
    }
}

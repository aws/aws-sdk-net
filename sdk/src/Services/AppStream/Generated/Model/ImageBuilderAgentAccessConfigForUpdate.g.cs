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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The configuration for updating agent access on an image builder. This type supports
    /// partial updates, so you only need to specify the fields you want to change. Fields
    /// that you omit keep their stored values.
    /// </summary>
    public partial class ImageBuilderAgentAccessConfigForUpdate
    {
        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where agent screenshots are
        /// stored. If ScreenshotsUploadEnabled is false after the merge, the stored bucket ARN
        /// is removed.
        /// </para>
        /// </summary>
        public string S3BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketArn property is set.
        /// </summary>
        internal bool IsSetS3BucketArn() => this.S3BucketArn != null;

        /// <summary>
        /// Gets and sets the property ScreenImageFormat. 
        /// <para>
        /// The image format for agent screen captures.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PNG - PNG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// JPEG - JPEG format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScreenImageFormat ScreenImageFormat { get; set; }

        /// <summary>
        /// Checks to see if the ScreenImageFormat property is set.
        /// </summary>
        internal bool IsSetScreenImageFormat() => this.ScreenImageFormat != null;

        /// <summary>
        /// Gets and sets the property ScreenResolution. 
        /// <para>
        /// The screen resolution for the agent streaming environment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// W_1280xH_720 - 1280 x 720 pixels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScreenResolution ScreenResolution { get; set; }

        /// <summary>
        /// Checks to see if the ScreenResolution property is set.
        /// </summary>
        internal bool IsSetScreenResolution() => this.ScreenResolution != null;

        /// <summary>
        /// Gets and sets the property ScreenshotsUploadEnabled. 
        /// <para>
        /// Specifies whether screenshot uploads to Amazon S3 are enabled for agent sessions.
        /// </para>
        /// </summary>
        public bool? ScreenshotsUploadEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ScreenshotsUploadEnabled property is set.
        /// </summary>
        internal bool IsSetScreenshotsUploadEnabled() => this.ScreenshotsUploadEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The list of agent access settings that define permissions for each agent action. These
        /// settings are merged with the stored settings by agent action. A setting that you specify
        /// replaces the stored setting for the same agent action. The merged settings must have
        /// at least one agent action enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<AgentAccessSetting> Settings { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentAccessSetting>() : null;

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null && (this.Settings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserControlMode. 
        /// <para>
        /// The user control mode for agent sessions. This setting determines how users can interact
        /// with agent sessions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VIEW_ONLY - Users can view and observe agent actions as they happen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VIEW_STOP - Users can view agent actions and stop the agent if needed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISABLED - Users cannot view or stop the agent session.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserControlMode UserControlMode { get; set; }

        /// <summary>
        /// Checks to see if the UserControlMode property is set.
        /// </summary>
        internal bool IsSetUserControlMode() => this.UserControlMode != null;
    }
}

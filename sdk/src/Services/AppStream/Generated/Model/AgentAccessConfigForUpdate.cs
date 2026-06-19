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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
    /// The configuration for updating agent access on a stack. This type supports partial
    /// updates, so you only need to specify the fields you want to change.
    /// </summary>
    public partial class AgentAccessConfigForUpdate
    {
        private string _s3BucketArn;
        private ScreenImageFormat _screenImageFormat;
        private ScreenResolution _screenResolution;
        private bool? _screenshotsUploadEnabled;
        private List<AgentAccessSetting> _settings = AWSConfigs.InitializeCollections ? new List<AgentAccessSetting>() : null;
        private UserControlMode _userControlMode;

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where agent screenshots are
        /// stored.
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScreenImageFormat. 
        /// <para>
        /// The image format for agent screen captures.
        /// </para>
        /// </summary>
        public ScreenImageFormat ScreenImageFormat
        {
            get { return this._screenImageFormat; }
            set { this._screenImageFormat = value; }
        }

        // Check to see if ScreenImageFormat property is set
        internal bool IsSetScreenImageFormat()
        {
            return this._screenImageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ScreenResolution. 
        /// <para>
        /// The screen resolution for the agent streaming environment.
        /// </para>
        /// </summary>
        public ScreenResolution ScreenResolution
        {
            get { return this._screenResolution; }
            set { this._screenResolution = value; }
        }

        // Check to see if ScreenResolution property is set
        internal bool IsSetScreenResolution()
        {
            return this._screenResolution != null;
        }

        /// <summary>
        /// Gets and sets the property ScreenshotsUploadEnabled. 
        /// <para>
        /// Indicates whether screenshot uploads to Amazon S3 are enabled for agent sessions.
        /// </para>
        /// </summary>
        public bool? ScreenshotsUploadEnabled
        {
            get { return this._screenshotsUploadEnabled; }
            set { this._screenshotsUploadEnabled = value; }
        }

        // Check to see if ScreenshotsUploadEnabled property is set
        internal bool IsSetScreenshotsUploadEnabled()
        {
            return this._screenshotsUploadEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The list of agent access settings that define permissions for each agent action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AgentAccessSetting> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null && (this._settings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserControlMode. 
        /// <para>
        /// The user control mode for agent sessions. This setting determines how users can interact
        /// with agent sessions.
        /// </para>
        /// </summary>
        public UserControlMode UserControlMode
        {
            get { return this._userControlMode; }
            set { this._userControlMode = value; }
        }

        // Check to see if UserControlMode property is set
        internal bool IsSetUserControlMode()
        {
            return this._userControlMode != null;
        }

    }
}
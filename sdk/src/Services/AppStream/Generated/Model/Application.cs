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
    /// Describes an application in the application catalog.
    /// </summary>
    public partial class Application
    {
        private string _appBlockArn;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private bool? _enabled;
        private S3Location _iconS3Location;
        private string _iconURL;
        private List<string> _instanceFamilies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _launchParameters;
        private string _launchPath;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;
        private List<string> _platforms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The app block ARN of the application.
        /// </para>
        /// </summary>
        public string AppBlockArn
        {
            get { return this._appBlockArn; }
            set { this._appBlockArn = value; }
        }

        // Check to see if AppBlockArn property is set
        internal bool IsSetAppBlockArn()
        {
            return this._appBlockArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time at which the application was created within the app block.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The application name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If there is a problem, the application can be disabled after image creation.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IconS3Location. 
        /// <para>
        /// The S3 location of the application icon.
        /// </para>
        /// </summary>
        public S3Location IconS3Location
        {
            get { return this._iconS3Location; }
            set { this._iconS3Location = value; }
        }

        // Check to see if IconS3Location property is set
        internal bool IsSetIconS3Location()
        {
            return this._iconS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property IconURL. 
        /// <para>
        /// The URL for the application icon. This URL might be time-limited.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string IconURL
        {
            get { return this._iconURL; }
            set { this._iconURL = value; }
        }

        // Check to see if IconURL property is set
        internal bool IsSetIconURL()
        {
            return this._iconURL != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFamilies. 
        /// <para>
        /// The instance families for the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceFamilies
        {
            get { return this._instanceFamilies; }
            set { this._instanceFamilies = value; }
        }

        // Check to see if InstanceFamilies property is set
        internal bool IsSetInstanceFamilies()
        {
            return this._instanceFamilies != null && (this._instanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// The arguments that are passed to the application at launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string LaunchParameters
        {
            get { return this._launchParameters; }
            set { this._launchParameters = value; }
        }

        // Check to see if LaunchParameters property is set
        internal bool IsSetLaunchParameters()
        {
            return this._launchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPath. 
        /// <para>
        /// The path to the application executable in the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string LaunchPath
        {
            get { return this._launchPath; }
            set { this._launchPath = value; }
        }

        // Check to see if LaunchPath property is set
        internal bool IsSetLaunchPath()
        {
            return this._launchPath != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional attributes that describe the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// The platforms on which the application can run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=4)]
        public List<string> Platforms
        {
            get { return this._platforms; }
            set { this._platforms = value; }
        }

        // Check to see if Platforms property is set
        internal bool IsSetPlatforms()
        {
            return this._platforms != null && (this._platforms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}
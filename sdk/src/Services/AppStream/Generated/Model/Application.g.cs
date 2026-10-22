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
    /// Describes an application in the application catalog.
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The app block ARN of the application.
        /// </para>
        /// </summary>
        public string AppBlockArn { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockArn property is set.
        /// </summary>
        internal bool IsSetAppBlockArn() => this.AppBlockArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time at which the application was created within the app block.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The application name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If there is a problem, the application can be disabled after image creation.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IconS3Location. 
        /// <para>
        /// The S3 location of the application icon.
        /// </para>
        /// </summary>
        public S3Location IconS3Location { get; set; }

        /// <summary>
        /// Checks to see if the IconS3Location property is set.
        /// </summary>
        internal bool IsSetIconS3Location() => this.IconS3Location != null;

        /// <summary>
        /// Gets and sets the property IconURL. 
        /// <para>
        /// The URL for the application icon. This URL might be time-limited.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string IconURL { get; set; }

        /// <summary>
        /// Checks to see if the IconURL property is set.
        /// </summary>
        internal bool IsSetIconURL() => this.IconURL != null;

        /// <summary>
        /// Gets and sets the property InstanceFamilies. 
        /// <para>
        /// The instance families for the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceFamilies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceFamilies property is set.
        /// </summary>
        internal bool IsSetInstanceFamilies() => this.InstanceFamilies != null && (this.InstanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// The arguments that are passed to the application at launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string LaunchParameters { get; set; }

        /// <summary>
        /// Checks to see if the LaunchParameters property is set.
        /// </summary>
        internal bool IsSetLaunchParameters() => this.LaunchParameters != null;

        /// <summary>
        /// Gets and sets the property LaunchPath. 
        /// <para>
        /// The path to the application executable in the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string LaunchPath { get; set; }

        /// <summary>
        /// Checks to see if the LaunchPath property is set.
        /// </summary>
        internal bool IsSetLaunchPath() => this.LaunchPath != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional attributes that describe the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// The platforms on which the application can run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<string> Platforms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Platforms property is set.
        /// </summary>
        internal bool IsSetPlatforms() => this.Platforms != null && (this.Platforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}

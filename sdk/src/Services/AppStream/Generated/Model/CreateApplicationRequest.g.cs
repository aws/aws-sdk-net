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
    /// Container for the parameters to the CreateApplication operation. Creates an application.
    /// <para> Applications are a WorkSpaces Applications resource that stores the details
    /// about how to launch applications on Elastic fleet streaming instances. An application
    /// consists of the launch details, icon, and display name. Applications are associated
    /// with an app block that contains the application binaries and other files. The applications
    /// assigned to an Elastic fleet are the applications users can launch. </para> <para>
    /// This is only supported for Elastic fleets. </para>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The app block ARN to which the application should be associated
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppBlockArn { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockArn property is set.
        /// </summary>
        internal bool IsSetAppBlockArn() => this.AppBlockArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the application. This name is visible to users in the application
        /// catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IconS3Location. 
        /// <para>
        /// The location in S3 of the application icon.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location IconS3Location { get; set; }

        /// <summary>
        /// Checks to see if the IconS3Location property is set.
        /// </summary>
        internal bool IsSetIconS3Location() => this.IconS3Location != null;

        /// <summary>
        /// Gets and sets the property InstanceFamilies. 
        /// <para>
        /// The instance families the application supports. Valid values are GENERAL_PURPOSE and
        /// GRAPHICS_G4.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> InstanceFamilies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceFamilies property is set.
        /// </summary>
        internal bool IsSetInstanceFamilies() => this.InstanceFamilies != null && (this.InstanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// The launch parameters of the application.
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
        /// The launch path of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string LaunchPath { get; set; }

        /// <summary>
        /// Checks to see if the LaunchPath property is set.
        /// </summary>
        internal bool IsSetLaunchPath() => this.LaunchPath != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application. This name is visible to users when display name is not
        /// specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// The platforms the application supports. WINDOWS_SERVER_2019, AMAZON_LINUX2 and UBUNTU_PRO_2404
        /// are supported for Elastic fleets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4)]
        public List<string> Platforms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Platforms property is set.
        /// </summary>
        internal bool IsSetPlatforms() => this.Platforms != null && (this.Platforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory of the application.
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

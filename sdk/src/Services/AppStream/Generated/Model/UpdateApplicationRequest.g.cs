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
    /// Container for the parameters to the UpdateApplication operation. Updates the specified
    /// application.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The ARN of the app block.
        /// </para>
        /// </summary>
        public string AppBlockArn { get; set; }

        /// <summary>
        /// Checks to see if the AppBlockArn property is set.
        /// </summary>
        internal bool IsSetAppBlockArn() => this.AppBlockArn != null;

        /// <summary>
        /// Gets and sets the property AttributesToDelete. 
        /// <para>
        /// The attributes to delete for an application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> AttributesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesToDelete property is set.
        /// </summary>
        internal bool IsSetAttributesToDelete() => this.AttributesToDelete != null && (this.AttributesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The icon S3 location of the application.
        /// </para>
        /// </summary>
        public S3Location IconS3Location { get; set; }

        /// <summary>
        /// Checks to see if the IconS3Location property is set.
        /// </summary>
        internal bool IsSetIconS3Location() => this.IconS3Location != null;

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
        [AWSProperty(Min = 1)]
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

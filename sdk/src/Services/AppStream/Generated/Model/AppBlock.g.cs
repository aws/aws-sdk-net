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
    /// Describes an app block.
    /// 
    ///  
    /// <para>
    /// App blocks are a WorkSpaces Applications resource that stores the details about the
    /// virtual hard disk in an S3 bucket. It also stores the setup script with details about
    /// how to mount the virtual hard disk. The virtual hard disk includes the application
    /// binaries and other files necessary to launch your applications. Multiple applications
    /// can be assigned to a single app block.
    /// </para>
    ///  
    /// <para>
    /// This is only supported for Elastic fleets.
    /// </para>
    /// </summary>
    public partial class AppBlock
    {
        /// <summary>
        /// Gets and sets the property AppBlockErrors. 
        /// <para>
        /// The errors of the app block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetails> AppBlockErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<ErrorDetails>() : null;

        /// <summary>
        /// Checks to see if the AppBlockErrors property is set.
        /// </summary>
        internal bool IsSetAppBlockErrors() => this.AppBlockErrors != null && (this.AppBlockErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The created time of the app block.
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
        /// The description of the app block.
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
        /// The display name of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PackagingType. 
        /// <para>
        /// The packaging type of the app block.
        /// </para>
        /// </summary>
        public PackagingType PackagingType { get; set; }

        /// <summary>
        /// Checks to see if the PackagingType property is set.
        /// </summary>
        internal bool IsSetPackagingType() => this.PackagingType != null;

        /// <summary>
        /// Gets and sets the property PostSetupScriptDetails. 
        /// <para>
        /// The post setup script details of the app block.
        /// </para>
        ///  
        /// <para>
        /// This only applies to app blocks with PackagingType <c>APPSTREAM2</c>.
        /// </para>
        /// </summary>
        public ScriptDetails PostSetupScriptDetails { get; set; }

        /// <summary>
        /// Checks to see if the PostSetupScriptDetails property is set.
        /// </summary>
        internal bool IsSetPostSetupScriptDetails() => this.PostSetupScriptDetails != null;

        /// <summary>
        /// Gets and sets the property SetupScriptDetails. 
        /// <para>
        /// The setup script details of the app block.
        /// </para>
        ///  
        /// <para>
        /// This only applies to app blocks with PackagingType <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        public ScriptDetails SetupScriptDetails { get; set; }

        /// <summary>
        /// Checks to see if the SetupScriptDetails property is set.
        /// </summary>
        internal bool IsSetSetupScriptDetails() => this.SetupScriptDetails != null;

        /// <summary>
        /// Gets and sets the property SourceS3Location. 
        /// <para>
        /// The source S3 location of the app block.
        /// </para>
        /// </summary>
        public S3Location SourceS3Location { get; set; }

        /// <summary>
        /// Checks to see if the SourceS3Location property is set.
        /// </summary>
        internal bool IsSetSourceS3Location() => this.SourceS3Location != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the app block.
        /// </para>
        ///  
        /// <para>
        /// An app block with WorkSpaces Applications packaging will be in the <c>INACTIVE</c>
        /// state if no application package (VHD) is assigned to it. After an application package
        /// (VHD) is created by an app block builder for an app block, it becomes <c>ACTIVE</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Custom app blocks are always in the <c>ACTIVE</c> state and no action is required
        /// to use them.
        /// </para>
        /// </summary>
        public AppBlockState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}

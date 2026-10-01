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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// This is the response object from the UpdateMicrovmImageVersion operation.
    /// </summary>
    public partial class UpdateMicrovmImageVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalOsCapabilities. 
        /// <para>
        /// Additional OS capabilities granted to the MicroVM runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalOsCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalOsCapabilities property is set.
        /// </summary>
        internal bool IsSetAdditionalOsCapabilities() => this.AdditionalOsCapabilities != null && (this.AdditionalOsCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BaseImageArn. 
        /// <para>
        /// The ARN of the base MicroVM image used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BaseImageArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseImageArn property is set.
        /// </summary>
        internal bool IsSetBaseImageArn() => this.BaseImageArn != null;

        /// <summary>
        /// Gets and sets the property BaseImageVersion. 
        /// <para>
        /// The specific version of the base MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string BaseImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the BaseImageVersion property is set.
        /// </summary>
        internal bool IsSetBaseImageVersion() => this.BaseImageVersion != null;

        /// <summary>
        /// Gets and sets the property BuildRoleArn. 
        /// <para>
        /// The ARN of the IAM build role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string BuildRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the BuildRoleArn property is set.
        /// </summary>
        internal bool IsSetBuildRoleArn() => this.BuildRoleArn != null;

        /// <summary>
        /// Gets and sets the property CodeArtifact. 
        /// <para>
        /// The code artifact for this version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodeArtifact CodeArtifact { get; set; }

        /// <summary>
        /// Checks to see if the CodeArtifact property is set.
        /// </summary>
        internal bool IsSetCodeArtifact() => this.CodeArtifact != null;

        /// <summary>
        /// Gets and sets the property CpuConfigurations. 
        /// <para>
        /// The list of supported CPU configurations for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CpuConfiguration> CpuConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CpuConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CpuConfigurations property is set.
        /// </summary>
        internal bool IsSetCpuConfigurations() => this.CpuConfigurations != null && (this.CpuConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EgressNetworkConnectors. 
        /// <para>
        /// The list of egress network connectors available to the MicroVM at runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> EgressNetworkConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EgressNetworkConnectors property is set.
        /// </summary>
        internal bool IsSetEgressNetworkConnectors() => this.EgressNetworkConnectors != null && (this.EgressNetworkConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables set in the MicroVM runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Hooks.
        /// </summary>
        public Hooks Hooks { get; set; }

        /// <summary>
        /// Checks to see if the Hooks property is set.
        /// </summary>
        internal bool IsSetHooks() => this.Hooks != null;

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersion property is set.
        /// </summary>
        internal bool IsSetImageVersion() => this.ImageVersion != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for this version.
        /// </para>
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resource requirements for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<Resources> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resources>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MicrovmImageVersionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the current state. For example, one or more builds failed.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The availability status of the version: ACTIVE (can be used by RunMicrovm) or INACTIVE
        /// (blocked from launching new MicroVMs).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MicrovmImageVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs associated with the version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the version was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}

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
    /// Container for the parameters to the UpdateMicrovmImage operation. Updates the configuration
    /// of a MicroVM image and triggers a new version build. This operation uses PUT semantics
    /// — all required fields (codeArtifact, baseImageArn, buildRoleArn) must be provided
    /// with every request.
    /// </summary>
    public partial class UpdateMicrovmImageRequest : AmazonLambdaMicrovmsRequest
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
        /// The ARN of the base MicroVM image.
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
        /// The specific version of the base MicroVM image to use.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CodeArtifact. 
        /// <para>
        /// The code artifact containing the application code and metadata for the MicroVM image.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the MicroVM image.
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
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// The unique identifier (ARN or ID) of the MicroVM image to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ImageIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ImageIdentifier property is set.
        /// </summary>
        internal bool IsSetImageIdentifier() => this.ImageIdentifier != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for build-time and runtime logs. Specify {"cloudWatch":
        /// {"logGroup": "..."}} to stream logs to a custom CloudWatch log group, or {"disabled":
        /// {}} to turn off logging.
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
    }
}

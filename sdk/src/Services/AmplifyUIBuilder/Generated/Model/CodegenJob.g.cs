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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration for a code generation job that is associated with an Amplify
    /// app.
    /// </summary>
    public partial class CodegenJob
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the Amplify app associated with the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        /// The <c>CodegenJobAsset</c> to use for the code generation job.
        /// </para>
        /// </summary>
        public CodegenJobAsset Asset { get; set; }

        /// <summary>
        /// Checks to see if the Asset property is set.
        /// </summary>
        internal bool IsSetAsset() => this.Asset != null;

        /// <summary>
        /// Gets and sets the property AutoGenerateForms. 
        /// <para>
        /// Specifies whether to autogenerate forms in the code generation job.
        /// </para>
        /// </summary>
        public bool? AutoGenerateForms { get; set; }

        /// <summary>
        /// Checks to see if the AutoGenerateForms property is set.
        /// </summary>
        internal bool IsSetAutoGenerateForms() => this.AutoGenerateForms.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the code generation job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Lists the dependency packages that may be required for the project code to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodegenDependency> Dependencies { get; set; } = AWSConfigs.InitializeCollections ? new List<CodegenDependency>() : null;

        /// <summary>
        /// Checks to see if the Dependencies property is set.
        /// </summary>
        internal bool IsSetDependencies() => this.Dependencies != null && (this.Dependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the backend environment associated with the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Features.
        /// </summary>
        public CodegenFeatureFlags Features { get; set; }

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null;

        /// <summary>
        /// Gets and sets the property GenericDataSchema.
        /// </summary>
        public CodegenJobGenericDataSchema GenericDataSchema { get; set; }

        /// <summary>
        /// Checks to see if the GenericDataSchema property is set.
        /// </summary>
        internal bool IsSetGenericDataSchema() => this.GenericDataSchema != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The time that the code generation job was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RenderConfig.
        /// </summary>
        public CodegenJobRenderConfig RenderConfig { get; set; }

        /// <summary>
        /// Checks to see if the RenderConfig property is set.
        /// </summary>
        internal bool IsSetRenderConfig() => this.RenderConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the code generation job.
        /// </para>
        /// </summary>
        public CodegenJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The customized status message for the code generation job.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the code generation job.
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
    }
}

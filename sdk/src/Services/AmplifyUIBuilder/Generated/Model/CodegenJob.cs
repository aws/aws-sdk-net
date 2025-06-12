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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
        private string _appId;
        private CodegenJobAsset _asset;
        private bool? _autoGenerateForms;
        private DateTime? _createdAt;
        private List<CodegenDependency> _dependencies = AWSConfigs.InitializeCollections ? new List<CodegenDependency>() : null;
        private string _environmentName;
        private CodegenFeatureFlags _features;
        private CodegenJobGenericDataSchema _genericDataSchema;
        private string _id;
        private DateTime? _modifiedAt;
        private CodegenJobRenderConfig _renderConfig;
        private CodegenJobStatus _status;
        private string _statusMessage;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the Amplify app associated with the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        /// The <c>CodegenJobAsset</c> to use for the code generation job.
        /// </para>
        /// </summary>
        public CodegenJobAsset Asset
        {
            get { return this._asset; }
            set { this._asset = value; }
        }

        // Check to see if Asset property is set
        internal bool IsSetAsset()
        {
            return this._asset != null;
        }

        /// <summary>
        /// Gets and sets the property AutoGenerateForms. 
        /// <para>
        /// Specifies whether to autogenerate forms in the code generation job.
        /// </para>
        /// </summary>
        public bool? AutoGenerateForms
        {
            get { return this._autoGenerateForms; }
            set { this._autoGenerateForms = value; }
        }

        // Check to see if AutoGenerateForms property is set
        internal bool IsSetAutoGenerateForms()
        {
            return this._autoGenerateForms.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the code generation job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Lists the dependency packages that may be required for the project code to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodegenDependency> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the backend environment associated with the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Features.
        /// </summary>
        public CodegenFeatureFlags Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null;
        }

        /// <summary>
        /// Gets and sets the property GenericDataSchema.
        /// </summary>
        public CodegenJobGenericDataSchema GenericDataSchema
        {
            get { return this._genericDataSchema; }
            set { this._genericDataSchema = value; }
        }

        // Check to see if GenericDataSchema property is set
        internal bool IsSetGenericDataSchema()
        {
            return this._genericDataSchema != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The time that the code generation job was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RenderConfig.
        /// </summary>
        public CodegenJobRenderConfig RenderConfig
        {
            get { return this._renderConfig; }
            set { this._renderConfig = value; }
        }

        // Check to see if RenderConfig property is set
        internal bool IsSetRenderConfig()
        {
            return this._renderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the code generation job.
        /// </para>
        /// </summary>
        public CodegenJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The customized status message for the code generation job.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the code generation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
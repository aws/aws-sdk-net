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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
    /// This is the response object from the CreateMicrovmImage operation.
    /// </summary>
    public partial class CreateMicrovmImageResponse : AmazonWebServiceResponse
    {
        private List<string> _additionalOsCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _baseImageArn;
        private string _baseImageVersion;
        private string _buildRoleArn;
        private CodeArtifact _codeArtifact;
        private List<CpuConfiguration> _cpuConfigurations = AWSConfigs.InitializeCollections ? new List<CpuConfiguration>() : null;
        private DateTime? _createdAt;
        private string _description;
        private List<string> _egressNetworkConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Hooks _hooks;
        private string _imageArn;
        private string _imageVersion;
        private string _latestActiveImageVersion;
        private string _latestFailedImageVersion;
        private Logging _logging;
        private string _name;
        private List<Resources> _resources = AWSConfigs.InitializeCollections ? new List<Resources>() : null;
        private MicrovmImageState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AdditionalOsCapabilities. 
        /// <para>
        /// Additional OS capabilities granted to the MicroVM runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalOsCapabilities
        {
            get { return this._additionalOsCapabilities; }
            set { this._additionalOsCapabilities = value; }
        }

        // Check to see if AdditionalOsCapabilities property is set
        internal bool IsSetAdditionalOsCapabilities()
        {
            return this._additionalOsCapabilities != null && (this._additionalOsCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BaseImageArn. 
        /// <para>
        /// The ARN of the base MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BaseImageArn
        {
            get { return this._baseImageArn; }
            set { this._baseImageArn = value; }
        }

        // Check to see if BaseImageArn property is set
        internal bool IsSetBaseImageArn()
        {
            return this._baseImageArn != null;
        }

        /// <summary>
        /// Gets and sets the property BaseImageVersion. 
        /// <para>
        /// The specific version of the base MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string BaseImageVersion
        {
            get { return this._baseImageVersion; }
            set { this._baseImageVersion = value; }
        }

        // Check to see if BaseImageVersion property is set
        internal bool IsSetBaseImageVersion()
        {
            return this._baseImageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property BuildRoleArn. 
        /// <para>
        /// The ARN of the IAM build role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string BuildRoleArn
        {
            get { return this._buildRoleArn; }
            set { this._buildRoleArn = value; }
        }

        // Check to see if BuildRoleArn property is set
        internal bool IsSetBuildRoleArn()
        {
            return this._buildRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CodeArtifact. 
        /// <para>
        /// The code artifact containing the application code and metadata for the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeArtifact CodeArtifact
        {
            get { return this._codeArtifact; }
            set { this._codeArtifact = value; }
        }

        // Check to see if CodeArtifact property is set
        internal bool IsSetCodeArtifact()
        {
            return this._codeArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property CpuConfigurations. 
        /// <para>
        /// The list of supported CPU configurations for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CpuConfiguration> CpuConfigurations
        {
            get { return this._cpuConfigurations; }
            set { this._cpuConfigurations = value; }
        }

        // Check to see if CpuConfigurations property is set
        internal bool IsSetCpuConfigurations()
        {
            return this._cpuConfigurations != null && (this._cpuConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the MicroVM image was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the MicroVM image.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EgressNetworkConnectors. 
        /// <para>
        /// The list of egress network connectors available to the MicroVM at runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> EgressNetworkConnectors
        {
            get { return this._egressNetworkConnectors; }
            set { this._egressNetworkConnectors = value; }
        }

        // Check to see if EgressNetworkConnectors property is set
        internal bool IsSetEgressNetworkConnectors()
        {
            return this._egressNetworkConnectors != null && (this._egressNetworkConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables set in the MicroVM runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Hooks.
        /// </summary>
        public Hooks Hooks
        {
            get { return this._hooks; }
            set { this._hooks = value; }
        }

        // Check to see if Hooks property is set
        internal bool IsSetHooks()
        {
            return this._hooks != null;
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the created MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LatestActiveImageVersion. 
        /// <para>
        /// The latest active version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LatestActiveImageVersion
        {
            get { return this._latestActiveImageVersion; }
            set { this._latestActiveImageVersion = value; }
        }

        // Check to see if LatestActiveImageVersion property is set
        internal bool IsSetLatestActiveImageVersion()
        {
            return this._latestActiveImageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LatestFailedImageVersion. 
        /// <para>
        /// The latest failed version of the MicroVM image, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LatestFailedImageVersion
        {
            get { return this._latestFailedImageVersion; }
            set { this._latestFailedImageVersion = value; }
        }

        // Check to see if LatestFailedImageVersion property is set
        internal bool IsSetLatestFailedImageVersion()
        {
            return this._latestFailedImageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for build-time and runtime logs. Specify {"cloudWatch":
        /// {"logGroup": "..."}} to stream logs to a custom CloudWatch log group, or {"disabled":
        /// {}} to turn off logging.
        /// </para>
        /// </summary>
        public Logging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resource requirements for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Resources> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MicrovmImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key-value pairs that you can attach to the resource. Use tags to categorize
        /// resources for cost allocation, access control (ABAC), and organization.
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the MicroVM image was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}
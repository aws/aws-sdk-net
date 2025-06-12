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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeployment operation.
    /// Starts a deployment.
    /// </summary>
    public partial class StartDeploymentRequest : AmazonAppConfigRequest
    {
        private string _applicationId;
        private string _configurationProfileId;
        private string _configurationVersion;
        private string _deploymentStrategyId;
        private string _description;
        private Dictionary<string, string> _dynamicExtensionParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _environmentId;
        private string _kmsKeyIdentifier;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The configuration profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationProfileId
        {
            get { return this._configurationProfileId; }
            set { this._configurationProfileId = value; }
        }

        // Check to see if ConfigurationProfileId property is set
        internal bool IsSetConfigurationProfileId()
        {
            return this._configurationProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationVersion. 
        /// <para>
        /// The configuration version to deploy. If deploying an AppConfig hosted configuration
        /// version, you can specify either the version number or version label. For all other
        /// configurations, you must specify the version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ConfigurationVersion
        {
            get { return this._configurationVersion; }
            set { this._configurationVersion = value; }
        }

        // Check to see if ConfigurationVersion property is set
        internal bool IsSetConfigurationVersion()
        {
            return this._configurationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStrategyId. 
        /// <para>
        /// The deployment strategy ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentStrategyId
        {
            get { return this._deploymentStrategyId; }
            set { this._deploymentStrategyId = value; }
        }

        // Check to see if DeploymentStrategyId property is set
        internal bool IsSetDeploymentStrategyId()
        {
            return this._deploymentStrategyId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property DynamicExtensionParameters. 
        /// <para>
        /// A map of dynamic extension parameter names to values to pass to associated extensions
        /// with <c>PRE_START_DEPLOYMENT</c> actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=10)]
        public Dictionary<string, string> DynamicExtensionParameters
        {
            get { return this._dynamicExtensionParameters; }
            set { this._dynamicExtensionParameters = value; }
        }

        // Check to see if DynamicExtensionParameters property is set
        internal bool IsSetDynamicExtensionParameters()
        {
            return this._dynamicExtensionParameters != null && (this._dynamicExtensionParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The KMS key identifier (key ID, key alias, or key ARN). AppConfig uses this ID to
        /// encrypt the configuration data using a customer managed key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata to assign to the deployment. Tags help organize and categorize your AppConfig
        /// resources. Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
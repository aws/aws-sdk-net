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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation.
    /// Creates a continuous deployment for a target, which is a Greengrass core device or
    /// group of core devices. When you add a new core device to a group of core devices that
    /// has a deployment, IoT Greengrass deploys that group's deployment to the new device.
    /// 
    ///  
    /// <para>
    /// You can define one deployment for each target. When you create a new deployment for
    /// a target that has an existing deployment, you replace the previous deployment. IoT
    /// Greengrass applies the new deployment to the target devices.
    /// </para>
    ///  
    /// <para>
    /// Every deployment has a revision number that indicates how many deployment revisions
    /// you define for a target. Use this operation to create a new revision of an existing
    /// deployment.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/create-deployments.html">Create
    /// deployments</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonGreengrassV2Request
    {
        private string _clientToken;
        private Dictionary<string, ComponentDeploymentSpecification> _components = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentDeploymentSpecification>() : null;
        private string _deploymentName;
        private DeploymentPolicies _deploymentPolicies;
        private DeploymentIoTJobConfiguration _iotJobConfiguration;
        private string _parentTargetArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you can provide to ensure that the request
        /// is idempotent. Idempotency means that the request is successfully processed only once,
        /// even if you send the request multiple times. When a request succeeds, and you specify
        /// the same client token for subsequent successful requests, the IoT Greengrass V2 service
        /// returns the successful response that it caches from the previous request. IoT Greengrass
        /// V2 caches successful responses for idempotent requests for up to 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The components to deploy. This is a dictionary, where each key is the name of a component,
        /// and each key's value is the version and configuration to deploy for that component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentDeploymentSpecification> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && (this._components.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DeploymentName
        {
            get { return this._deploymentName; }
            set { this._deploymentName = value; }
        }

        // Check to see if DeploymentName property is set
        internal bool IsSetDeploymentName()
        {
            return this._deploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentPolicies. 
        /// <para>
        /// The deployment policies for the deployment. These policies define how the deployment
        /// updates components and handles failure.
        /// </para>
        /// </summary>
        public DeploymentPolicies DeploymentPolicies
        {
            get { return this._deploymentPolicies; }
            set { this._deploymentPolicies = value; }
        }

        // Check to see if DeploymentPolicies property is set
        internal bool IsSetDeploymentPolicies()
        {
            return this._deploymentPolicies != null;
        }

        /// <summary>
        /// Gets and sets the property IotJobConfiguration. 
        /// <para>
        /// The job configuration for the deployment configuration. The job configuration specifies
        /// the rollout, timeout, and stop configurations for the deployment configuration.
        /// </para>
        /// </summary>
        public DeploymentIoTJobConfiguration IotJobConfiguration
        {
            get { return this._iotJobConfiguration; }
            set { this._iotJobConfiguration = value; }
        }

        // Check to see if IotJobConfiguration property is set
        internal bool IsSetIotJobConfiguration()
        {
            return this._iotJobConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ParentTargetArn. 
        /// <para>
        /// The parent deployment's target <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// within a subdeployment.
        /// </para>
        /// </summary>
        public string ParentTargetArn
        {
            get { return this._parentTargetArn; }
            set { this._parentTargetArn = value; }
        }

        // Check to see if ParentTargetArn property is set
        internal bool IsSetParentTargetArn()
        {
            return this._parentTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/tag-resources.html">Tag
        /// your resources</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target IoT thing or thing group. When creating a subdeployment, the targetARN
        /// can only be a thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}
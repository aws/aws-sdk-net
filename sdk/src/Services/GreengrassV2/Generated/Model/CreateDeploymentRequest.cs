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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation.
    /// Creates a continuous deployment for a target, which is a AWS IoT Greengrass core device
    /// or group of core devices. When you add a new core device to a group of core devices
    /// that has a deployment, AWS IoT Greengrass deploys that group's deployment to the new
    /// device.
    /// 
    ///  
    /// <para>
    /// You can define one deployment for each target. When you create a new deployment for
    /// a target that has an existing deployment, you replace the previous deployment. AWS
    /// IoT Greengrass applies the new deployment to the target devices.
    /// </para>
    ///  
    /// <para>
    /// Every deployment has a revision number that indicates how many deployment revisions
    /// you define for a target. Use this operation to create a new revision of an existing
    /// deployment. This operation returns the revision number of the new deployment when
    /// you create it.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/latest/developerguide/create-deployments.html">Create
    /// deployments</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonGreengrassV2Request
    {
        private Dictionary<string, ComponentDeploymentSpecification> _components = new Dictionary<string, ComponentDeploymentSpecification>();
        private string _deploymentName;
        private DeploymentPolicies _deploymentPolicies;
        private DeploymentIoTJobConfiguration _iotJobConfiguration;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The components to deploy. This is a dictionary, where each key is the name of a component,
        /// and each key's value is the version and configuration to deploy for that component.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentDeploymentSpecification> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && this._components.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        ///  
        /// <para>
        /// You can create deployments without names. If you create a deployment without a name,
        /// the AWS IoT Greengrass V2 console shows the deployment name as <code>&lt;targetType&gt;:&lt;targetName&gt;</code>,
        /// where <code>targetType</code> and <code>targetName</code> are the type and name of
        /// the deployment target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/tag-resources.html">Tag your
        /// resources</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target AWS IoT thing or thing group.
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
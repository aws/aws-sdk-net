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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation. Creates a continuous
    /// deployment for a target, which is a Greengrass core device or group of core devices.
    /// When you add a new core device to a group of core devices that has a deployment, IoT
    /// Greengrass deploys that group's deployment to the new device. <para> You can define
    /// one deployment for each target. When you create a new deployment for a target that
    /// has an existing deployment, you replace the previous deployment. IoT Greengrass applies
    /// the new deployment to the target devices. </para> <para> Every deployment has a revision
    /// number that indicates how many deployment revisions you define for a target. Use this
    /// operation to create a new revision of an existing deployment. </para> <para> For more
    /// information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/create-deployments.html">Create
    /// deployments</a> in the <i>IoT Greengrass V2 Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonGreengrassV2Request
    {
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
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The components to deploy. This is a dictionary, where each key is the name of a component,
        /// and each key's value is the version and configuration to deploy for that component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentDeploymentSpecification> Components { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentDeploymentSpecification>() : null;

        /// <summary>
        /// Checks to see if the Components property is set.
        /// </summary>
        internal bool IsSetComponents() => this.Components != null && (this.Components.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentName property is set.
        /// </summary>
        internal bool IsSetDeploymentName() => this.DeploymentName != null;

        /// <summary>
        /// Gets and sets the property DeploymentPolicies. 
        /// <para>
        /// The deployment policies for the deployment. These policies define how the deployment
        /// updates components and handles failure.
        /// </para>
        /// </summary>
        public DeploymentPolicies DeploymentPolicies { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentPolicies property is set.
        /// </summary>
        internal bool IsSetDeploymentPolicies() => this.DeploymentPolicies != null;

        /// <summary>
        /// Gets and sets the property IotJobConfiguration. 
        /// <para>
        /// The job configuration for the deployment configuration. The job configuration specifies
        /// the rollout, timeout, and stop configurations for the deployment configuration.
        /// </para>
        /// </summary>
        public DeploymentIoTJobConfiguration IotJobConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IotJobConfiguration property is set.
        /// </summary>
        internal bool IsSetIotJobConfiguration() => this.IotJobConfiguration != null;

        /// <summary>
        /// Gets and sets the property ParentTargetArn. 
        /// <para>
        /// The parent deployment's target <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// within a subdeployment.
        /// </para>
        /// </summary>
        public string ParentTargetArn { get; set; }

        /// <summary>
        /// Checks to see if the ParentTargetArn property is set.
        /// </summary>
        internal bool IsSetParentTargetArn() => this.ParentTargetArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/tag-resources.html">Tag
        /// your resources</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target IoT thing or thing group. When creating a subdeployment, the targetARN
        /// can only be a thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}

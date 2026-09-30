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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation. Creates a deployment.
    /// ''CreateDeployment'' requests are idempotent with respect to the ''X-Amzn-Client-Token''
    /// token and the request parameters.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonGreengrassRequest
    {
        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken { get; set; }

        /// <summary>
        /// Checks to see if the AmznClientToken property is set.
        /// </summary>
        internal bool IsSetAmznClientToken() => this.AmznClientToken != null;

        /// <summary>
        /// Gets and sets the property DeploymentId. The ID of the deployment if you wish to redeploy
        /// a previous deployment.
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. The type of deployment. When used for ''CreateDeployment'',
        /// only ''NewDeployment'' and ''Redeployment'' are valid.
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property GroupId. The ID of the Greengrass group.
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupVersionId. The ID of the group version to be deployed.
        /// </summary>
        public string GroupVersionId { get; set; }

        /// <summary>
        /// Checks to see if the GroupVersionId property is set.
        /// </summary>
        internal bool IsSetGroupVersionId() => this.GroupVersionId != null;
    }
}

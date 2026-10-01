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
    /// Information about a deployment.
    /// </summary>
    public partial class Deployment
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in milliseconds since the epoch, when
        /// the deployment was created.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property DeploymentArn. The ARN of the deployment.
        /// </summary>
        public string DeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentArn property is set.
        /// </summary>
        internal bool IsSetDeploymentArn() => this.DeploymentArn != null;

        /// <summary>
        /// Gets and sets the property DeploymentId. The ID of the deployment.
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. The type of the deployment.
        /// </summary>
        public DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property GroupArn. The ARN of the group for this deployment.
        /// </summary>
        public string GroupArn { get; set; }

        /// <summary>
        /// Checks to see if the GroupArn property is set.
        /// </summary>
        internal bool IsSetGroupArn() => this.GroupArn != null;
    }
}

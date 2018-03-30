/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about a deployment.
    /// </summary>
    public partial class Deployment
    {
        private string _createdAt;
        private string _deploymentArn;
        private string _deploymentId;
        private DeploymentType _deploymentType;
        private string _groupArn;

        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in milliseconds since the epoch, when
        /// the deployment was created.
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentArn. The ARN of the deployment.
        /// </summary>
        public string DeploymentArn
        {
            get { return this._deploymentArn; }
            set { this._deploymentArn = value; }
        }

        // Check to see if DeploymentArn property is set
        internal bool IsSetDeploymentArn()
        {
            return this._deploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. The ID of the deployment.
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. The type of the deployment.
        /// </summary>
        public DeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property GroupArn. The ARN of the group for this deployment.
        /// </summary>
        public string GroupArn
        {
            get { return this._groupArn; }
            set { this._groupArn = value; }
        }

        // Check to see if GroupArn property is set
        internal bool IsSetGroupArn()
        {
            return this._groupArn != null;
        }

    }
}
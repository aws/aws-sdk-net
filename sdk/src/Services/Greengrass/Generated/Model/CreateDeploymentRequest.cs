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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
    /// Container for the parameters to the CreateDeployment operation.
    /// Creates a deployment. ''CreateDeployment'' requests are idempotent with respect to
    /// the ''X-Amzn-Client-Token'' token and the request parameters.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _deploymentId;
        private DeploymentType _deploymentType;
        private string _groupId;
        private string _groupVersionId;

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. The ID of the deployment if you wish to redeploy
        /// a previous deployment.
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
        /// Gets and sets the property DeploymentType. The type of deployment. When used for ''CreateDeployment'',
        /// only ''NewDeployment'' and ''Redeployment'' are valid.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property GroupId. The ID of the Greengrass group.
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupVersionId. The ID of the group version to be deployed.
        /// </summary>
        public string GroupVersionId
        {
            get { return this._groupVersionId; }
            set { this._groupVersionId = value; }
        }

        // Check to see if GroupVersionId property is set
        internal bool IsSetGroupVersionId()
        {
            return this._groupVersionId != null;
        }

    }
}
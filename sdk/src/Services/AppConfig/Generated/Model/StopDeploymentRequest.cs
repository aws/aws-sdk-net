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
    /// Container for the parameters to the StopDeployment operation.
    /// Stops a deployment. This API action works only on deployments that have a status of
    /// <c>DEPLOYING</c>, unless an <c>AllowRevert</c> parameter is supplied. If the <c>AllowRevert</c>
    /// parameter is supplied, the status of an in-progress deployment will be <c>ROLLED_BACK</c>.
    /// The status of a completed deployment will be <c>REVERTED</c>. AppConfig only allows
    /// a revert within 72 hours of deployment completion.
    /// </summary>
    public partial class StopDeploymentRequest : AmazonAppConfigRequest
    {
        private bool? _allowRevert;
        private string _applicationId;
        private int? _deploymentNumber;
        private string _environmentId;

        /// <summary>
        /// Gets and sets the property AllowRevert. 
        /// <para>
        /// A Boolean that enables AppConfig to rollback a <c>COMPLETED</c> deployment to the
        /// previous configuration version. This action moves the deployment to a status of <c>REVERTED</c>.
        /// </para>
        /// </summary>
        public bool? AllowRevert
        {
            get { return this._allowRevert; }
            set { this._allowRevert = value; }
        }

        // Check to see if AllowRevert property is set
        internal bool IsSetAllowRevert()
        {
            return this._allowRevert.HasValue; 
        }

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
        /// Gets and sets the property DeploymentNumber. 
        /// <para>
        /// The sequence number of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DeploymentNumber
        {
            get { return this._deploymentNumber; }
            set { this._deploymentNumber = value; }
        }

        // Check to see if DeploymentNumber property is set
        internal bool IsSetDeploymentNumber()
        {
            return this._deploymentNumber.HasValue; 
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

    }
}
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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the StopDeployment operation. Stops a deployment.
    /// This API action works only on deployments that have a status of <c>DEPLOYING</c>,
    /// unless an <c>AllowRevert</c> parameter is supplied. If the <c>AllowRevert</c> parameter
    /// is supplied, the status of an in-progress deployment will be <c>ROLLED_BACK</c>. The
    /// status of a completed deployment will be <c>REVERTED</c>. AppConfig only allows a
    /// revert within 72 hours of deployment completion.
    /// </summary>
    public partial class StopDeploymentRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property AllowRevert. 
        /// <para>
        /// A Boolean that enables AppConfig to rollback a <c>COMPLETED</c> deployment to the
        /// previous configuration version. This action moves the deployment to a status of <c>REVERTED</c>.
        /// </para>
        /// </summary>
        public bool? AllowRevert { get; set; }

        /// <summary>
        /// Checks to see if the AllowRevert property is set.
        /// </summary>
        internal bool IsSetAllowRevert() => this.AllowRevert.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property DeploymentNumber. 
        /// <para>
        /// The sequence number of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DeploymentNumber { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentNumber property is set.
        /// </summary>
        internal bool IsSetDeploymentNumber() => this.DeploymentNumber.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;
    }
}

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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeployment operation.
    /// Retrieves the details of the specified deployment, including coverage information
    /// and any warnings.
    /// </summary>
    public partial class GetDeploymentRequest : AmazonNetworkSecurityManagerRequest
    {
        private string _deploymentIdentifier;

        /// <summary>
        /// Gets and sets the property DeploymentIdentifier. 
        /// <para>
        /// The identifier of the deployment. This is the deployment's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1010)]
        public string DeploymentIdentifier
        {
            get { return this._deploymentIdentifier; }
            set { this._deploymentIdentifier = value; }
        }

        // Check to see if DeploymentIdentifier property is set
        internal bool IsSetDeploymentIdentifier()
        {
            return this._deploymentIdentifier != null;
        }

    }
}
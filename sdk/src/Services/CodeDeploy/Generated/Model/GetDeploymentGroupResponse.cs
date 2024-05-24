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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a <c>GetDeploymentGroup</c> operation.
    /// </summary>
    public partial class GetDeploymentGroupResponse : AmazonWebServiceResponse
    {
        private DeploymentGroupInfo _deploymentGroupInfo;

        /// <summary>
        /// Gets and sets the property DeploymentGroupInfo. 
        /// <para>
        /// Information about the deployment group.
        /// </para>
        /// </summary>
        public DeploymentGroupInfo DeploymentGroupInfo
        {
            get { return this._deploymentGroupInfo; }
            set { this._deploymentGroupInfo = value; }
        }

        // Check to see if DeploymentGroupInfo property is set
        internal bool IsSetDeploymentGroupInfo()
        {
            return this._deploymentGroupInfo != null;
        }

    }
}
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
    /// Represents the output of a <c>CreateDeploymentGroup</c> operation.
    /// </summary>
    public partial class CreateDeploymentGroupResponse : AmazonWebServiceResponse
    {
        private string _deploymentGroupId;

        /// <summary>
        /// Gets and sets the property DeploymentGroupId. 
        /// <para>
        /// A unique deployment group ID.
        /// </para>
        /// </summary>
        public string DeploymentGroupId
        {
            get { return this._deploymentGroupId; }
            set { this._deploymentGroupId = value; }
        }

        // Check to see if DeploymentGroupId property is set
        internal bool IsSetDeploymentGroupId()
        {
            return this._deploymentGroupId != null;
        }

    }
}
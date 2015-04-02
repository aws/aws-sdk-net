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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeploymentInstances operation.
    /// Lists the instances for a deployment associated with the applicable IAM user or AWS
    /// account.
    /// </summary>
    public partial class ListDeploymentInstancesRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private List<string> _instanceStatusFilter = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The unique ID of a deployment.
        /// </para>
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
        /// Gets and sets the property InstanceStatusFilter. 
        /// <para>
        /// A subset of instances to list, by status:
        /// </para>
        ///  <ul> <li>Pending: Include in the resulting list those instances with pending deployments.</li>
        /// <li>InProgress: Include in the resulting list those instances with in-progress deployments.</li>
        /// <li>Succeeded: Include in the resulting list those instances with succeeded deployments.</li>
        /// <li>Failed: Include in the resulting list those instances with failed deployments.</li>
        /// <li>Skipped: Include in the resulting list those instances with skipped deployments.</li>
        /// <li>Unknown: Include in the resulting list those instances with deployments in an
        /// unknown state.</li> </ul>
        /// </summary>
        public List<string> InstanceStatusFilter
        {
            get { return this._instanceStatusFilter; }
            set { this._instanceStatusFilter = value; }
        }

        // Check to see if InstanceStatusFilter property is set
        internal bool IsSetInstanceStatusFilter()
        {
            return this._instanceStatusFilter != null && this._instanceStatusFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous list deployment instances call,
        /// which can be used to return the next set of deployment instances in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}
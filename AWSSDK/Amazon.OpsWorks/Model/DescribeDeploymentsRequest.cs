/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDeployments operation.
    /// <para>Requests a description of a specified set of deployments.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeDeployments"/>
    public class DescribeDeploymentsRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private string appId;
        private List<string> deploymentIds = new List<string>();

        /// <summary>
        /// The stack ID. If you include this parameter, <c>DescribeDeployments</c> returns a description of the commands associated with the specified
        /// stack.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public DescribeDeploymentsRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The app ID. If you include this parameter, <c>DescribeDeployments</c> returns a description of the commands associated with the specified
        /// app.
        ///  
        /// </summary>
        public string AppId
        {
            get { return this.appId; }
            set { this.appId = value; }
        }

        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        public DescribeDeploymentsRequest WithAppId(string appId)
        {
            this.appId = appId;
            return this;
        }
            

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this.appId != null;
        }

        /// <summary>
        /// An array of deployment IDs to be described. If you include this parameter, <c>DescribeDeployments</c> returns a description of the specified
        /// deployments. Otherwise, it returns a description of every deployment.
        ///  
        /// </summary>
        public List<string> DeploymentIds
        {
            get { return this.deploymentIds; }
            set { this.deploymentIds = value; }
        }
        /// <summary>
        /// Adds elements to the DeploymentIds collection
        /// </summary>
        /// <param name="deploymentIds">The values to add to the DeploymentIds collection </param>
        /// <returns>this instance</returns>
        public DescribeDeploymentsRequest WithDeploymentIds(params string[] deploymentIds)
        {
            foreach (string element in deploymentIds)
            {
                this.deploymentIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DeploymentIds collection
        /// </summary>
        /// <param name="deploymentIds">The values to add to the DeploymentIds collection </param>
        /// <returns>this instance</returns>
        public DescribeDeploymentsRequest WithDeploymentIds(IEnumerable<string> deploymentIds)
        {
            foreach (string element in deploymentIds)
            {
                this.deploymentIds.Add(element);
            }

            return this;
        }

        // Check to see if DeploymentIds property is set
        internal bool IsSetDeploymentIds()
        {
            return this.deploymentIds.Count > 0;
        }
    }
}
    

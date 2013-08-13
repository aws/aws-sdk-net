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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeDeployments</c> request.</para>
    /// </summary>
    public class DescribeDeploymentsResult
    {
        
        private List<Deployment> deployments = new List<Deployment>();

        /// <summary>
        /// An array of <c>Deployment</c> objects that describe the deployments.
        ///  
        /// </summary>
        public List<Deployment> Deployments
        {
            get { return this.deployments; }
            set { this.deployments = value; }
        }
        /// <summary>
        /// Adds elements to the Deployments collection
        /// </summary>
        /// <param name="deployments">The values to add to the Deployments collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDeploymentsResult WithDeployments(params Deployment[] deployments)
        {
            foreach (Deployment element in deployments)
            {
                this.deployments.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Deployments collection
        /// </summary>
        /// <param name="deployments">The values to add to the Deployments collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDeploymentsResult WithDeployments(IEnumerable<Deployment> deployments)
        {
            foreach (Deployment element in deployments)
            {
                this.deployments.Add(element);
            }

            return this;
        }

        // Check to see if Deployments property is set
        internal bool IsSetDeployments()
        {
            return this.deployments.Count > 0;
        }
    }
}

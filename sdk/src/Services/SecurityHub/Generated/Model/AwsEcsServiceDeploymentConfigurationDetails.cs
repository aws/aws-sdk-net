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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Optional deployment parameters for the service.
    /// </summary>
    public partial class AwsEcsServiceDeploymentConfigurationDetails
    {
        private AwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerDetails _deploymentCircuitBreaker;
        private int? _maximumPercent;
        private int? _minimumHealthyPercent;

        /// <summary>
        /// Gets and sets the property DeploymentCircuitBreaker. 
        /// <para>
        /// Determines whether a service deployment fails if a service cannot reach a steady state.
        /// </para>
        /// </summary>
        public AwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerDetails DeploymentCircuitBreaker
        {
            get { return this._deploymentCircuitBreaker; }
            set { this._deploymentCircuitBreaker = value; }
        }

        // Check to see if DeploymentCircuitBreaker property is set
        internal bool IsSetDeploymentCircuitBreaker()
        {
            return this._deploymentCircuitBreaker != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPercent. 
        /// <para>
        /// For a service that uses the rolling update (<c>ECS</c>) deployment type, the maximum
        /// number of tasks in a service that are allowed in the <c>RUNNING</c> or <c>PENDING</c>
        /// state during a deployment, and for tasks that use the EC2 launch type, when any container
        /// instances are in the <c>DRAINING</c> state. Provided as a percentage of the desired
        /// number of tasks. The default value is 200%.
        /// </para>
        ///  
        /// <para>
        /// For a service that uses the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c> deployment
        /// types, and tasks that use the EC2 launch type, the maximum number of tasks in the
        /// service that remain in the <c>RUNNING</c> state while the container instances are
        /// in the <c>DRAINING</c> state.
        /// </para>
        ///  
        /// <para>
        /// For the Fargate launch type, the maximum percent value is not used.
        /// </para>
        /// </summary>
        public int? MaximumPercent
        {
            get { return this._maximumPercent; }
            set { this._maximumPercent = value; }
        }

        // Check to see if MaximumPercent property is set
        internal bool IsSetMaximumPercent()
        {
            return this._maximumPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumHealthyPercent. 
        /// <para>
        /// For a service that uses the rolling update (<c>ECS</c>) deployment type, the minimum
        /// number of tasks in a service that must remain in the <c>RUNNING</c> state during a
        /// deployment, and while any container instances are in the <c>DRAINING</c> state if
        /// the service contains tasks using the EC2 launch type. Expressed as a percentage of
        /// the desired number of tasks. The default value is 100%.
        /// </para>
        ///  
        /// <para>
        /// For a service that uses the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c> deployment
        /// types and tasks that use the EC2 launch type, the minimum number of the tasks in the
        /// service that remain in the <c>RUNNING</c> state while the container instances are
        /// in the <c>DRAINING</c> state.
        /// </para>
        ///  
        /// <para>
        /// For the Fargate launch type, the minimum healthy percent value is not used.
        /// </para>
        /// </summary>
        public int? MinimumHealthyPercent
        {
            get { return this._minimumHealthyPercent; }
            set { this._minimumHealthyPercent = value; }
        }

        // Check to see if MinimumHealthyPercent property is set
        internal bool IsSetMinimumHealthyPercent()
        {
            return this._minimumHealthyPercent.HasValue; 
        }

    }
}
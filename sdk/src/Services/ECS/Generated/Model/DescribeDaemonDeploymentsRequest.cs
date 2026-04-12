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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDaemonDeployments operation.
    /// Describes one or more of your daemon deployments.
    /// 
    ///  
    /// <para>
    /// A daemon deployment orchestrates the progressive rollout of daemon task updates across
    /// container instances managed by the daemon's capacity providers. Each deployment includes
    /// circuit breaker and alarm-based rollback capabilities.
    /// </para>
    /// </summary>
    public partial class DescribeDaemonDeploymentsRequest : AmazonECSRequest
    {
        private List<string> _daemonDeploymentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DaemonDeploymentArns. 
        /// <para>
        /// The ARN of the daemon deployments to describe. You can specify up to 20 ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DaemonDeploymentArns
        {
            get { return this._daemonDeploymentArns; }
            set { this._daemonDeploymentArns = value; }
        }

        // Check to see if DaemonDeploymentArns property is set
        internal bool IsSetDaemonDeploymentArns()
        {
            return this._daemonDeploymentArns != null && (this._daemonDeploymentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
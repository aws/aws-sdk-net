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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Update policy for a blue/green deployment. If this update policy is specified, SageMaker
    /// creates a new fleet during the deployment while maintaining the old fleet. SageMaker
    /// flips traffic to the new fleet according to the specified traffic routing configuration.
    /// Only one update policy should be used in the deployment configuration. If no update
    /// policy is specified, SageMaker uses a blue/green deployment strategy with all at once
    /// traffic shifting by default.
    /// </summary>
    public partial class BlueGreenUpdatePolicy
    {
        private int? _maximumExecutionTimeoutInSeconds;
        private int? _terminationWaitInSeconds;
        private TrafficRoutingConfig _trafficRoutingConfiguration;

        /// <summary>
        /// Gets and sets the property MaximumExecutionTimeoutInSeconds. 
        /// <para>
        /// Maximum execution timeout for the deployment. Note that the timeout value should be
        /// larger than the total waiting time specified in <c>TerminationWaitInSeconds</c> and
        /// <c>WaitIntervalInSeconds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=600, Max=28800)]
        public int? MaximumExecutionTimeoutInSeconds
        {
            get { return this._maximumExecutionTimeoutInSeconds; }
            set { this._maximumExecutionTimeoutInSeconds = value; }
        }

        // Check to see if MaximumExecutionTimeoutInSeconds property is set
        internal bool IsSetMaximumExecutionTimeoutInSeconds()
        {
            return this._maximumExecutionTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminationWaitInSeconds. 
        /// <para>
        /// Additional waiting time in seconds after the completion of an endpoint deployment
        /// before terminating the old endpoint fleet. Default is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? TerminationWaitInSeconds
        {
            get { return this._terminationWaitInSeconds; }
            set { this._terminationWaitInSeconds = value; }
        }

        // Check to see if TerminationWaitInSeconds property is set
        internal bool IsSetTerminationWaitInSeconds()
        {
            return this._terminationWaitInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrafficRoutingConfiguration. 
        /// <para>
        /// Defines the traffic routing strategy to shift traffic from the old fleet to the new
        /// fleet during an endpoint deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrafficRoutingConfig TrafficRoutingConfiguration
        {
            get { return this._trafficRoutingConfiguration; }
            set { this._trafficRoutingConfiguration = value; }
        }

        // Check to see if TrafficRoutingConfiguration property is set
        internal bool IsSetTrafficRoutingConfiguration()
        {
            return this._trafficRoutingConfiguration != null;
        }

    }
}
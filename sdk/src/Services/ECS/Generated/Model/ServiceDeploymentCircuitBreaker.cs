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
    /// Information about the circuit breaker used to determine when a service deployment
    /// has failed.
    /// 
    ///  
    /// <para>
    /// The deployment circuit breaker is the rolling update mechanism that determines if
    /// the tasks reach a steady state. The deployment circuit breaker has an option that
    /// will automatically roll back a failed deployment to the last cpompleted service revision.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-circuit-breaker.html">How
    /// the Amazon ECS deployment circuit breaker detects failures</a> in the<i> Amazon ECS
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ServiceDeploymentCircuitBreaker
    {
        private int? _failureCount;
        private ServiceDeploymentRollbackMonitorsStatus _status;
        private int? _threshold;

        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of times the circuit breaker detected a service deploymeny failure.
        /// </para>
        /// </summary>
        public int? FailureCount
        {
            get { return this._failureCount; }
            set { this._failureCount = value; }
        }

        // Check to see if FailureCount property is set
        internal bool IsSetFailureCount()
        {
            return this._failureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The circuit breaker status. Amazon ECS is not using the circuit breaker for service
        /// deployment failures when the status is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ServiceDeploymentRollbackMonitorsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshhold which determines that the service deployment failed.
        /// </para>
        ///  
        /// <para>
        /// The deployment circuit breaker calculates the threshold value, and then uses the value
        /// to determine when to move the deployment to a FAILED state. The deployment circuit
        /// breaker has a minimum threshold of 3 and a maximum threshold of 200. and uses the
        /// values in the following formula to determine the deployment failure.
        /// </para>
        ///  
        /// <para>
        ///  <c>0.5 * desired task count</c> 
        /// </para>
        /// </summary>
        public int? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

    }
}
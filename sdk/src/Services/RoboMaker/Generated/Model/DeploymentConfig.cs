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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a deployment configuration.
    /// </summary>
    public partial class DeploymentConfig
    {
        private int? _concurrentDeploymentPercentage;
        private int? _failureThresholdPercentage;

        /// <summary>
        /// Gets and sets the property ConcurrentDeploymentPercentage. 
        /// <para>
        /// The percentage of robots receiving the deployment at the same time.
        /// </para>
        /// </summary>
        public int ConcurrentDeploymentPercentage
        {
            get { return this._concurrentDeploymentPercentage.GetValueOrDefault(); }
            set { this._concurrentDeploymentPercentage = value; }
        }

        // Check to see if ConcurrentDeploymentPercentage property is set
        internal bool IsSetConcurrentDeploymentPercentage()
        {
            return this._concurrentDeploymentPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureThresholdPercentage. 
        /// <para>
        /// The percentage of deployments that need to fail before stopping deployment.
        /// </para>
        /// </summary>
        public int FailureThresholdPercentage
        {
            get { return this._failureThresholdPercentage.GetValueOrDefault(); }
            set { this._failureThresholdPercentage = value; }
        }

        // Check to see if FailureThresholdPercentage property is set
        internal bool IsSetFailureThresholdPercentage()
        {
            return this._failureThresholdPercentage.HasValue; 
        }

    }
}
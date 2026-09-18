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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Determines whether a service deployment fails if a service cannot reach a steady state.
    /// </summary>
    public partial class AwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerDetails
    {
        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Whether to enable the deployment circuit breaker logic for the service.
        /// </para>
        /// </summary>
        public bool? Enable { get; set; }

        /// <summary>
        /// Checks to see if the Enable property is set.
        /// </summary>
        internal bool IsSetEnable() => this.Enable.HasValue;

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// Whether to roll back the service if a service deployment fails. If rollback is enabled,
        /// when a service deployment fails, the service is rolled back to the last deployment
        /// that completed successfully.
        /// </para>
        /// </summary>
        public bool? Rollback { get; set; }

        /// <summary>
        /// Checks to see if the Rollback property is set.
        /// </summary>
        internal bool IsSetRollback() => this.Rollback.HasValue;
    }
}

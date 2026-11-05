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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateCollector operation. Associates one Collector
    /// with this Environment and configures the customer role Continuum uses to authorize
    /// access to associated Collector data. The caller must have permission on the Environment
    /// and permission to pass the role. Continuum assumes the supplied role and calls GetCollectorDataAccessAuthorization
    /// on the requested Collector; only a successful authorization response permits the association.
    /// The caller does not need Collector data-access permission. The Environment retains
    /// its other Collector associations. Calling again with an existing association is safe
    /// and does not create a duplicate.
    /// </summary>
    public partial class AssociateCollectorRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Caller-provided token that makes retried association
        /// requests idempotent. The first successful request binds the token to the complete
        /// Collector ARN, supplied role, and result for at least 24 hours. During that retry
        /// window, reusing it with a different request fails with ConflictException. A matching
        /// replay still requires the supplied role to have current Collector access. Once authorized,
        /// a matching replay returns the stored result without changing association state. Revocation
        /// can deny a replay; it does not remove the stored association or its original result.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CollectorArn. The ARN of the Collector to associate with
        /// this Environment.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string CollectorArn { get; set; }

        /// <summary>
        /// Checks to see if the CollectorArn property is set.
        /// </summary>
        internal bool IsSetCollectorArn() => this.CollectorArn != null;

        /// <summary>
        /// Gets and sets the property CollectorDataAccessRoleArn. IAM role in the Environment
        /// account that Continuum assumes before authorizing access to associated Collector inventory.
        /// Every association, including a same-account association, requires this role. The supplied
        /// ARN replaces the Environment's previously stored role. The customer is responsible
        /// for granting the role access to every Collector that should contribute data.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string CollectorDataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CollectorDataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetCollectorDataAccessRoleArn() => this.CollectorDataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The unique identifier of the Environment
        /// making the association.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;
    }
}

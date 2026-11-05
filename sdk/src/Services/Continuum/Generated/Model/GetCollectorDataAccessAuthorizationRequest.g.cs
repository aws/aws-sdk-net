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
    /// Container for the parameters to the GetCollectorDataAccessAuthorization operation.
    /// Authorizes an Environment's access to a Collector's data. Continuum calls this operation
    /// with the Environment's Collector data-access role before it reads the Collector's
    /// inventory, so grant continuum:GetCollectorDataAccessAuthorization to that role and,
    /// for a Collector in another account, in the Collector's resource policy. The operation
    /// evaluates the action against the exact Collector ARN and the Collector's current resource
    /// policy using IAM and the caller's authenticated request context, with environmentArn
    /// as the continuum:EnvironmentArn condition key. A successful request returns HTTP 200
    /// with no response members. If access is not granted, the operation returns AccessDeniedException
    /// without disclosing Collector existence, ownership, or the policy layer that denied
    /// access. The service does not reinterpret the policy using only an account ID.
    /// </summary>
    public partial class GetCollectorDataAccessAuthorizationRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. The AWS account that owns the Collector.
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CollectorId. The unique identifier of the Collector.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CollectorId { get; set; }

        /// <summary>
        /// Checks to see if the CollectorId property is set.
        /// </summary>
        internal bool IsSetCollectorId() => this.CollectorId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. The full ARN of the Environment requesting
        /// the Collector's data. The Environment must be in the caller's account. Continuum supplies
        /// this value as the continuum:EnvironmentArn condition key.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;
    }
}

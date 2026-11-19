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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyNetworkingFlexCostAllocationPolicy operation.
    /// </summary>
    public partial class ModifyNetworkingFlexCostAllocationPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FcaPolicyId. 
        /// <para>
        /// The ID of the flex cost allocation policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string FcaPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyId property is set.
        /// </summary>
        internal bool IsSetFcaPolicyId() => this.FcaPolicyId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the policy was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the policy that this modification created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;

        /// <summary>
        /// Gets and sets the property VersionExpectedEffectiveAt. 
        /// <para>
        /// The date and time when the new version of the policy is expected to apply to network
        /// traffic.
        /// </para>
        /// </summary>
        public DateTime? VersionExpectedEffectiveAt { get; set; }

        /// <summary>
        /// Checks to see if the VersionExpectedEffectiveAt property is set.
        /// </summary>
        internal bool IsSetVersionExpectedEffectiveAt() => this.VersionExpectedEffectiveAt.HasValue;
    }
}

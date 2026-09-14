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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the GetAuthPolicy operation.
    /// </summary>
    public partial class GetAuthPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the auth policy was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time that the auth policy was last updated, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The auth policy.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 36864)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the auth policy. The auth policy is only active when the auth type is
        /// set to <c>AWS_IAM</c>. If you provide a policy, then authentication and authorization
        /// decisions are made based on this policy and the client's IAM policy. If the auth type
        /// is <c>NONE</c>, then any auth policy that you provide remains inactive. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html#create-service-network">Create
        /// a service network</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        public AuthPolicyState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}

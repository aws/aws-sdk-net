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
    /// Container for the parameters to the PutAuthPolicy operation. Creates or updates the
    /// auth policy. The policy string in JSON must not contain newlines or blank lines. <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/auth-policies.html">Auth
    /// policies</a> in the <i>Amazon VPC Lattice User Guide</i>. </para>
    /// </summary>
    public partial class PutAuthPolicyRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The auth policy. The policy string in JSON must not contain newlines or blank lines.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36864)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ID or ARN of the service network or service for which the policy is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 200)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;
    }
}

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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the PutAuthPolicy operation.
    /// </summary>
    public partial class PutAuthPolicyResponse : AmazonWebServiceResponse
    {
        private string _policy;
        private AuthPolicyState _state;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The auth policy. The policy string in JSON must not contain newlines or blank lines.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the auth policy. The auth policy is only active when the auth type is
        /// set to <code>AWS_IAM</code>. If you provide a policy, then authentication and authorization
        /// decisions are made based on this policy and the client's IAM policy. If the Auth type
        /// is <code>NONE</code>, then, any auth policy you provide will remain inactive. For
        /// more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html#create-service-network">Create
        /// a service network</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        public AuthPolicyState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}
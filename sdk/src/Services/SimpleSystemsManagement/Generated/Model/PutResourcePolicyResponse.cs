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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the PutResourcePolicy operation.
    /// </summary>
    public partial class PutResourcePolicyResponse : AmazonWebServiceResponse
    {
        private string _policyHash;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property PolicyHash. 
        /// <para>
        /// ID of the current policy version.
        /// </para>
        /// </summary>
        public string PolicyHash
        {
            get { return this._policyHash; }
            set { this._policyHash = value; }
        }

        // Check to see if PolicyHash property is set
        internal bool IsSetPolicyHash()
        {
            return this._policyHash != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The policy ID. To update a policy, you must specify <code>PolicyId</code> and <code>PolicyHash</code>.
        /// </para>
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

    }
}
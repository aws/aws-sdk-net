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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the ListAutomaticTapeCreationPolicies operation.
    /// </summary>
    public partial class ListAutomaticTapeCreationPoliciesResponse : AmazonWebServiceResponse
    {
        private List<AutomaticTapeCreationPolicyInfo> _automaticTapeCreationPolicyInfos = new List<AutomaticTapeCreationPolicyInfo>();

        /// <summary>
        /// Gets and sets the property AutomaticTapeCreationPolicyInfos. 
        /// <para>
        /// Gets a listing of information about the gateway's automatic tape creation policies,
        /// including the automatic tape creation rules and the gateway that is using the policies.
        /// </para>
        /// </summary>
        public List<AutomaticTapeCreationPolicyInfo> AutomaticTapeCreationPolicyInfos
        {
            get { return this._automaticTapeCreationPolicyInfos; }
            set { this._automaticTapeCreationPolicyInfos = value; }
        }

        // Check to see if AutomaticTapeCreationPolicyInfos property is set
        internal bool IsSetAutomaticTapeCreationPolicyInfos()
        {
            return this._automaticTapeCreationPolicyInfos != null && this._automaticTapeCreationPolicyInfos.Count > 0; 
        }

    }
}
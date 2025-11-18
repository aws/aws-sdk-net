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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptDelegationRequest operation.
    /// Accepts a delegation request, granting the requested temporary access.
    /// 
    ///  
    /// <para>
    /// Once the delegation request is accepted, it is eligible to send the exchange token
    /// to the partner. The <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SendDelegationToken.html">SendDelegationToken</a>
    /// API has to be explicitly called to send the delegation token. 
    /// </para>
    ///  
    /// <para>
    /// At the time of acceptance, IAM records the details and the state of the identity that
    /// called this API. This is the identity that gets mapped to the delegated credential.
    /// 
    /// </para>
    ///  
    /// <para>
    /// An accepted request may be rejected before the exchange token is sent to the partner.
    /// </para>
    /// </summary>
    public partial class AcceptDelegationRequestRequest : AmazonIdentityManagementServiceRequest
    {
        private string _delegationRequestId;

        /// <summary>
        /// Gets and sets the property DelegationRequestId. 
        /// <para>
        /// The unique identifier of the delegation request to accept.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=128)]
        public string DelegationRequestId
        {
            get { return this._delegationRequestId; }
            set { this._delegationRequestId = value; }
        }

        // Check to see if DelegationRequestId property is set
        internal bool IsSetDelegationRequestId()
        {
            return this._delegationRequestId != null;
        }

    }
}
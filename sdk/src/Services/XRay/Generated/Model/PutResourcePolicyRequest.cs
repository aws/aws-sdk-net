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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Sets the resource policy to grant one or more Amazon Web Services services and accounts
    /// permissions to access X-Ray. Each resource policy will be associated with a specific
    /// Amazon Web Services account. Each Amazon Web Services account can have a maximum of
    /// 5 resource policies, and each policy name must be unique within that account. The
    /// maximum size of each resource policy is 5KB.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonXRayRequest
    {
        private bool? _bypassPolicyLockoutCheck;
        private string _policyDocument;
        private string _policyName;
        private string _policyRevisionId;

        /// <summary>
        /// Gets and sets the property BypassPolicyLockoutCheck. 
        /// <para>
        /// A flag to indicate whether to bypass the resource policy lockout safety check.
        /// </para>
        ///  <important> 
        /// <para>
        /// Setting this value to true increases the risk that the policy becomes unmanageable.
        /// Do not set this value to true indiscriminately.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use this parameter only when you include a policy in the request and you intend to
        /// prevent the principal that is making the request from making a subsequent <c>PutResourcePolicy</c>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool? BypassPolicyLockoutCheck
        {
            get { return this._bypassPolicyLockoutCheck; }
            set { this._bypassPolicyLockoutCheck = value; }
        }

        // Check to see if BypassPolicyLockoutCheck property is set
        internal bool IsSetBypassPolicyLockoutCheck()
        {
            return this._bypassPolicyLockoutCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The resource policy document, which can be up to 5kb in size.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the resource policy. Must be unique within a specific Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// Specifies a specific policy revision, to ensure an atomic create operation. By default
        /// the resource policy is created if it does not exist, or updated with an incremented
        /// revision id. The revision id is unique to each policy in the account.
        /// </para>
        ///  
        /// <para>
        /// If the policy revision id does not match the latest revision id, the operation will
        /// fail with an <c>InvalidPolicyRevisionIdException</c> exception. You can also provide
        /// a <c>PolicyRevisionId</c> of 0. In this case, the operation will fail with an <c>InvalidPolicyRevisionIdException</c>
        /// exception if a resource policy with the same name already exists. 
        /// </para>
        /// </summary>
        public string PolicyRevisionId
        {
            get { return this._policyRevisionId; }
            set { this._policyRevisionId = value; }
        }

        // Check to see if PolicyRevisionId property is set
        internal bool IsSetPolicyRevisionId()
        {
            return this._policyRevisionId != null;
        }

    }
}
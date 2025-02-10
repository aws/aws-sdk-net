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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFirewallManagerRuleGroups operation.
    /// Deletes all rule groups that are managed by Firewall Manager from the specified <a>WebACL</a>.
    /// 
    /// 
    ///  
    /// <para>
    /// You can only use this if <c>ManagedByFirewallManager</c> and <c>RetrofittedByFirewallManager</c>
    /// are both false in the web ACL. 
    /// </para>
    /// </summary>
    public partial class DeleteFirewallManagerRuleGroupsRequest : AmazonWAFV2Request
    {
        private string _webACLArn;
        private string _webACLLockToken;

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string WebACLArn
        {
            get { return this._webACLArn; }
            set { this._webACLArn = value; }
        }

        // Check to see if WebACLArn property is set
        internal bool IsSetWebACLArn()
        {
            return this._webACLArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebACLLockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string WebACLLockToken
        {
            get { return this._webACLLockToken; }
            set { this._webACLLockToken = value; }
        }

        // Check to see if WebACLLockToken property is set
        internal bool IsSetWebACLLockToken()
        {
            return this._webACLLockToken != null;
        }

    }
}
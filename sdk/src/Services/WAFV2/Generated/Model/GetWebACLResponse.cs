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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the GetWebACL operation.
    /// </summary>
    public partial class GetWebACLResponse : AmazonWebServiceResponse
    {
        private string _lockToken;
        private WebACL _webACL;

        /// <summary>
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. AWS WAF returns a token to your get and list
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// update and delete. AWS WAF uses the token to ensure that no changes have been made
        /// to the entity since you last retrieved it. If a change has been made, the update fails
        /// with a <code>WAFOptimisticLockException</code>. If this happens, perform another get,
        /// and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string LockToken
        {
            get { return this._lockToken; }
            set { this._lockToken = value; }
        }

        // Check to see if LockToken property is set
        internal bool IsSetLockToken()
        {
            return this._lockToken != null;
        }

        /// <summary>
        /// Gets and sets the property WebACL. 
        /// <para>
        /// The Web ACL specification. You can modify the settings in this Web ACL and use it
        /// to update this Web ACL or create a new one.
        /// </para>
        /// </summary>
        public WebACL WebACL
        {
            get { return this._webACL; }
            set { this._webACL = value; }
        }

        // Check to see if WebACL property is set
        internal bool IsSetWebACL()
        {
            return this._webACL != null;
        }

    }
}
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
    /// This is the response object from the UpdateIPSet operation.
    /// </summary>
    public partial class UpdateIPSetResponse : AmazonWebServiceResponse
    {
        private string _nextLockToken;

        /// <summary>
        /// Gets and sets the property NextLockToken. 
        /// <para>
        /// A token used for optimistic locking. AWS WAF returns this token to your update requests.
        /// You use <code>NextLockToken</code> in the same manner as you use <code>LockToken</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string NextLockToken
        {
            get { return this._nextLockToken; }
            set { this._nextLockToken = value; }
        }

        // Check to see if NextLockToken property is set
        internal bool IsSetNextLockToken()
        {
            return this._nextLockToken != null;
        }

    }
}
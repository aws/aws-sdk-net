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
    /// In a <a>WebACL</a>, this is the action that you want WAF to perform when a web request
    /// doesn't match any of the rules in the <c>WebACL</c>. The default action must be a
    /// terminating action.
    /// </summary>
    public partial class DefaultAction
    {
        private AllowAction _allow;
        private BlockAction _block;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Specifies that WAF should allow requests by default.
        /// </para>
        /// </summary>
        public AllowAction Allow
        {
            get { return this._allow; }
            set { this._allow = value; }
        }

        // Check to see if Allow property is set
        internal bool IsSetAllow()
        {
            return this._allow != null;
        }

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// Specifies that WAF should block requests by default. 
        /// </para>
        /// </summary>
        public BlockAction Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null;
        }

    }
}
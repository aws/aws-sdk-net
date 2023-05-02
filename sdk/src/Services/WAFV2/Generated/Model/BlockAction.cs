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
    /// Specifies that WAF should block the request and optionally defines additional custom
    /// handling for the response to the web request.
    /// 
    ///  
    /// <para>
    /// This is used in the context of other settings, for example to specify values for <a>RuleAction</a>
    /// and web ACL <a>DefaultAction</a>. 
    /// </para>
    /// </summary>
    public partial class BlockAction
    {
        private CustomResponse _customResponse;

        /// <summary>
        /// Gets and sets the property CustomResponse. 
        /// <para>
        /// Defines a custom response for the web request.
        /// </para>
        ///  
        /// <para>
        /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
        /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        public CustomResponse CustomResponse
        {
            get { return this._customResponse; }
            set { this._customResponse = value; }
        }

        // Check to see if CustomResponse property is set
        internal bool IsSetCustomResponse()
        {
            return this._customResponse != null;
        }

    }
}
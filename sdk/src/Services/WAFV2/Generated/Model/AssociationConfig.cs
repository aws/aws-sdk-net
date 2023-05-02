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
    /// Specifies custom configurations for the associations between the web ACL and protected
    /// resources. 
    /// 
    ///  
    /// <para>
    /// Use this to customize the maximum size of the request body that your protected CloudFront
    /// distributions forward to WAF for inspection. The default is 16 KB (16,384 kilobytes).
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// You are charged additional fees when your protected resources forward body sizes that
    /// are larger than the default. For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF
    /// Pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociationConfig
    {
        private Dictionary<string, RequestBodyAssociatedResourceTypeConfig> _requestBody = new Dictionary<string, RequestBodyAssociatedResourceTypeConfig>();

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// Customizes the maximum size of the request body that your protected CloudFront distributions
        /// forward to WAF for inspection. The default size is 16 KB (16,384 kilobytes). 
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged additional fees when your protected resources forward body sizes that
        /// are larger than the default. For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF
        /// Pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, RequestBodyAssociatedResourceTypeConfig> RequestBody
        {
            get { return this._requestBody; }
            set { this._requestBody = value; }
        }

        // Check to see if RequestBody property is set
        internal bool IsSetRequestBody()
        {
            return this._requestBody != null && this._requestBody.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an HTTP method condition.
    /// 
    ///  
    /// <para>
    /// HTTP defines a set of request methods, also referred to as HTTP verbs. For more information,
    /// see the <a href="https://www.iana.org/assignments/http-methods/http-methods.xhtml">HTTP
    /// Method Registry</a>. You can also define custom HTTP methods.
    /// </para>
    /// </summary>
    public partial class HttpRequestMethodConditionConfig
    {
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The name of the request method. The maximum size is 40 characters. The allowed characters
        /// are A-Z, hyphen (-), and underscore (_). The comparison is case sensitive. Wildcards
        /// are not supported; therefore, the method name must be an exact match.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple strings, the condition is satisfied if one of the strings
        /// matches the HTTP request method. We recommend that you route GET and HEAD requests
        /// in the same way, because the response to a HEAD request may be cached.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}
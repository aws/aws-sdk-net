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
    /// Inspect the body of the web request. The body immediately follows the request headers.
    /// 
    ///  
    /// <para>
    /// This is used to indicate the web request component to inspect, in the <a>FieldToMatch</a>
    /// specification. 
    /// </para>
    /// </summary>
    public partial class Body
    {
        private OversizeHandling _oversizeHandling;

        /// <summary>
        /// Gets and sets the property OversizeHandling. 
        /// <para>
        /// What WAF should do if the body is larger than WAF can inspect. 
        /// </para>
        ///  
        /// <para>
        /// WAF does not support inspecting the entire contents of the web request body if the
        /// body exceeds the limit for the resource type. When a web request body is larger than
        /// the limit, the underlying host service only forwards the contents that are within
        /// the limit to WAF for inspection. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CloudFront, API Gateway, Amazon Cognito, App Runner, and Verified Access, the
        /// default limit is 16 KB (16,384 bytes), and you can increase the limit for each resource
        /// type in the web ACL <c>AssociationConfig</c>, for additional processing fees. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amplify, use the CloudFront limit.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The options for oversize handling are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTINUE</c> - Inspect the available body contents normally, according to the
        /// rule inspection criteria. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MATCH</c> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_MATCH</c> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can combine the <c>MATCH</c> or <c>NO_MATCH</c> settings for oversize handling
        /// with your rule and web ACL action settings, so that you block any request whose body
        /// is over the limit. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>CONTINUE</c> 
        /// </para>
        /// </summary>
        public OversizeHandling OversizeHandling
        {
            get { return this._oversizeHandling; }
            set { this._oversizeHandling = value; }
        }

        // Check to see if OversizeHandling property is set
        internal bool IsSetOversizeHandling()
        {
            return this._oversizeHandling != null;
        }

    }
}
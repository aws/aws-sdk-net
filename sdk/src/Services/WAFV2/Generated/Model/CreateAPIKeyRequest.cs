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
    /// Container for the parameters to the CreateAPIKey operation.
    /// Creates an API key that contains a set of token domains.
    /// 
    ///  
    /// <para>
    /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
    /// applications. The API lets you customize the placement and characteristics of the
    /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
    /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
    /// client application integration</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can use a single key for up to 5 domains. After you generate a key, you can copy
    /// it for use in your JavaScript integration. 
    /// </para>
    /// </summary>
    public partial class CreateAPIKeyRequest : AmazonWAFV2Request
    {
        private Scope _scope;
        private List<string> _tokenDomains = new List<string>();

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an Amazon CloudFront distribution or for a regional
        /// application. A regional application can be an Application Load Balancer (ALB), an
        /// Amazon API Gateway REST API, an AppSync GraphQL API, an Amazon Cognito user pool,
        /// an App Runner service, or an Amazon Web Services Verified Access instance. 
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <code>--scope=CLOUDFRONT
        /// --region=us-east-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TokenDomains. 
        /// <para>
        /// The client application domains that you want to use this API key for. 
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <code>"TokenDomains": ["abc.com", "store.abc.com"]</code> 
        /// </para>
        ///  
        /// <para>
        /// Public suffixes aren't allowed. For example, you can't use <code>usa.gov</code> or
        /// <code>co.uk</code> as token domains.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> TokenDomains
        {
            get { return this._tokenDomains; }
            set { this._tokenDomains = value; }
        }

        // Check to see if TokenDomains property is set
        internal bool IsSetTokenDomains()
        {
            return this._tokenDomains != null && this._tokenDomains.Count > 0; 
        }

    }
}
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
    /// Container for the parameters to the GetDecryptedAPIKey operation.
    /// Returns your API key in decrypted form. Use this to check the token domains that you
    /// have defined for the key. 
    /// 
    ///  
    /// <para>
    /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
    /// applications. The API lets you customize the placement and characteristics of the
    /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
    /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
    /// client application integration</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetDecryptedAPIKeyRequest : AmazonWAFV2Request
    {
        private string _apiKey;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property APIKey. 
        /// <para>
        /// The encrypted API key. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string APIKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if APIKey property is set
        internal bool IsSetAPIKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
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

    }
}
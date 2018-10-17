/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents an AWS account that is associated with API Gateway.
    /// 
    ///  <div class="remarks"> 
    /// <para>
    /// To view the account info, call <code>GET</code> on this resource.
    /// </para>
    ///  <h4>Error Codes</h4> 
    /// <para>
    /// The following exception may be thrown when the request fails.
    /// </para>
    ///  <ul> <li>UnauthorizedException</li> <li>NotFoundException</li> <li>TooManyRequestsException</li>
    /// </ul> 
    /// <para>
    /// For detailed error code information, including the corresponding HTTP Status Codes,
    /// see <a href="https://docs.aws.amazon.com/apigateway/api-reference/handling-errors/#api-error-codes">API
    /// Gateway Error Codes</a>
    /// </para>
    ///  <h4>Example: Get the information about an account.</h4> <h5>Request</h5> <pre><code>GET
    /// /account HTTP/1.1 Content-Type: application/json Host: apigateway.us-east-1.amazonaws.com
    /// X-Amz-Date: 20160531T184618Z Authorization: AWS4-HMAC-SHA256 Credential={access_key_ID}/us-east-1/apigateway/aws4_request,
    /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash} </code></pre> <h5>Response</h5>
    /// 
    /// <para>
    /// The successful response returns a <code>200 OK</code> status code and a payload similar
    /// to the following:
    /// </para>
    ///  <pre><code>{ "_links": { "curies": { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/account-apigateway-{rel}.html",
    /// "name": "account", "templated": true }, "self": { "href": "/account" }, "account:update":
    /// { "href": "/account" } }, "cloudwatchRoleArn": "arn:aws:iam::123456789012:role/apigAwsProxyRole",
    /// "throttleSettings": { "rateLimit": 500, "burstLimit": 1000 } } </code></pre> 
    /// <para>
    /// In addition to making the REST API call directly, you can use the AWS CLI and an AWS
    /// SDK to access this resource.
    /// </para>
    ///  </div> <div class="seeAlso"> <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-limits.html">API
    /// Gateway Limits</a> <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/welcome.html">Developer
    /// Guide</a>, <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-account.html">AWS
    /// CLI</a> </div>
    /// </summary>
    public partial class UpdateAccountResponse : AmazonWebServiceResponse
    {
        private string _apiKeyVersion;
        private string _cloudwatchRoleArn;
        private List<string> _features = new List<string>();
        private ThrottleSettings _throttleSettings;

        /// <summary>
        /// Gets and sets the property ApiKeyVersion. 
        /// <para>
        /// The version of the API keys used for the account.
        /// </para>
        /// </summary>
        public string ApiKeyVersion
        {
            get { return this._apiKeyVersion; }
            set { this._apiKeyVersion = value; }
        }

        // Check to see if ApiKeyVersion property is set
        internal bool IsSetApiKeyVersion()
        {
            return this._apiKeyVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CloudwatchRoleArn. 
        /// <para>
        /// The ARN of an Amazon CloudWatch role for the current <a>Account</a>. 
        /// </para>
        /// </summary>
        public string CloudwatchRoleArn
        {
            get { return this._cloudwatchRoleArn; }
            set { this._cloudwatchRoleArn = value; }
        }

        // Check to see if CloudwatchRoleArn property is set
        internal bool IsSetCloudwatchRoleArn()
        {
            return this._cloudwatchRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A list of features supported for the account. When usage plans are enabled, the features
        /// list will include an entry of <code>"UsagePlans"</code>.
        /// </para>
        /// </summary>
        public List<string> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && this._features.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThrottleSettings. 
        /// <para>
        /// Specifies the API request limits configured for the current <a>Account</a>.
        /// </para>
        /// </summary>
        public ThrottleSettings ThrottleSettings
        {
            get { return this._throttleSettings; }
            set { this._throttleSettings = value; }
        }

        // Check to see if ThrottleSettings property is set
        internal bool IsSetThrottleSettings()
        {
            return this._throttleSettings != null;
        }

    }
}
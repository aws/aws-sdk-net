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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// A <c>LambdaAuthorizerConfig</c> specifies how to authorize AppSync API access when
    /// using the <c>AWS_LAMBDA</c> authorizer mode. Be aware that an AppSync API can have
    /// only one Lambda authorizer configured at a time.
    /// </summary>
    public partial class LambdaAuthorizerConfig
    {
        private int? _authorizerResultTtlInSeconds;
        private string _authorizerUri;
        private string _identityValidationExpression;

        /// <summary>
        /// Gets and sets the property AuthorizerResultTtlInSeconds. 
        /// <para>
        /// The number of seconds a response should be cached for. The default is 0 seconds, which
        /// disables caching. If you don't specify a value for <c>authorizerResultTtlInSeconds</c>,
        /// the default value is used. The maximum value is one hour (3600 seconds). The Lambda
        /// function can override this by returning a <c>ttlOverride</c> key in its response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? AuthorizerResultTtlInSeconds
        {
            get { return this._authorizerResultTtlInSeconds; }
            set { this._authorizerResultTtlInSeconds = value; }
        }

        // Check to see if AuthorizerResultTtlInSeconds property is set
        internal bool IsSetAuthorizerResultTtlInSeconds()
        {
            return this._authorizerResultTtlInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizerUri. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function to be called for authorization.
        /// This can be a standard Lambda ARN, a version ARN (<c>.../v3</c>), or an alias ARN.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: This Lambda function must have the following resource-based policy assigned
        /// to it. When configuring Lambda authorizers in the console, this is done for you. To
        /// use the Command Line Interface (CLI), run the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws lambda add-permission --function-name "arn:aws:lambda:us-east-2:111122223333:function:my-function"
        /// --statement-id "appsync" --principal appsync.amazonaws.com --action lambda:InvokeFunction</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AuthorizerUri
        {
            get { return this._authorizerUri; }
            set { this._authorizerUri = value; }
        }

        // Check to see if AuthorizerUri property is set
        internal bool IsSetAuthorizerUri()
        {
            return this._authorizerUri != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityValidationExpression. 
        /// <para>
        /// A regular expression for validation of tokens before the Lambda function is called.
        /// </para>
        /// </summary>
        public string IdentityValidationExpression
        {
            get { return this._identityValidationExpression; }
            set { this._identityValidationExpression = value; }
        }

        // Check to see if IdentityValidationExpression property is set
        internal bool IsSetIdentityValidationExpression()
        {
            return this._identityValidationExpression != null;
        }

    }
}
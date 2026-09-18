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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the authorization configuration for using an Lambda function with your
    /// AppSync GraphQL API endpoint.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetails
    {
        /// <summary>
        /// Gets and sets the property AuthorizerResultTtlInSeconds. 
        /// <para>
        ///  The number of seconds a response should be cached for. The default is 5 minutes (300
        /// seconds). 
        /// </para>
        /// </summary>
        public int? AuthorizerResultTtlInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerResultTtlInSeconds property is set.
        /// </summary>
        internal bool IsSetAuthorizerResultTtlInSeconds() => this.AuthorizerResultTtlInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AuthorizerUri. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lambda function to be called for authorization.
        /// This can be a standard Lambda ARN, a version ARN (.../v3), or an alias ARN. 
        /// </para>
        /// </summary>
        public string AuthorizerUri { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerUri property is set.
        /// </summary>
        internal bool IsSetAuthorizerUri() => this.AuthorizerUri != null;

        /// <summary>
        /// Gets and sets the property IdentityValidationExpression. 
        /// <para>
        ///  A regular expression for validation of tokens before the Lambda function is called.
        /// 
        /// </para>
        /// </summary>
        public string IdentityValidationExpression { get; set; }

        /// <summary>
        /// Checks to see if the IdentityValidationExpression property is set.
        /// </summary>
        internal bool IsSetIdentityValidationExpression() => this.IdentityValidationExpression != null;
    }
}

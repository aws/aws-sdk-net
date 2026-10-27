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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The request object for this operation.
    /// </summary>
    public partial class LoginAuthConfigReqObj
    {
        /// <summary>
        /// Gets and sets the property AwsCognitoIdentityPoolId. 
        /// <para>
        /// The Amazon Cognito identity pool ID used for the Amplify Admin UI login authorization.
        /// </para>
        /// </summary>
        public string AwsCognitoIdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the AwsCognitoIdentityPoolId property is set.
        /// </summary>
        internal bool IsSetAwsCognitoIdentityPoolId() => this.AwsCognitoIdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property AwsCognitoRegion. 
        /// <para>
        /// The AWS Region for the Amplify Admin UI login.
        /// </para>
        /// </summary>
        public string AwsCognitoRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsCognitoRegion property is set.
        /// </summary>
        internal bool IsSetAwsCognitoRegion() => this.AwsCognitoRegion != null;

        /// <summary>
        /// Gets and sets the property AwsUserPoolsId. 
        /// <para>
        /// The Amazon Cognito user pool ID used for Amplify Admin UI login authentication.
        /// </para>
        /// </summary>
        public string AwsUserPoolsId { get; set; }

        /// <summary>
        /// Checks to see if the AwsUserPoolsId property is set.
        /// </summary>
        internal bool IsSetAwsUserPoolsId() => this.AwsUserPoolsId != null;

        /// <summary>
        /// Gets and sets the property AwsUserPoolsWebClientId. 
        /// <para>
        /// The web client ID for the Amazon Cognito user pools.
        /// </para>
        /// </summary>
        public string AwsUserPoolsWebClientId { get; set; }

        /// <summary>
        /// Checks to see if the AwsUserPoolsWebClientId property is set.
        /// </summary>
        internal bool IsSetAwsUserPoolsWebClientId() => this.AwsUserPoolsWebClientId != null;
    }
}

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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
        private string _awsCognitoIdentityPoolId;
        private string _awsCognitoRegion;
        private string _awsUserPoolsId;
        private string _awsUserPoolsWebClientId;

        /// <summary>
        /// Gets and sets the property AwsCognitoIdentityPoolId. 
        /// <para>
        /// The Amazon Cognito identity pool ID used for the Amplify Admin UI login authorization.
        /// </para>
        /// </summary>
        public string AwsCognitoIdentityPoolId
        {
            get { return this._awsCognitoIdentityPoolId; }
            set { this._awsCognitoIdentityPoolId = value; }
        }

        // Check to see if AwsCognitoIdentityPoolId property is set
        internal bool IsSetAwsCognitoIdentityPoolId()
        {
            return this._awsCognitoIdentityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCognitoRegion. 
        /// <para>
        /// The AWS Region for the Amplify Admin UI login.
        /// </para>
        /// </summary>
        public string AwsCognitoRegion
        {
            get { return this._awsCognitoRegion; }
            set { this._awsCognitoRegion = value; }
        }

        // Check to see if AwsCognitoRegion property is set
        internal bool IsSetAwsCognitoRegion()
        {
            return this._awsCognitoRegion != null;
        }

        /// <summary>
        /// Gets and sets the property AwsUserPoolsId. 
        /// <para>
        /// The Amazon Cognito user pool ID used for Amplify Admin UI login authentication.
        /// </para>
        /// </summary>
        public string AwsUserPoolsId
        {
            get { return this._awsUserPoolsId; }
            set { this._awsUserPoolsId = value; }
        }

        // Check to see if AwsUserPoolsId property is set
        internal bool IsSetAwsUserPoolsId()
        {
            return this._awsUserPoolsId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsUserPoolsWebClientId. 
        /// <para>
        /// The web client ID for the Amazon Cognito user pools.
        /// </para>
        /// </summary>
        public string AwsUserPoolsWebClientId
        {
            get { return this._awsUserPoolsWebClientId; }
            set { this._awsUserPoolsWebClientId = value; }
        }

        // Check to see if AwsUserPoolsWebClientId property is set
        internal bool IsSetAwsUserPoolsWebClientId()
        {
            return this._awsUserPoolsWebClientId != null;
        }

    }
}
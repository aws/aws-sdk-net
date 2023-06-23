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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains configuration information used when creating a new identity source.
    /// 
    ///  <note> 
    /// <para>
    /// At this time, the only valid member of this structure is a Amazon Cognito user pool
    /// configuration.
    /// </para>
    ///  
    /// <para>
    /// You must specify a <code>userPoolArn</code>, and optionally, a <code>ClientId</code>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This data type is used as a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_CreateIdentitySource.html">CreateIdentitySource</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class Configuration
    {
        private CognitoUserPoolConfiguration _cognitoUserPoolConfiguration;

        /// <summary>
        /// Gets and sets the property CognitoUserPoolConfiguration. 
        /// <para>
        /// Contains configuration details of a Amazon Cognito user pool that Verified Permissions
        /// can use as a source of authenticated identities as entities. It specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of a Amazon Cognito user pool and one or more application
        /// client IDs.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>"configuration":{"cognitoUserPoolConfiguration":{"userPoolArn":"arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5","clientIds":
        /// ["a1b2c3d4e5f6g7h8i9j0kalbmc"]}}</code> 
        /// </para>
        /// </summary>
        public CognitoUserPoolConfiguration CognitoUserPoolConfiguration
        {
            get { return this._cognitoUserPoolConfiguration; }
            set { this._cognitoUserPoolConfiguration = value; }
        }

        // Check to see if CognitoUserPoolConfiguration property is set
        internal bool IsSetCognitoUserPoolConfiguration()
        {
            return this._cognitoUserPoolConfiguration != null;
        }

    }
}
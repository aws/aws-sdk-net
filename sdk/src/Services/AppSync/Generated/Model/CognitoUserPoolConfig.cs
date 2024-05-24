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
    /// Describes an Amazon Cognito user pool configuration.
    /// </summary>
    public partial class CognitoUserPoolConfig
    {
        private string _appIdClientRegex;
        private string _awsRegion;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AppIdClientRegex. 
        /// <para>
        /// A regular expression for validating the incoming Amazon Cognito user pool app client
        /// ID. If this value isn't set, no filtering is applied.
        /// </para>
        /// </summary>
        public string AppIdClientRegex
        {
            get { return this._appIdClientRegex; }
            set { this._appIdClientRegex = value; }
        }

        // Check to see if AppIdClientRegex property is set
        internal bool IsSetAppIdClientRegex()
        {
            return this._appIdClientRegex != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region in which the user pool was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}
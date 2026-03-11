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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// The configuration for using Amazon Cognito user pools to control access to your portal.
    /// </summary>
    public partial class CognitoConfig
    {
        private string _appClientId;
        private string _userPoolArn;
        private string _userPoolDomain;

        /// <summary>
        /// Gets and sets the property AppClientId. 
        /// <para>
        /// The app client ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AppClientId
        {
            get { return this._appClientId; }
            set { this._appClientId = value; }
        }

        // Check to see if AppClientId property is set
        internal bool IsSetAppClientId()
        {
            return this._appClientId != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The user pool ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string UserPoolArn
        {
            get { return this._userPoolArn; }
            set { this._userPoolArn = value; }
        }

        // Check to see if UserPoolArn property is set
        internal bool IsSetUserPoolArn()
        {
            return this._userPoolArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolDomain. 
        /// <para>
        /// The user pool domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string UserPoolDomain
        {
            get { return this._userPoolDomain; }
            set { this._userPoolDomain = value; }
        }

        // Check to see if UserPoolDomain property is set
        internal bool IsSetUserPoolDomain()
        {
            return this._userPoolDomain != null;
        }

    }
}
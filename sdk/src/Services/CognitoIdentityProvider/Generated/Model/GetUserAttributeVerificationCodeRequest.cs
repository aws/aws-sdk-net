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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the GetUserAttributeVerificationCode operation.
    /// Gets the user attribute verification code for the specified attribute name.
    /// </summary>
    public partial class GetUserAttributeVerificationCodeRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _attributeName;
        private Dictionary<string, string> _clientMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token returned by the server response to get the user attribute verification
        /// code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The attribute name returned by the server response to get the user attribute verification
        /// code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientMetadata. 
        /// <para>
        /// A map of custom key-value pairs that you can provide as input for any custom workflows
        /// that this action triggers. 
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning AWS Lambda functions to user pool triggers.
        /// When you use the GetUserAttributeVerificationCode API action, Amazon Cognito invokes
        /// the function that is assigned to the <i>custom message</i> trigger. When Amazon Cognito
        /// invokes this function, it passes a JSON payload, which the function receives as input.
        /// This payload contains a <code>clientMetadata</code> attribute, which provides the
        /// data that you assigned to the ClientMetadata parameter in your GetUserAttributeVerificationCode
        /// request. In your function code in AWS Lambda, you can process the <code>clientMetadata</code>
        /// value to enhance your workflow for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">Customizing
        /// User Pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Take the following limitations into consideration when you use the ClientMetadata
        /// parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Cognito does not store the ClientMetadata value. This data is available only
        /// to AWS Lambda triggers that are assigned to a user pool to support custom workflows.
        /// If your user pool configuration does not include triggers, the ClientMetadata parameter
        /// serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito does not validate the ClientMetadata value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito does not encrypt the the ClientMetadata value, so don't use it to provide
        /// sensitive information.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public Dictionary<string, string> ClientMetadata
        {
            get { return this._clientMetadata; }
            set { this._clientMetadata = value; }
        }

        // Check to see if ClientMetadata property is set
        internal bool IsSetClientMetadata()
        {
            return this._clientMetadata != null && this._clientMetadata.Count > 0; 
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}
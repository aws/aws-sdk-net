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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The verification code response returned by the server response to get the user attribute
    /// verification code.
    /// </summary>
    public partial class GetUserAttributeVerificationCodeResponse : AmazonWebServiceResponse
    {
        private CodeDeliveryDetailsType _codeDeliveryDetails;

        /// <summary>
        /// Gets and sets the property CodeDeliveryDetails. 
        /// <para>
        /// The code delivery details returned by the server in response to the request to get
        /// the user attribute verification code.
        /// </para>
        /// </summary>
        public CodeDeliveryDetailsType CodeDeliveryDetails
        {
            get { return this._codeDeliveryDetails; }
            set { this._codeDeliveryDetails = value; }
        }

        // Check to see if CodeDeliveryDetails property is set
        internal bool IsSetCodeDeliveryDetails()
        {
            return this._codeDeliveryDetails != null;
        }

    }
}
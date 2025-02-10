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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the AssociateWhatsAppBusinessAccount operation.
    /// </summary>
    public partial class AssociateWhatsAppBusinessAccountResponse : AmazonWebServiceResponse
    {
        private WhatsAppSignupCallbackResult _signupCallbackResult;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property SignupCallbackResult. 
        /// <para>
        /// Contains your WhatsApp registration status.
        /// </para>
        /// </summary>
        public WhatsAppSignupCallbackResult SignupCallbackResult
        {
            get { return this._signupCallbackResult; }
            set { this._signupCallbackResult = value; }
        }

        // Check to see if SignupCallbackResult property is set
        internal bool IsSetSignupCallbackResult()
        {
            return this._signupCallbackResult != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code for the response.
        /// </para>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}
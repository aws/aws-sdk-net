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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The confirm-device response.
    /// </summary>
    public partial class ConfirmDeviceResponse : AmazonWebServiceResponse
    {
        private bool? _userConfirmationNecessary;

        /// <summary>
        /// Gets and sets the property UserConfirmationNecessary. 
        /// <para>
        /// When <c>true</c>, your user must confirm that they want to remember the device. Prompt
        /// the user for an answer.
        /// </para>
        ///  
        /// <para>
        /// When <c>false</c>, immediately sets the device as remembered and eligible for device
        /// authentication.
        /// </para>
        ///  
        /// <para>
        /// You can configure your user pool to always remember devices, in which case this response
        /// is <c>false</c>, or to allow users to opt in, in which case this response is <c>true</c>.
        /// Configure this option under <i>Device tracking</i> in the <i>Sign-in</i> menu of your
        /// user pool.
        /// </para>
        /// </summary>
        public bool? UserConfirmationNecessary
        {
            get { return this._userConfirmationNecessary; }
            set { this._userConfirmationNecessary = value; }
        }

        // Check to see if UserConfirmationNecessary property is set
        internal bool IsSetUserConfirmationNecessary()
        {
            return this._userConfirmationNecessary.HasValue; 
        }

    }
}
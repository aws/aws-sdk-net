/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Confirms the device response.
    /// </summary>
    public partial class ConfirmDeviceResponse : AmazonWebServiceResponse
    {
        private bool? _userConfirmationNecessary;

        /// <summary>
        /// Gets and sets the property UserConfirmationNecessary. 
        /// <para>
        /// Indicates whether the user confirmation is necessary to confirm the device response.
        /// </para>
        /// </summary>
        public bool UserConfirmationNecessary
        {
            get { return this._userConfirmationNecessary.GetValueOrDefault(); }
            set { this._userConfirmationNecessary = value; }
        }

        // Check to see if UserConfirmationNecessary property is set
        internal bool IsSetUserConfirmationNecessary()
        {
            return this._userConfirmationNecessary.HasValue; 
        }

    }
}
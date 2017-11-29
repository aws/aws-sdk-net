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
    /// Contextual data such as the user's device fingerprint, IP address, or location used
    /// for evaluating the risk of an unexpected event by Amazon Cognito advanced security.
    /// </summary>
    public partial class UserContextDataType
    {
        private string _encodedData;

        /// <summary>
        /// Gets and sets the property EncodedData. 
        /// <para>
        /// Contextual data such as the user's device fingerprint, IP address, or location used
        /// for evaluating the risk of an unexpected event by Amazon Cognito advanced security.
        /// </para>
        /// </summary>
        public string EncodedData
        {
            get { return this._encodedData; }
            set { this._encodedData = value; }
        }

        // Check to see if EncodedData property is set
        internal bool IsSetEncodedData()
        {
            return this._encodedData != null;
        }

    }
}
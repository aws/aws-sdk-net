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
    /// The SMS configuratoin type.
    /// </summary>
    public partial class SmsConfigurationType
    {
        private string _externalId;
        private string _snsCallerArn;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property SnsCallerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) caller.
        /// </para>
        /// </summary>
        public string SnsCallerArn
        {
            get { return this._snsCallerArn; }
            set { this._snsCallerArn = value; }
        }

        // Check to see if SnsCallerArn property is set
        internal bool IsSetSnsCallerArn()
        {
            return this._snsCallerArn != null;
        }

    }
}
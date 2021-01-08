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
    /// The user pool add-ons type.
    /// </summary>
    public partial class UserPoolAddOnsType
    {
        private AdvancedSecurityModeType _advancedSecurityMode;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityMode. 
        /// <para>
        /// The advanced security mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AdvancedSecurityModeType AdvancedSecurityMode
        {
            get { return this._advancedSecurityMode; }
            set { this._advancedSecurityMode = value; }
        }

        // Check to see if AdvancedSecurityMode property is set
        internal bool IsSetAdvancedSecurityMode()
        {
            return this._advancedSecurityMode != null;
        }

    }
}
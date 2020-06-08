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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The data type for <code>AccountRecoverySetting</code>.
    /// </summary>
    public partial class AccountRecoverySettingType
    {
        private List<RecoveryOptionType> _recoveryMechanisms = new List<RecoveryOptionType>();

        /// <summary>
        /// Gets and sets the property RecoveryMechanisms. 
        /// <para>
        /// The list of <code>RecoveryOptionTypes</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<RecoveryOptionType> RecoveryMechanisms
        {
            get { return this._recoveryMechanisms; }
            set { this._recoveryMechanisms = value; }
        }

        // Check to see if RecoveryMechanisms property is set
        internal bool IsSetRecoveryMechanisms()
        {
            return this._recoveryMechanisms != null && this._recoveryMechanisms.Count > 0; 
        }

    }
}
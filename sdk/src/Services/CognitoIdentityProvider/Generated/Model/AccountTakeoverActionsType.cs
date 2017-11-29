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
    /// Account takeover actions type.
    /// </summary>
    public partial class AccountTakeoverActionsType
    {
        private AccountTakeoverActionType _highAction;
        private AccountTakeoverActionType _lowAction;
        private AccountTakeoverActionType _mediumAction;

        /// <summary>
        /// Gets and sets the property HighAction. 
        /// <para>
        /// Action to take for a high risk.
        /// </para>
        /// </summary>
        public AccountTakeoverActionType HighAction
        {
            get { return this._highAction; }
            set { this._highAction = value; }
        }

        // Check to see if HighAction property is set
        internal bool IsSetHighAction()
        {
            return this._highAction != null;
        }

        /// <summary>
        /// Gets and sets the property LowAction. 
        /// <para>
        /// Action to take for a low risk.
        /// </para>
        /// </summary>
        public AccountTakeoverActionType LowAction
        {
            get { return this._lowAction; }
            set { this._lowAction = value; }
        }

        // Check to see if LowAction property is set
        internal bool IsSetLowAction()
        {
            return this._lowAction != null;
        }

        /// <summary>
        /// Gets and sets the property MediumAction. 
        /// <para>
        /// Action to take for a medium risk.
        /// </para>
        /// </summary>
        public AccountTakeoverActionType MediumAction
        {
            get { return this._mediumAction; }
            set { this._mediumAction = value; }
        }

        // Check to see if MediumAction property is set
        internal bool IsSetMediumAction()
        {
            return this._mediumAction != null;
        }

    }
}
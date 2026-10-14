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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A list of account-takeover actions for each level of risk that Amazon Cognito might
    /// assess with threat protection features.
    /// </summary>
    public partial class AccountTakeoverActionsType
    {
        /// <summary>
        /// Gets and sets the property HighAction. 
        /// <para>
        /// The action that you assign to a high-risk assessment by threat protection.
        /// </para>
        /// </summary>
        public AccountTakeoverActionType HighAction { get; set; }

        /// <summary>
        /// Checks to see if the HighAction property is set.
        /// </summary>
        internal bool IsSetHighAction() => this.HighAction != null;

        /// <summary>
        /// Gets and sets the property LowAction. 
        /// <para>
        /// The action that you assign to a low-risk assessment by threat protection.
        /// </para>
        /// </summary>
        public AccountTakeoverActionType LowAction { get; set; }

        /// <summary>
        /// Checks to see if the LowAction property is set.
        /// </summary>
        internal bool IsSetLowAction() => this.LowAction != null;

        /// <summary>
        /// Gets and sets the property MediumAction. 
        /// <para>
        /// The action that you assign to a medium-risk assessment by threat protection.
        /// </para>
        /// </summary>
        public AccountTakeoverActionType MediumAction { get; set; }

        /// <summary>
        /// Checks to see if the MediumAction property is set.
        /// </summary>
        internal bool IsSetMediumAction() => this.MediumAction != null;
    }
}

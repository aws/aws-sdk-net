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
    /// A recovery option for a user. The <c>AccountRecoverySettingType</c> data type is an
    /// array of this object. Each <c>RecoveryOptionType</c> has a priority property that
    /// determines whether it is a primary or secondary option.
    /// 
    ///  
    /// <para>
    /// For example, if <c>verified_email</c> has a priority of <c>1</c> and <c>verified_phone_number</c>
    /// has a priority of <c>2</c>, your user pool sends account-recovery messages to a verified
    /// email address but falls back to an SMS message if the user has a verified phone number.
    /// The <c>admin_only</c> option prevents self-service account recovery.
    /// </para>
    /// </summary>
    public partial class RecoveryOptionType
    {
        private RecoveryOptionNameType _name;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The recovery method that this object sets a recovery option for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryOptionNameType Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Your priority preference for using the specified attribute in account recovery. The
        /// highest priority is <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

    }
}
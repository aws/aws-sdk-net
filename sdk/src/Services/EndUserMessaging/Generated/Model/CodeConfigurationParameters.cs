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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// The passcode policy parameters that are grouped for reuse across a notify code configuration
    /// and its create request. Each member is optional. When you omit a member on a create
    /// request, no value is applied at create time and the default is applied when a passcode
    /// is sent.
    /// </summary>
    public partial class CodeConfigurationParameters
    {
        private int? _codeLength;
        private CodeType _codeType;
        private int? _maxAttempts;
        private int? _validityPeriodMinutes;

        /// <summary>
        /// Gets and sets the property CodeLength. 
        /// <para>
        /// The number of characters in the one-time passcode. Valid values range from 4 through
        /// 8. When you do not specify a value, the default is applied when a passcode is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=8)]
        public int? CodeLength
        {
            get { return this._codeLength; }
            set { this._codeLength = value; }
        }

        // Check to see if CodeLength property is set
        internal bool IsSetCodeLength()
        {
            return this._codeLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeType. 
        /// <para>
        /// The character set used to generate the one-time passcode. Valid values are NUMERIC
        /// (digits only), ALPHA (uppercase letters only), and ALPHANUMERIC (uppercase letters
        /// and digits). When you do not specify a value, the default is applied when a passcode
        /// is sent.
        /// </para>
        /// </summary>
        public CodeType CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        // Check to see if CodeType property is set
        internal bool IsSetCodeType()
        {
            return this._codeType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The maximum number of validation attempts that are allowed before the verification
        /// is locked. Valid values range from 1 through 5. When you do not specify a value, the
        /// default is applied when a passcode is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? MaxAttempts
        {
            get { return this._maxAttempts; }
            set { this._maxAttempts = value; }
        }

        // Check to see if MaxAttempts property is set
        internal bool IsSetMaxAttempts()
        {
            return this._maxAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidityPeriodMinutes. 
        /// <para>
        /// The length of time, in minutes, that the one-time passcode remains valid. Valid values
        /// range from 1 through 60. When you do not specify a value, the default is applied when
        /// a passcode is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? ValidityPeriodMinutes
        {
            get { return this._validityPeriodMinutes; }
            set { this._validityPeriodMinutes = value; }
        }

        // Check to see if ValidityPeriodMinutes property is set
        internal bool IsSetValidityPeriodMinutes()
        {
            return this._validityPeriodMinutes.HasValue; 
        }

    }
}
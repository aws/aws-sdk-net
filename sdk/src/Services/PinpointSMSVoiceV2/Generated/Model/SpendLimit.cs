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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Describes the current monthly spend limits for sending voice and text messages. For
    /// more information on increasing your monthly spend limit, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/awssupport-spend-threshold.html">
    /// Requesting a spending quota increase </a> in the <i>AWS End User Messaging SMS User
    /// Guide</i>.
    /// </summary>
    public partial class SpendLimit
    {
        private long? _enforcedLimit;
        private long? _maxLimit;
        private SpendLimitName _name;
        private bool? _overridden;

        /// <summary>
        /// Gets and sets the property EnforcedLimit. 
        /// <para>
        /// The maximum amount of money, in US dollars, that you want to be able to spend sending
        /// messages each month. This value has to be less than or equal to the amount in <c>MaxLimit</c>.
        /// To use this custom limit, <c>Overridden</c> must be set to true.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? EnforcedLimit
        {
            get { return this._enforcedLimit; }
            set { this._enforcedLimit = value; }
        }

        // Check to see if EnforcedLimit property is set
        internal bool IsSetEnforcedLimit()
        {
            return this._enforcedLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLimit. 
        /// <para>
        ///  The maximum amount of money that you are able to spend to send messages each month,
        /// in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? MaxLimit
        {
            get { return this._maxLimit; }
            set { this._maxLimit = value; }
        }

        // Check to see if MaxLimit property is set
        internal bool IsSetMaxLimit()
        {
            return this._maxLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the SpendLimit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpendLimitName Name
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
        /// Gets and sets the property Overridden. 
        /// <para>
        /// When set to <c>True</c>, the value that has been specified in the <c>EnforcedLimit</c>
        /// is used to determine the maximum amount in US dollars that can be spent to send messages
        /// each month, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Overridden
        {
            get { return this._overridden; }
            set { this._overridden = value; }
        }

        // Check to see if Overridden property is set
        internal bool IsSetOverridden()
        {
            return this._overridden.HasValue; 
        }

    }
}
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
    /// Container for the parameters to the SetTextMessageSpendLimitOverride operation.
    /// Sets an account level monthly spend limit override for sending text messages. The
    /// requested spend limit must be less than or equal to the <c>MaxLimit</c>, which is
    /// set by Amazon Web Services.
    /// </summary>
    public partial class SetTextMessageSpendLimitOverrideRequest : AmazonPinpointSMSVoiceV2Request
    {
        private long? _monthlyLimit;

        /// <summary>
        /// Gets and sets the property MonthlyLimit. 
        /// <para>
        /// The new monthly limit to enforce on text messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000000)]
        public long? MonthlyLimit
        {
            get { return this._monthlyLimit; }
            set { this._monthlyLimit = value; }
        }

        // Check to see if MonthlyLimit property is set
        internal bool IsSetMonthlyLimit()
        {
            return this._monthlyLimit.HasValue; 
        }

    }
}
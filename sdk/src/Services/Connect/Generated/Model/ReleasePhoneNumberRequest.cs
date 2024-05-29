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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ReleasePhoneNumber operation.
    /// Releases a phone number previously claimed to an Amazon Connect instance or traffic
    /// distribution group. You can call this API only in the Amazon Web Services Region where
    /// the number was claimed.
    /// 
    ///  <important> 
    /// <para>
    /// To release phone numbers from a traffic distribution group, use the <c>ReleasePhoneNumber</c>
    /// API, not the Amazon Connect admin website.
    /// </para>
    ///  
    /// <para>
    /// After releasing a phone number, the phone number enters into a cooldown period for
    /// up to 180 days. It cannot be searched for or claimed again until the period has ended.
    /// If you accidentally release a phone number, contact Amazon Web Services Support.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you plan to claim and release numbers frequently, contact us for a service quota
    /// exception. Otherwise, it is possible you will be blocked from claiming and releasing
    /// any more numbers until up to 180 days past the oldest number released has expired.
    /// </para>
    ///  
    /// <para>
    /// By default you can claim and release up to 200% of your maximum number of active phone
    /// numbers. If you claim and release phone numbers using the UI or API during a rolling
    /// 180 day cycle that exceeds 200% of your phone number service level quota, you will
    /// be blocked from claiming any more numbers until 180 days past the oldest number released
    /// has expired. 
    /// </para>
    ///  
    /// <para>
    /// For example, if you already have 99 claimed numbers and a service level quota of 99
    /// phone numbers, and in any 180 day period you release 99, claim 99, and then release
    /// 99, you will have exceeded the 200% limit. At that point you are blocked from claiming
    /// any more numbers until you open an Amazon Web Services support ticket.
    /// </para>
    /// </summary>
    public partial class ReleasePhoneNumberRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private string _phoneNumberId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// A unique identifier for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

    }
}
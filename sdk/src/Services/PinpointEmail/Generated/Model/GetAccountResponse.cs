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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// A list of details about the email-sending capabilities of your Amazon Pinpoint account
    /// in the current AWS Region.
    /// </summary>
    public partial class GetAccountResponse : AmazonWebServiceResponse
    {
        private bool? _dedicatedIpAutoWarmupEnabled;
        private string _enforcementStatus;
        private bool? _productionAccessEnabled;
        private bool? _sendingEnabled;
        private SendQuota _sendQuota;

        /// <summary>
        /// Gets and sets the property DedicatedIpAutoWarmupEnabled. 
        /// <para>
        /// Indicates whether or not the automatic warm-up feature is enabled for dedicated IP
        /// addresses that are associated with your account.
        /// </para>
        /// </summary>
        public bool? DedicatedIpAutoWarmupEnabled
        {
            get { return this._dedicatedIpAutoWarmupEnabled; }
            set { this._dedicatedIpAutoWarmupEnabled = value; }
        }

        // Check to see if DedicatedIpAutoWarmupEnabled property is set
        internal bool IsSetDedicatedIpAutoWarmupEnabled()
        {
            return this._dedicatedIpAutoWarmupEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnforcementStatus. 
        /// <para>
        /// The reputation status of your Amazon Pinpoint account. The status can be one of the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEALTHY</c> – There are no reputation-related issues that currently impact your
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROBATION</c> – We've identified some issues with your Amazon Pinpoint account.
        /// We're placing your account under review while you work on correcting these issues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHUTDOWN</c> – Your account's ability to send email is currently paused because
        /// of an issue with the email sent from your account. When you correct the issue, you
        /// can contact us and request that your account's ability to send email is resumed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EnforcementStatus
        {
            get { return this._enforcementStatus; }
            set { this._enforcementStatus = value; }
        }

        // Check to see if EnforcementStatus property is set
        internal bool IsSetEnforcementStatus()
        {
            return this._enforcementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionAccessEnabled. 
        /// <para>
        /// Indicates whether or not your account has production access in the current AWS Region.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>false</c>, then your account is in the <i>sandbox</i>. When your
        /// account is in the sandbox, you can only send email to verified identities. Additionally,
        /// the maximum number of emails you can send in a 24-hour period (your sending quota)
        /// is 200, and the maximum number of emails you can send per second (your maximum sending
        /// rate) is 1.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>true</c>, then your account has production access. When your account
        /// has production access, you can send email to any address. The sending quota and maximum
        /// sending rate for your account vary based on your specific use case.
        /// </para>
        /// </summary>
        public bool? ProductionAccessEnabled
        {
            get { return this._productionAccessEnabled; }
            set { this._productionAccessEnabled = value; }
        }

        // Check to see if ProductionAccessEnabled property is set
        internal bool IsSetProductionAccessEnabled()
        {
            return this._productionAccessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SendingEnabled. 
        /// <para>
        /// Indicates whether or not email sending is enabled for your Amazon Pinpoint account
        /// in the current AWS Region.
        /// </para>
        /// </summary>
        public bool? SendingEnabled
        {
            get { return this._sendingEnabled; }
            set { this._sendingEnabled = value; }
        }

        // Check to see if SendingEnabled property is set
        internal bool IsSetSendingEnabled()
        {
            return this._sendingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SendQuota. 
        /// <para>
        /// An object that contains information about the per-day and per-second sending limits
        /// for your Amazon Pinpoint account in the current AWS Region.
        /// </para>
        /// </summary>
        public SendQuota SendQuota
        {
            get { return this._sendQuota; }
            set { this._sendQuota = value; }
        }

        // Check to see if SendQuota property is set
        internal bool IsSetSendQuota()
        {
            return this._sendQuota != null;
        }

    }
}
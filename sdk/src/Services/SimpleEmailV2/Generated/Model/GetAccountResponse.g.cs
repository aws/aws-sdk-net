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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// This is the response object from the GetAccount operation.
    /// </summary>
    public partial class GetAccountResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DedicatedIpAutoWarmupEnabled. 
        /// <para>
        /// Indicates whether or not the automatic warm-up feature is enabled for dedicated IP
        /// addresses that are associated with your account.
        /// </para>
        /// </summary>
        public bool? DedicatedIpAutoWarmupEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedIpAutoWarmupEnabled property is set.
        /// </summary>
        internal bool IsSetDedicatedIpAutoWarmupEnabled() => this.DedicatedIpAutoWarmupEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// An object that defines your account details.
        /// </para>
        /// </summary>
        public AccountDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property EnforcementStatus. 
        /// <para>
        /// The reputation status of your Amazon SES account. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEALTHY</c> – There are no reputation-related issues that currently impact your
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROBATION</c> – We've identified potential issues with your Amazon SES account.
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
        public string EnforcementStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnforcementStatus property is set.
        /// </summary>
        internal bool IsSetEnforcementStatus() => this.EnforcementStatus != null;

        /// <summary>
        /// Gets and sets the property PricingAttributes. 
        /// <para>
        /// The pricing attributes that apply to your Amazon SES account, including the currently
        /// active pricing plan and any scheduled change.
        /// </para>
        /// </summary>
        public PricingAttributes PricingAttributes { get; set; }

        /// <summary>
        /// Checks to see if the PricingAttributes property is set.
        /// </summary>
        internal bool IsSetPricingAttributes() => this.PricingAttributes != null;

        /// <summary>
        /// Gets and sets the property ProductionAccessEnabled. 
        /// <para>
        /// Indicates whether or not your account has production access in the current Amazon
        /// Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>false</c>, then your account is in the <i>sandbox</i>. When your
        /// account is in the sandbox, you can only send email to verified identities. 
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>true</c>, then your account has production access. When your account
        /// has production access, you can send email to any address. The sending quota and maximum
        /// sending rate for your account vary based on your specific use case.
        /// </para>
        /// </summary>
        public bool? ProductionAccessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ProductionAccessEnabled property is set.
        /// </summary>
        internal bool IsSetProductionAccessEnabled() => this.ProductionAccessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SendQuota. 
        /// <para>
        /// An object that contains information about the per-day and per-second sending limits
        /// for your Amazon SES account in the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public SendQuota SendQuota { get; set; }

        /// <summary>
        /// Checks to see if the SendQuota property is set.
        /// </summary>
        internal bool IsSetSendQuota() => this.SendQuota != null;

        /// <summary>
        /// Gets and sets the property SendingEnabled. 
        /// <para>
        /// Indicates whether or not email sending is enabled for your Amazon SES account in the
        /// current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public bool? SendingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SendingEnabled property is set.
        /// </summary>
        internal bool IsSetSendingEnabled() => this.SendingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SuppressionAttributes. 
        /// <para>
        /// An object that contains information about the email address suppression preferences
        /// for your account in the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public SuppressionAttributes SuppressionAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionAttributes property is set.
        /// </summary>
        internal bool IsSetSuppressionAttributes() => this.SuppressionAttributes != null;

        /// <summary>
        /// Gets and sets the property VdmAttributes. 
        /// <para>
        /// The VDM attributes that apply to your Amazon SES account.
        /// </para>
        /// </summary>
        public VdmAttributes VdmAttributes { get; set; }

        /// <summary>
        /// Checks to see if the VdmAttributes property is set.
        /// </summary>
        internal bool IsSetVdmAttributes() => this.VdmAttributes != null;
    }
}

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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the SendOutboundEmail operation. Send outbound email
    /// for outbound campaigns. For more information about outbound campaigns, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-outbound-campaigns.html">Set
    /// up Connect Customer outbound campaigns</a>. <note> <para> Only the Connect Customer
    /// outbound campaigns service principal is allowed to assume a role in your account and
    /// call this API. </para> </note>
    /// </summary>
    public partial class SendOutboundEmailRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalRecipients. 
        /// <para>
        /// The additional recipients address of the email in CC.
        /// </para>
        /// </summary>
        public OutboundAdditionalRecipients AdditionalRecipients { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalRecipients property is set.
        /// </summary>
        internal bool IsSetAdditionalRecipients() => this.AdditionalRecipients != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DestinationEmailAddress. 
        /// <para>
        /// The email address to send the email to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EmailAddressInfo DestinationEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEmailAddress property is set.
        /// </summary>
        internal bool IsSetDestinationEmailAddress() => this.DestinationEmailAddress != null;

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The email message body to be sent to the newly created email.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutboundEmailContent EmailMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessage property is set.
        /// </summary>
        internal bool IsSetEmailMessage() => this.EmailMessage != null;

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address to be used for sending email.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EmailAddressInfo FromEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property SourceCampaign. 
        /// <para>
        /// A Campaign object need for Campaign traffic type.
        /// </para>
        /// </summary>
        public SourceCampaign SourceCampaign { get; set; }

        /// <summary>
        /// Checks to see if the SourceCampaign property is set.
        /// </summary>
        internal bool IsSetSourceCampaign() => this.SourceCampaign != null;

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// Denotes the class of traffic.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the CAMPAIGN traffic type is supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrafficType TrafficType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficType property is set.
        /// </summary>
        internal bool IsSetTrafficType() => this.TrafficType != null;
    }
}

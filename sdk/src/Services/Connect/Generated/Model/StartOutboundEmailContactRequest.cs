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
    /// Container for the parameters to the StartOutboundEmailContact operation.
    /// Initiates a flow to send an agent reply or outbound email contact (created from the
    /// CreateContact API) to a customer.
    /// </summary>
    public partial class StartOutboundEmailContactRequest : AmazonConnectRequest
    {
        private OutboundAdditionalRecipients _additionalRecipients;
        private string _clientToken;
        private string _contactId;
        private EmailAddressInfo _destinationEmailAddress;
        private OutboundEmailContent _emailMessage;
        private EmailAddressInfo _fromEmailAddress;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AdditionalRecipients. 
        /// <para>
        /// The additional recipients address of email in CC.
        /// </para>
        /// </summary>
        public OutboundAdditionalRecipients AdditionalRecipients
        {
            get { return this._additionalRecipients; }
            set { this._additionalRecipients = value; }
        }

        // Check to see if AdditionalRecipients property is set
        internal bool IsSetAdditionalRecipients()
        {
            return this._additionalRecipients != null;
        }

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
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEmailAddress. 
        /// <para>
        /// The email address of the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EmailAddressInfo DestinationEmailAddress
        {
            get { return this._destinationEmailAddress; }
            set { this._destinationEmailAddress = value; }
        }

        // Check to see if DestinationEmailAddress property is set
        internal bool IsSetDestinationEmailAddress()
        {
            return this._destinationEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The email message body to be sent to the newly created email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutboundEmailContent EmailMessage
        {
            get { return this._emailMessage; }
            set { this._emailMessage = value; }
        }

        // Check to see if EmailMessage property is set
        internal bool IsSetEmailMessage()
        {
            return this._emailMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address associated with the Amazon Connect instance.
        /// </para>
        /// </summary>
        public EmailAddressInfo FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}
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
    /// Container for the parameters to the SendOutboundEmail operation.
    /// 
    /// </summary>
    public partial class SendOutboundEmailRequest : AmazonConnectRequest
    {
        private OutboundAdditionalRecipients _additionalRecipients;
        private string _clientToken;
        private EmailAddressInfo _destinationEmailAddress;
        private OutboundEmailContent _emailMessage;
        private EmailAddressInfo _fromEmailAddress;
        private string _instanceId;
        private SourceCampaign _sourceCampaign;
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property AdditionalRecipients.
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
        /// Gets and sets the property DestinationEmailAddress.
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
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property SourceCampaign.
        /// </summary>
        public SourceCampaign SourceCampaign
        {
            get { return this._sourceCampaign; }
            set { this._sourceCampaign = value; }
        }

        // Check to see if SourceCampaign property is set
        internal bool IsSetSourceCampaign()
        {
            return this._sourceCampaign != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficType.
        /// </summary>
        [AWSProperty(Required=true)]
        public TrafficType TrafficType
        {
            get { return this._trafficType; }
            set { this._trafficType = value; }
        }

        // Check to see if TrafficType property is set
        internal bool IsSetTrafficType()
        {
            return this._trafficType != null;
        }

    }
}
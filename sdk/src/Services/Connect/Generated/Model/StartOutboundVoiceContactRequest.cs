/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartOutboundVoiceContact operation.
    /// The <code>StartOutboundVoiceContact</code> operation initiates a contact flow to place
    /// an outbound call to a customer.
    /// 
    ///  
    /// <para>
    /// There is a throttling limit placed on usage of the API that includes a RateLimit of
    /// 2 per second, and a BurstLimit of 5 per second.
    /// </para>
    ///  
    /// <para>
    /// If you are using an IAM account, it must have permission to the <code>connect:StartOutboundVoiceContact</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class StartOutboundVoiceContactRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _clientToken;
        private string _contactFlowId;
        private string _destinationPhoneNumber;
        private string _instanceId;
        private string _queueId;
        private string _sourcePhoneNumber;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Specify a custom key-value pair using an attribute map. The attributes are standard
        /// Amazon Connect attributes, and can be accessed in contact flows just like any other
        /// contact attributes.
        /// </para>
        ///  
        /// <para>
        /// There can be up to 32,768 UTF-8 bytes across all key-value pairs. Attribute keys can
        /// include only alphanumeric, dash, and underscore characters.
        /// </para>
        ///  
        /// <para>
        /// For example, if you want play a greeting when the customer answers the call, you can
        /// pass the customer name in attributes similar to the following:
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. The token is valid for 7 days after creation. If a contact is already
        /// started, the contact ID is returned. If the contact is disconnected, a new contact
        /// is started.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier for the contact flow to connect the outbound call to.
        /// </para>
        ///  
        /// <para>
        /// To find the <code>ContactFlowId</code>, open the contact flow you want to use in the
        /// Amazon Connect contact flow editor. The ID for the contact flow is displayed in the
        /// address bar as part of the URL. For example, the contact flow ID is the set of characters
        /// at the end of the URL, after 'contact-flow/' such as <code>78ea8fd5-2659-4f2b-b528-699760ccfc1b</code>.
        /// </para>
        /// </summary>
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The phone number of the customer in E.164 format.
        /// </para>
        /// </summary>
        public string DestinationPhoneNumber
        {
            get { return this._destinationPhoneNumber; }
            set { this._destinationPhoneNumber = value; }
        }

        // Check to see if DestinationPhoneNumber property is set
        internal bool IsSetDestinationPhoneNumber()
        {
            return this._destinationPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier for your Amazon Connect instance. To find the ID of your instance,
        /// open the AWS console and select Amazon Connect. Select the alias of the instance in
        /// the Instance alias column. The instance ID is displayed in the Overview section of
        /// your instance settings. For example, the instance ID is the set of characters at the
        /// end of the instance ARN, after instance/, such as 10a4c4eb-f57e-4d4c-b602-bf39176ced07.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue to add the call to. If you specify a queue, the phone displayed for caller
        /// ID is the phone number specified in the queue. If you do not specify a queue, the
        /// queue used will be the queue defined in the contact flow.
        /// </para>
        ///  
        /// <para>
        /// To find the <code>QueueId</code>, open the queue you want to use in the Amazon Connect
        /// Queue editor. The ID for the queue is displayed in the address bar as part of the
        /// URL. For example, the queue ID is the set of characters at the end of the URL, after
        /// 'queue/' such as <code>queue/aeg40574-2d01-51c3-73d6-bf8624d2168c</code>.
        /// </para>
        /// </summary>
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePhoneNumber. 
        /// <para>
        /// The phone number, in E.164 format, associated with your Amazon Connect instance to
        /// use for the outbound call.
        /// </para>
        /// </summary>
        public string SourcePhoneNumber
        {
            get { return this._sourcePhoneNumber; }
            set { this._sourcePhoneNumber = value; }
        }

        // Check to see if SourcePhoneNumber property is set
        internal bool IsSetSourcePhoneNumber()
        {
            return this._sourcePhoneNumber != null;
        }

    }
}
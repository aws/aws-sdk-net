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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartOutboundVoiceContact operation.
    /// This API places an outbound call to a contact, and then initiates the contact flow.
    /// It performs the actions in the contact flow that's specified (in <code>ContactFlowId</code>).
    /// 
    ///  
    /// <para>
    /// Agents are not involved in initiating the outbound API (that is, dialing the contact).
    /// If the contact flow places an outbound call to a contact, and then puts the contact
    /// in queue, that's when the call is routed to the agent, like any other inbound case.
    /// </para>
    ///  
    /// <para>
    /// There is a 60 second dialing timeout for this operation. If the call is not connected
    /// after 60 seconds, it fails.
    /// </para>
    ///  <note> 
    /// <para>
    /// UK numbers with a 447 prefix are not allowed by default. Before you can dial these
    /// UK mobile numbers, you must submit a service quota increase request. For more information,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
    /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>. 
    /// </para>
    ///  </note>
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
        /// A custom key-value pair using an attribute map. The attributes are standard Amazon
        /// Connect attributes, and can be accessed in contact flows just like any other contact
        /// attributes.
        /// </para>
        ///  
        /// <para>
        /// There can be up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters.
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
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the contact flow for the outbound call. To see the ContactFlowId
        /// in the Amazon Connect console user interface, on the navigation menu go to <b>Routing</b>,
        /// <b>Contact Flows</b>. Choose the contact flow. On the contact flow page, under the
        /// name of the contact flow, choose <b>Show additional flow information</b>. The ContactFlowId
        /// is the last part of the ARN, shown here in bold: 
        /// </para>
        ///  
        /// <para>
        /// arn:aws:connect:us-west-2:xxxxxxxxxxxx:instance/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/contact-flow/<b>846ec553-a005-41c0-8341-xxxxxxxxxxxx</b>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=500)]
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
        /// The phone number of the customer, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier of the Amazon Connect instance.
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

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue for the call. If you specify a queue, the phone displayed for caller ID
        /// is the phone number specified in the queue. If you do not specify a queue, the queue
        /// defined in the contact flow is used. If you do not specify a queue, you must specify
        /// a source phone number.
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
        /// The phone number associated with the Amazon Connect instance, in E.164 format. If
        /// you do not specify a source phone number, you must specify a queue.
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
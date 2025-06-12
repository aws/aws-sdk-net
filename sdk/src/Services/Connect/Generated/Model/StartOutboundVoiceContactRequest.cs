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
    /// Container for the parameters to the StartOutboundVoiceContact operation.
    /// Places an outbound call to a contact, and then initiates the flow. It performs the
    /// actions in the flow that's specified (in <c>ContactFlowId</c>).
    /// 
    ///  
    /// <para>
    /// Agents do not initiate the outbound API, which means that they do not dial the contact.
    /// If the flow places an outbound call to a contact, and then puts the contact in queue,
    /// the call is then routed to the agent, like any other inbound case.
    /// </para>
    ///  
    /// <para>
    /// There is a 60-second dialing timeout for this operation. If the call is not connected
    /// after 60 seconds, it fails.
    /// </para>
    ///  <note> 
    /// <para>
    /// UK numbers with a 447 prefix are not allowed by default. Before you can dial these
    /// UK mobile numbers, you must submit a service quota increase request. For more information,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
    /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>. 
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Campaign calls are not allowed by default. Before you can make a call with <c>TrafficType</c>
    /// = <c>CAMPAIGN</c>, you must submit a service quota increase request to the quota <a
    /// href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#outbound-communications-quotas">Amazon
    /// Connect campaigns</a>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartOutboundVoiceContactRequest : AmazonConnectRequest
    {
        private AnswerMachineDetectionConfig _answerMachineDetectionConfig;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _campaignId;
        private string _clientToken;
        private string _contactFlowId;
        private string _description;
        private string _destinationPhoneNumber;
        private string _instanceId;
        private string _name;
        private string _queueId;
        private Dictionary<string, Reference> _references = AWSConfigs.InitializeCollections ? new Dictionary<string, Reference>() : null;
        private string _relatedContactId;
        private string _sourcePhoneNumber;
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property AnswerMachineDetectionConfig. 
        /// <para>
        /// Configuration of the answering machine detection for this outbound call. 
        /// </para>
        /// </summary>
        public AnswerMachineDetectionConfig AnswerMachineDetectionConfig
        {
            get { return this._answerMachineDetectionConfig; }
            set { this._answerMachineDetectionConfig = value; }
        }

        // Check to see if AnswerMachineDetectionConfig property is set
        internal bool IsSetAnswerMachineDetectionConfig()
        {
            return this._answerMachineDetectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A custom key-value pair using an attribute map. The attributes are standard Amazon
        /// Connect attributes, and can be accessed in flows just like any other contact attributes.
        /// </para>
        ///  
        /// <para>
        /// There can be up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The campaign identifier of the outbound communication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string CampaignId
        {
            get { return this._campaignId; }
            set { this._campaignId = value; }
        }

        // Check to see if CampaignId property is set
        internal bool IsSetCampaignId()
        {
            return this._campaignId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>. The token is valid for 7 days after creation.
        /// If a contact is already started, the contact ID is returned. 
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
        /// The identifier of the flow for the outbound call. To see the ContactFlowId in the
        /// Amazon Connect admin website, on the navigation menu go to <b>Routing</b>, <b>Contact
        /// Flows</b>. Choose the flow. On the flow page, under the name of the flow, choose <b>Show
        /// additional flow information</b>. The ContactFlowId is the last part of the ARN, shown
        /// here in bold: 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the voice contact that appears in the agent's snapshot in the CCP
        /// logs. For more information about CCP logs, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/download-ccp-logs.html">Download
        /// and review CCP logs</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a voice contact that is shown to an agent in the Contact Control Panel
        /// (CCP).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Name
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
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue for the call. If you specify a queue, the phone displayed for caller ID
        /// is the phone number specified in the queue. If you do not specify a queue, the queue
        /// defined in the flow is used. If you do not specify a queue, you must specify a source
        /// phone number.
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
        /// Gets and sets the property References. 
        /// <para>
        /// A formatted URL that is shown to an agent in the Contact Control Panel (CCP). Contacts
        /// can have the following reference types at the time of creation: <c>URL</c> | <c>NUMBER</c>
        /// | <c>STRING</c> | <c>DATE</c> | <c>EMAIL</c>. <c>ATTACHMENT</c> is not a supported
        /// reference type during voice contact creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Reference> References
        {
            get { return this._references; }
            set { this._references = value; }
        }

        // Check to see if References property is set
        internal bool IsSetReferences()
        {
            return this._references != null && (this._references.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The <c>contactId</c> that is related to this contact. Linking voice, task, or chat
        /// by using <c>RelatedContactID</c> copies over contact attributes from the related contact
        /// to the new contact. All updates to user-defined attributes in the new contact are
        /// limited to the individual contact ID. There are no limits to the number of contacts
        /// that can be linked by using <c>RelatedContactId</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RelatedContactId
        {
            get { return this._relatedContactId; }
            set { this._relatedContactId = value; }
        }

        // Check to see if RelatedContactId property is set
        internal bool IsSetRelatedContactId()
        {
            return this._relatedContactId != null;
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

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// Denotes the class of traffic. Calls with different traffic types are handled differently
        /// by Amazon Connect. The default value is <c>GENERAL</c>. Use <c>CAMPAIGN</c> if <c>EnableAnswerMachineDetection</c>
        /// is set to <c>true</c>. For all other cases, use <c>GENERAL</c>. 
        /// </para>
        /// </summary>
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
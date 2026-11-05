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
    /// Container for the parameters to the StartOutboundVoiceContact operation. Places an
    /// outbound call to a contact, and then initiates the flow. It performs the actions in
    /// the flow that's specified (in <c>ContactFlowId</c>). <para> Agents do not initiate
    /// the outbound API, which means that they do not dial the contact. If the flow places
    /// an outbound call to a contact, and then puts the contact in queue, the call is then
    /// routed to the agent, like any other inbound case. </para> <para> Dialing timeout for
    /// this operation can be configured with the “RingTimeoutInSeconds” parameter. If not
    /// specified, the default dialing timeout will be 60 seconds which means if the call
    /// is not connected within 60 seconds, it fails. </para> <note> <para> UK numbers with
    /// a 447 prefix are not allowed by default. Before you can dial these UK mobile numbers,
    /// you must submit a service quota increase request. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Connect
    /// Customer Service Quotas</a> in the <i>Connect Customer Administrator Guide</i>. </para>
    /// </note> <note> <para> Campaign calls are not allowed by default. Before you can make
    /// a call with <c>TrafficType</c> = <c>CAMPAIGN</c>, you must submit a service quota
    /// increase request to the quota <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#outbound-communications-quotas">Connect
    /// Customer campaigns</a>. </para> </note> <note> <para> For Preview dialing mode, only
    /// the Amazon Connect outbound campaigns service principal is allowed to assume a role
    /// in your account and call this API with OutboundStrategy. </para> </note>
    /// </summary>
    public partial class StartOutboundVoiceContactRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AnswerMachineDetectionConfig. 
        /// <para>
        /// Configuration of the answering machine detection for this outbound call. 
        /// </para>
        /// </summary>
        public AnswerMachineDetectionConfig AnswerMachineDetectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the AnswerMachineDetectionConfig property is set.
        /// </summary>
        internal bool IsSetAnswerMachineDetectionConfig() => this.AnswerMachineDetectionConfig != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A custom key-value pair using an attribute map. The attributes are standard Connect
        /// Customer attributes, and can be accessed in flows just like any other contact attributes.
        /// </para>
        ///  
        /// <para>
        /// There can be up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The campaign identifier of the outbound communication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

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
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow for the outbound call. To see the ContactFlowId in the
        /// Connect Customer admin website, on the navigation menu go to <b>Routing</b>, <b>Contact
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
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowId property is set.
        /// </summary>
        internal bool IsSetContactFlowId() => this.ContactFlowId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the voice contact that appears in the agent's snapshot in the CCP
        /// logs. For more information about CCP logs, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/download-ccp-logs.html">Download
        /// and review CCP logs</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The phone number of the customer, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDestinationPhoneNumber() => this.DestinationPhoneNumber != null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a voice contact that is shown to an agent in the Contact Control Panel
        /// (CCP).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutboundStrategy. 
        /// <para>
        /// Information about the outbound strategy.
        /// </para>
        /// </summary>
        public OutboundStrategy OutboundStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OutboundStrategy property is set.
        /// </summary>
        internal bool IsSetOutboundStrategy() => this.OutboundStrategy != null;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue for the call. If you specify a queue, the phone displayed for caller ID
        /// is the phone number specified in the queue. If you do not specify a queue, the queue
        /// defined in the flow is used. If you do not specify a queue, you must specify a source
        /// phone number.
        /// </para>
        /// </summary>
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// A formatted URL that is shown to an agent in the Contact Control Panel (CCP). Contacts
        /// can have the following reference types at the time of creation: <c>URL</c> | <c>NUMBER</c>
        /// | <c>STRING</c> | <c>DATE</c> | <c>EMAIL</c>. <c>ATTACHMENT</c> is not a supported
        /// reference type during voice contact creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Reference> References { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Reference>() : null;

        /// <summary>
        /// Checks to see if the References property is set.
        /// </summary>
        internal bool IsSetReferences() => this.References != null && (this.References.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;

        /// <summary>
        /// Gets and sets the property RingTimeoutInSeconds. 
        /// <para>
        /// The maximum time the outbound call will wait for the destination to answer the call,
        /// in seconds 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 60)]
        public int? RingTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RingTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetRingTimeoutInSeconds() => this.RingTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SourcePhoneNumber. 
        /// <para>
        /// The phone number associated with the Connect Customer instance, in E.164 format. If
        /// you do not specify a source phone number, you must specify a queue.
        /// </para>
        /// </summary>
        public string SourcePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the SourcePhoneNumber property is set.
        /// </summary>
        internal bool IsSetSourcePhoneNumber() => this.SourcePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// Denotes the class of traffic. Calls with different traffic types are handled differently
        /// by Connect Customer. The default value is <c>GENERAL</c>. Use <c>CAMPAIGN</c> if <c>EnableAnswerMachineDetection</c>
        /// is set to <c>true</c>. For all other cases, use <c>GENERAL</c>. 
        /// </para>
        /// </summary>
        public TrafficType TrafficType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficType property is set.
        /// </summary>
        internal bool IsSetTrafficType() => this.TrafficType != null;
    }
}

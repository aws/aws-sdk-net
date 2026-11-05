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
    /// Container for the parameters to the UpdateContact operation. This API is in preview
    /// release for Connect Customer and is subject to change. <para> Adds or updates user-defined
    /// contact information associated with the specified contact. At least one field to be
    /// updated must be present in the request. </para> <important> <para> You can add or
    /// update user-defined contact information for both ongoing and completed contacts. </para>
    /// </important>
    /// </summary>
    public partial class UpdateContactRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalRecipients. 
        /// <para>
        /// The additional recipients of an outbound email. Use this field to update the CC email
        /// address recipients of a contact. An empty list clears the existing CC recipients.
        /// </para>
        /// </summary>
        public NullableAdditionalRecipients AdditionalRecipients { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalRecipients property is set.
        /// </summary>
        internal bool IsSetAdditionalRecipients() => this.AdditionalRecipients != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact. This is the identifier of the contact associated with
        /// the first interaction with your contact center.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// The endpoint of the customer for which the contact was initiated. For external audio
        /// contacts, this is usually the end customer's phone number. This value can only be
        /// updated for external audio contacts. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Connect
        /// Customer Contact Lens integration</a> in the <i>Connect Customer Administrator Guide</i>.
        /// For email contacts with an <c>OUTBOUND</c> or <c>AGENT_REPLY</c> initiation method,
        /// this value can be updated while the outbound email is still a draft, before you send
        /// it.
        /// </para>
        /// </summary>
        public Endpoint CustomerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEndpoint property is set.
        /// </summary>
        internal bool IsSetCustomerEndpoint() => this.CustomerEndpoint != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// The name of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QueueInfo. 
        /// <para>
        ///  Information about the queue associated with a contact. This parameter can only be
        /// updated for external audio contacts. It is used when you integrate third-party systems
        /// with Contact Lens for analytics. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Connect
        /// Customer Contact Lens integration</a> in the <i> Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        public QueueInfoInput QueueInfo { get; set; }

        /// <summary>
        /// Checks to see if the QueueInfo property is set.
        /// </summary>
        internal bool IsSetQueueInfo() => this.QueueInfo != null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// Well-formed data on contact, shown to agents on Contact Control Panel (CCP).
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
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// A set of system defined key-value pairs stored on individual contact segments (unique
        /// contact ID) using an attribute map. The attributes are standard Connect Customer attributes.
        /// They can be accessed in flows.
        /// </para>
        ///  
        /// <para>
        /// Attribute keys can include only alphanumeric, -, and _.
        /// </para>
        ///  
        /// <para>
        /// This field can be used to show channel subtype, such as <c>connect:Guide</c>.
        /// </para>
        ///  
        /// <para>
        /// Contact Expiry, and user-defined attributes (String - String) that are defined in
        /// predefined attributes, can be updated by using the UpdateContact API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SegmentAttributeValue> SegmentAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the SegmentAttributes property is set.
        /// </summary>
        internal bool IsSetSegmentAttributes() => this.SegmentAttributes != null && (this.SegmentAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// External system endpoint for the contact was initiated. For external audio contacts,
        /// this is the phone number of the external system such as the contact center. This value
        /// can only be updated for external audio contacts. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Connect
        /// Customer Contact Lens integration</a> in the <i>Connect Customer Administrator Guide</i>.
        /// For email contacts with an <c>OUTBOUND</c> or <c>AGENT_REPLY</c> initiation method,
        /// this value can be updated while the outbound email is still a draft, before you send
        /// it.
        /// </para>
        /// </summary>
        public Endpoint SystemEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SystemEndpoint property is set.
        /// </summary>
        internal bool IsSetSystemEndpoint() => this.SystemEndpoint != null;

        /// <summary>
        /// Gets and sets the property UserInfo. 
        /// <para>
        /// Information about the agent associated with a contact. This parameter can only be
        /// updated for external audio contacts. It is used when you integrate third-party systems
        /// with Contact Lens for analytics. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Connect
        /// Customer Contact Lens integration</a> in the <i> Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// Checks to see if the UserInfo property is set.
        /// </summary>
        internal bool IsSetUserInfo() => this.UserInfo != null;
    }
}

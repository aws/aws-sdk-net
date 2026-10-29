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
    /// Container for the parameters to the CreateContact operation. <important> <para> Only
    /// the VOICE, EMAIL, and TASK channels are supported. </para> <ul> <li> <para> For VOICE:
    /// The supported initiation method is <c>TRANSFER</c>. The contacts created with this
    /// initiation method have a subtype <c>connect:ExternalAudio</c>. </para> </li> <li>
    /// <para> For EMAIL: The supported initiation methods are <c>OUTBOUND</c>, <c>AGENT_REPLY</c>,
    /// and <c>FLOW</c>. </para> </li> <li> <para> For TASK: The supported initiation method
    /// is <c>API</c>. Contacts created with this API have a sub-type of <c>connect:ExternalTask</c>.
    /// </para> </li> </ul> </important> <para> Creates a new VOICE, EMAIL, or TASK contact.
    /// </para> <para> After a contact is created, you can move it to the desired state by
    /// using the <c>InitiateAs</c> parameter. While you can use API to create task contacts
    /// that are in the <c>COMPLETED</c> state, you must contact Amazon Web Services Support
    /// before using it for bulk import use cases. Bulk import causes your requests to be
    /// throttled or fail if your CreateContact limits aren't high enough. </para>
    /// </summary>
    public partial class CreateContactRequest : AmazonConnectRequest
    {
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
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel for the contact.
        /// </para>
        ///  <important> 
        /// <para>
        /// The CHAT channel is not supported. The following information is incorrect. We're working
        /// to correct it.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpiryDurationInMinutes. 
        /// <para>
        /// Number of minutes the contact will be active for before expiring
        /// </para>
        /// </summary>
        public int? ExpiryDurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryDurationInMinutes property is set.
        /// </summary>
        internal bool IsSetExpiryDurationInMinutes() => this.ExpiryDurationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property InitiateAs. 
        /// <para>
        /// Initial state of the contact when it's created. Only TASK channel contacts can be
        /// initiated with <c>COMPLETED</c> state.
        /// </para>
        /// </summary>
        public InitiateAs InitiateAs { get; set; }

        /// <summary>
        /// Checks to see if the InitiateAs property is set.
        /// </summary>
        internal bool IsSetInitiateAs() => this.InitiateAs != null;

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// Indicates how the contact was initiated. 
        /// </para>
        ///  <important> 
        /// <para>
        /// CreateContact only supports the following initiation methods. Valid values by channel
        /// are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For VOICE: <c>TRANSFER</c> and the subtype <c>connect:ExternalAudio</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For EMAIL: <c>OUTBOUND</c> | <c>AGENT_REPLY</c> | <c>FLOW</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For TASK: <c>API</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The other channels listed below are incorrect. We're working to correct this information.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContactInitiationMethod InitiationMethod { get; set; }

        /// <summary>
        /// Checks to see if the InitiationMethod property is set.
        /// </summary>
        internal bool IsSetInitiationMethod() => this.InitiationMethod != null;

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
        /// The name of a the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// The ID of the previous contact when creating a transfer contact. This value can be
        /// provided only for external audio contacts. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Integrate
        /// Connect Customer Contact Lens with external voice systems</a> in the <i>Connect Customer
        /// Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PreviousContactId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousContactId property is set.
        /// </summary>
        internal bool IsSetPreviousContactId() => this.PreviousContactId != null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// A formatted URL that is shown to an agent in the Contact Control Panel (CCP). Tasks
        /// can have the following reference types at the time of creation: <c>URL</c> | <c>NUMBER</c>
        /// | <c>STRING</c> | <c>DATE</c> | <c>EMAIL</c> | <c>ATTACHMENT</c>.
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
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;

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
        /// This field can be used to set Segment Contact Expiry as a duration in minutes.
        /// </para>
        ///  <note> 
        /// <para>
        /// To set contact expiry, a ValueMap must be specified containing the integer number
        /// of minutes the contact will be active for before expiring, with <c>SegmentAttributes</c>
        /// like { <c> "connect:ContactExpiry": {"ValueMap" : { "ExpiryDuration": { "ValueInteger":
        /// 135}}}}</c>. 
        /// </para>
        ///  </note>
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
        /// Gets and sets the property UserInfo. 
        /// <para>
        /// User details for the contact
        /// </para>
        ///  <important> 
        /// <para>
        /// UserInfo is required when creating an EMAIL contact with <c>OUTBOUND</c> and <c>AGENT_REPLY</c>
        /// contact initiation methods.
        /// </para>
        ///  </important>
        /// </summary>
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// Checks to see if the UserInfo property is set.
        /// </summary>
        internal bool IsSetUserInfo() => this.UserInfo != null;
    }
}

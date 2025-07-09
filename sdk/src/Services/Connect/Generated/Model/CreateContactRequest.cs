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
    /// Container for the parameters to the CreateContact operation.
    /// <important> 
    /// <para>
    /// Only the VOICE, EMAIL, and TASK channels are supported. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For VOICE: The supported initiation method is <c>TRANSFER</c>. The contacts created
    /// with this initiation method have a subtype <c>connect:ExternalAudio</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For EMAIL: The supported initiation methods are <c>OUTBOUND</c>, <c>AGENT_REPLY</c>,
    /// and <c>FLOW</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For TASK: The supported initiation method is <c>API</c>. Contacts created with this
    /// API have a sub-type of <c>connect:ExternalTask</c>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Creates a new VOICE, EMAIL, or TASK contact. 
    /// </para>
    ///  
    /// <para>
    /// After a contact is created, you can move it to the desired state by using the <c>InitiateAs</c>
    /// parameter. While you can use API to create task contacts that are in the <c>COMPLETED</c>
    /// state, you must contact Amazon Web Services Support before using it for bulk import
    /// use cases. Bulk import causes your requests to be throttled or fail if your CreateContact
    /// limits aren't high enough. 
    /// </para>
    /// </summary>
    public partial class CreateContactRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Channel _channel;
        private string _clientToken;
        private string _description;
        private int? _expiryDurationInMinutes;
        private InitiateAs _initiateAs;
        private ContactInitiationMethod _initiationMethod;
        private string _instanceId;
        private string _name;
        private string _previousContactId;
        private Dictionary<string, Reference> _references = AWSConfigs.InitializeCollections ? new Dictionary<string, Reference>() : null;
        private string _relatedContactId;
        private Dictionary<string, SegmentAttributeValue> _segmentAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private UserInfo _userInfo;

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
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the contact.
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
        /// Gets and sets the property ExpiryDurationInMinutes. 
        /// <para>
        /// Number of minutes the contact will be active for before expiring
        /// </para>
        /// </summary>
        public int? ExpiryDurationInMinutes
        {
            get { return this._expiryDurationInMinutes; }
            set { this._expiryDurationInMinutes = value; }
        }

        // Check to see if ExpiryDurationInMinutes property is set
        internal bool IsSetExpiryDurationInMinutes()
        {
            return this._expiryDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitiateAs. 
        /// <para>
        /// Initial state of the contact when it's created. Only TASK channel contacts can be
        /// initiated with <c>COMPLETED</c> state.
        /// </para>
        /// </summary>
        public InitiateAs InitiateAs
        {
            get { return this._initiateAs; }
            set { this._initiateAs = value; }
        }

        // Check to see if InitiateAs property is set
        internal bool IsSetInitiateAs()
        {
            return this._initiateAs != null;
        }

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
        [AWSProperty(Required=true)]
        public ContactInitiationMethod InitiationMethod
        {
            get { return this._initiationMethod; }
            set { this._initiationMethod = value; }
        }

        // Check to see if InitiationMethod property is set
        internal bool IsSetInitiationMethod()
        {
            return this._initiationMethod != null;
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
        /// The name of a the contact.
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
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// The ID of the previous contact when creating a transfer contact. This value can be
        /// provided only for external audio contacts. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Integrate
        /// Amazon Connect Contact Lens with external voice systems</a> in the <i>Amazon Connect
        /// Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PreviousContactId
        {
            get { return this._previousContactId; }
            set { this._previousContactId = value; }
        }

        // Check to see if PreviousContactId property is set
        internal bool IsSetPreviousContactId()
        {
            return this._previousContactId != null;
        }

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// A formatted URL that is shown to an agent in the Contact Control Panel (CCP). Tasks
        /// can have the following reference types at the time of creation: <c>URL</c> | <c>NUMBER</c>
        /// | <c>STRING</c> | <c>DATE</c> | <c>EMAIL</c> | <c>ATTACHMENT</c>.
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
        /// The identifier of the contact in this instance of Amazon Connect. 
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
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// A set of system defined key-value pairs stored on individual contact segments (unique
        /// contact ID) using an attribute map. The attributes are standard Amazon Connect attributes.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SegmentAttributeValue> SegmentAttributes
        {
            get { return this._segmentAttributes; }
            set { this._segmentAttributes = value; }
        }

        // Check to see if SegmentAttributes property is set
        internal bool IsSetSegmentAttributes()
        {
            return this._segmentAttributes != null && (this._segmentAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public UserInfo UserInfo
        {
            get { return this._userInfo; }
            set { this._userInfo = value; }
        }

        // Check to see if UserInfo property is set
        internal bool IsSetUserInfo()
        {
            return this._userInfo != null;
        }

    }
}
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
    /// Container for the parameters to the UpdateContact operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Adds or updates user-defined contact information associated with the specified contact.
    /// At least one field to be updated must be present in the request.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can add or update user-defined contact information for both ongoing and completed
    /// contacts.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateContactRequest : AmazonConnectRequest
    {
        private string _contactId;
        private Endpoint _customerEndpoint;
        private string _description;
        private string _instanceId;
        private string _name;
        private QueueInfoInput _queueInfo;
        private Dictionary<string, Reference> _references = AWSConfigs.InitializeCollections ? new Dictionary<string, Reference>() : null;
        private Dictionary<string, SegmentAttributeValue> _segmentAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private Endpoint _systemEndpoint;
        private UserInfo _userInfo;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact. This is the identifier of the contact associated with
        /// the first interaction with your contact center.
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
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// The endpoint of the customer for which the contact was initiated. For external audio
        /// contacts, this is usually the end customer's phone number. This value can only be
        /// updated for external audio contacts. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Amazon
        /// Connect Contact Lens integration</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        public Endpoint CustomerEndpoint
        {
            get { return this._customerEndpoint; }
            set { this._customerEndpoint = value; }
        }

        // Check to see if CustomerEndpoint property is set
        internal bool IsSetCustomerEndpoint()
        {
            return this._customerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the contact.
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
        /// The name of the contact.
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
        /// Gets and sets the property QueueInfo. 
        /// <para>
        ///  Information about the queue associated with a contact. This parameter can only be
        /// updated for external audio contacts. It is used when you integrate third-party systems
        /// with Contact Lens for analytics. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Amazon
        /// Connect Contact Lens integration</a> in the <i> Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        public QueueInfoInput QueueInfo
        {
            get { return this._queueInfo; }
            set { this._queueInfo = value; }
        }

        // Check to see if QueueInfo property is set
        internal bool IsSetQueueInfo()
        {
            return this._queueInfo != null;
        }

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// Well-formed data on contact, shown to agents on Contact Control Panel (CCP).
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
        /// This field can be used to show channel subtype, such as <c>connect:Guide</c>.
        /// </para>
        ///  
        /// <para>
        /// Contact Expiry, and user-defined attributes (String - String) that are defined in
        /// predefined attributes, can be updated by using the UpdateContact API.
        /// </para>
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
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// External system endpoint for the contact was initiated. For external audio contacts,
        /// this is the phone number of the external system such as the contact center. This value
        /// can only be updated for external audio contacts. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Amazon
        /// Connect Contact Lens integration</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        public Endpoint SystemEndpoint
        {
            get { return this._systemEndpoint; }
            set { this._systemEndpoint = value; }
        }

        // Check to see if SystemEndpoint property is set
        internal bool IsSetSystemEndpoint()
        {
            return this._systemEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property UserInfo. 
        /// <para>
        /// Information about the agent associated with a contact. This parameter can only be
        /// updated for external audio contacts. It is used when you integrate third-party systems
        /// with Contact Lens for analytics. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-integration.html">Amazon
        /// Connect Contact Lens integration</a> in the <i> Amazon Connect Administrator Guide</i>.
        /// </para>
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
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
    /// Container for the parameters to the StartTaskContact operation.
    /// Initiates a flow to start a new task contact. For more information about task contacts,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/tasks.html">Concepts:
    /// Tasks in Amazon Connect</a> in the <i>Amazon Connect Administrator Guide</i>. 
    /// 
    ///  
    /// <para>
    /// When using <c>PreviousContactId</c> and <c>RelatedContactId</c> input parameters,
    /// note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>PreviousContactId</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Any updates to user-defined task contact attributes on any contact linked through
    /// the same <c>PreviousContactId</c> will affect every contact in the chain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There can be a maximum of 12 linked task contacts in a chain. That is, 12 task contacts
    /// can be created that share the same <c>PreviousContactId</c>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>RelatedContactId</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Copies contact attributes from the related task contact to the new contact.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any update on attributes in a new task contact does not update attributes on previous
    /// contact.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There’s no limit on the number of task contacts that can be created that use the same
    /// <c>RelatedContactId</c>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// In addition, when calling StartTaskContact include only one of these parameters: <c>ContactFlowID</c>,
    /// <c>QuickConnectID</c>, or <c>TaskTemplateID</c>. Only one parameter is required as
    /// long as the task template has a flow configured to run it. If more than one parameter
    /// is specified, or only the <c>TaskTemplateID</c> is specified but it does not have
    /// a flow configured, the request returns an error because Amazon Connect cannot identify
    /// the unique flow to run when the task is created.
    /// </para>
    ///  
    /// <para>
    /// A <c>ServiceQuotaExceededException</c> occurs when the number of open tasks exceeds
    /// the active tasks quota or there are already 12 tasks referencing the same <c>PreviousContactId</c>.
    /// For more information about service quotas for task contacts, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
    /// Connect service quotas</a> in the <i>Amazon Connect Administrator Guide</i>. 
    /// </para>
    /// </summary>
    public partial class StartTaskContactRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientToken;
        private string _contactFlowId;
        private string _description;
        private string _instanceId;
        private string _name;
        private string _previousContactId;
        private string _quickConnectId;
        private Dictionary<string, Reference> _references = AWSConfigs.InitializeCollections ? new Dictionary<string, Reference>() : null;
        private string _relatedContactId;
        private DateTime? _scheduledTime;
        private Dictionary<string, SegmentAttributeValue> _segmentAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private string _taskTemplateId;

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
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow for initiating the tasks. To see the ContactFlowId in the
        /// Amazon Connect admin website, on the navigation menu go to <b>Routing</b>, <b>Flows</b>.
        /// Choose the flow. On the flow page, under the name of the flow, choose <b>Show additional
        /// flow information</b>. The ContactFlowId is the last part of the ARN, shown here in
        /// bold: 
        /// </para>
        ///  
        /// <para>
        /// arn:aws:connect:us-west-2:xxxxxxxxxxxx:instance/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/contact-flow/<b>846ec553-a005-41c0-8341-xxxxxxxxxxxx</b>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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
        /// A description of the task that is shown to an agent in the Contact Control Panel (CCP).
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
        /// The name of a task that is shown to an agent in the Contact Control Panel (CCP).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1024)]
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
        /// The identifier of the previous chat, voice, or task contact. Any updates to user-defined
        /// attributes to task contacts linked using the same <c>PreviousContactID</c> will affect
        /// every contact in the chain. There can be a maximum of 12 linked task contacts in a
        /// chain.
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
        /// Gets and sets the property QuickConnectId. 
        /// <para>
        /// The identifier for the quick connect. Tasks that are created by using <c>QuickConnectId</c>
        /// will use the flow that is defined on agent or queue quick connect. For more information
        /// about quick connects, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/quick-connects.html">Create
        /// quick connects</a>.
        /// </para>
        /// </summary>
        public string QuickConnectId
        {
            get { return this._quickConnectId; }
            set { this._quickConnectId = value; }
        }

        // Check to see if QuickConnectId property is set
        internal bool IsSetQuickConnectId()
        {
            return this._quickConnectId != null;
        }

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// A formatted URL that is shown to an agent in the Contact Control Panel (CCP). Tasks
        /// can have the following reference types at the time of creation: <c>URL</c> | <c>NUMBER</c>
        /// | <c>STRING</c> | <c>DATE</c> | <c>EMAIL</c>. <c>ATTACHMENT</c> is not a supported
        /// reference type during task creation.
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
        /// The contactId that is <a href="https://docs.aws.amazon.com/connect/latest/adminguide/tasks.html#linked-tasks">related</a>
        /// to this contact. Linking tasks together by using <c>RelatedContactID</c> copies over
        /// contact attributes from the related task contact to the new task contact. All updates
        /// to user-defined attributes in the new task contact are limited to the individual contact
        /// ID, unlike what happens when tasks are linked by using <c>PreviousContactID</c>. There
        /// are no limits to the number of contacts that can be linked by using <c>RelatedContactId</c>.
        /// 
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
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The timestamp, in Unix Epoch seconds format, at which to start running the inbound
        /// flow. The scheduled time cannot be in the past. It must be within up to 6 days in
        /// future. 
        /// </para>
        /// </summary>
        public DateTime? ScheduledTime
        {
            get { return this._scheduledTime; }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
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
        /// This field can be used to set Contact Expiry as a duration in minutes and set a UserId
        /// for the User who created a task.
        /// </para>
        ///  <note> 
        /// <para>
        /// To set contact expiry, a ValueMap must be specified containing the integer number
        /// of minutes the contact will be active for before expiring, with <c>SegmentAttributes</c>
        /// like { <c> "connect:ContactExpiry": {"ValueMap" : { "ExpiryDuration": { "ValueInteger":
        /// 135}}}}</c>. 
        /// </para>
        ///  
        /// <para>
        /// To set the created by user, a valid AgentResourceId must be supplied, with <c>SegmentAttributes</c>
        /// like { <c>"connect:CreatedByUser" { "ValueString": "arn:aws:connect:us-west-2:xxxxxxxxxxxx:instance/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/agent/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"}}}</c>.
        /// 
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
        /// Gets and sets the property TaskTemplateId. 
        /// <para>
        /// A unique identifier for the task template. For more information about task templates,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/task-templates.html">Create
        /// task templates</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string TaskTemplateId
        {
            get { return this._taskTemplateId; }
            set { this._taskTemplateId = value; }
        }

        // Check to see if TaskTemplateId property is set
        internal bool IsSetTaskTemplateId()
        {
            return this._taskTemplateId != null;
        }

    }
}
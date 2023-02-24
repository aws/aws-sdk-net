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
    /// Container for the parameters to the StartTaskContact operation.
    /// Initiates a flow to start a new task.
    /// </summary>
    public partial class StartTaskContactRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _clientToken;
        private string _contactFlowId;
        private string _description;
        private string _instanceId;
        private string _name;
        private string _previousContactId;
        private string _quickConnectId;
        private Dictionary<string, Reference> _references = new Dictionary<string, Reference>();
        private string _relatedContactId;
        private DateTime? _scheduledTime;
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
        /// Amazon Connect console user interface, on the navigation menu go to <b>Routing</b>,
        /// <b>Contact Flows</b>. Choose the flow. On the flow page, under the name of the flow,
        /// choose <b>Show additional flow information</b>. The ContactFlowId is the last part
        /// of the ARN, shown here in bold: 
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
        [AWSProperty(Min=0, Max=4096)]
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
        [AWSProperty(Required=true, Min=0, Max=512)]
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
        /// The identifier of the previous chat, voice, or task contact. 
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
        /// The identifier for the quick connect.
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
        /// A formatted URL that is shown to an agent in the Contact Control Panel (CCP).
        /// </para>
        /// </summary>
        public Dictionary<string, Reference> References
        {
            get { return this._references; }
            set { this._references = value; }
        }

        // Check to see if References property is set
        internal bool IsSetReferences()
        {
            return this._references != null && this._references.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId that is <a href="https://docs.aws.amazon.com/connect/latest/adminguide/tasks.html#linked-tasks">related</a>
        /// to this contact.
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
        public DateTime ScheduledTime
        {
            get { return this._scheduledTime.GetValueOrDefault(); }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskTemplateId. 
        /// <para>
        /// A unique identifier for the task template.
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
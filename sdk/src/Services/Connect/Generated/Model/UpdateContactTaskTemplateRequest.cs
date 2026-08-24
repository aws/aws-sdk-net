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
    /// Container for the parameters to the UpdateContactTaskTemplate operation.
    /// Updates the task template association on an existing task contact. You can update
    /// the task template on a contact before assignment to support tasks that are created
    /// without a template (for example <a href="https://docs.aws.amazon.com/connect/latest/adminguide/connect-rules.html">Rules</a>
    /// or <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-disconnect-flow.html">disconnect
    /// flows</a>) or change the agent interaction form to represent the latest task data
    /// (for example an initial request that was submitted as a refund gets updated to an
    /// account cancellation and requires a new template).
    /// 
    ///  
    /// <para>
    /// This operation can only be used with task contacts that are in progress and not connected
    /// to an agent. A task template can be updated a maximum of 5 times per contact.
    /// </para>
    ///  
    /// <para>
    /// The task's references must be compatible with the fields of the target task template.
    /// If the target template has a required field, the task must have a corresponding reference
    /// with a matching name and compatible type. The following task template field types
    /// map to reference types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>TEXT</c>, <c>TEXT_AREA</c>, <c>BOOLEAN</c>, and <c>SINGLE_SELECT</c> map to references
    /// of type <c>STRING</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>NUMBER</c> maps to references of type <c>NUMBER</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DATE_TIME</c> maps to references of type <c>DATE</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>URL</c> maps to references of type <c>URL</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>EMAIL</c> maps to references of type <c>EMAIL</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// References corresponding to <c>TEXT</c> fields must be fewer than 512 characters.
    /// <c>TEXT_AREA</c> fields must be fewer than 4,096 characters. <c>BOOLEAN</c> fields
    /// must have a value of <c>true</c> or <c>false</c>.
    /// </para>
    ///  
    /// <para>
    /// An <c>InvalidRequestException</c> occurs when <c>UpdateContactTaskTemplate</c> is
    /// called on a connected or terminated task, when it is called on non-task contacts,
    /// and when the task contact already uses the provided task template. A <c>PropertyValidationException</c>
    /// occurs when the task's references conflict with the task template's fields, for example
    /// if the task is missing a reference that matches a required field, or if the task has
    /// a reference that matches a required field's name but not its datatype.
    /// </para>
    /// </summary>
    public partial class UpdateContactTaskTemplateRequest : AmazonConnectRequest
    {
        private string _contactId;
        private string _instanceId;
        private string _taskTemplateId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
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
        /// Gets and sets the property TaskTemplateId. 
        /// <para>
        /// A unique identifier for the task template. For more information about task templates,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/task-templates.html">Task
        /// templates</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
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
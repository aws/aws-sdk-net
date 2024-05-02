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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the PollForActivityTask operation.
    /// Used by workers to get an <a>ActivityTask</a> from the specified activity <c>taskList</c>.
    /// This initiates a long poll, where the service holds the HTTP connection open and responds
    /// as soon as a task becomes available. The maximum time the service holds on to the
    /// request before responding is 60 seconds. If no task is available within 60 seconds,
    /// the poll returns an empty result. An empty result, in this context, means that an
    /// ActivityTask is returned, but that the value of taskToken is an empty string. If a
    /// task is returned, the worker should use its type to identify and process it correctly.
    /// 
    ///  <important> 
    /// <para>
    /// Workers should set their client side socket timeout to at least 70 seconds (10 seconds
    /// higher than the maximum time service may hold the poll request).
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <c>Resource</c> element with the domain name to limit the action to only specified
    /// domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <c>Action</c> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the <c>taskList.name</c> parameter by using a <c>Condition</c> element with
    /// the <c>swf:taskList.name</c> key to allow the action to access only certain task lists.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <c>cause</c> parameter is set to <c>OPERATION_NOT_PERMITTED</c>. For details
    /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PollForActivityTaskRequest : AmazonSimpleWorkflowRequest
    {
        private string _domain;
        private string _identity;
        private TaskList _taskList;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the task lists being polled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// Identity of the worker making the request, recorded in the <c>ActivityTaskStarted</c>
        /// event in the workflow history. This enables diagnostic tracing when problems arise.
        /// The form of this identity is user defined.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// Specifies the task list to poll for activity tasks.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters
        /// (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>). Also, it must <i>not</i> be the literal
        /// string <c>arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskList TaskList
        {
            get { return this._taskList; }
            set { this._taskList = value; }
        }

        // Check to see if TaskList property is set
        internal bool IsSetTaskList()
        {
            return this._taskList != null;
        }

    }
}
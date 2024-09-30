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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a command filter.
    /// 
    ///  <note> 
    /// <para>
    /// A managed node ID can't be specified when a command status is <c>Pending</c> because
    /// the command hasn't run on the node yet.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CommandFilter
    {
        private CommandFilterKey _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ExecutionStage</c> filter can't be used with the <c>ListCommandInvocations</c>
        /// operation, only with <c>ListCommands</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommandFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The filter value. Valid values for each filter key are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>InvokedAfter</b>: Specify a timestamp to limit your results. For example, specify
        /// <c>2024-07-07T00:00:00Z</c> to see a list of command executions occurring July 7,
        /// 2021, and later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvokedBefore</b>: Specify a timestamp to limit your results. For example, specify
        /// <c>2024-07-07T00:00:00Z</c> to see a list of command executions from before July 7,
        /// 2021.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Status</b>: Specify a valid command status to see a list of all command executions
        /// with that status. The status choices depend on the API you call.
        /// </para>
        ///  
        /// <para>
        /// The status values you can specify for <c>ListCommands</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pending</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Success</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Cancelled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TimedOut</c> (this includes both Delivery and Execution time outs) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDenied</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeliveryTimedOut</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExecutionTimedOut</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Incomplete</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoInstancesInTag</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LimitExceeded</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The status values you can specify for <c>ListCommandInvocations</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pending</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delayed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Success</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Cancelled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TimedOut</c> (this includes both Delivery and Execution time outs) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDenied</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeliveryTimedOut</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExecutionTimedOut</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Undeliverable</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidPlatform</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminated</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>DocumentName</b>: Specify name of the Amazon Web Services Systems Manager document
        /// (SSM document) for which you want to see command execution results. For example, specify
        /// <c>AWS-RunPatchBaseline</c> to see command executions that used this SSM document
        /// to perform security patching operations on managed nodes. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ExecutionStage</b>: Specify one of the following values (<c>ListCommands</c> operations
        /// only):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Executing</c>: Returns a list of command executions that are currently still running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Complete</c>: Returns a list of command executions that have already completed.
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}
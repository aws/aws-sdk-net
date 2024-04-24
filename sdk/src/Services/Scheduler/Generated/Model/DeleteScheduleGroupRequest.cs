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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteScheduleGroup operation.
    /// Deletes the specified schedule group. Deleting a schedule group results in EventBridge
    /// Scheduler deleting all schedules associated with the group. When you delete a group,
    /// it remains in a <c>DELETING</c> state until all of its associated schedules are deleted.
    /// Schedules associated with the group that are set to run while the schedule group is
    /// in the process of being deleted might continue to invoke their targets until the schedule
    /// group and its associated schedules are deleted.
    /// 
    ///  <note> 
    /// <para>
    ///  This operation is eventually consistent. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteScheduleGroupRequest : AmazonSchedulerRequest
    {
        private string _clientToken;
        private string _name;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, EventBridge Scheduler uses a randomly generated
        /// token for the request to ensure idempotency. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule group to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}
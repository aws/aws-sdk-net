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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMonitor operation.
    /// Removes a Deadline Cloud monitor. After you delete a monitor, you can create a new
    /// one and attach farms to the monitor.
    /// </summary>
    public partial class DeleteMonitorRequest : AmazonDeadlineRequest
    {
        private string _monitorId;

        /// <summary>
        /// Gets and sets the property MonitorId. 
        /// <para>
        /// The unique identifier of the monitor to delete. This ID is returned by the <c>CreateMonitor</c>
        /// operation, and is included in the response to the <c>GetMonitor</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MonitorId
        {
            get { return this._monitorId; }
            set { this._monitorId = value; }
        }

        // Check to see if MonitorId property is set
        internal bool IsSetMonitorId()
        {
            return this._monitorId != null;
        }

    }
}
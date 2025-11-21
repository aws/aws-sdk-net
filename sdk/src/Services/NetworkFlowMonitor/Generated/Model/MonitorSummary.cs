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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// A summary of information about a monitor, including the ARN, the name, and the status.
    /// </summary>
    public partial class MonitorSummary
    {
        private string _monitorArn;
        private string _monitorName;
        private MonitorStatus _monitorStatus;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=512)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorStatus. 
        /// <para>
        /// The status of a monitor. The status can be one of the following
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The monitor is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The monitor is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>: The monitor is inactive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: Monitor creation failed due to an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The monitor is in the process of being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitorStatus MonitorStatus
        {
            get { return this._monitorStatus; }
            set { this._monitorStatus = value; }
        }

        // Check to see if MonitorStatus property is set
        internal bool IsSetMonitorStatus()
        {
            return this._monitorStatus != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// This is the response object from the UpdateMonitor operation.
    /// </summary>
    public partial class UpdateMonitorResponse : AmazonWebServiceResponse
    {
        private string _monitorArn;
        private MonitorConfigState _status;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitorConfigState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
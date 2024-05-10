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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
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
namespace Amazon.NetworkMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMonitor operation.
    /// Deletes a specified monitor.
    /// 
    ///  
    /// <para>
    /// This action requires the <c>monitorName</c> parameter. Run <c>ListMonitors</c> to
    /// get a list of monitor names. 
    /// </para>
    /// </summary>
    public partial class DeleteMonitorRequest : AmazonNetworkMonitorRequest
    {
        private string _monitorName;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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

    }
}
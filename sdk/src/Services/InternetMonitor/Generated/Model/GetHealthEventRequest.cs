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
    /// Container for the parameters to the GetHealthEvent operation.
    /// Gets information the Amazon CloudWatch Internet Monitor has created and stored about
    /// a health event for a specified monitor. This information includes the impacted locations,
    /// and all of the information related to the event by location.
    /// 
    ///  
    /// <para>
    /// The information returned includes the performance, availability, and round-trip time
    /// impact, information about the network providers, the event type, and so on.
    /// </para>
    ///  
    /// <para>
    /// Information rolled up at the global traffic level is also returned, including the
    /// impact type and total traffic impact.
    /// </para>
    /// </summary>
    public partial class GetHealthEventRequest : AmazonInternetMonitorRequest
    {
        private string _eventId;
        private string _monitorName;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The internally generated identifier of a health event. Because <code>EventID</code>
        /// contains the forward slash (“/”) character, you must URL-encode the <code>EventID</code>
        /// field in the request URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
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

    }
}
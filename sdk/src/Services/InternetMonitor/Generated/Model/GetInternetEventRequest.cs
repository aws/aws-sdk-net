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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the GetInternetEvent operation.
    /// Gets information that Amazon CloudWatch Internet Monitor has generated about an internet
    /// event. Internet Monitor displays information about recent global health events, called
    /// internet events, on a global outages map that is available to all Amazon Web Services
    /// customers. 
    /// 
    ///  
    /// <para>
    /// The information returned here includes the impacted location, when the event started
    /// and (if the event is over) ended, the type of event (<c>PERFORMANCE</c> or <c>AVAILABILITY</c>),
    /// and the status (<c>ACTIVE</c> or <c>RESOLVED</c>).
    /// </para>
    /// </summary>
    public partial class GetInternetEventRequest : AmazonInternetMonitorRequest
    {
        private string _eventId;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The <c>EventId</c> of the internet event to return information for. 
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

    }
}
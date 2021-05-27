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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Container for the parameters to the BatchAcknowledgeAlarm operation.
    /// Acknowledges one or more alarms. The alarms change to the <code>ACKNOWLEDGED</code>
    /// state after you acknowledge them.
    /// </summary>
    public partial class BatchAcknowledgeAlarmRequest : AmazonIoTEventsDataRequest
    {
        private List<AcknowledgeAlarmActionRequest> _acknowledgeActionRequests = new List<AcknowledgeAlarmActionRequest>();

        /// <summary>
        /// Gets and sets the property AcknowledgeActionRequests. 
        /// <para>
        /// The list of acknowledge action requests. You can specify up to 10 requests per operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AcknowledgeAlarmActionRequest> AcknowledgeActionRequests
        {
            get { return this._acknowledgeActionRequests; }
            set { this._acknowledgeActionRequests = value; }
        }

        // Check to see if AcknowledgeActionRequests property is set
        internal bool IsSetAcknowledgeActionRequests()
        {
            return this._acknowledgeActionRequests != null && this._acknowledgeActionRequests.Count > 0; 
        }

    }
}
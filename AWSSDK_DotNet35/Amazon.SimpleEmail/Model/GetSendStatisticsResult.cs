/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents a list of            <code>SendDataPoint</code>            items returned
    /// from a successful            <code>GetSendStatistics</code>            request. This
    /// list contains aggregated data from the previous two weeks of sending activity.
    /// </summary>
    public partial class GetSendStatisticsResult : AmazonWebServiceResponse
    {
        private List<SendDataPoint> _sendDataPoints = new List<SendDataPoint>();

        /// <summary>
        /// Gets and sets the property SendDataPoints. 
        /// <para>
        /// A list of data points, each of which represents 15 minutes of activity.
        /// </para>
        /// </summary>
        public List<SendDataPoint> SendDataPoints
        {
            get { return this._sendDataPoints; }
            set { this._sendDataPoints = value; }
        }

        // Check to see if SendDataPoints property is set
        internal bool IsSetSendDataPoints()
        {
            return this._sendDataPoints != null && this._sendDataPoints.Count > 0; 
        }

    }
}
/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents a list of <c>SendDataPoint</c> items returned from a successful <c>GetSendStatistics</c> request. This list contains
    /// aggregated data from the previous two weeks of sending activity. </para>
    /// </summary>
    public partial class GetSendStatisticsResult : AmazonWebServiceResponse
    {
        
        private List<SendDataPoint> sendDataPoints = new List<SendDataPoint>();

        /// <summary>
        /// A list of data points, each of which represents 15 minutes of activity.
        ///  
        /// </summary>
        public List<SendDataPoint> SendDataPoints
        {
            get { return this.sendDataPoints; }
            set { this.sendDataPoints = value; }
        }

        // Check to see if SendDataPoints property is set
        internal bool IsSetSendDataPoints()
        {
            return this.sendDataPoints.Count > 0;
        }
    }
}

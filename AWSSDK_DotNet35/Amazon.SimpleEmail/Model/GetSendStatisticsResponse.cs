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

using Amazon.Runtime;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Returns information about the  GetSendStatistics response and response metadata.
    /// </summary>
    public class GetSendStatisticsResponse : GetSendStatisticsResult
    {
        /// <summary>
        /// Gets and sets the GetSendStatisticsResult property.
        /// Represents a list of SendDataPoint items returned from a successful GetSendStatistics request. This list contains aggregated data from the
        /// previous two weeks of sending activity.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the GetSendStatisticsResult class are now available on the GetSendStatisticsResponse class. You should use the properties on GetSendStatisticsResponse instead of accessing them through GetSendStatisticsResult.")]
        public GetSendStatisticsResult GetSendStatisticsResult
        {
            get
            {
                return this;
            }
        }
    }
}
    

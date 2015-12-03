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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetSampledRequestsResponse : AmazonWebServiceResponse
    {
        private long? _populationSize;
        private List<SampledHTTPRequest> _sampledRequests = new List<SampledHTTPRequest>();
        private TimeWindow _timeWindow;

        /// <summary>
        /// Gets and sets the property PopulationSize. 
        /// <para>
        /// The total number of requests from which <code>GetSampledRequests</code> got a sample
        /// of <code>MaxItems</code> requests. If <code>PopulationSize</code> is less than <code>MaxItems</code>,
        /// the sample includes every request that your AWS resource received during the specified
        /// time range.
        /// </para>
        /// </summary>
        public long PopulationSize
        {
            get { return this._populationSize.GetValueOrDefault(); }
            set { this._populationSize = value; }
        }

        // Check to see if PopulationSize property is set
        internal bool IsSetPopulationSize()
        {
            return this._populationSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampledRequests. 
        /// <para>
        /// A complex type that contains detailed information about each of the requests in the
        /// sample.
        /// </para>
        /// </summary>
        public List<SampledHTTPRequest> SampledRequests
        {
            get { return this._sampledRequests; }
            set { this._sampledRequests = value; }
        }

        // Check to see if SampledRequests property is set
        internal bool IsSetSampledRequests()
        {
            return this._sampledRequests != null && this._sampledRequests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// Usually, <code>TimeWindow</code> is the time range that you specified in the <code>GetSampledRequests</code>
        /// request. However, if your AWS resource received more than 5,000 requests during the
        /// time range that you specified in the request, <code>GetSampledRequests</code> returns
        /// the time range for the first 5,000 requests.
        /// </para>
        /// </summary>
        public TimeWindow TimeWindow
        {
            get { return this._timeWindow; }
            set { this._timeWindow = value; }
        }

        // Check to see if TimeWindow property is set
        internal bool IsSetTimeWindow()
        {
            return this._timeWindow != null;
        }

    }
}
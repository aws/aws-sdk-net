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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the GetSampledRequests operation.
    /// </summary>
    public partial class GetSampledRequestsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property PopulationSize. 
        /// <para>
        /// The total number of requests from which <c>GetSampledRequests</c> got a sample of
        /// <c>MaxItems</c> requests. If <c>PopulationSize</c> is less than <c>MaxItems</c>, the
        /// sample includes every request that your AWS resource received during the specified
        /// time range.
        /// </para>
        /// </summary>
        public long? PopulationSize { get; set; }

        /// <summary>
        /// Checks to see if the PopulationSize property is set.
        /// </summary>
        internal bool IsSetPopulationSize() => this.PopulationSize.HasValue;

        /// <summary>
        /// Gets and sets the property SampledRequests. 
        /// <para>
        /// A complex type that contains detailed information about each of the requests in the
        /// sample.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SampledHTTPRequest> SampledRequests { get; set; } = AWSConfigs.InitializeCollections ? new List<SampledHTTPRequest>() : null;

        /// <summary>
        /// Checks to see if the SampledRequests property is set.
        /// </summary>
        internal bool IsSetSampledRequests() => this.SampledRequests != null && (this.SampledRequests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// Usually, <c>TimeWindow</c> is the time range that you specified in the <c>GetSampledRequests</c>
        /// request. However, if your AWS resource received more than 5,000 requests during the
        /// time range that you specified in the request, <c>GetSampledRequests</c> returns the
        /// time range for the first 5,000 requests. Times are in Coordinated Universal Time (UTC)
        /// format.
        /// </para>
        /// </summary>
        public TimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;
    }
}

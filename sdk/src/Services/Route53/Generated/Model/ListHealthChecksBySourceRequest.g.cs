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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthChecksBySource operation. Retrieves
    /// a list of the health checks that use a specified health check source. <para> Results
    /// are paginated. If <c>IsTruncated</c> is <c>true</c>, specify the <c>NextMarker</c>
    /// value for <c>marker</c> to get more results. </para>
    /// </summary>
    public partial class ListHealthChecksBySourceRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HealthCheckSourceId. 
        /// <para>
        /// The ID of the health check source whose health checks you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string HealthCheckSourceId { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceId property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceId() => this.HealthCheckSourceId != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The <c>NextMarker</c> value from the previous response, if the value of <c>IsTruncated</c>
        /// was <c>true</c>. Specify it to get the next group of health checks. If <c>IsTruncated</c>
        /// was <c>false</c>, there are no more health checks to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of health checks that you want <c>ListHealthChecksBySource</c>
        /// to return. Route 53 returns a maximum of 1000 health checks. If you specify a value
        /// greater than 1000, Route 53 returns only the first 1000.
        /// </para>
        /// </summary>
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;
    }
}

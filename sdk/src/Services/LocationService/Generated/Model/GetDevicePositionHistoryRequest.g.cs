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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the GetDevicePositionHistory operation. Retrieves
    /// the device position history from a tracker resource within a specified range of time.
    /// <note> <para> Device positions are deleted after 30 days. </para> </note>
    /// </summary>
    public partial class GetDevicePositionHistoryRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device whose position history you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property EndTimeExclusive. 
        /// <para>
        /// Specify the end time for the position history in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. By default, the value will be
        /// the time that the request is made.
        /// </para>
        ///  
        /// <para>
        /// Requirement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The time specified for <c>EndTimeExclusive</c> must be after the time for <c>StartTimeInclusive</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public DateTime? EndTimeExclusive { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeExclusive property is set.
        /// </summary>
        internal bool IsSetEndTimeExclusive() => this.EndTimeExclusive.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional limit for the number of device positions returned in a single call.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>100</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>null</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTimeInclusive. 
        /// <para>
        /// Specify the start time for the position history in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. By default, the value will be
        /// 24 hours prior to the time that the request is made.
        /// </para>
        ///  
        /// <para>
        /// Requirement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The time specified for <c>StartTimeInclusive</c> must be before <c>EndTimeExclusive</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public DateTime? StartTimeInclusive { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeInclusive property is set.
        /// </summary>
        internal bool IsSetStartTimeInclusive() => this.StartTimeInclusive.HasValue;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The tracker resource receiving the request for the device position history.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;
    }
}

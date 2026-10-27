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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetRelationalDatabaseEvents operation. Returns
    /// a list of events for a specific database in Amazon Lightsail.
    /// </summary>
    public partial class GetRelationalDatabaseEventsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// The number of minutes in the past from which to retrieve events. For example, to get
        /// all events from the past 2 hours, enter 120.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>60</c> 
        /// </para>
        ///  
        /// <para>
        /// The minimum is 1 and the maximum is 14 days (20160 minutes).
        /// </para>
        /// </summary>
        public int? DurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationInMinutes property is set.
        /// </summary>
        internal bool IsSetDurationInMinutes() => this.DurationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetRelationalDatabaseEvents</c> request.
        /// If your results are paginated, the response will return a next page token that you
        /// can specify as the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of the database from which to get events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelationalDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseName property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseName() => this.RelationalDatabaseName != null;
    }
}

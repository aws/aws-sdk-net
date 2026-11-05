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
    /// Container for the parameters to the GetRelationalDatabaseLogEvents operation. Returns
    /// a list of log events for a database in Amazon Lightsail.
    /// </summary>
    public partial class GetRelationalDatabaseLogEventsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time interval from which to get log events.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use an end time of October 1, 2018, at 8 PM UTC, then
        /// you input <c>1538424000</c> as the end time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>get relational database log streams</c> operation to get a list of available
        /// log streams.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamName property is set.
        /// </summary>
        internal bool IsSetLogStreamName() => this.LogStreamName != null;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next or previous page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetRelationalDatabaseLogEvents</c> request.
        /// If your results are paginated, the response will return a next forward token and/or
        /// next backward token that you can specify as the page token in a subsequent request.
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
        /// The name of your database for which to get log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelationalDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseName property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseName() => this.RelationalDatabaseName != null;

        /// <summary>
        /// Gets and sets the property StartFromHead. 
        /// <para>
        /// Parameter to specify if the log should start from head or tail. If <c>true</c> is
        /// specified, the log event starts from the head of the log. If <c>false</c> is specified,
        /// the log event starts from the tail of the log.
        /// </para>
        ///  <note> 
        /// <para>
        /// For PostgreSQL, the default value of <c>false</c> is the only option available.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? StartFromHead { get; set; }

        /// <summary>
        /// Checks to see if the StartFromHead property is set.
        /// </summary>
        internal bool IsSetStartFromHead() => this.StartFromHead.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time interval from which to get log events.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use a start time of October 1, 2018, at 8 PM UTC, then
        /// you input <c>1538424000</c> as the start time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}

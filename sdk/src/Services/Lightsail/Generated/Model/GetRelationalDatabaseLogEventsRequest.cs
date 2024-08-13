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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
    /// Container for the parameters to the GetRelationalDatabaseLogEvents operation.
    /// Returns a list of log events for a database in Amazon Lightsail.
    /// </summary>
    public partial class GetRelationalDatabaseLogEventsRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private string _logStreamName;
        private string _pageToken;
        private string _relationalDatabaseName;
        private bool? _startFromHead;
        private DateTime? _startTime;

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
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

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
        [AWSProperty(Required=true)]
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
        }

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
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of your database for which to get log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

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
        public bool? StartFromHead
        {
            get { return this._startFromHead; }
            set { this._startFromHead = value; }
        }

        // Check to see if StartFromHead property is set
        internal bool IsSetStartFromHead()
        {
            return this._startFromHead.HasValue; 
        }

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
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}
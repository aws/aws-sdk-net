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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// Specified in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use an end time of October 1, 2018, at 8 PM UTC, then
        /// you input <code>1538424000</code> as the end time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// Use the <code>get relational database log streams</code> operation to get a list of
        /// available log streams.
        /// </para>
        /// </summary>
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
        /// A token used for advancing to a specific page of results for your <code>get relational
        /// database log events</code> request.
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
        /// Parameter to specify if the log should start from head or tail. If <code>true</code>
        /// is specified, the log event starts from the head of the log. If <code>false</code>
        /// is specified, the log event starts from the tail of the log.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool StartFromHead
        {
            get { return this._startFromHead.GetValueOrDefault(); }
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
        /// Specified in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use a start time of October 1, 2018, at 8 PM UTC, then
        /// you input <code>1538424000</code> as the start time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object contains information about this Live Tail session, including the log groups
    /// included and the log stream filters, if any.
    /// </summary>
    public partial class LiveTailSessionStart
        : IEventStreamEvent
    {
        private string _logEventFilterPattern;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logStreamNamePrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logStreamNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _requestId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property LogEventFilterPattern. 
        /// <para>
        /// An optional pattern to filter the results to include only log events that match the
        /// pattern. For example, a filter pattern of <c>error 404</c> displays only log events
        /// that include both <c>error</c> and <c>404</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about filter pattern syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">Filter
        /// and Pattern Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LogEventFilterPattern
        {
            get { return this._logEventFilterPattern; }
            set { this._logEventFilterPattern = value; }
        }

        // Check to see if LogEventFilterPattern property is set
        internal bool IsSetLogEventFilterPattern()
        {
            return this._logEventFilterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// An array of the names and ARNs of the log groups included in this Live Tail session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> LogGroupIdentifiers
        {
            get { return this._logGroupIdentifiers; }
            set { this._logGroupIdentifiers = value; }
        }

        // Check to see if LogGroupIdentifiers property is set
        internal bool IsSetLogGroupIdentifiers()
        {
            return this._logGroupIdentifiers != null && (this._logGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogStreamNamePrefixes. 
        /// <para>
        /// If your StartLiveTail operation request included a <c>logStreamNamePrefixes</c> parameter
        /// that filtered the session to only include log streams that have names that start with
        /// certain prefixes, these prefixes are listed here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> LogStreamNamePrefixes
        {
            get { return this._logStreamNamePrefixes; }
            set { this._logStreamNamePrefixes = value; }
        }

        // Check to see if LogStreamNamePrefixes property is set
        internal bool IsSetLogStreamNamePrefixes()
        {
            return this._logStreamNamePrefixes != null && (this._logStreamNamePrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogStreamNames. 
        /// <para>
        /// If your StartLiveTail operation request included a <c>logStreamNames</c> parameter
        /// that filtered the session to only include certain log streams, these streams are listed
        /// here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> LogStreamNames
        {
            get { return this._logStreamNames; }
            set { this._logStreamNames = value; }
        }

        // Check to see if LogStreamNames property is set
        internal bool IsSetLogStreamNames()
        {
            return this._logStreamNames != null && (this._logStreamNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique ID generated by CloudWatch Logs to identify this Live Tail session request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique ID generated by CloudWatch Logs to identify this Live Tail session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}
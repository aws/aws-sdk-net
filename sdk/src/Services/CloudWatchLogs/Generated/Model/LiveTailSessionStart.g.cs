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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object contains information about this Live Tail session, including the log groups
    /// included and the log stream filters, if any.
    /// </summary>
    public partial class LiveTailSessionStart : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
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
        [AWSProperty(Min = 0, Max = 1024)]
        public string LogEventFilterPattern { get; set; }

        /// <summary>
        /// Checks to see if the LogEventFilterPattern property is set.
        /// </summary>
        internal bool IsSetLogEventFilterPattern() => this.LogEventFilterPattern != null;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// An array of the names and ARNs of the log groups included in this Live Tail session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> LogGroupIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogGroupIdentifiers property is set.
        /// </summary>
        internal bool IsSetLogGroupIdentifiers() => this.LogGroupIdentifiers != null && (this.LogGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogStreamNamePrefixes. 
        /// <para>
        /// If your StartLiveTail operation request included a <c>logStreamNamePrefixes</c> parameter
        /// that filtered the session to only include log streams that have names that start with
        /// certain prefixes, these prefixes are listed here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> LogStreamNamePrefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogStreamNamePrefixes property is set.
        /// </summary>
        internal bool IsSetLogStreamNamePrefixes() => this.LogStreamNamePrefixes != null && (this.LogStreamNamePrefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogStreamNames. 
        /// <para>
        /// If your StartLiveTail operation request included a <c>logStreamNames</c> parameter
        /// that filtered the session to only include certain log streams, these streams are listed
        /// here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> LogStreamNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogStreamNames property is set.
        /// </summary>
        internal bool IsSetLogStreamNames() => this.LogStreamNames != null && (this.LogStreamNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique ID generated by CloudWatch Logs to identify this Live Tail session request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique ID generated by CloudWatch Logs to identify this Live Tail session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}

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
    /// Container for the parameters to the GetContainerLog operation.
    /// Returns the log events of a container of your Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// If your container service has more than one node (i.e., a scale greater than 1), then
    /// the log events that are returned for the specified container are merged from all nodes
    /// on your container service.
    /// </para>
    ///  <note> 
    /// <para>
    /// Container logs are retained for a certain amount of time. For more information, see
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon Lightsail
    /// endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetContainerLogRequest : AmazonLightsailRequest
    {
        private string _containerName;
        private DateTime? _endTime;
        private string _filterPattern;
        private string _pageToken;
        private string _serviceName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that is either running or previously ran on the container
        /// service for which to return a log.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time interval for which to get log data.
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
        /// For example, if you wish to use an end time of October 1, 2018, at 9 PM UTC, specify
        /// <c>1538427600</c> as the end time.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can convert a human-friendly time to Unix time format using a converter like <a
        /// href="https://www.epochconverter.com/">Epoch converter</a>.
        /// </para>
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
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// The pattern to use to filter the returned log events to a specific term.
        /// </para>
        ///  
        /// <para>
        /// The following are a few examples of filter patterns that you can specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To return all log events, specify a filter pattern of <c>""</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude log events that contain the <c>ERROR</c> term, and return all other log
        /// events, specify a filter pattern of <c>"-ERROR"</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To return log events that contain the <c>ERROR</c> term, specify a filter pattern
        /// of <c>"ERROR"</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To return log events that contain both the <c>ERROR</c> and <c>Exception</c> terms,
        /// specify a filter pattern of <c>"ERROR Exception"</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To return log events that contain the <c>ERROR</c> <i>or</i> the <c>Exception</c>
        /// term, specify a filter pattern of <c>"?ERROR ?Exception"</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetContainerLog</c> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service for which to get a container log.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time interval for which to get log data.
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
        /// For example, if you wish to use a start time of October 1, 2018, at 8 PM UTC, specify
        /// <c>1538424000</c> as the start time.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can convert a human-friendly time to Unix time format using a converter like <a
        /// href="https://www.epochconverter.com/">Epoch converter</a>.
        /// </para>
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
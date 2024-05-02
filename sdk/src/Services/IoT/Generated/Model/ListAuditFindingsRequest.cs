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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuditFindings operation.
    /// Lists the findings (results) of a Device Defender audit or of the audits performed
    /// during a specified time period. (Findings are retained for 90 days.)
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditFindings</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListAuditFindingsRequest : AmazonIoTRequest
    {
        private string _checkName;
        private DateTime? _endTime;
        private bool? _listSuppressedFindings;
        private int? _maxResults;
        private string _nextToken;
        private ResourceIdentifier _resourceIdentifier;
        private DateTime? _startTime;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property CheckName. 
        /// <para>
        /// A filter to limit results to the findings for the specified audit check.
        /// </para>
        /// </summary>
        public string CheckName
        {
            get { return this._checkName; }
            set { this._checkName = value; }
        }

        // Check to see if CheckName property is set
        internal bool IsSetCheckName()
        {
            return this._checkName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A filter to limit results to those found before the specified time. You must specify
        /// either the startTime and endTime or the taskId, but not both.
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
        /// Gets and sets the property ListSuppressedFindings. 
        /// <para>
        ///  Boolean flag indicating whether only the suppressed findings or the unsuppressed
        /// findings should be listed. If this parameter isn't provided, the response will list
        /// both suppressed and unsuppressed findings. 
        /// </para>
        /// </summary>
        public bool? ListSuppressedFindings
        {
            get { return this._listSuppressedFindings; }
            set { this._listSuppressedFindings = value; }
        }

        // Check to see if ListSuppressedFindings property is set
        internal bool IsSetListSuppressedFindings()
        {
            return this._listSuppressedFindings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time. The default is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Information identifying the noncompliant resource.
        /// </para>
        /// </summary>
        public ResourceIdentifier ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A filter to limit results to those found after the specified time. You must specify
        /// either the startTime and endTime or the taskId, but not both.
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

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// A filter to limit results to the audit with the specified ID. You must specify either
        /// the taskId or the startTime and endTime, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}
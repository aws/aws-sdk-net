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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns list of event descriptions matching criteria up to the last 6 weeks.
    /// 
    ///  <note> 
    /// <para>
    /// This action returns the most recent 1,000 events from the specified <c>NextToken</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private DateTime? _endTime;
        private string _environmentId;
        private string _environmentName;
        private int? _maxRecords;
        private string _nextToken;
        private string _platformArn;
        private string _requestId;
        private EventSeverity _severity;
        private DateTime? _startTime;
        private string _templateName;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEventsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include
        /// only those associated with this application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  If specified, AWS Elastic Beanstalk restricts the returned descriptions to those
        /// that occur up to, but not including, the <c>EndTime</c>. 
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to those associated
        /// with this environment.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to those associated
        /// with this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Specifies the maximum number of events that can be returned, beginning with the most
        /// recent event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token. If specified, the events return the next batch of results.
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
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of a custom platform version. If specified, AWS Elastic Beanstalk restricts
        /// the returned descriptions to those associated with this custom platform version.
        /// </para>
        /// </summary>
        public string PlatformArn
        {
            get { return this._platformArn; }
            set { this._platformArn = value; }
        }

        // Check to see if PlatformArn property is set
        internal bool IsSetPlatformArn()
        {
            return this._platformArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the described events to include only
        /// those associated with this request ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// If specified, limits the events returned from this call to include only those with
        /// the specified severity or higher.
        /// </para>
        /// </summary>
        public EventSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to those that
        /// occur on or after this time.
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to those that
        /// are associated with this environment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to those associated
        /// with this application version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}
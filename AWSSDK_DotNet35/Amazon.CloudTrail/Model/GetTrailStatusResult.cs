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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Returns the objects or data listed below if successful. Otherwise, returns an error.
    /// </summary>
    public partial class GetTrailStatusResult : AmazonWebServiceResponse
    {
        private bool? _isLogging;
        private string _latestCloudWatchLogsDeliveryError;
        private DateTime? _latestCloudWatchLogsDeliveryTime;
        private string _latestDeliveryError;
        private DateTime? _latestDeliveryTime;
        private string _latestNotificationError;
        private DateTime? _latestNotificationTime;
        private DateTime? _startLoggingTime;
        private DateTime? _stopLoggingTime;

        /// <summary>
        /// Gets and sets the property IsLogging. 
        /// <para>
        /// Whether the CloudTrail is currently logging AWS API calls.
        /// </para>
        /// </summary>
        public bool IsLogging
        {
            get { return this._isLogging.GetValueOrDefault(); }
            set { this._isLogging = value; }
        }

        // Check to see if IsLogging property is set
        internal bool IsSetIsLogging()
        {
            return this._isLogging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestCloudWatchLogsDeliveryError. 
        /// <para>
        /// Displays any CloudWatch Logs error that CloudTrail encountered when attempting to
        /// deliver logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public string LatestCloudWatchLogsDeliveryError
        {
            get { return this._latestCloudWatchLogsDeliveryError; }
            set { this._latestCloudWatchLogsDeliveryError = value; }
        }

        // Check to see if LatestCloudWatchLogsDeliveryError property is set
        internal bool IsSetLatestCloudWatchLogsDeliveryError()
        {
            return this._latestCloudWatchLogsDeliveryError != null;
        }

        /// <summary>
        /// Gets and sets the property LatestCloudWatchLogsDeliveryTime. 
        /// <para>
        /// Displays the most recent date and time when CloudTrail delivered logs to CloudWatch
        /// Logs.
        /// </para>
        /// </summary>
        public DateTime LatestCloudWatchLogsDeliveryTime
        {
            get { return this._latestCloudWatchLogsDeliveryTime.GetValueOrDefault(); }
            set { this._latestCloudWatchLogsDeliveryTime = value; }
        }

        // Check to see if LatestCloudWatchLogsDeliveryTime property is set
        internal bool IsSetLatestCloudWatchLogsDeliveryTime()
        {
            return this._latestCloudWatchLogsDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryError. 
        /// <para>
        /// Displays any Amazon S3 error that CloudTrail encountered when attempting to deliver
        /// log files to the designated bucket. For more information see the topic <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html">Error
        /// Responses</a> in the Amazon S3 API Reference. 
        /// </para>
        /// </summary>
        public string LatestDeliveryError
        {
            get { return this._latestDeliveryError; }
            set { this._latestDeliveryError = value; }
        }

        // Check to see if LatestDeliveryError property is set
        internal bool IsSetLatestDeliveryError()
        {
            return this._latestDeliveryError != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryTime. 
        /// <para>
        /// Specifies the date and time that CloudTrail last delivered log files to an account's
        /// Amazon S3 bucket.
        /// </para>
        /// </summary>
        public DateTime LatestDeliveryTime
        {
            get { return this._latestDeliveryTime.GetValueOrDefault(); }
            set { this._latestDeliveryTime = value; }
        }

        // Check to see if LatestDeliveryTime property is set
        internal bool IsSetLatestDeliveryTime()
        {
            return this._latestDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestNotificationError. 
        /// <para>
        /// Displays any Amazon SNS error that CloudTrail encountered when attempting to send
        /// a notification. For more information about Amazon SNS errors, see the <a href="http://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon
        /// SNS Developer Guide</a>. 
        /// </para>
        /// </summary>
        public string LatestNotificationError
        {
            get { return this._latestNotificationError; }
            set { this._latestNotificationError = value; }
        }

        // Check to see if LatestNotificationError property is set
        internal bool IsSetLatestNotificationError()
        {
            return this._latestNotificationError != null;
        }

        /// <summary>
        /// Gets and sets the property LatestNotificationTime. 
        /// <para>
        /// Specifies the date and time of the most recent Amazon SNS notification that CloudTrail
        /// has written a new log file to an account's Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public DateTime LatestNotificationTime
        {
            get { return this._latestNotificationTime.GetValueOrDefault(); }
            set { this._latestNotificationTime = value; }
        }

        // Check to see if LatestNotificationTime property is set
        internal bool IsSetLatestNotificationTime()
        {
            return this._latestNotificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartLoggingTime. 
        /// <para>
        /// Specifies the most recent date and time when CloudTrail started recording API calls
        /// for an AWS account. 
        /// </para>
        /// </summary>
        public DateTime StartLoggingTime
        {
            get { return this._startLoggingTime.GetValueOrDefault(); }
            set { this._startLoggingTime = value; }
        }

        // Check to see if StartLoggingTime property is set
        internal bool IsSetStartLoggingTime()
        {
            return this._startLoggingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopLoggingTime. 
        /// <para>
        /// Specifies the most recent date and time when CloudTrail stopped recording API calls
        /// for an AWS account. 
        /// </para>
        /// </summary>
        public DateTime StopLoggingTime
        {
            get { return this._stopLoggingTime.GetValueOrDefault(); }
            set { this._stopLoggingTime = value; }
        }

        // Check to see if StopLoggingTime property is set
        internal bool IsSetStopLoggingTime()
        {
            return this._stopLoggingTime.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Returns the objects or data listed below if successful. Otherwise, returns an error.
    /// </summary>
    public partial class GetTrailStatusResponse : AmazonWebServiceResponse
    {
        private bool? _isLogging;
        private string _latestCloudWatchLogsDeliveryError;
        private DateTime? _latestCloudWatchLogsDeliveryTime;
        private string _latestDeliveryAttemptSucceeded;
        private string _latestDeliveryAttemptTime;
        private string _latestDeliveryError;
        private DateTime? _latestDeliveryTime;
        private string _latestDigestDeliveryError;
        private DateTime? _latestDigestDeliveryTime;
        private string _latestNotificationAttemptSucceeded;
        private string _latestNotificationAttemptTime;
        private string _latestNotificationError;
        private DateTime? _latestNotificationTime;
        private DateTime? _startLoggingTime;
        private DateTime? _stopLoggingTime;
        private string _timeLoggingStarted;
        private string _timeLoggingStopped;

        /// <summary>
        /// Gets and sets the property IsLogging. 
        /// <para>
        /// Whether the CloudTrail trail is currently logging Amazon Web Services API calls.
        /// </para>
        /// </summary>
        public bool? IsLogging
        {
            get { return this._isLogging; }
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
        public DateTime? LatestCloudWatchLogsDeliveryTime
        {
            get { return this._latestCloudWatchLogsDeliveryTime; }
            set { this._latestCloudWatchLogsDeliveryTime = value; }
        }

        // Check to see if LatestCloudWatchLogsDeliveryTime property is set
        internal bool IsSetLatestCloudWatchLogsDeliveryTime()
        {
            return this._latestCloudWatchLogsDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryAttemptSucceeded. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestDeliveryAttemptSucceeded
        {
            get { return this._latestDeliveryAttemptSucceeded; }
            set { this._latestDeliveryAttemptSucceeded = value; }
        }

        // Check to see if LatestDeliveryAttemptSucceeded property is set
        internal bool IsSetLatestDeliveryAttemptSucceeded()
        {
            return this._latestDeliveryAttemptSucceeded != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryAttemptTime. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestDeliveryAttemptTime
        {
            get { return this._latestDeliveryAttemptTime; }
            set { this._latestDeliveryAttemptTime = value; }
        }

        // Check to see if LatestDeliveryAttemptTime property is set
        internal bool IsSetLatestDeliveryAttemptTime()
        {
            return this._latestDeliveryAttemptTime != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryError. 
        /// <para>
        /// Displays any Amazon S3 error that CloudTrail encountered when attempting to deliver
        /// log files to the designated bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html">Error
        /// Responses</a> in the Amazon S3 API Reference. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This error occurs only when there is a problem with the destination S3 bucket, and
        /// does not occur for requests that time out. To resolve the issue, fix the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/create-s3-bucket-policy-for-cloudtrail.html">bucket
        /// policy</a> so that CloudTrail can write to the bucket; or create a new bucket and
        /// call <c>UpdateTrail</c> to specify the new bucket.
        /// </para>
        ///  </note>
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
        public DateTime? LatestDeliveryTime
        {
            get { return this._latestDeliveryTime; }
            set { this._latestDeliveryTime = value; }
        }

        // Check to see if LatestDeliveryTime property is set
        internal bool IsSetLatestDeliveryTime()
        {
            return this._latestDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestDigestDeliveryError. 
        /// <para>
        /// Displays any Amazon S3 error that CloudTrail encountered when attempting to deliver
        /// a digest file to the designated bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html">Error
        /// Responses</a> in the Amazon S3 API Reference. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This error occurs only when there is a problem with the destination S3 bucket, and
        /// does not occur for requests that time out. To resolve the issue, fix the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/create-s3-bucket-policy-for-cloudtrail.html">bucket
        /// policy</a> so that CloudTrail can write to the bucket; or create a new bucket and
        /// call <c>UpdateTrail</c> to specify the new bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public string LatestDigestDeliveryError
        {
            get { return this._latestDigestDeliveryError; }
            set { this._latestDigestDeliveryError = value; }
        }

        // Check to see if LatestDigestDeliveryError property is set
        internal bool IsSetLatestDigestDeliveryError()
        {
            return this._latestDigestDeliveryError != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDigestDeliveryTime. 
        /// <para>
        /// Specifies the date and time that CloudTrail last delivered a digest file to an account's
        /// Amazon S3 bucket.
        /// </para>
        /// </summary>
        public DateTime? LatestDigestDeliveryTime
        {
            get { return this._latestDigestDeliveryTime; }
            set { this._latestDigestDeliveryTime = value; }
        }

        // Check to see if LatestDigestDeliveryTime property is set
        internal bool IsSetLatestDigestDeliveryTime()
        {
            return this._latestDigestDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestNotificationAttemptSucceeded. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestNotificationAttemptSucceeded
        {
            get { return this._latestNotificationAttemptSucceeded; }
            set { this._latestNotificationAttemptSucceeded = value; }
        }

        // Check to see if LatestNotificationAttemptSucceeded property is set
        internal bool IsSetLatestNotificationAttemptSucceeded()
        {
            return this._latestNotificationAttemptSucceeded != null;
        }

        /// <summary>
        /// Gets and sets the property LatestNotificationAttemptTime. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestNotificationAttemptTime
        {
            get { return this._latestNotificationAttemptTime; }
            set { this._latestNotificationAttemptTime = value; }
        }

        // Check to see if LatestNotificationAttemptTime property is set
        internal bool IsSetLatestNotificationAttemptTime()
        {
            return this._latestNotificationAttemptTime != null;
        }

        /// <summary>
        /// Gets and sets the property LatestNotificationError. 
        /// <para>
        /// Displays any Amazon SNS error that CloudTrail encountered when attempting to send
        /// a notification. For more information about Amazon SNS errors, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon
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
        public DateTime? LatestNotificationTime
        {
            get { return this._latestNotificationTime; }
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
        /// for an Amazon Web Services account.
        /// </para>
        /// </summary>
        public DateTime? StartLoggingTime
        {
            get { return this._startLoggingTime; }
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
        /// for an Amazon Web Services account.
        /// </para>
        /// </summary>
        public DateTime? StopLoggingTime
        {
            get { return this._stopLoggingTime; }
            set { this._stopLoggingTime = value; }
        }

        // Check to see if StopLoggingTime property is set
        internal bool IsSetStopLoggingTime()
        {
            return this._stopLoggingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeLoggingStarted. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string TimeLoggingStarted
        {
            get { return this._timeLoggingStarted; }
            set { this._timeLoggingStarted = value; }
        }

        // Check to see if TimeLoggingStarted property is set
        internal bool IsSetTimeLoggingStarted()
        {
            return this._timeLoggingStarted != null;
        }

        /// <summary>
        /// Gets and sets the property TimeLoggingStopped. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string TimeLoggingStopped
        {
            get { return this._timeLoggingStopped; }
            set { this._timeLoggingStopped = value; }
        }

        // Check to see if TimeLoggingStopped property is set
        internal bool IsSetTimeLoggingStopped()
        {
            return this._timeLoggingStopped != null;
        }

    }
}
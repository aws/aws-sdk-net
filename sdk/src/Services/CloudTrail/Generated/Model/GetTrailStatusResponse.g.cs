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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GetTrailStatus operation.
    /// </summary>
    public partial class GetTrailStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IsLogging. 
        /// <para>
        /// Whether the CloudTrail trail is currently logging Amazon Web Services API calls.
        /// </para>
        /// </summary>
        public bool? IsLogging { get; set; }

        /// <summary>
        /// Checks to see if the IsLogging property is set.
        /// </summary>
        internal bool IsSetIsLogging() => this.IsLogging.HasValue;

        /// <summary>
        /// Gets and sets the property LatestCloudWatchLogsDeliveryError. 
        /// <para>
        /// Displays any CloudWatch Logs error that CloudTrail encountered when attempting to
        /// deliver logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public string LatestCloudWatchLogsDeliveryError { get; set; }

        /// <summary>
        /// Checks to see if the LatestCloudWatchLogsDeliveryError property is set.
        /// </summary>
        internal bool IsSetLatestCloudWatchLogsDeliveryError() => this.LatestCloudWatchLogsDeliveryError != null;

        /// <summary>
        /// Gets and sets the property LatestCloudWatchLogsDeliveryTime. 
        /// <para>
        /// Displays the most recent date and time when CloudTrail delivered logs to CloudWatch
        /// Logs.
        /// </para>
        /// </summary>
        public DateTime? LatestCloudWatchLogsDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestCloudWatchLogsDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLatestCloudWatchLogsDeliveryTime() => this.LatestCloudWatchLogsDeliveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestDeliveryAttemptSucceeded. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestDeliveryAttemptSucceeded { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryAttemptSucceeded property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryAttemptSucceeded() => this.LatestDeliveryAttemptSucceeded != null;

        /// <summary>
        /// Gets and sets the property LatestDeliveryAttemptTime. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestDeliveryAttemptTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryAttemptTime property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryAttemptTime() => this.LatestDeliveryAttemptTime != null;

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
        public string LatestDeliveryError { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryError property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryError() => this.LatestDeliveryError != null;

        /// <summary>
        /// Gets and sets the property LatestDeliveryTime. 
        /// <para>
        /// Specifies the date and time that CloudTrail last delivered log files to an account's
        /// Amazon S3 bucket.
        /// </para>
        /// </summary>
        public DateTime? LatestDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryTime() => this.LatestDeliveryTime.HasValue;

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
        public string LatestDigestDeliveryError { get; set; }

        /// <summary>
        /// Checks to see if the LatestDigestDeliveryError property is set.
        /// </summary>
        internal bool IsSetLatestDigestDeliveryError() => this.LatestDigestDeliveryError != null;

        /// <summary>
        /// Gets and sets the property LatestDigestDeliveryTime. 
        /// <para>
        /// Specifies the date and time that CloudTrail last delivered a digest file to an account's
        /// Amazon S3 bucket.
        /// </para>
        /// </summary>
        public DateTime? LatestDigestDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestDigestDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLatestDigestDeliveryTime() => this.LatestDigestDeliveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestNotificationAttemptSucceeded. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestNotificationAttemptSucceeded { get; set; }

        /// <summary>
        /// Checks to see if the LatestNotificationAttemptSucceeded property is set.
        /// </summary>
        internal bool IsSetLatestNotificationAttemptSucceeded() => this.LatestNotificationAttemptSucceeded != null;

        /// <summary>
        /// Gets and sets the property LatestNotificationAttemptTime. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string LatestNotificationAttemptTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestNotificationAttemptTime property is set.
        /// </summary>
        internal bool IsSetLatestNotificationAttemptTime() => this.LatestNotificationAttemptTime != null;

        /// <summary>
        /// Gets and sets the property LatestNotificationError. 
        /// <para>
        /// Displays any Amazon SNS error that CloudTrail encountered when attempting to send
        /// a notification. For more information about Amazon SNS errors, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon
        /// SNS Developer Guide</a>. 
        /// </para>
        /// </summary>
        public string LatestNotificationError { get; set; }

        /// <summary>
        /// Checks to see if the LatestNotificationError property is set.
        /// </summary>
        internal bool IsSetLatestNotificationError() => this.LatestNotificationError != null;

        /// <summary>
        /// Gets and sets the property LatestNotificationTime. 
        /// <para>
        /// Specifies the date and time of the most recent Amazon SNS notification that CloudTrail
        /// has written a new log file to an account's Amazon S3 bucket.
        /// </para>
        /// </summary>
        public DateTime? LatestNotificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestNotificationTime property is set.
        /// </summary>
        internal bool IsSetLatestNotificationTime() => this.LatestNotificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartLoggingTime. 
        /// <para>
        /// Specifies the most recent date and time when CloudTrail started recording API calls
        /// for an Amazon Web Services account.
        /// </para>
        /// </summary>
        public DateTime? StartLoggingTime { get; set; }

        /// <summary>
        /// Checks to see if the StartLoggingTime property is set.
        /// </summary>
        internal bool IsSetStartLoggingTime() => this.StartLoggingTime.HasValue;

        /// <summary>
        /// Gets and sets the property StopLoggingTime. 
        /// <para>
        /// Specifies the most recent date and time when CloudTrail stopped recording API calls
        /// for an Amazon Web Services account.
        /// </para>
        /// </summary>
        public DateTime? StopLoggingTime { get; set; }

        /// <summary>
        /// Checks to see if the StopLoggingTime property is set.
        /// </summary>
        internal bool IsSetStopLoggingTime() => this.StopLoggingTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimeLoggingStarted. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string TimeLoggingStarted { get; set; }

        /// <summary>
        /// Checks to see if the TimeLoggingStarted property is set.
        /// </summary>
        internal bool IsSetTimeLoggingStarted() => this.TimeLoggingStarted != null;

        /// <summary>
        /// Gets and sets the property TimeLoggingStopped. 
        /// <para>
        /// This field is no longer in use.
        /// </para>
        /// </summary>
        public string TimeLoggingStopped { get; set; }

        /// <summary>
        /// Checks to see if the TimeLoggingStopped property is set.
        /// </summary>
        internal bool IsSetTimeLoggingStopped() => this.TimeLoggingStopped != null;
    }
}

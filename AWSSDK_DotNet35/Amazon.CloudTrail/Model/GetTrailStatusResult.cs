/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public partial class GetTrailStatusResult : AmazonWebServiceResponse
    {
        
        private bool? isLogging;
        private string latestDeliveryError;
        private string latestNotificationError;
        private string latestDeliveryAttemptTime;
        private string latestDeliveryAttemptSucceeded;
        private string latestNotificationAttemptTime;
        private string latestNotificationAttemptSucceeded;
        private string timeLoggingStarted;
        private string timeLoggingStopped;


        /// <summary>
        /// Whether the CloudTrail is currently logging AWS API calls.
        ///  
        /// </summary>
        public bool IsLogging
        {
            get { return this.isLogging ?? default(bool); }
            set { this.isLogging = value; }
        }

        // Check to see if IsLogging property is set
        internal bool IsSetIsLogging()
        {
            return this.isLogging.HasValue;
        }

        /// <summary>
        /// Information about the most recent error CloudTrail encountered when attempting to deliver log files to the account's Amazon S3 bucket.
        ///  
        /// </summary>
        public string LatestDeliveryError
        {
            get { return this.latestDeliveryError; }
            set { this.latestDeliveryError = value; }
        }

        // Check to see if LatestDeliveryError property is set
        internal bool IsSetLatestDeliveryError()
        {
            return this.latestDeliveryError != null;
        }

        /// <summary>
        /// Information about the most recent error CloudTrail encountered when attempting to send an Amazon SNS notification.
        ///  
        /// </summary>
        public string LatestNotificationError
        {
            get { return this.latestNotificationError; }
            set { this.latestNotificationError = value; }
        }

        // Check to see if LatestNotificationError property is set
        internal bool IsSetLatestNotificationError()
        {
            return this.latestNotificationError != null;
        }

        /// <summary>
        /// The last time CloudTrail attempted to deliver a file to an account's Amazon S3 bucket.
        ///  
        /// </summary>
        public string LatestDeliveryAttemptTime
        {
            get { return this.latestDeliveryAttemptTime; }
            set { this.latestDeliveryAttemptTime = value; }
        }

        // Check to see if LatestDeliveryAttemptTime property is set
        internal bool IsSetLatestDeliveryAttemptTime()
        {
            return this.latestDeliveryAttemptTime != null;
        }

        /// <summary>
        /// The last time CloudTrail successfully delivered a log file to an account's Amazon S3 bucket.
        ///  
        /// </summary>
        public string LatestDeliveryAttemptSucceeded
        {
            get { return this.latestDeliveryAttemptSucceeded; }
            set { this.latestDeliveryAttemptSucceeded = value; }
        }

        // Check to see if LatestDeliveryAttemptSucceeded property is set
        internal bool IsSetLatestDeliveryAttemptSucceeded()
        {
            return this.latestDeliveryAttemptSucceeded != null;
        }

        /// <summary>
        /// The last time CloudTrail attempted to notify an account's owner of a log delivery to the account's Amazon S3 bucket.
        ///  
        /// </summary>
        public string LatestNotificationAttemptTime
        {
            get { return this.latestNotificationAttemptTime; }
            set { this.latestNotificationAttemptTime = value; }
        }

        // Check to see if LatestNotificationAttemptTime property is set
        internal bool IsSetLatestNotificationAttemptTime()
        {
            return this.latestNotificationAttemptTime != null;
        }

        /// <summary>
        /// The last time CloudTrail successfully notified an account's owner of a log delivery to the account's Amazon S3 bucket.
        ///  
        /// </summary>
        public string LatestNotificationAttemptSucceeded
        {
            get { return this.latestNotificationAttemptSucceeded; }
            set { this.latestNotificationAttemptSucceeded = value; }
        }

        // Check to see if LatestNotificationAttemptSucceeded property is set
        internal bool IsSetLatestNotificationAttemptSucceeded()
        {
            return this.latestNotificationAttemptSucceeded != null;
        }

        /// <summary>
        /// The time at which CloudTrail started logging AWS API calls for an account.
        ///  
        /// </summary>
        public string TimeLoggingStarted
        {
            get { return this.timeLoggingStarted; }
            set { this.timeLoggingStarted = value; }
        }

        // Check to see if TimeLoggingStarted property is set
        internal bool IsSetTimeLoggingStarted()
        {
            return this.timeLoggingStarted != null;
        }

        /// <summary>
        /// The time at which CloudTrail stopped logging AWS API calls for an account.
        ///  
        /// </summary>
        public string TimeLoggingStopped
        {
            get { return this.timeLoggingStopped; }
            set { this.timeLoggingStopped = value; }
        }

        // Check to see if TimeLoggingStopped property is set
        internal bool IsSetTimeLoggingStopped()
        {
            return this.timeLoggingStopped != null;
        }
    }
}

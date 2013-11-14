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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public partial class GetTrailStatusResult
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

        /// <summary>
        /// Sets the IsLogging property
        /// </summary>
        /// <param name="isLogging">The value to set for the IsLogging property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithIsLogging(bool isLogging)
        {
            this.isLogging = isLogging;
            return this;
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

        /// <summary>
        /// Sets the LatestDeliveryError property
        /// </summary>
        /// <param name="latestDeliveryError">The value to set for the LatestDeliveryError property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithLatestDeliveryError(string latestDeliveryError)
        {
            this.latestDeliveryError = latestDeliveryError;
            return this;
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

        /// <summary>
        /// Sets the LatestNotificationError property
        /// </summary>
        /// <param name="latestNotificationError">The value to set for the LatestNotificationError property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithLatestNotificationError(string latestNotificationError)
        {
            this.latestNotificationError = latestNotificationError;
            return this;
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

        /// <summary>
        /// Sets the LatestDeliveryAttemptTime property
        /// </summary>
        /// <param name="latestDeliveryAttemptTime">The value to set for the LatestDeliveryAttemptTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithLatestDeliveryAttemptTime(string latestDeliveryAttemptTime)
        {
            this.latestDeliveryAttemptTime = latestDeliveryAttemptTime;
            return this;
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

        /// <summary>
        /// Sets the LatestDeliveryAttemptSucceeded property
        /// </summary>
        /// <param name="latestDeliveryAttemptSucceeded">The value to set for the LatestDeliveryAttemptSucceeded property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithLatestDeliveryAttemptSucceeded(string latestDeliveryAttemptSucceeded)
        {
            this.latestDeliveryAttemptSucceeded = latestDeliveryAttemptSucceeded;
            return this;
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

        /// <summary>
        /// Sets the LatestNotificationAttemptTime property
        /// </summary>
        /// <param name="latestNotificationAttemptTime">The value to set for the LatestNotificationAttemptTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithLatestNotificationAttemptTime(string latestNotificationAttemptTime)
        {
            this.latestNotificationAttemptTime = latestNotificationAttemptTime;
            return this;
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

        /// <summary>
        /// Sets the LatestNotificationAttemptSucceeded property
        /// </summary>
        /// <param name="latestNotificationAttemptSucceeded">The value to set for the LatestNotificationAttemptSucceeded property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithLatestNotificationAttemptSucceeded(string latestNotificationAttemptSucceeded)
        {
            this.latestNotificationAttemptSucceeded = latestNotificationAttemptSucceeded;
            return this;
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

        /// <summary>
        /// Sets the TimeLoggingStarted property
        /// </summary>
        /// <param name="timeLoggingStarted">The value to set for the TimeLoggingStarted property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithTimeLoggingStarted(string timeLoggingStarted)
        {
            this.timeLoggingStarted = timeLoggingStarted;
            return this;
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

        /// <summary>
        /// Sets the TimeLoggingStopped property
        /// </summary>
        /// <param name="timeLoggingStopped">The value to set for the TimeLoggingStopped property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetTrailStatusResult WithTimeLoggingStopped(string timeLoggingStopped)
        {
            this.timeLoggingStopped = timeLoggingStopped;
            return this;
        }
            

        // Check to see if TimeLoggingStopped property is set
        internal bool IsSetTimeLoggingStopped()
        {
            return this.timeLoggingStopped != null;
        }
    }
}

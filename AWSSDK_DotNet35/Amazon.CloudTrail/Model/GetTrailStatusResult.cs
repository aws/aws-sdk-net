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
        private DateTime? latestDeliveryTime;
        private DateTime? latestNotificationTime;
        private DateTime? startLoggingTime;
        private DateTime? stopLoggingTime;


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
        /// Displays any Amazon S3 error that CloudTrail encountered when attempting to deliver log files to the designated bucket. For more information
        /// see the topic <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html">Error Responses</a> in the Amazon S3 API
        /// Reference.
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
        /// Displays any Amazon SNS error that CloudTrail encountered when attempting to send a notification. For more information about Amazon SNS
        /// errors, see the <a href="http://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon SNS Developer Guide</a>.
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
        /// Specifies the date and time that CloudTrail last delivered log files to an account's Amazon S3 bucket.
        ///  
        /// </summary>
        public DateTime LatestDeliveryTime
        {
            get { return this.latestDeliveryTime ?? default(DateTime); }
            set { this.latestDeliveryTime = value; }
        }

        // Check to see if LatestDeliveryTime property is set
        internal bool IsSetLatestDeliveryTime()
        {
            return this.latestDeliveryTime.HasValue;
        }

        /// <summary>
        /// Specifies the date and time of the most recent Amazon SNS notification that CloudTrail has written a new log file to an account's Amazon S3
        /// bucket.
        ///  
        /// </summary>
        public DateTime LatestNotificationTime
        {
            get { return this.latestNotificationTime ?? default(DateTime); }
            set { this.latestNotificationTime = value; }
        }

        // Check to see if LatestNotificationTime property is set
        internal bool IsSetLatestNotificationTime()
        {
            return this.latestNotificationTime.HasValue;
        }

        /// <summary>
        /// Specifies the most recent date and time when CloudTrail started recording API calls for an AWS account.
        ///  
        /// </summary>
        public DateTime StartLoggingTime
        {
            get { return this.startLoggingTime ?? default(DateTime); }
            set { this.startLoggingTime = value; }
        }

        // Check to see if StartLoggingTime property is set
        internal bool IsSetStartLoggingTime()
        {
            return this.startLoggingTime.HasValue;
        }

        /// <summary>
        /// Specifies the most recent date and time when CloudTrail stopped recording API calls for an AWS account.
        ///  
        /// </summary>
        public DateTime StopLoggingTime
        {
            get { return this.stopLoggingTime ?? default(DateTime); }
            set { this.stopLoggingTime = value; }
        }

        // Check to see if StopLoggingTime property is set
        internal bool IsSetStopLoggingTime()
        {
            return this.stopLoggingTime.HasValue;
        }
    }
}

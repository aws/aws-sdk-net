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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes the status of logging for a cluster.</para>
    /// </summary>
    public partial class DisableLoggingResult : AmazonWebServiceResponse
    {
        
        private bool? loggingEnabled;
        private string bucketName;
        private string s3KeyPrefix;
        private DateTime? lastSuccessfulDeliveryTime;
        private DateTime? lastFailureTime;
        private string lastFailureMessage;


        /// <summary>
        /// <c>true</c> if logging is on, <c>false</c> if logging is off.
        ///  
        /// </summary>
        public bool LoggingEnabled
        {
            get { return this.loggingEnabled ?? default(bool); }
            set { this.loggingEnabled = value; }
        }

        // Check to see if LoggingEnabled property is set
        internal bool IsSetLoggingEnabled()
        {
            return this.loggingEnabled.HasValue;
        }

        /// <summary>
        /// The name of the S3 bucket where the log files are stored.
        ///  
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The prefix applied to the log file names.
        ///  
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this.s3KeyPrefix; }
            set { this.s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this.s3KeyPrefix != null;
        }

        /// <summary>
        /// The last time when logs were delivered.
        ///  
        /// </summary>
        public DateTime LastSuccessfulDeliveryTime
        {
            get { return this.lastSuccessfulDeliveryTime ?? default(DateTime); }
            set { this.lastSuccessfulDeliveryTime = value; }
        }

        // Check to see if LastSuccessfulDeliveryTime property is set
        internal bool IsSetLastSuccessfulDeliveryTime()
        {
            return this.lastSuccessfulDeliveryTime.HasValue;
        }

        /// <summary>
        /// The last time when logs failed to be delivered.
        ///  
        /// </summary>
        public DateTime LastFailureTime
        {
            get { return this.lastFailureTime ?? default(DateTime); }
            set { this.lastFailureTime = value; }
        }

        // Check to see if LastFailureTime property is set
        internal bool IsSetLastFailureTime()
        {
            return this.lastFailureTime.HasValue;
        }

        /// <summary>
        /// The message indicating that logs failed to be delivered.
        ///  
        /// </summary>
        public string LastFailureMessage
        {
            get { return this.lastFailureMessage; }
            set { this.lastFailureMessage = value; }
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this.lastFailureMessage != null;
        }
    }
}

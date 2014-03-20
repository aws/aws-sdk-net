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
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrail operation.
    /// <para>From the command line, use <c>update-subscription</c> .</para> <para>Updates the settings that specify delivery of log files. Changes
    /// to a trail do not require stopping the CloudTrail service. Use this action to designate an existing bucket for log delivery. If the existing
    /// bucket has previously been a target for CloudTrail log files, an IAM policy exists for the bucket. </para>
    /// </summary>
    public partial class UpdateTrailRequest : AmazonCloudTrailRequest
    {
        private string name;
        private string s3BucketName;
        private string s3KeyPrefix;
        private string snsTopicName;
        private bool? includeGlobalServiceEvents;


        /// <summary>
        /// Specifies the name of the trail.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Specifies the name of the Amazon S3 bucket designated for publishing log files.
        ///  
        /// </summary>
        public string S3BucketName
        {
            get { return this.s3BucketName; }
            set { this.s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this.s3BucketName != null;
        }

        /// <summary>
        /// Specifies the Amazon S3 key prefix that precedes the name of the bucket you have designated for log file delivery.
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
        /// Specifies the name of the Amazon SNS topic defined for notification of log file delivery.
        ///  
        /// </summary>
        public string SnsTopicName
        {
            get { return this.snsTopicName; }
            set { this.snsTopicName = value; }
        }

        // Check to see if SnsTopicName property is set
        internal bool IsSetSnsTopicName()
        {
            return this.snsTopicName != null;
        }

        /// <summary>
        /// Specifies whether the trail is publishing events from global services such as IAM to the log files.
        ///  
        /// </summary>
        public bool IncludeGlobalServiceEvents
        {
            get { return this.includeGlobalServiceEvents ?? default(bool); }
            set { this.includeGlobalServiceEvents = value; }
        }

        // Check to see if IncludeGlobalServiceEvents property is set
        internal bool IsSetIncludeGlobalServiceEvents()
        {
            return this.includeGlobalServiceEvents.HasValue;
        }

    }
}
    

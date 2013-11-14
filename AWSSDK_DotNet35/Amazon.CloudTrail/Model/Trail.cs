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
    /// <para> The settings for a trail. </para>
    /// </summary>
    public class Trail
    {
        
        private string name;
        private string s3BucketName;
        private string s3KeyPrefix;
        private string snsTopicName;
        private bool? includeGlobalServiceEvents;


        /// <summary>
        /// Name of the trail defined when you call when you call <a>CreateTrail</a>
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
        /// Name of the Amazon S3 bucket into which CloudTrail delivers your trail files. Passed when you call <a>CreateTrail</a>.
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
        /// Value of the Amazon S3 prefix
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
        /// Name of the existing Amazon SNS topic that CloudTrail uses to notify the account owner when new CloudTrail log files have been delivered.
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
        /// Set to <b>True</b> to include AWS API calls from AWS global services such as IAM. Otherwise, <b>False</b>.
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

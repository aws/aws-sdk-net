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
    /// <para> Returns the objects or data listed below if successful. Otherwise, returns an error. </para>
    /// </summary>
    public partial class UpdateTrailResult
    {
        
        private string name;
        private string s3BucketName;
        private string s3KeyPrefix;
        private string snsTopicName;
        private bool? includeGlobalServiceEvents;
        private Trail trail;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateTrailResult WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }
        public string S3BucketName
        {
            get { return this.s3BucketName; }
            set { this.s3BucketName = value; }
        }

        /// <summary>
        /// Sets the S3BucketName property
        /// </summary>
        /// <param name="s3BucketName">The value to set for the S3BucketName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateTrailResult WithS3BucketName(string s3BucketName)
        {
            this.s3BucketName = s3BucketName;
            return this;
        }
            

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this.s3BucketName != null;
        }
        public string S3KeyPrefix
        {
            get { return this.s3KeyPrefix; }
            set { this.s3KeyPrefix = value; }
        }

        /// <summary>
        /// Sets the S3KeyPrefix property
        /// </summary>
        /// <param name="s3KeyPrefix">The value to set for the S3KeyPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateTrailResult WithS3KeyPrefix(string s3KeyPrefix)
        {
            this.s3KeyPrefix = s3KeyPrefix;
            return this;
        }
            

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this.s3KeyPrefix != null;
        }
        public string SnsTopicName
        {
            get { return this.snsTopicName; }
            set { this.snsTopicName = value; }
        }

        /// <summary>
        /// Sets the SnsTopicName property
        /// </summary>
        /// <param name="snsTopicName">The value to set for the SnsTopicName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateTrailResult WithSnsTopicName(string snsTopicName)
        {
            this.snsTopicName = snsTopicName;
            return this;
        }
            

        // Check to see if SnsTopicName property is set
        internal bool IsSetSnsTopicName()
        {
            return this.snsTopicName != null;
        }
        public bool IncludeGlobalServiceEvents
        {
            get { return this.includeGlobalServiceEvents ?? default(bool); }
            set { this.includeGlobalServiceEvents = value; }
        }

        /// <summary>
        /// Sets the IncludeGlobalServiceEvents property
        /// </summary>
        /// <param name="includeGlobalServiceEvents">The value to set for the IncludeGlobalServiceEvents property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateTrailResult WithIncludeGlobalServiceEvents(bool includeGlobalServiceEvents)
        {
            this.includeGlobalServiceEvents = includeGlobalServiceEvents;
            return this;
        }
            

        // Check to see if IncludeGlobalServiceEvents property is set
        internal bool IsSetIncludeGlobalServiceEvents()
        {
            return this.includeGlobalServiceEvents.HasValue;
        }

        /// <summary>
        /// Represents the CloudTrail settings that were updated by calling <a>UpdateTrail</a>.
        ///  
        /// </summary>
        public Trail Trail
        {
            get { return this.trail; }
            set { this.trail = value; }
        }

        /// <summary>
        /// Sets the Trail property
        /// </summary>
        /// <param name="trail">The value to set for the Trail property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateTrailResult WithTrail(Trail trail)
        {
            this.trail = trail;
            return this;
        }
            

        // Check to see if Trail property is set
        internal bool IsSetTrail()
        {
            return this.trail != null;
        }
    }
}

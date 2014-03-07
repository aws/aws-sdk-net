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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para>The <c>AccessLog</c> data type.</para>
    /// </summary>
    public partial class AccessLog
    {
        
        private bool? enabled;
        private string s3BucketName;
        private int? emitInterval;
        private string s3BucketPrefix;

        /// <summary>
        /// Specifies whether access log is enabled for the load balancer.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessLog WithEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
        }
            

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }

        /// <summary>
        /// The name of the Amazon S3 bucket where the access logs are stored.
        ///  
        /// </summary>
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
        public AccessLog WithS3BucketName(string s3BucketName)
        {
            this.s3BucketName = s3BucketName;
            return this;
        }
            

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this.s3BucketName != null;
        }

        /// <summary>
        /// The interval for publishing the access logs. You can specify an interval of either 5 minutes or 60 minutes. Default: 60 minutes
        ///  
        /// </summary>
        public int EmitInterval
        {
            get { return this.emitInterval ?? default(int); }
            set { this.emitInterval = value; }
        }

        /// <summary>
        /// Sets the EmitInterval property
        /// </summary>
        /// <param name="emitInterval">The value to set for the EmitInterval property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessLog WithEmitInterval(int emitInterval)
        {
            this.emitInterval = emitInterval;
            return this;
        }
            

        // Check to see if EmitInterval property is set
        internal bool IsSetEmitInterval()
        {
            return this.emitInterval.HasValue;
        }

        /// <summary>
        /// The logical hierarchy you created for your Amazon S3 bucket, for example <c>/my-bucket-prefix/prod</c>. If the prefix is not provided, the
        /// log is placed at the root level of the bucket.
        ///  
        /// </summary>
        public string S3BucketPrefix
        {
            get { return this.s3BucketPrefix; }
            set { this.s3BucketPrefix = value; }
        }

        /// <summary>
        /// Sets the S3BucketPrefix property
        /// </summary>
        /// <param name="s3BucketPrefix">The value to set for the S3BucketPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessLog WithS3BucketPrefix(string s3BucketPrefix)
        {
            this.s3BucketPrefix = s3BucketPrefix;
            return this;
        }
            

        // Check to see if S3BucketPrefix property is set
        internal bool IsSetS3BucketPrefix()
        {
            return this.s3BucketPrefix != null;
        }
    }
}

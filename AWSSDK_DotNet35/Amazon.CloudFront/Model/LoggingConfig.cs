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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A complex type that controls whether access logs are written for the distribution. </para>
    /// </summary>
    public class LoggingConfig
    {
        
        private bool? enabled;
        private bool? includeCookies;
        private string bucket;
        private string prefix;

        /// <summary>
        /// Specifies whether you want CloudFront to save access logs to an Amazon S3 bucket. If you do not want to enable logging when you create a
        /// distribution or if you want to disable logging for an existing distribution, specify false for Enabled, and specify empty Bucket and Prefix
        /// elements. If you specify false for Enabled but you specify values for Bucket, prefix and IncludeCookies, the values are automatically
        /// deleted.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }

        /// <summary>
        /// Specifies whether you want CloudFront to include cookies in access logs, specify true for IncludeCookies. If you choose to include cookies
        /// in logs, CloudFront logs all cookies regardless of how you configure the cache behaviors for this distribution. If you do not want to
        /// include cookies when you create a distribution or if you want to disable include cookies for an existing distribution, specify false for
        /// IncludeCookies.
        ///  
        /// </summary>
        public bool IncludeCookies
        {
            get { return this.includeCookies ?? default(bool); }
            set { this.includeCookies = value; }
        }

        // Check to see if IncludeCookies property is set
        internal bool IsSetIncludeCookies()
        {
            return this.includeCookies.HasValue;
        }

        /// <summary>
        /// The Amazon S3 bucket to store the access logs in, for example, myawslogbucket.s3.amazonaws.com.
        ///  
        /// </summary>
        public string Bucket
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this.bucket != null;
        }

        /// <summary>
        /// An optional string that you want CloudFront to prefix to the access log filenames for this distribution, for example, myprefix/. If you want
        /// to enable logging, but you do not want to specify a prefix, you still must include an empty Prefix element in the Logging element.
        ///  
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }
    }
}

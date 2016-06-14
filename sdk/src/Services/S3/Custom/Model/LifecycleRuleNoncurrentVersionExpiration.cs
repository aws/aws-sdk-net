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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Noncurrent Version Expiration
    /// </summary>
    public class LifecycleRuleNoncurrentVersionExpiration
    {
        private int? noncurrentDays;

        /// <summary>
        /// Specifies the number of days an object is noncurrent before Amazon S3 can perform the associated 
        /// action. For information about the noncurrent days calculations, see 
        /// <a href=\"http://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html\">How Amazon S3 Calculates When an Object Became Noncurrent</a> 
        /// in the Amazon Simple Storage Service Developer Guide.
        /// </summary>
        public int NoncurrentDays
        {
            get { return this.noncurrentDays ?? default(int); }
            set { this.noncurrentDays = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetNoncurrentDays()
        {
            return this.noncurrentDays.HasValue;
        }
    }

}

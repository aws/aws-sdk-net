/*
 * Copyright 2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>Bucket
    /// Represents a set of filter criteria that limits the objects that can trigger event notifications
    /// </summary>
    public class Filter
    {
        private S3KeyFilter s3KeyFilter;

        /// <summary>
        /// Filter criteria that limits the objects that can trigger event notifications based on their S3 Key name.
        ///  
        /// </summary>
        public S3KeyFilter S3KeyFilter
        {
            get { return this.s3KeyFilter; }
            set { this.s3KeyFilter = value; }
        }

        // Check to see if S3KeyFilter property is set
        internal bool IsSetS3KeyFilter()
        {
            return this.s3KeyFilter != null;
        }
    }
}

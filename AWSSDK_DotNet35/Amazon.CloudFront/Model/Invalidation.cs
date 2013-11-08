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
    /// <para> An invalidation. </para>
    /// </summary>
    public class Invalidation
    {
        
        private string id;
        private string status;
        private DateTime? createTime;
        private InvalidationBatch invalidationBatch;

        /// <summary>
        /// The identifier for the invalidation request. For example: IDFDVBD632BHDS5.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The status of the invalidation request. When the invalidation batch is finished, the status is Completed.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The date and time the invalidation request was first made.
        ///  
        /// </summary>
        public DateTime CreateTime
        {
            get { return this.createTime ?? default(DateTime); }
            set { this.createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this.createTime.HasValue;
        }

        /// <summary>
        /// The current invalidation information for the batch request.
        ///  
        /// </summary>
        public InvalidationBatch InvalidationBatch
        {
            get { return this.invalidationBatch; }
            set { this.invalidationBatch = value; }
        }

        // Check to see if InvalidationBatch property is set
        internal bool IsSetInvalidationBatch()
        {
            return this.invalidationBatch != null;
        }
    }
}

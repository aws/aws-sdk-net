/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>
    /// Container for the expiration for the lifecycle of the object.
    /// </para>
    /// <para>
    /// For more information see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public class LifecycleRuleExpiration
    {
        private DateTime? date;
        private int? days;
        private bool? expiredObjectDeleteMarker;

        /// <summary>
        /// Indicates at what date the object is to be moved or deleted. The date value must conform
        /// to the ISO 8601 format. The time is always midnight UTC.
        /// </summary>
        public DateTime? Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this.date.HasValue;
        }

        /// <summary>
        /// Indicates the lifetime, in days, of the objects that are subject to the rule. The value must be a non-zero positive integer.
        ///  
        /// </summary>
        public int? Days
        {
            get { return this.days; }
            set { this.days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this.days.HasValue;
        }


        /// <summary>
        /// Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set to true, the delete marker will be expired; if set to false the policy takes no action. This cannot be specified with Days or Date in a Lifecycle Expiration Policy.
        ///  
        /// </summary>
        public bool? ExpiredObjectDeleteMarker
        {
            get { return this.expiredObjectDeleteMarker; }
            set { this.expiredObjectDeleteMarker = value; }
        }

        // Check to see if ExpiredObjectDeleteMarker property is set
        internal bool IsSetExpiredObjectDeleteMarker()
        {
            return this.expiredObjectDeleteMarker.HasValue;
        }

    }
}

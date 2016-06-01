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
    /// <summary>Expiration
    /// </summary>
    public class LifecycleRuleExpiration
    {
        private DateTime? date;
        private int? days;
        private bool? expiredObjectDeleteMarker;

        /// <summary>
        /// Indicates at what date the object is to be moved or deleted. Should be in GMT ISO 8601 Format.
        ///  
        /// </summary>
        public DateTime Date
        {
            get { return this.date ?? default(DateTime); }
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
        public int Days
        {
            get { return this.days ?? default(int); }
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
        public bool ExpiredObjectDeleteMarker
        {
            get { return this.expiredObjectDeleteMarker.GetValueOrDefault(); }
            set { this.expiredObjectDeleteMarker = value; }
        }

        // Check to see if ExpiredObjectDeleteMarker property is set
        internal bool IsSetExpiredObjectDeleteMarker()
        {
            return this.expiredObjectDeleteMarker.HasValue;
        }

    }
}

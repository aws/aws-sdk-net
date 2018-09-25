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
    /// LifecycleTransition defines when and how objects transition.
    /// </summary>
    public class LifecycleTransition
    {

        private DateTime? date;
        private DateTime? dateUtc;
        private int? days;
        private S3StorageClass storageClass;

        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. Use DateUtc instead.", false)]
        public DateTime Date
        {
            get { return this.date ?? default(DateTime); }
            set
            {
                this.date = value;
                this.dateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// Indicates at what date the object is to be moved or deleted. Should be in GMT ISO 8601 Format.
        ///  
        /// </summary>
        public DateTime DateUtc
        {
            get { return this.dateUtc ?? default(DateTime); }
            set { this.dateUtc = this.date = value; }
        }

        // Check to see if DateUtc property is set
        internal bool IsSetDateUtc()
        {
            return this.dateUtc.HasValue;
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
        /// The class of storage used to store the object.
        ///  
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }
    }
}

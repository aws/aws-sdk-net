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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A rule for when objects transition to specific storage classes.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails
    {
        private string _date;
        private int? _days;
        private string _storageClass;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// A date on which to transition objects to the specified storage class. If you provide
        /// <code>Date</code>, you cannot provide <code>Days</code>.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date != null;
        }

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// The number of days after which to transition the object to the specified storage class.
        /// If you provide <code>Days</code>, you cannot provide <code>Date</code>.
        /// </para>
        /// </summary>
        public int Days
        {
            get { return this._days.GetValueOrDefault(); }
            set { this._days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this._days.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class to transition the object to. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DEEP_ARCHIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GLACIER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INTELLIGENT_TIERING</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ONEZONE_IA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STANDARD_IA</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}
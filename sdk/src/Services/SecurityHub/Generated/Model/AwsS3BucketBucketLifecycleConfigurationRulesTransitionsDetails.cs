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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// <c>Date</c>, you cannot provide <c>Days</c>.
        /// </para>
        ///  
        /// <para>
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
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
        /// If you provide <c>Days</c>, you cannot provide <c>Date</c>.
        /// </para>
        /// </summary>
        public int? Days
        {
            get { return this._days; }
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
        ///  <c>DEEP_ARCHIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GLACIER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTELLIGENT_TIERING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONEZONE_IA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD_IA</c> 
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
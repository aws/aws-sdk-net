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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies when an object transitions to a specified storage class. For more information
    /// about Amazon S3 lifecycle configuration rules, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-transition-general-considerations.html">Transitioning
    /// Objects Using Amazon S3 Lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class LifecycleTransition
    {
        private DateTime? _date;
        private int? _days;
        private S3StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// Indicates when objects are transitioned to the specified storage class. The date value
        /// must be in ISO 8601 format. The time is always midnight UTC.
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// Indicates the number of days after creation when objects are transitioned to the specified
        /// storage class. If the specified storage class is <c>INTELLIGENT_TIERING</c>, <c>GLACIER_IR</c>,
        /// <c>GLACIER</c>, or <c>DEEP_ARCHIVE</c>, valid values are <c>0</c> or positive integers.
        /// If the specified storage class is <c>STANDARD_IA</c> or <c>ONEZONE_IA</c>, valid values
        /// are positive integers greater than <c>30</c>. Be aware that some storage classes have
        /// a minimum storage duration and that you're charged for transitioning objects before
        /// their minimum storage duration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/lifecycle-transition-general-considerations.html#lifecycle-configuration-constraints">
        /// Constraints and considerations for transitions</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The storage class to which you want the object to transition.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass
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
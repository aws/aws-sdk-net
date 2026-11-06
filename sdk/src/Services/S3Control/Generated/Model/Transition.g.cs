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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Specifies when an object transitions to a specified storage class. For more information
    /// about Amazon S3 Lifecycle configuration rules, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-transition-general-considerations.html">
    /// Transitioning objects using Amazon S3 Lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class Transition
    {
        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// Indicates when objects are transitioned to the specified storage class. The date value
        /// must be in ISO 8601 format. The time is always midnight UTC.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// Indicates the number of days after creation when objects are transitioned to the specified
        /// storage class. The value must be a positive integer.
        /// </para>
        /// </summary>
        public int? Days { get; set; }

        /// <summary>
        /// Checks to see if the Days property is set.
        /// </summary>
        internal bool IsSetDays() => this.Days.HasValue;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class to which you want the object to transition.
        /// </para>
        /// </summary>
        public TransitionStorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}

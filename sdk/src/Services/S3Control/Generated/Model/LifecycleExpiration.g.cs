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
    /// The container of the Outposts bucket lifecycle expiration.
    /// </summary>
    public partial class LifecycleExpiration
    {
        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// Indicates at what date the object is to be deleted. Should be in GMT ISO 8601 format.
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
        /// Indicates the lifetime, in days, of the objects that are subject to the rule. The
        /// value must be a non-zero positive integer.
        /// </para>
        /// </summary>
        public int? Days { get; set; }

        /// <summary>
        /// Checks to see if the Days property is set.
        /// </summary>
        internal bool IsSetDays() => this.Days.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiredObjectDeleteMarker. 
        /// <para>
        /// Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions.
        /// If set to true, the delete marker will be expired. If set to false, the policy takes
        /// no action. This cannot be specified with Days or Date in a Lifecycle Expiration Policy.
        /// To learn more about delete markers, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeleteMarker.html">Working
        /// with delete markers</a>.
        /// </para>
        /// </summary>
        public bool? ExpiredObjectDeleteMarker { get; set; }

        /// <summary>
        /// Checks to see if the ExpiredObjectDeleteMarker property is set.
        /// </summary>
        internal bool IsSetExpiredObjectDeleteMarker() => this.ExpiredObjectDeleteMarker.HasValue;
    }
}

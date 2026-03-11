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
    /// The S3 Intelligent-Tiering storage class is designed to optimize storage costs by
    /// automatically moving data to the most cost-effective storage access tier, without
    /// additional operational overhead.
    /// </summary>
    public partial class Tiering
    {
        private IntelligentTieringAccessTier _accessTier;
        private int? _days;

        /// <summary>
        /// Gets and sets the property AccessTier. 
        /// <para>
        /// S3 Intelligent-Tiering access tier. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html#sc-dynamic-data-access">Storage
        /// class for automatically optimizing frequently and infrequently accessed objects</a>
        /// for a list of access tiers in the S3 Intelligent-Tiering storage class.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntelligentTieringAccessTier AccessTier
        {
            get { return this._accessTier; }
            set { this._accessTier = value; }
        }

        // Check to see if AccessTier property is set
        internal bool IsSetAccessTier()
        {
            return this._accessTier != null;
        }

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// The number of consecutive days of no access after which an object will be eligible
        /// to be transitioned to the corresponding tier. The minimum number of days specified
        /// for Archive Access tier must be at least 90 days and Deep Archive Access tier must
        /// be at least 180 days. The maximum can be up to 2 years (730 days).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}
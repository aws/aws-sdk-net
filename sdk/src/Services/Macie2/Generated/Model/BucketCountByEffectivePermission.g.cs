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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the number of S3 buckets that are publicly accessible due
    /// to a combination of permissions settings for each bucket.
    /// </summary>
    public partial class BucketCountByEffectivePermission
    {
        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// The total number of buckets that allow the general public to have read or write access
        /// to the bucket.
        /// </para>
        /// </summary>
        public long? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyReadable. 
        /// <para>
        /// The total number of buckets that allow the general public to have read access to the
        /// bucket.
        /// </para>
        /// </summary>
        public long? PubliclyReadable { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyReadable property is set.
        /// </summary>
        internal bool IsSetPubliclyReadable() => this.PubliclyReadable.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyWritable. 
        /// <para>
        /// The total number of buckets that allow the general public to have write access to
        /// the bucket.
        /// </para>
        /// </summary>
        public long? PubliclyWritable { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyWritable property is set.
        /// </summary>
        internal bool IsSetPubliclyWritable() => this.PubliclyWritable.HasValue;

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The total number of buckets that Amazon Macie wasn't able to evaluate permissions
        /// settings for. For example, the buckets' policies or a quota prevented Macie from retrieving
        /// the requisite data. Macie can't determine whether the buckets are publicly accessible.
        /// </para>
        /// </summary>
        public long? Unknown { get; set; }

        /// <summary>
        /// Checks to see if the Unknown property is set.
        /// </summary>
        internal bool IsSetUnknown() => this.Unknown.HasValue;
    }
}

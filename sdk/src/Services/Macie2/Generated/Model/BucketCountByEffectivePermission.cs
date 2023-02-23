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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the number of S3 buckets that are publicly accessible due
    /// to a combination of permissions settings for each bucket.
    /// </summary>
    public partial class BucketCountByEffectivePermission
    {
        private long? _publiclyAccessible;
        private long? _publiclyReadable;
        private long? _publiclyWritable;
        private long? _unknown;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// The total number of buckets that allow the general public to have read or write access
        /// to the bucket.
        /// </para>
        /// </summary>
        public long PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyReadable. 
        /// <para>
        /// The total number of buckets that allow the general public to have read access to the
        /// bucket.
        /// </para>
        /// </summary>
        public long PubliclyReadable
        {
            get { return this._publiclyReadable.GetValueOrDefault(); }
            set { this._publiclyReadable = value; }
        }

        // Check to see if PubliclyReadable property is set
        internal bool IsSetPubliclyReadable()
        {
            return this._publiclyReadable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyWritable. 
        /// <para>
        /// The total number of buckets that allow the general public to have write access to
        /// the bucket.
        /// </para>
        /// </summary>
        public long PubliclyWritable
        {
            get { return this._publiclyWritable.GetValueOrDefault(); }
            set { this._publiclyWritable = value; }
        }

        // Check to see if PubliclyWritable property is set
        internal bool IsSetPubliclyWritable()
        {
            return this._publiclyWritable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The total number of buckets that Amazon Macie wasn't able to evaluate permissions
        /// settings for. Macie can't determine whether these buckets are publicly accessible.
        /// </para>
        /// </summary>
        public long Unknown
        {
            get { return this._unknown.GetValueOrDefault(); }
            set { this._unknown = value; }
        }

        // Check to see if Unknown property is set
        internal bool IsSetUnknown()
        {
            return this._unknown.HasValue; 
        }

    }
}
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
    /// Provides information about the number of S3 buckets that are or aren't shared with
    /// other Amazon Web Services accounts, Amazon CloudFront origin access identities (OAIs),
    /// or CloudFront origin access controls (OACs). In this data, an <i>Amazon Macie organization</i>
    /// is defined as a set of Macie accounts that are centrally managed as a group of related
    /// accounts through Organizations or by Macie invitation.
    /// </summary>
    public partial class BucketCountBySharedAccessType
    {
        private long? _external;
        private long? _internal;
        private long? _notShared;
        private long? _unknown;

        /// <summary>
        /// Gets and sets the property External. 
        /// <para>
        /// The total number of buckets that are shared with one or more of the following or any
        /// combination of the following: an Amazon CloudFront OAI, a CloudFront OAC, or an Amazon
        /// Web Services account that isn't in the same Amazon Macie organization.
        /// </para>
        /// </summary>
        public long External
        {
            get { return this._external.GetValueOrDefault(); }
            set { this._external = value; }
        }

        // Check to see if External property is set
        internal bool IsSetExternal()
        {
            return this._external.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Internal. 
        /// <para>
        /// The total number of buckets that are shared with one or more Amazon Web Services accounts
        /// in the same Amazon Macie organization. These buckets aren't shared with Amazon CloudFront
        /// OAIs or OACs.
        /// </para>
        /// </summary>
        public long Internal
        {
            get { return this._internal.GetValueOrDefault(); }
            set { this._internal = value; }
        }

        // Check to see if Internal property is set
        internal bool IsSetInternal()
        {
            return this._internal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotShared. 
        /// <para>
        /// The total number of buckets that aren't shared with other Amazon Web Services accounts,
        /// Amazon CloudFront OAIs, or CloudFront OACs.
        /// </para>
        /// </summary>
        public long NotShared
        {
            get { return this._notShared.GetValueOrDefault(); }
            set { this._notShared = value; }
        }

        // Check to see if NotShared property is set
        internal bool IsSetNotShared()
        {
            return this._notShared.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The total number of buckets that Amazon Macie wasn't able to evaluate shared access
        /// settings for. Macie can't determine whether these buckets are shared with other Amazon
        /// Web Services accounts, Amazon CloudFront OAIs, or CloudFront OACs.
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
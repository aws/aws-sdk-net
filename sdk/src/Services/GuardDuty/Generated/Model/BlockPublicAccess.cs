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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information on how the bucker owner's S3 Block Public Access settings are
    /// being applied to the S3 bucket. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">S3
    /// Block Public Access</a> for more information.
    /// </summary>
    public partial class BlockPublicAccess
    {
        private bool? _blockPublicAcls;
        private bool? _blockPublicPolicy;
        private bool? _ignorePublicAcls;
        private bool? _restrictPublicBuckets;

        /// <summary>
        /// Gets and sets the property BlockPublicAcls. 
        /// <para>
        /// Indicates if S3 Block Public Access is set to <code>BlockPublicAcls</code>.
        /// </para>
        /// </summary>
        public bool BlockPublicAcls
        {
            get { return this._blockPublicAcls.GetValueOrDefault(); }
            set { this._blockPublicAcls = value; }
        }

        // Check to see if BlockPublicAcls property is set
        internal bool IsSetBlockPublicAcls()
        {
            return this._blockPublicAcls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlockPublicPolicy. 
        /// <para>
        /// Indicates if S3 Block Public Access is set to <code>BlockPublicPolicy</code>.
        /// </para>
        /// </summary>
        public bool BlockPublicPolicy
        {
            get { return this._blockPublicPolicy.GetValueOrDefault(); }
            set { this._blockPublicPolicy = value; }
        }

        // Check to see if BlockPublicPolicy property is set
        internal bool IsSetBlockPublicPolicy()
        {
            return this._blockPublicPolicy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnorePublicAcls. 
        /// <para>
        /// Indicates if S3 Block Public Access is set to <code>IgnorePublicAcls</code>.
        /// </para>
        /// </summary>
        public bool IgnorePublicAcls
        {
            get { return this._ignorePublicAcls.GetValueOrDefault(); }
            set { this._ignorePublicAcls = value; }
        }

        // Check to see if IgnorePublicAcls property is set
        internal bool IsSetIgnorePublicAcls()
        {
            return this._ignorePublicAcls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestrictPublicBuckets. 
        /// <para>
        /// Indicates if S3 Block Public Access is set to <code>RestrictPublicBuckets</code>.
        /// </para>
        /// </summary>
        public bool RestrictPublicBuckets
        {
            get { return this._restrictPublicBuckets.GetValueOrDefault(); }
            set { this._restrictPublicBuckets = value; }
        }

        // Check to see if RestrictPublicBuckets property is set
        internal bool IsSetRestrictPublicBuckets()
        {
            return this._restrictPublicBuckets.HasValue; 
        }

    }
}
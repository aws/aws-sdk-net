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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a POST Object restore job. S3 Batch Operations
    /// passes every object to the underlying <code>RestoreObject</code> API operation. For
    /// more information about the parameters for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectPOSTrestore.html#RESTObjectPOSTrestore-restore-request">RestoreObject</a>.
    /// </summary>
    public partial class S3InitiateRestoreObjectOperation
    {
        private int? _expirationInDays;
        private S3GlacierJobTier _glacierJobTier;

        /// <summary>
        /// Gets and sets the property ExpirationInDays. 
        /// <para>
        /// This argument specifies how long the S3 Glacier or S3 Glacier Deep Archive object
        /// remains available in Amazon S3. S3 Initiate Restore Object jobs that target S3 Glacier
        /// and S3 Glacier Deep Archive objects require <code>ExpirationInDays</code> set to 1
        /// or greater.
        /// </para>
        ///  
        /// <para>
        /// Conversely, do <i>not</i> set <code>ExpirationInDays</code> when creating S3 Initiate
        /// Restore Object jobs that target S3 Intelligent-Tiering Archive Access and Deep Archive
        /// Access tier objects. Objects in S3 Intelligent-Tiering archive access tiers are not
        /// subject to restore expiry, so specifying <code>ExpirationInDays</code> results in
        /// restore request failure.
        /// </para>
        ///  
        /// <para>
        /// S3 Batch Operations jobs can operate either on S3 Glacier and S3 Glacier Deep Archive
        /// storage class objects or on S3 Intelligent-Tiering Archive Access and Deep Archive
        /// Access storage tier objects, but not both types in the same job. If you need to restore
        /// objects of both types you <i>must</i> create separate Batch Operations jobs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ExpirationInDays
        {
            get { return this._expirationInDays.GetValueOrDefault(); }
            set { this._expirationInDays = value; }
        }

        // Check to see if ExpirationInDays property is set
        internal bool IsSetExpirationInDays()
        {
            return this._expirationInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlacierJobTier. 
        /// <para>
        /// S3 Batch Operations supports <code>STANDARD</code> and <code>BULK</code> retrieval
        /// tiers, but not the <code>EXPEDITED</code> retrieval tier.
        /// </para>
        /// </summary>
        public S3GlacierJobTier GlacierJobTier
        {
            get { return this._glacierJobTier; }
            set { this._glacierJobTier = value; }
        }

        // Check to see if GlacierJobTier property is set
        internal bool IsSetGlacierJobTier()
        {
            return this._glacierJobTier != null;
        }

    }
}
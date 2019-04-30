/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for an Initiate Glacier Restore job. Amazon
    /// S3 batch operations passes each value through to the underlying POST Object restore
    /// API. For more information about the parameters for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectPOSTrestore.html#RESTObjectPOSTrestore-restore-request">Restoring
    /// Archives</a>.
    /// </summary>
    public partial class S3InitiateRestoreObjectOperation
    {
        private int? _expirationInDays;
        private S3GlacierJobTier _glacierJobTier;

        /// <summary>
        /// Gets and sets the property ExpirationInDays.
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
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The details of an AWS S3 Bucket.
    /// </summary>
    public partial class AwsS3BucketDetails
    {
        private string _ownerId;
        private string _ownerName;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The canonical user ID of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerName. 
        /// <para>
        /// The display name of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerName
        {
            get { return this._ownerName; }
            set { this._ownerName = value; }
        }

        // Check to see if OwnerName property is set
        internal bool IsSetOwnerName()
        {
            return this._ownerName != null;
        }

    }
}
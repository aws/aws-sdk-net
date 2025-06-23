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
    /// This is the response object from the GetBucketOwnershipControls operation.
    /// </summary>
    public partial class GetBucketOwnershipControlsResponse : AmazonWebServiceResponse
    {
        private OwnershipControls _ownershipControls;

        /// <summary>
        /// Gets and sets the property OwnershipControls. 
        /// <para>
        /// The <c>OwnershipControls</c> (BucketOwnerEnforced, BucketOwnerPreferred, or ObjectWriter)
        /// currently in effect for this Amazon S3 bucket.
        /// </para>
        /// </summary>
        public OwnershipControls OwnershipControls
        {
            get { return this._ownershipControls; }
            set { this._ownershipControls = value; }
        }

        // Check to see if OwnershipControls property is set
        internal bool IsSetOwnershipControls()
        {
            return this._ownershipControls != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
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
namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// This is the response object from the GetVectorBucket operation.
    /// </summary>
    public partial class GetVectorBucketResponse : AmazonWebServiceResponse
    {
        private VectorBucket _vectorBucket;

        /// <summary>
        /// Gets and sets the property VectorBucket. 
        /// <para>
        /// The attributes of the vector bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorBucket VectorBucket
        {
            get { return this._vectorBucket; }
            set { this._vectorBucket = value; }
        }

        // Check to see if VectorBucket property is set
        internal bool IsSetVectorBucket()
        {
            return this._vectorBucket != null;
        }

    }
}
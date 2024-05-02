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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The container for the regional bucket.
    /// </summary>
    public partial class RegionalBucket
    {
        private string _bucket;
        private string _bucketArn;
        private DateTime? _creationDate;
        private string _outpostId;
        private bool? _publicAccessBlockEnabled;

        /// <summary>
        /// Gets and sets the property Bucket.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the regional bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=128)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the regional bucket
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The Outposts ID of the regional bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlockEnabled.
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PublicAccessBlockEnabled
        {
            get { return this._publicAccessBlockEnabled; }
            set { this._publicAccessBlockEnabled = value; }
        }

        // Check to see if PublicAccessBlockEnabled property is set
        internal bool IsSetPublicAccessBlockEnabled()
        {
            return this._publicAccessBlockEnabled.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBucket operation.
    /// Deletes a Amazon Lightsail bucket.
    /// 
    ///  <note> 
    /// <para>
    /// When you delete your bucket, the bucket name is released and can be reused for a new
    /// bucket in your account or another Amazon Web Services account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteBucketRequest : AmazonLightsailRequest
    {
        private string _bucketName;
        private bool? _forceDelete;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to delete.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBuckets.html">GetBuckets</a>
        /// action to get a list of bucket names that you can specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=54)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// A Boolean value that indicates whether to force delete the bucket.
        /// </para>
        ///  
        /// <para>
        /// You must force delete the bucket if it has one of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The bucket is the origin of a distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket has instances that were granted access to it using the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_SetResourceAccessForBucket.html">SetResourceAccessForBucket</a>
        /// action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket has objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket has access keys.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Force deleting a bucket might impact other resources that rely on the bucket, such
        /// as instances, distributions, or software that use the issued access keys.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? ForceDelete
        {
            get { return this._forceDelete; }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

    }
}
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
    /// The container for the bucket configuration.
    /// 
    ///  <note> 
    /// <para>
    /// This is not supported by Amazon S3 on Outposts buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateBucketConfiguration
    {
        private BucketLocationConstraint _locationConstraint;

        /// <summary>
        /// Gets and sets the property LocationConstraint. 
        /// <para>
        /// Specifies the Region where the bucket will be created. If you are creating a bucket
        /// on the US East (N. Virginia) Region (us-east-1), you do not need to specify the location.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public BucketLocationConstraint LocationConstraint
        {
            get { return this._locationConstraint; }
            set { this._locationConstraint = value; }
        }

        // Check to see if LocationConstraint property is set
        internal bool IsSetLocationConstraint()
        {
            return this._locationConstraint != null;
        }

    }
}
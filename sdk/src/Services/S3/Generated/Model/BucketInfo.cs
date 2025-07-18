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
    /// Specifies the information about the bucket that will be created. For more information
    /// about directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Directory
    /// buckets</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// This functionality is only supported by directory buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BucketInfo
    {
        private DataRedundancy _dataRedundancy;
        private BucketType _type;

        /// <summary>
        /// Gets and sets the property DataRedundancy. 
        /// <para>
        /// The number of Zone (Availability Zone or Local Zone) that's used for redundancy for
        /// the bucket.
        /// </para>
        /// </summary>
        public DataRedundancy DataRedundancy
        {
            get { return this._dataRedundancy; }
            set { this._dataRedundancy = value; }
        }

        // Check to see if DataRedundancy property is set
        internal bool IsSetDataRedundancy()
        {
            return this._dataRedundancy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of bucket.
        /// </para>
        /// </summary>
        public BucketType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLocationS3 operation.
    /// Modifies the following configuration parameters of the Amazon S3 transfer location
    /// that you're using with DataSync.
    /// 
    ///  <important> 
    /// <para>
    /// Before you begin, make sure that you read the following topics:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
    /// class considerations with Amazon S3 locations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
    /// S3 request costs when using DataSync</a> 
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class UpdateLocationS3Request : AmazonDataSyncRequest
    {
        private string _locationArn;
        private S3Config _s3Config;
        private S3StorageClass _s3StorageClass;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the Amazon S3 transfer location that you're
        /// updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Config.
        /// </summary>
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property S3StorageClass. 
        /// <para>
        /// Specifies the storage class that you want your objects to use when Amazon S3 is a
        /// transfer destination.
        /// </para>
        ///  
        /// <para>
        /// For buckets in Amazon Web Services Regions, the storage class defaults to <c>STANDARD</c>.
        /// For buckets on Outposts, the storage class defaults to <c>OUTPOSTS</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 transfers</a>.
        /// </para>
        /// </summary>
        public S3StorageClass S3StorageClass
        {
            get { return this._s3StorageClass; }
            set { this._s3StorageClass = value; }
        }

        // Check to see if S3StorageClass property is set
        internal bool IsSetS3StorageClass()
        {
            return this._s3StorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a prefix in the S3 bucket that DataSync reads from or writes to (depending
        /// on whether the bucket is a source or destination location).
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync can't transfer objects with a prefix that begins with a slash (<c>/</c>)
        /// or includes <c>//</c>, <c>/./</c>, or <c>/../</c> patterns. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>/photos</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>photos//2006/January</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>photos/./2006/February</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>photos/../2006/March</c> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

    }
}
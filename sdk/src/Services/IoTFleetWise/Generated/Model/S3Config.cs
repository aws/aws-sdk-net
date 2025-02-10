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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The Amazon S3 bucket where the Amazon Web Services IoT FleetWise campaign sends data.
    /// Amazon S3 is an object storage service that stores data as objects within buckets.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/creating-buckets-s3.html">Creating,
    /// configuring, and working with Amazon S3 buckets</a> in the <i>Amazon Simple Storage
    /// Service User Guide</i>.
    /// </summary>
    public partial class S3Config
    {
        private string _bucketArn;
        private DataFormat _dataFormat;
        private string _prefix;
        private StorageCompressionFormat _storageCompressionFormat;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=100)]
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
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// Specify the format that files are saved in the Amazon S3 bucket. You can save files
        /// in an Apache Parquet or JSON format.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Parquet - Store data in a columnar storage file format. Parquet is optimal for fast
        /// data retrieval and can reduce costs. This option is selected by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// JSON - Store data in a standard text-based JSON file format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Enter an S3 bucket prefix. The prefix is the string of characters after the bucket
        /// name and before the object name. You can use the prefix to organize data stored in
        /// Amazon S3 buckets. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-prefixes.html">Organizing
        /// objects using prefixes</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon Web Services IoT FleetWise sets the prefix <c>processed-data/year=YY/month=MM/date=DD/hour=HH/</c>
        /// (in UTC) to data it delivers to Amazon S3. You can enter a prefix to append it to
        /// this default prefix. For example, if you enter the prefix <c>vehicles</c>, the prefix
        /// will be <c>vehicles/processed-data/year=YY/month=MM/date=DD/hour=HH/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property StorageCompressionFormat. 
        /// <para>
        /// By default, stored data is compressed as a .gzip file. Compressed files have a reduced
        /// file size, which can optimize the cost of data storage.
        /// </para>
        /// </summary>
        public StorageCompressionFormat StorageCompressionFormat
        {
            get { return this._storageCompressionFormat; }
            set { this._storageCompressionFormat = value; }
        }

        // Check to see if StorageCompressionFormat property is set
        internal bool IsSetStorageCompressionFormat()
        {
            return this._storageCompressionFormat != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the destination Amazon Simple Storage Service (Amazon S3) bucket name and
    /// object keys of a recommendations export file, and its associated metadata file.
    /// </summary>
    public partial class S3Destination
    {
        private string _bucket;
        private string _key;
        private string _metadataKey;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket used as the destination of an export file.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Key. 
        /// <para>
        /// The Amazon S3 bucket key of an export file.
        /// </para>
        ///  
        /// <para>
        /// The key uniquely identifies the object, or export file, in the S3 bucket.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataKey. 
        /// <para>
        /// The Amazon S3 bucket key of a metadata file.
        /// </para>
        ///  
        /// <para>
        /// The key uniquely identifies the object, or metadata file, in the S3 bucket.
        /// </para>
        /// </summary>
        public string MetadataKey
        {
            get { return this._metadataKey; }
            set { this._metadataKey = value; }
        }

        // Check to see if MetadataKey property is set
        internal bool IsSetMetadataKey()
        {
            return this._metadataKey != null;
        }

    }
}
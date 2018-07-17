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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes the S3 data source.
    /// </summary>
    public partial class TransformS3DataSource
    {
        private S3DataType _s3DataType;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// If you choose <code>S3Prefix</code>, <code>S3Uri</code> identifies a key name prefix.
        /// Amazon SageMaker uses all objects with the specified key name prefix for batch transform.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you choose <code>ManifestFile</code>, <code>S3Uri</code> identifies an object that
        /// is a manifest file containing a list of object keys that you want Amazon SageMaker
        /// to use for batch transform. 
        /// </para>
        /// </summary>
        public S3DataType S3DataType
        {
            get { return this._s3DataType; }
            set { this._s3DataType = value; }
        }

        // Check to see if S3DataType property is set
        internal bool IsSetS3DataType()
        {
            return this._s3DataType != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// Depending on the value specified for the <code>S3DataType</code>, identifies either
        /// a key name prefix or a manifest. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A key name prefix might look like this: <code>s3://bucketname/exampleprefix</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A manifest might look like this: <code>s3://bucketname/example.manifest</code> 
        /// </para>
        ///  
        /// <para>
        ///  The manifest is an S3 object which is a JSON file with the following format: 
        /// </para>
        ///  
        /// <para>
        ///  <code>[</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {"prefix": "s3://customer_bucket/some/prefix/"},</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "relative/path/to/custdata-1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "relative/path/custdata-2",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ...</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ]</code> 
        /// </para>
        ///  
        /// <para>
        ///  The preceding JSON matches the following <code>S3Uris</code>: 
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://customer_bucket/some/prefix/relative/path/to/custdata-1</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://customer_bucket/some/prefix/relative/path/custdata-1</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>...</code> 
        /// </para>
        ///  
        /// <para>
        ///  The complete set of <code>S3Uris</code> in this manifest constitutes the input data
        /// for the channel for this datasource. The object that each <code>S3Uris</code> points
        /// to must be readable by the IAM role that Amazon SageMaker uses to perform tasks on
        /// your behalf.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}
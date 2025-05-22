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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes the Amazon S3 data source.
    /// </summary>
    public partial class AutoMLS3DataSource
    {
        private AutoMLS3DataType _s3DataType;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// The data type. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you choose <c>S3Prefix</c>, <c>S3Uri</c> identifies a key name prefix. SageMaker
        /// AI uses all objects that match the specified key name prefix for model training.
        /// </para>
        ///  
        /// <para>
        /// The <c>S3Prefix</c> should have the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://DOC-EXAMPLE-BUCKET/DOC-EXAMPLE-FOLDER-OR-FILE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you choose <c>ManifestFile</c>, <c>S3Uri</c> identifies an object that is a manifest
        /// file containing a list of object keys that you want SageMaker AI to use for model
        /// training.
        /// </para>
        ///  
        /// <para>
        /// A <c>ManifestFile</c> should have the format shown below:
        /// </para>
        ///  
        /// <para>
        ///  <c>[ {"prefix": "s3://DOC-EXAMPLE-BUCKET/DOC-EXAMPLE-FOLDER/DOC-EXAMPLE-PREFIX/"},
        /// </c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"DOC-EXAMPLE-RELATIVE-PATH/DOC-EXAMPLE-FOLDER/DATA-1",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"DOC-EXAMPLE-RELATIVE-PATH/DOC-EXAMPLE-FOLDER/DATA-2",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>... "DOC-EXAMPLE-RELATIVE-PATH/DOC-EXAMPLE-FOLDER/DATA-N" ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you choose <c>AugmentedManifestFile</c>, <c>S3Uri</c> identifies an object that
        /// is an augmented manifest file in JSON lines format. This file contains the data you
        /// want to use for model training. <c>AugmentedManifestFile</c> is available for V2 API
        /// jobs only (for example, for jobs created by calling <c>CreateAutoMLJobV2</c>).
        /// </para>
        ///  
        /// <para>
        /// Here is a minimal, single-record example of an <c>AugmentedManifestFile</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"source-ref": "s3://DOC-EXAMPLE-BUCKET/DOC-EXAMPLE-FOLDER/cats/cat.jpg",</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"label-metadata": {"class-name": "cat"</c> }
        /// </para>
        ///  
        /// <para>
        /// For more information on <c>AugmentedManifestFile</c>, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/augmented-manifest.html">Provide
        /// Dataset Metadata to Training Jobs with an Augmented Manifest File</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLS3DataType S3DataType
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
        /// The URL to the Amazon S3 data source. The Uri refers to the Amazon S3 prefix or ManifestFile
        /// depending on the data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
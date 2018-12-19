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
    /// Describes the input source of a transform job and the way the transform job consumes
    /// it.
    /// </summary>
    public partial class TransformInput
    {
        private CompressionType _compressionType;
        private string _contentType;
        private TransformDataSource _dataSource;
        private SplitType _splitType;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// Compressing data helps save on storage space. If your transform data is compressed,
        /// specify the compression type. Amazon SageMaker automatically decompresses the data
        /// for the transform job accordingly. The default value is <code>None</code>.
        /// </para>
        /// </summary>
        public CompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The multipurpose internet mail extension (MIME) type of the data. Amazon SageMaker
        /// uses the MIME type with each http call to transfer data to the transform job.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Describes the location of the channel data, meaning the S3 location of the input data
        /// that the model can consume.
        /// </para>
        /// </summary>
        public TransformDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property SplitType. 
        /// <para>
        /// The method to use to split the transform job's data files into smaller batches. Splitting
        /// is necessary when the total size of each object is too large to fit in a single request.
        /// You can also use data splitting to improve performance by processing multiple concurrent
        /// mini-batches. The default value for <code>SplitType</code> is <code>None</code>, which
        /// indicates that input data files are not split, and request payloads contain the entire
        /// contents of an input object. Set the value of this parameter to <code>Line</code>
        /// to split records on a newline character boundary. <code>SplitType</code> also supports
        /// a number of record-oriented binary data formats.
        /// </para>
        ///  
        /// <para>
        /// When splitting is enabled, the size of a mini-batch depends on the values of the <code>BatchStrategy</code>
        /// and <code>MaxPayloadInMB</code> parameters. When the value of <code>BatchStrategy</code>
        /// is <code>MultiRecord</code>, Amazon SageMaker sends the maximum number of records
        /// in each request, up to the <code>MaxPayloadInMB</code> limit. If the value of <code>BatchStrategy</code>
        /// is <code>SingleRecord</code>, Amazon SageMaker sends individual records in each request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some data formats represent a record as a binary payload wrapped with extra padding
        /// bytes. When splitting is applied to a binary data format, padding is removed if the
        /// value of <code>BatchStrategy</code> is set to <code>SingleRecord</code>. Padding is
        /// not removed if the value of <code>BatchStrategy</code> is set to <code>MultiRecord</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about the RecordIO data format, see <a href="http://mxnet.io/architecture/note_data_loading.html#data-format">Data
        /// Format</a> in the MXNet documentation. For more information about the TFRecord fofmat,
        /// see <a href="https://www.tensorflow.org/guide/datasets#consuming_tfrecord_data">Consuming
        /// TFRecord data</a> in the TensorFlow documentation.
        /// </para>
        /// </summary>
        public SplitType SplitType
        {
            get { return this._splitType; }
            set { this._splitType = value; }
        }

        // Check to see if SplitType property is set
        internal bool IsSetSplitType()
        {
            return this._splitType != null;
        }

    }
}
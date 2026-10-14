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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A channel is a named input source that training algorithms can consume.
    /// </summary>
    public partial class Channel
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// If training data is compressed, the compression type. The default value is <c>None</c>.
        /// <c>CompressionType</c> is used only in Pipe input mode. In File mode, leave this field
        /// unset or set it to None.
        /// </para>
        /// </summary>
        public CompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The location of the channel data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property InputMode. 
        /// <para>
        /// (Optional) The input mode to use for the data channel in a training job. If you don't
        /// set a value for <c>InputMode</c>, SageMaker uses the value set for <c>TrainingInputMode</c>.
        /// Use this parameter to override the <c>TrainingInputMode</c> setting in a <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AlgorithmSpecification.html">AlgorithmSpecification</a>
        /// request when you have a channel that needs a different input mode from the training
        /// job's general setting. To download the data from Amazon Simple Storage Service (Amazon
        /// S3) to the provisioned ML storage volume, and mount the directory to a Docker volume,
        /// use <c>File</c> input mode. To stream data directly from Amazon S3 to the container,
        /// choose <c>Pipe</c> input mode.
        /// </para>
        ///  
        /// <para>
        /// To use a model for incremental training, choose <c>File</c> input model.
        /// </para>
        /// </summary>
        public TrainingInputMode InputMode { get; set; }

        /// <summary>
        /// Checks to see if the InputMode property is set.
        /// </summary>
        internal bool IsSetInputMode() => this.InputMode != null;

        /// <summary>
        /// Gets and sets the property RecordWrapperType.  
        /// <para>
        /// Specify RecordIO as the value when input data is in raw format but the training algorithm
        /// requires the RecordIO format. In this case, SageMaker wraps each individual S3 object
        /// in a RecordIO record. If the input data is already in RecordIO format, you don't need
        /// to set this attribute. For more information, see <a href="https://mxnet.apache.org/api/architecture/note_data_loading#data-format">Create
        /// a Dataset Using RecordIO</a>. 
        /// </para>
        ///  
        /// <para>
        /// In File mode, leave this field unset or set it to None.
        /// </para>
        /// </summary>
        public RecordWrapper RecordWrapperType { get; set; }

        /// <summary>
        /// Checks to see if the RecordWrapperType property is set.
        /// </summary>
        internal bool IsSetRecordWrapperType() => this.RecordWrapperType != null;

        /// <summary>
        /// Gets and sets the property ShuffleConfig. 
        /// <para>
        /// A configuration for a shuffle option for input data in a channel. If you use <c>S3Prefix</c>
        /// for <c>S3DataType</c>, this shuffles the results of the S3 key prefix matches. If
        /// you use <c>ManifestFile</c>, the order of the S3 object references in the <c>ManifestFile</c>
        /// is shuffled. If you use <c>AugmentedManifestFile</c>, the order of the JSON lines
        /// in the <c>AugmentedManifestFile</c> is shuffled. The shuffling order is determined
        /// using the <c>Seed</c> value.
        /// </para>
        ///  
        /// <para>
        /// For Pipe input mode, shuffling is done at the start of every epoch. With large datasets
        /// this ensures that the order of the training data is different for each epoch, it helps
        /// reduce bias and possible overfitting. In a multi-node training job when ShuffleConfig
        /// is combined with <c>S3DataDistributionType</c> of <c>ShardedByS3Key</c>, the data
        /// is shuffled across nodes so that the content sent to a particular node on the first
        /// epoch might be sent to a different node on the second epoch.
        /// </para>
        /// </summary>
        public ShuffleConfig ShuffleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ShuffleConfig property is set.
        /// </summary>
        internal bool IsSetShuffleConfig() => this.ShuffleConfig != null;
    }
}

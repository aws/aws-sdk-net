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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchPrediction operation.
    /// Generates predictions for a group of observations. The observations to process exist
    /// in one or more data files referenced by a <c>DataSource</c>. This operation creates
    /// a new <c>BatchPrediction</c>, and uses an <c>MLModel</c> and the data files referenced
    /// by the <c>DataSource</c> as information sources. 
    /// 
    ///  
    /// <para>
    ///  <c>CreateBatchPrediction</c> is an asynchronous operation. In response to <c>CreateBatchPrediction</c>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>BatchPrediction</c>
    /// status to <c>PENDING</c>. After the <c>BatchPrediction</c> completes, Amazon ML sets
    /// the status to <c>COMPLETED</c>. 
    /// </para>
    ///  
    /// <para>
    /// You can poll for status updates by using the <a>GetBatchPrediction</a> operation and
    /// checking the <c>Status</c> parameter of the result. After the <c>COMPLETED</c> status
    /// appears, the results are available in the location specified by the <c>OutputUri</c>
    /// parameter.
    /// </para>
    /// </summary>
    public partial class CreateBatchPredictionRequest : AmazonMachineLearningRequest
    {
        private string _batchPredictionDataSourceId;
        private string _batchPredictionId;
        private string _batchPredictionName;
        private string _mlModelId;
        private string _outputUri;

        /// <summary>
        /// Gets and sets the property BatchPredictionDataSourceId. 
        /// <para>
        /// The ID of the <c>DataSource</c> that points to the group of observations to predict.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string BatchPredictionDataSourceId
        {
            get { return this._batchPredictionDataSourceId; }
            set { this._batchPredictionDataSourceId = value; }
        }

        // Check to see if BatchPredictionDataSourceId property is set
        internal bool IsSetBatchPredictionDataSourceId()
        {
            return this._batchPredictionDataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property BatchPredictionId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>BatchPrediction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string BatchPredictionId
        {
            get { return this._batchPredictionId; }
            set { this._batchPredictionId = value; }
        }

        // Check to see if BatchPredictionId property is set
        internal bool IsSetBatchPredictionId()
        {
            return this._batchPredictionId != null;
        }

        /// <summary>
        /// Gets and sets the property BatchPredictionName. 
        /// <para>
        /// A user-supplied name or description of the <c>BatchPrediction</c>. <c>BatchPredictionName</c>
        /// can only use the UTF-8 character set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string BatchPredictionName
        {
            get { return this._batchPredictionName; }
            set { this._batchPredictionName = value; }
        }

        // Check to see if BatchPredictionName property is set
        internal bool IsSetBatchPredictionName()
        {
            return this._batchPredictionName != null;
        }

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <c>MLModel</c> that will generate predictions for the group of observations.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// The location of an Amazon Simple Storage Service (Amazon S3) bucket or directory to
        /// store the batch prediction results. The following substrings are not allowed in the
        /// <c>s3 key</c> portion of the <c>outputURI</c> field: ':', '//', '/./', '/../'.
        /// </para>
        ///  
        /// <para>
        /// Amazon ML needs permissions to store and retrieve the logs on your behalf. For information
        /// about how to set permissions, see the <a href="https://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
        /// Machine Learning Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string OutputUri
        {
            get { return this._outputUri; }
            set { this._outputUri = value; }
        }

        // Check to see if OutputUri property is set
        internal bool IsSetOutputUri()
        {
            return this._outputUri != null;
        }

    }
}
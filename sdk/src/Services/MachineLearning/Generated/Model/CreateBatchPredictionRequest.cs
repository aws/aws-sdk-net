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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchPrediction operation.
    /// Generates predictions for a group of observations. The observations to process exist
    /// in one or more data files referenced by a <code>DataSource</code>. This operation
    /// creates a new <code>BatchPrediction</code>, and uses an <code>MLModel</code> and the
    /// data files referenced by the <code>DataSource</code> as information sources. 
    /// 
    ///  
    /// <para>
    /// <code>CreateBatchPrediction</code> is an asynchronous operation. In response to <code>CreateBatchPrediction</code>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>BatchPrediction</code>
    /// status to <code>PENDING</code>. After the <code>BatchPrediction</code> completes,
    /// Amazon ML sets the status to <code>COMPLETED</code>. 
    /// </para>
    ///  
    /// <para>
    /// You can poll for status updates by using the <a>GetBatchPrediction</a> operation and
    /// checking the <code>Status</code> parameter of the result. After the <code>COMPLETED</code>
    /// status appears, the results are available in the location specified by the <code>OutputUri</code>
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
        /// The ID of the <code>DataSource</code> that points to the group of observations to
        /// predict.
        /// </para>
        /// </summary>
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
        /// A user-supplied ID that uniquely identifies the <code>BatchPrediction</code>.
        /// </para>
        /// </summary>
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
        /// A user-supplied name or description of the <code>BatchPrediction</code>. <code>BatchPredictionName</code>
        /// can only use the UTF-8 character set.
        /// </para>
        /// </summary>
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
        /// The ID of the <code>MLModel</code> that will generate predictions for the group of
        /// observations. 
        /// </para>
        /// </summary>
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
        /// <code>s3 key</code> portion of the <code>outputURI</code> field: ':', '//', '/./',
        /// '/../'.
        /// </para>
        ///  
        /// <para>
        /// Amazon ML needs permissions to store and retrieve the logs on your behalf. For information
        /// about how to set permissions, see the <a href="http://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
        /// Machine Learning Developer Guide</a>.
        /// </para>
        /// </summary>
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
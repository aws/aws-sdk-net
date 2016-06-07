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
    /// Container for the parameters to the CreateDataSourceFromS3 operation.
    /// Creates a <code>DataSource</code> object. A <code>DataSource</code> references data
    /// that can be used to perform <code>CreateMLModel</code>, <code>CreateEvaluation</code>,
    /// or <code>CreateBatchPrediction</code> operations.
    /// 
    ///  
    /// <para>
    /// <code>CreateDataSourceFromS3</code> is an asynchronous operation. In response to <code>CreateDataSourceFromS3</code>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>DataSource</code>
    /// status to <code>PENDING</code>. After the <code>DataSource</code> has been created
    /// and is ready for use, Amazon ML sets the <code>Status</code> parameter to <code>COMPLETED</code>.
    /// <code>DataSource</code> in the <code>COMPLETED</code> or <code>PENDING</code> state
    /// can be used to perform only <code>CreateMLModel</code>, <code>CreateEvaluation</code>
    /// or <code>CreateBatchPrediction</code> operations. 
    /// </para>
    ///  
    /// <para>
    ///  If Amazon ML can't accept the input source, it sets the <code>Status</code> parameter
    /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
    /// of the <code>GetDataSource</code> operation response. 
    /// </para>
    ///  
    /// <para>
    /// The observation data used in a <code>DataSource</code> should be ready to use; that
    /// is, it should have a consistent structure, and missing data values should be kept
    /// to a minimum. The observation data must reside in one or more .csv files in an Amazon
    /// Simple Storage Service (Amazon S3) location, along with a schema that describes the
    /// data items by name and type. The same schema must be used for all of the data files
    /// referenced by the <code>DataSource</code>. 
    /// </para>
    ///  
    /// <para>
    /// After the <code>DataSource</code> has been created, it's ready to use in evaluations
    /// and batch predictions. If you plan to use the <code>DataSource</code> to train an
    /// <code>MLModel</code>, the <code>DataSource</code> also needs a recipe. A recipe describes
    /// how each input variable will be used in training an <code>MLModel</code>. Will the
    /// variable be included or excluded from training? Will the variable be manipulated;
    /// for example, will it be combined with another variable or will it be split apart into
    /// word combinations? The recipe provides answers to these questions.
    /// </para>
    /// </summary>
    public partial class CreateDataSourceFromS3Request : AmazonMachineLearningRequest
    {
        private bool? _computeStatistics;
        private string _dataSourceId;
        private string _dataSourceName;
        private S3DataSpec _dataSpec;

        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        /// The compute statistics for a <code>DataSource</code>. The statistics are generated
        /// from the observation data referenced by a <code>DataSource</code>. Amazon ML uses
        /// the statistics internally during <code>MLModel</code> training. This parameter must
        /// be set to <code>true</code> if the <code></code>DataSource<code></code> needs to be
        /// used for <code>MLModel</code> training.
        /// </para>
        /// </summary>
        public bool ComputeStatistics
        {
            get { return this._computeStatistics.GetValueOrDefault(); }
            set { this._computeStatistics = value; }
        }

        // Check to see if ComputeStatistics property is set
        internal bool IsSetComputeStatistics()
        {
            return this._computeStatistics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A user-supplied identifier that uniquely identifies the <code>DataSource</code>. 
        /// </para>
        /// </summary>
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// A user-supplied name or description of the <code>DataSource</code>. 
        /// </para>
        /// </summary>
        public string DataSourceName
        {
            get { return this._dataSourceName; }
            set { this._dataSourceName = value; }
        }

        // Check to see if DataSourceName property is set
        internal bool IsSetDataSourceName()
        {
            return this._dataSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSpec. 
        /// <para>
        /// The data specification of a <code>DataSource</code>:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// DataLocationS3 - The Amazon S3 location of the observation data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DataSchemaLocationS3 - The Amazon S3 location of the <code>DataSchema</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DataSchema - A JSON string representing the schema. This is not required if <code>DataSchemaUri</code>
        /// is specified. 
        /// </para>
        /// </li> <li> 
        /// <para>
        /// DataRearrangement - A JSON string that represents the splitting and rearrangement
        /// requirements for the <code>Datasource</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Sample - <code> "{\"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public S3DataSpec DataSpec
        {
            get { return this._dataSpec; }
            set { this._dataSpec = value; }
        }

        // Check to see if DataSpec property is set
        internal bool IsSetDataSpec()
        {
            return this._dataSpec != null;
        }

    }
}
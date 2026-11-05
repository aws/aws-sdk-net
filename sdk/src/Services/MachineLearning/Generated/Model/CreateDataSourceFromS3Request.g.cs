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

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSourceFromS3 operation. Creates a <c>DataSource</c>
    /// object. A <c>DataSource</c> references data that can be used to perform <c>CreateMLModel</c>,
    /// <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c> operations. <para> <c>CreateDataSourceFromS3</c>
    /// is an asynchronous operation. In response to <c>CreateDataSourceFromS3</c>, Amazon
    /// Machine Learning (Amazon ML) immediately returns and sets the <c>DataSource</c> status
    /// to <c>PENDING</c>. After the <c>DataSource</c> has been created and is ready for use,
    /// Amazon ML sets the <c>Status</c> parameter to <c>COMPLETED</c>. <c>DataSource</c>
    /// in the <c>COMPLETED</c> or <c>PENDING</c> state can be used to perform only <c>CreateMLModel</c>,
    /// <c>CreateEvaluation</c> or <c>CreateBatchPrediction</c> operations. </para> <para>
    /// If Amazon ML can't accept the input source, it sets the <c>Status</c> parameter to
    /// <c>FAILED</c> and includes an error message in the <c>Message</c> attribute of the
    /// <c>GetDataSource</c> operation response. </para> <para> The observation data used
    /// in a <c>DataSource</c> should be ready to use; that is, it should have a consistent
    /// structure, and missing data values should be kept to a minimum. The observation data
    /// must reside in one or more .csv files in an Amazon Simple Storage Service (Amazon
    /// S3) location, along with a schema that describes the data items by name and type.
    /// The same schema must be used for all of the data files referenced by the <c>DataSource</c>.
    /// </para> <para> After the <c>DataSource</c> has been created, it's ready to use in
    /// evaluations and batch predictions. If you plan to use the <c>DataSource</c> to train
    /// an <c>MLModel</c>, the <c>DataSource</c> also needs a recipe. A recipe describes how
    /// each input variable will be used in training an <c>MLModel</c>. Will the variable
    /// be included or excluded from training? Will the variable be manipulated; for example,
    /// will it be combined with another variable or will it be split apart into word combinations?
    /// The recipe provides answers to these questions. </para>
    /// </summary>
    public partial class CreateDataSourceFromS3Request : AmazonMachineLearningRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        /// The compute statistics for a <c>DataSource</c>. The statistics are generated from
        /// the observation data referenced by a <c>DataSource</c>. Amazon ML uses the statistics
        /// internally during <c>MLModel</c> training. This parameter must be set to <c>true</c>
        /// if the <c></c>DataSource<c></c> needs to be used for <c>MLModel</c> training.
        /// </para>
        /// </summary>
        public bool? ComputeStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ComputeStatistics property is set.
        /// </summary>
        internal bool IsSetComputeStatistics() => this.ComputeStatistics.HasValue;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A user-supplied identifier that uniquely identifies the <c>DataSource</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// A user-supplied name or description of the <c>DataSource</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceName property is set.
        /// </summary>
        internal bool IsSetDataSourceName() => this.DataSourceName != null;

        /// <summary>
        /// Gets and sets the property DataSpec. 
        /// <para>
        /// The data specification of a <c>DataSource</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DataLocationS3 - The Amazon S3 location of the observation data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DataSchemaLocationS3 - The Amazon S3 location of the <c>DataSchema</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DataSchema - A JSON string representing the schema. This is not required if <c>DataSchemaUri</c>
        /// is specified. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DataRearrangement - A JSON string that represents the splitting and rearrangement
        /// requirements for the <c>Datasource</c>. 
        /// </para>
        ///  
        /// <para>
        ///  Sample - <c> "{\"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3DataSpec DataSpec { get; set; }

        /// <summary>
        /// Checks to see if the DataSpec property is set.
        /// </summary>
        internal bool IsSetDataSpec() => this.DataSpec != null;
    }
}

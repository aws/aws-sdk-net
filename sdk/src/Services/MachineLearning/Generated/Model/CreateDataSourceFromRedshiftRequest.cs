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
    /// Container for the parameters to the CreateDataSourceFromRedshift operation.
    /// Creates a <c>DataSource</c> from a database hosted on an Amazon Redshift cluster.
    /// A <c>DataSource</c> references data that can be used to perform either <c>CreateMLModel</c>,
    /// <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c> operations.
    /// 
    ///  
    /// <para>
    ///  <c>CreateDataSourceFromRedshift</c> is an asynchronous operation. In response to
    /// <c>CreateDataSourceFromRedshift</c>, Amazon Machine Learning (Amazon ML) immediately
    /// returns and sets the <c>DataSource</c> status to <c>PENDING</c>. After the <c>DataSource</c>
    /// is created and ready for use, Amazon ML sets the <c>Status</c> parameter to <c>COMPLETED</c>.
    /// <c>DataSource</c> in <c>COMPLETED</c> or <c>PENDING</c> states can be used to perform
    /// only <c>CreateMLModel</c>, <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c>
    /// operations. 
    /// </para>
    ///  
    /// <para>
    ///  If Amazon ML can't accept the input source, it sets the <c>Status</c> parameter to
    /// <c>FAILED</c> and includes an error message in the <c>Message</c> attribute of the
    /// <c>GetDataSource</c> operation response. 
    /// </para>
    ///  
    /// <para>
    /// The observations should be contained in the database hosted on an Amazon Redshift
    /// cluster and should be specified by a <c>SelectSqlQuery</c> query. Amazon ML executes
    /// an <c>Unload</c> command in Amazon Redshift to transfer the result set of the <c>SelectSqlQuery</c>
    /// query to <c>S3StagingLocation</c>.
    /// </para>
    ///  
    /// <para>
    /// After the <c>DataSource</c> has been created, it's ready for use in evaluations and
    /// batch predictions. If you plan to use the <c>DataSource</c> to train an <c>MLModel</c>,
    /// the <c>DataSource</c> also requires a recipe. A recipe describes how each input variable
    /// will be used in training an <c>MLModel</c>. Will the variable be included or excluded
    /// from training? Will the variable be manipulated; for example, will it be combined
    /// with another variable or will it be split apart into word combinations? The recipe
    /// provides answers to these questions.
    /// </para>
    ///  
    /// <para>
    /// You can't change an existing datasource, but you can copy and modify the settings
    /// from an existing Amazon Redshift datasource to create a new datasource. To do so,
    /// call <c>GetDataSource</c> for an existing datasource and copy the values to a <c>CreateDataSource</c>
    /// call. Change the settings that you want to change and make sure that all required
    /// fields have the appropriate values.
    /// </para>
    /// </summary>
    public partial class CreateDataSourceFromRedshiftRequest : AmazonMachineLearningRequest
    {
        private bool? _computeStatistics;
        private string _dataSourceId;
        private string _dataSourceName;
        private RedshiftDataSpec _dataSpec;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        /// The compute statistics for a <c>DataSource</c>. The statistics are generated from
        /// the observation data referenced by a <c>DataSource</c>. Amazon ML uses the statistics
        /// internally during <c>MLModel</c> training. This parameter must be set to <c>true</c>
        /// if the <c>DataSource</c> needs to be used for <c>MLModel</c> training.
        /// </para>
        /// </summary>
        public bool? ComputeStatistics
        {
            get { return this._computeStatistics; }
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
        /// A user-supplied ID that uniquely identifies the <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// A user-supplied name or description of the <c>DataSource</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// The data specification of an Amazon Redshift <c>DataSource</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DatabaseInformation -
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DatabaseName</c> - The name of the Amazon Redshift database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> ClusterIdentifier</c> - The unique ID for the Amazon Redshift cluster.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// DatabaseCredentials - The AWS Identity and Access Management (IAM) credentials that
        /// are used to connect to the Amazon Redshift database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SelectSqlQuery - The query that is used to retrieve the observation data for the <c>Datasource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// S3StagingLocation - The Amazon Simple Storage Service (Amazon S3) location for staging
        /// Amazon Redshift data. The data retrieved from Amazon Redshift using the <c>SelectSqlQuery</c>
        /// query is stored in this location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DataSchemaUri - The Amazon S3 location of the <c>DataSchema</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DataSchema - A JSON string representing the schema. This is not required if <c>DataSchemaUri</c>
        /// is specified. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DataRearrangement - A JSON string that represents the splitting and rearrangement
        /// requirements for the <c>DataSource</c>.
        /// </para>
        ///  
        /// <para>
        ///  Sample - <c> "{\"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftDataSpec DataSpec
        {
            get { return this._dataSpec; }
            set { this._dataSpec = value; }
        }

        // Check to see if DataSpec property is set
        internal bool IsSetDataSpec()
        {
            return this._dataSpec != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// A fully specified role Amazon Resource Name (ARN). Amazon ML assumes the role on behalf
        /// of the user to create the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A security group to allow Amazon ML to execute the <c>SelectSqlQuery</c> query on
        /// an Amazon Redshift cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon S3 bucket policy to grant Amazon ML read/write permissions on the <c>S3StagingLocation</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=110)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

    }
}
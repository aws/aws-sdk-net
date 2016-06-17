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
    /// Container for the parameters to the CreateDataSourceFromRedshift operation.
    /// Creates a <code>DataSource</code> from a database hosted on an Amazon Redshift cluster.
    /// A <code>DataSource</code> references data that can be used to perform either <code>CreateMLModel</code>,
    /// <code>CreateEvaluation</code>, or <code>CreateBatchPrediction</code> operations.
    /// 
    ///  
    /// <para>
    /// <code>CreateDataSourceFromRedshift</code> is an asynchronous operation. In response
    /// to <code>CreateDataSourceFromRedshift</code>, Amazon Machine Learning (Amazon ML)
    /// immediately returns and sets the <code>DataSource</code> status to <code>PENDING</code>.
    /// After the <code>DataSource</code> is created and ready for use, Amazon ML sets the
    /// <code>Status</code> parameter to <code>COMPLETED</code>. <code>DataSource</code> in
    /// <code>COMPLETED</code> or <code>PENDING</code> states can be used to perform only
    /// <code>CreateMLModel</code>, <code>CreateEvaluation</code>, or <code>CreateBatchPrediction</code>
    /// operations. 
    /// </para>
    ///  
    /// <para>
    ///  If Amazon ML can't accept the input source, it sets the <code>Status</code> parameter
    /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
    /// of the <code>GetDataSource</code> operation response. 
    /// </para>
    ///  
    /// <para>
    /// The observations should be contained in the database hosted on an Amazon Redshift
    /// cluster and should be specified by a <code>SelectSqlQuery</code> query. Amazon ML
    /// executes an <code>Unload</code> command in Amazon Redshift to transfer the result
    /// set of the <code>SelectSqlQuery</code> query to <code>S3StagingLocation</code>.
    /// </para>
    ///  
    /// <para>
    /// After the <code>DataSource</code> has been created, it's ready for use in evaluations
    /// and batch predictions. If you plan to use the <code>DataSource</code> to train an
    /// <code>MLModel</code>, the <code>DataSource</code> also requires a recipe. A recipe
    /// describes how each input variable will be used in training an <code>MLModel</code>.
    /// Will the variable be included or excluded from training? Will the variable be manipulated;
    /// for example, will it be combined with another variable or will it be split apart into
    /// word combinations? The recipe provides answers to these questions.
    /// </para>
    ///  
    /// <para>
    /// You can't change an existing datasource, but you can copy and modify the settings
    /// from an existing Amazon Redshift datasource to create a new datasource. To do so,
    /// call <code>GetDataSource</code> for an existing datasource and copy the values to
    /// a <code>CreateDataSource</code> call. Change the settings that you want to change
    /// and make sure that all required fields have the appropriate values.
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
        /// The compute statistics for a <code>DataSource</code>. The statistics are generated
        /// from the observation data referenced by a <code>DataSource</code>. Amazon ML uses
        /// the statistics internally during <code>MLModel</code> training. This parameter must
        /// be set to <code>true</code> if the <code>DataSource</code> needs to be used for <code>MLModel</code>
        /// training.
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
        /// A user-supplied ID that uniquely identifies the <code>DataSource</code>.
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
        /// The data specification of an Amazon Redshift <code>DataSource</code>:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// DatabaseInformation - <ul> <li> <code>DatabaseName</code> - The name of the Amazon
        /// Redshift database. </li> <li> <code> ClusterIdentifier</code> - The unique ID for
        /// the Amazon Redshift cluster.</li> </ul>
        /// </para>
        /// </li> <li>
        /// <para>
        /// DatabaseCredentials - The AWS Identity and Access Management (IAM) credentials that
        /// are used to connect to the Amazon Redshift database.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SelectSqlQuery - The query that is used to retrieve the observation data for the <code>Datasource</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3StagingLocation - The Amazon Simple Storage Service (Amazon S3) location for staging
        /// Amazon Redshift data. The data retrieved from Amazon Redshift using the <code>SelectSqlQuery</code>
        /// query is stored in this location.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DataSchemaUri - The Amazon S3 location of the <code>DataSchema</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DataSchema - A JSON string representing the schema. This is not required if <code>DataSchemaUri</code>
        /// is specified. 
        /// </para>
        /// </li> <li> 
        /// <para>
        /// DataRearrangement - A JSON string that represents the splitting and rearrangement
        /// requirements for the <code>DataSource</code>.
        /// </para>
        ///  
        /// <para>
        ///  Sample - <code> "{\"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        ///  
        /// <para>
        ///  <ul> <li>
        /// <para>
        /// A security group to allow Amazon ML to execute the <code>SelectSqlQuery</code> query
        /// on an Amazon Redshift cluster
        /// </para>
        /// </li> <li>
        /// <para>
        /// An Amazon S3 bucket policy to grant Amazon ML read/write permissions on the <code>S3StagingLocation</code>
        /// </para>
        /// </li> </ul> 
        /// </para>
        /// </summary>
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
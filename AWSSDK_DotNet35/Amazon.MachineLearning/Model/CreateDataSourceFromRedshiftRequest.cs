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
    /// Creates a <code>DataSource</code> from <a href="http://aws.amazon.com/redshift/">Amazon
    /// Redshift</a>. A <code>DataSource</code> references data that can be used to perform
    /// either <a>CreateMLModel</a>, <a>CreateEvaluation</a> or <a>CreateBatchPrediction</a>
    /// operations.
    /// 
    ///  
    /// <para>
    /// <code>CreateDataSourceFromRedshift</code> is an asynchronous operation. In response
    /// to <code>CreateDataSourceFromRedshift</code>, Amazon Machine Learning (Amazon ML)
    /// immediately returns and sets the <code>DataSource</code> status to <code>PENDING</code>.
    /// After the <code>DataSource</code> is created and ready for use, Amazon ML sets the
    /// <code>Status</code> parameter to <code>COMPLETED</code>. <code>DataSource</code> in
    /// <code>COMPLETED</code> or <code>PENDING</code> status can only be used to perform
    /// <a>CreateMLModel</a>, <a>CreateEvaluation</a>, or <a>CreateBatchPrediction</a> operations.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  If Amazon ML cannot accept the input source, it sets the <code>Status</code> parameter
    /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
    /// of the <a>GetDataSource</a> operation response. 
    /// </para>
    ///  
    /// <para>
    /// The observations should exist in the database hosted on an Amazon Redshift cluster
    /// and should be specified by a <code>SelectSqlQuery</code>. Amazon ML executes <a href="http://docs.aws.amazon.com/redshift/latest/dg/t_Unloading_tables.html">
    /// Unload</a> command in Amazon Redshift to transfer the result set of <code>SelectSqlQuery</code>
    /// to <code>S3StagingLocation.</code> 
    /// </para>
    ///  
    /// <para>
    /// After the <code>DataSource</code> is created, it's ready for use in evaluations and
    /// batch predictions. If you plan to use the <code>DataSource</code> to train an <code>MLModel</code>,
    /// the <code>DataSource</code> requires another item -- a recipe. A recipe describes
    /// the observation variables that participate in training an <code>MLModel</code>. A
    /// recipe describes how each input variable will be used in training. Will the variable
    /// be included or excluded from training? Will the variable be manipulated, for example,
    /// combined with another variable or split apart into word combinations? The recipe provides
    /// answers to these questions. For more information, see the Amazon Machine Learning
    /// Developer Guide.
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
        /// be set to <code>true</code> if the <code></code>DataSource<code></code> needs to be
        /// used for <code>MLModel</code> training
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
        /// DatabaseInformation - <ul> <li> <code>DatabaseName </code> - Name of the Amazon Redshift
        /// database. </li> <li> <code> ClusterIdentifier </code> - Unique ID for the Amazon Redshift
        /// cluster.</li> </ul>
        /// </para>
        /// </li> <li>
        /// <para>
        /// DatabaseCredentials - AWS Identity abd Access Management (IAM) credentials that are
        /// used to connect to the Amazon Redshift database.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SelectSqlQuery - Query that is used to retrieve the observation data for the <code>Datasource</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3StagingLocation - Amazon Simple Storage Service (Amazon S3) location for staging
        /// Amazon Redshift data. The data retrieved from Amazon Relational Database Service (Amazon
        /// RDS) using <code>SelectSqlQuery</code> is stored in this location.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DataSchemaUri - Amazon S3 location of the <code>DataSchema</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DataSchema - A JSON string representing the schema. This is not required if <code>DataSchemaUri</code>
        /// is specified. 
        /// </para>
        /// </li> <li> 
        /// <para>
        /// DataRearrangement - A JSON string representing the splitting requirement of a <code>Datasource</code>.
        /// 
        /// </para>
        ///   
        /// <para>
        ///  Sample - <code> "{\"randomSeed\":\"some-random-seed\", \"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</code>
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
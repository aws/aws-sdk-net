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
    /// Container for the parameters to the CreateDataSourceFromRDS operation.
    /// Creates a <code>DataSource</code> object from an <a href="http://aws.amazon.com/rds/">
    /// Amazon Relational Database Service</a> (Amazon RDS). A <code>DataSource</code> references
    /// data that can be used to perform <a>CreateMLModel</a>, <a>CreateEvaluation</a>, or
    /// <a>CreateBatchPrediction</a> operations.
    /// 
    ///  
    /// <para>
    /// <code>CreateDataSourceFromRDS</code> is an asynchronous operation. In response to
    /// <code>CreateDataSourceFromRDS</code>, Amazon Machine Learning (Amazon ML) immediately
    /// returns and sets the <code>DataSource</code> status to <code>PENDING</code>. After
    /// the <code>DataSource</code> is created and ready for use, Amazon ML sets the <code>Status</code>
    /// parameter to <code>COMPLETED</code>. <code>DataSource</code> in <code>COMPLETED</code>
    /// or <code>PENDING</code> status can only be used to perform <a>CreateMLModel</a>, <a>CreateEvaluation</a>,
    /// or <a>CreateBatchPrediction</a> operations. 
    /// </para>
    ///  
    /// <para>
    ///  If Amazon ML cannot accept the input source, it sets the <code>Status</code> parameter
    /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
    /// of the <a>GetDataSource</a> operation response. 
    /// </para>
    /// </summary>
    public partial class CreateDataSourceFromRDSRequest : AmazonMachineLearningRequest
    {
        private bool? _computeStatistics;
        private string _dataSourceId;
        private string _dataSourceName;
        private RDSDataSpec _rdsData;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        /// The compute statistics for a <code>DataSource</code>. The statistics are generated
        /// from the observation data referenced by a <code>DataSource</code>. Amazon ML uses
        /// the statistics internally during an <code>MLModel</code> training. This parameter
        /// must be set to <code>true</code> if the <code></code>DataSource<code></code> needs
        /// to be used for <code>MLModel</code> training. 
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
        /// A user-supplied ID that uniquely identifies the <code>DataSource</code>. Typically,
        /// an Amazon Resource Number (ARN) becomes the ID for a <code>DataSource</code>.
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
        /// Gets and sets the property RDSData. 
        /// <para>
        /// The data specification of an Amazon RDS <code>DataSource</code>:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// DatabaseInformation - <ul> <li> <code>DatabaseName </code> - Name of the Amazon RDS
        /// database.</li> <li> <code> InstanceIdentifier </code> - Unique identifier for the
        /// Amazon RDS database instance.</li> </ul> 
        /// </para>
        /// </li> <li>
        /// <para>
        /// DatabaseCredentials - AWS Identity and Access Management (IAM) credentials that are
        /// used to connect to the Amazon RDS database.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ResourceRole - Role (DataPipelineDefaultResourceRole) assumed by an Amazon Elastic
        /// Compute Cloud (EC2) instance to carry out the copy task from Amazon RDS to Amazon
        /// S3. For more information, see <a href="http://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ServiceRole - Role (DataPipelineDefaultRole) assumed by the AWS Data Pipeline service
        /// to monitor the progress of the copy task from Amazon RDS to Amazon Simple Storage
        /// Service (S3). For more information, see <a href="http://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SecurityInfo - Security information to use to access an Amazon RDS instance. You need
        /// to set up appropriate ingress rules for the security entity IDs provided to allow
        /// access to the Amazon RDS instance. Specify a [<code>SubnetId</code>, <code>SecurityGroupIds</code>]
        /// pair for a VPC-based Amazon RDS instance.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SelectSqlQuery - Query that is used to retrieve the observation data for the <code>Datasource</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3StagingLocation - Amazon S3 location for staging RDS data. The data retrieved from
        /// Amazon RDS using <code>SelectSqlQuery</code> is stored in this location.
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
        public RDSDataSpec RDSData
        {
            get { return this._rdsData; }
            set { this._rdsData = value; }
        }

        // Check to see if RDSData property is set
        internal bool IsSetRDSData()
        {
            return this._rdsData != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The role that Amazon ML assumes on behalf of the user to create and activate a data
        /// pipeline in the user’s account and copy data (using the <code>SelectSqlQuery</code>)
        /// query from Amazon RDS to Amazon S3.
        /// </para>
        ///  
        /// <para>
        ///  
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
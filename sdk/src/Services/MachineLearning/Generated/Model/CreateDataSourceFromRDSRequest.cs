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
    /// Container for the parameters to the CreateDataSourceFromRDS operation.
    /// Creates a <c>DataSource</c> object from an <a href="http://aws.amazon.com/rds/"> Amazon
    /// Relational Database Service</a> (Amazon RDS). A <c>DataSource</c> references data
    /// that can be used to perform <c>CreateMLModel</c>, <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c>
    /// operations.
    /// 
    ///  
    /// <para>
    ///  <c>CreateDataSourceFromRDS</c> is an asynchronous operation. In response to <c>CreateDataSourceFromRDS</c>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>DataSource</c>
    /// status to <c>PENDING</c>. After the <c>DataSource</c> is created and ready for use,
    /// Amazon ML sets the <c>Status</c> parameter to <c>COMPLETED</c>. <c>DataSource</c>
    /// in the <c>COMPLETED</c> or <c>PENDING</c> state can be used only to perform <c>&gt;CreateMLModel</c>&gt;,
    /// <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c> operations. 
    /// </para>
    ///  
    /// <para>
    ///  If Amazon ML cannot accept the input source, it sets the <c>Status</c> parameter
    /// to <c>FAILED</c> and includes an error message in the <c>Message</c> attribute of
    /// the <c>GetDataSource</c> operation response. 
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
        /// The compute statistics for a <c>DataSource</c>. The statistics are generated from
        /// the observation data referenced by a <c>DataSource</c>. Amazon ML uses the statistics
        /// internally during <c>MLModel</c> training. This parameter must be set to <c>true</c>
        /// if the <code/>DataSource<code/> needs to be used for <c>MLModel</c> training. 
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
        /// A user-supplied ID that uniquely identifies the <c>DataSource</c>. Typically, an Amazon
        /// Resource Number (ARN) becomes the ID for a <c>DataSource</c>.
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
        /// Gets and sets the property RDSData. 
        /// <para>
        /// The data specification of an Amazon RDS <c>DataSource</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DatabaseInformation -
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DatabaseName</c> - The name of the Amazon RDS database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceIdentifier </c> - A unique identifier for the Amazon RDS database instance.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// DatabaseCredentials - AWS Identity and Access Management (IAM) credentials that are
        /// used to connect to the Amazon RDS database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResourceRole - A role (DataPipelineDefaultResourceRole) assumed by an EC2 instance
        /// to carry out the copy task from Amazon RDS to Amazon Simple Storage Service (Amazon
        /// S3). For more information, see <a href="https://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ServiceRole - A role (DataPipelineDefaultRole) assumed by the AWS Data Pipeline service
        /// to monitor the progress of the copy task from Amazon RDS to Amazon S3. For more information,
        /// see <a href="https://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SecurityInfo - The security information to use to access an RDS DB instance. You need
        /// to set up appropriate ingress rules for the security entity IDs provided to allow
        /// access to the Amazon RDS instance. Specify a [<c>SubnetId</c>, <c>SecurityGroupIds</c>]
        /// pair for a VPC-based RDS DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SelectSqlQuery - A query that is used to retrieve the observation data for the <c>Datasource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// S3StagingLocation - The Amazon S3 location for staging Amazon RDS data. The data retrieved
        /// from Amazon RDS using <c>SelectSqlQuery</c> is stored in this location.
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
        /// requirements for the <c>Datasource</c>. 
        /// </para>
        ///  
        /// <para>
        ///  Sample - <c> "{\"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// pipeline in the user's account and copy data using the <c>SelectSqlQuery</c> query
        /// from Amazon RDS to Amazon S3.
        /// </para>
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
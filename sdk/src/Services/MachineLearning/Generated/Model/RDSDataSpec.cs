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
    /// The data specification of an Amazon Relational Database Service (Amazon RDS) <code>DataSource</code>.
    /// </summary>
    public partial class RDSDataSpec
    {
        private RDSDatabaseCredentials _databaseCredentials;
        private RDSDatabase _databaseInformation;
        private string _dataRearrangement;
        private string _dataSchema;
        private string _dataSchemaUri;
        private string _resourceRole;
        private string _s3StagingLocation;
        private List<string> _securityGroupIds = new List<string>();
        private string _selectSqlQuery;
        private string _serviceRole;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property DatabaseCredentials. 
        /// <para>
        /// The AWS Identity and Access Management (IAM) credentials that are used connect to
        /// the Amazon RDS database.
        /// </para>
        /// </summary>
        public RDSDatabaseCredentials DatabaseCredentials
        {
            get { return this._databaseCredentials; }
            set { this._databaseCredentials = value; }
        }

        // Check to see if DatabaseCredentials property is set
        internal bool IsSetDatabaseCredentials()
        {
            return this._databaseCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseInformation. 
        /// <para>
        /// Describes the <code>DatabaseName</code> and <code>InstanceIdentifier</code> of an
        /// an Amazon RDS database.
        /// </para>
        /// </summary>
        public RDSDatabase DatabaseInformation
        {
            get { return this._databaseInformation; }
            set { this._databaseInformation = value; }
        }

        // Check to see if DatabaseInformation property is set
        internal bool IsSetDatabaseInformation()
        {
            return this._databaseInformation != null;
        }

        /// <summary>
        /// Gets and sets the property DataRearrangement. 
        /// <para>
        /// DataRearrangement - A JSON string that represents the splitting requirement of a <code>DataSource</code>.
        /// 
        /// </para>
        ///   
        /// <para>
        ///  Sample - <code> "{\"randomSeed\":\"some-random-seed\", \"splitting\":{\"percentBegin\":10,\"percentEnd\":60}}"</code>
        /// 
        /// </para>
        /// </summary>
        public string DataRearrangement
        {
            get { return this._dataRearrangement; }
            set { this._dataRearrangement = value; }
        }

        // Check to see if DataRearrangement property is set
        internal bool IsSetDataRearrangement()
        {
            return this._dataRearrangement != null;
        }

        /// <summary>
        /// Gets and sets the property DataSchema. 
        /// <para>
        /// A JSON string that represents the schema. This is not required if <code>DataSchemaUri</code>
        /// is specified. 
        /// </para>
        /// </summary>
        public string DataSchema
        {
            get { return this._dataSchema; }
            set { this._dataSchema = value; }
        }

        // Check to see if DataSchema property is set
        internal bool IsSetDataSchema()
        {
            return this._dataSchema != null;
        }

        /// <summary>
        /// Gets and sets the property DataSchemaUri. 
        /// <para>
        /// The Amazon S3 location of the <code>DataSchema</code>. 
        /// </para>
        /// </summary>
        public string DataSchemaUri
        {
            get { return this._dataSchemaUri; }
            set { this._dataSchemaUri = value; }
        }

        // Check to see if DataSchemaUri property is set
        internal bool IsSetDataSchemaUri()
        {
            return this._dataSchemaUri != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRole. 
        /// <para>
        /// The role (DataPipelineDefaultResourceRole) assumed by an Amazon Elastic Compute Cloud
        /// (Amazon EC2) instance to carry out the copy operation from Amazon RDS to an Amazon
        /// S3 task. For more information, see <a href="http://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        /// </summary>
        public string ResourceRole
        {
            get { return this._resourceRole; }
            set { this._resourceRole = value; }
        }

        // Check to see if ResourceRole property is set
        internal bool IsSetResourceRole()
        {
            return this._resourceRole != null;
        }

        /// <summary>
        /// Gets and sets the property S3StagingLocation. 
        /// <para>
        /// The Amazon S3 location for staging Amazon RDS data. The data retrieved from Amazon
        /// RDS using <code>SelectSqlQuery</code> is stored in this location.
        /// </para>
        /// </summary>
        public string S3StagingLocation
        {
            get { return this._s3StagingLocation; }
            set { this._s3StagingLocation = value; }
        }

        // Check to see if S3StagingLocation property is set
        internal bool IsSetS3StagingLocation()
        {
            return this._s3StagingLocation != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs to be used to access a VPC-based RDS DB instance. Ensure that
        /// there are appropriate ingress rules set up to allow access to the RDS DB instance.
        /// This attribute is used by Data Pipeline to carry out the copy operation from Amazon
        /// RDS to an Amazon S3 task.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelectSqlQuery. 
        /// <para>
        /// The query that is used to retrieve the observation data for the <code>DataSource</code>.
        /// </para>
        /// </summary>
        public string SelectSqlQuery
        {
            get { return this._selectSqlQuery; }
            set { this._selectSqlQuery = value; }
        }

        // Check to see if SelectSqlQuery property is set
        internal bool IsSetSelectSqlQuery()
        {
            return this._selectSqlQuery != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The role (DataPipelineDefaultRole) assumed by AWS Data Pipeline service to monitor
        /// the progress of the copy task from Amazon RDS to Amazon S3. For more information,
        /// see <a href="http://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID to be used to access a VPC-based RDS DB instance. This attribute is
        /// used by Data Pipeline to carry out the copy task from Amazon RDS to Amazon S3.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}
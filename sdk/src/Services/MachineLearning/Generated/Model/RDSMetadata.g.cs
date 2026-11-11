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
    /// The datasource details that are specific to Amazon RDS.
    /// </summary>
    public partial class RDSMetadata
    {
        /// <summary>
        /// Gets and sets the property DataPipelineId. 
        /// <para>
        /// The ID of the Data Pipeline instance that is used to carry to copy data from Amazon
        /// RDS to Amazon S3. You can use the ID to find details about the instance in the Data
        /// Pipeline console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DataPipelineId { get; set; }

        /// <summary>
        /// Checks to see if the DataPipelineId property is set.
        /// </summary>
        internal bool IsSetDataPipelineId() => this.DataPipelineId != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database details required to connect to an Amazon RDS.
        /// </para>
        /// </summary>
        public RDSDatabase Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property DatabaseUserName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DatabaseUserName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseUserName property is set.
        /// </summary>
        internal bool IsSetDatabaseUserName() => this.DatabaseUserName != null;

        /// <summary>
        /// Gets and sets the property ResourceRole. 
        /// <para>
        /// The role (DataPipelineDefaultResourceRole) assumed by an Amazon EC2 instance to carry
        /// out the copy task from Amazon RDS to Amazon S3. For more information, see <a href="https://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ResourceRole { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRole property is set.
        /// </summary>
        internal bool IsSetResourceRole() => this.ResourceRole != null;

        /// <summary>
        /// Gets and sets the property SelectSqlQuery. 
        /// <para>
        /// The SQL query that is supplied during <a>CreateDataSourceFromRDS</a>. Returns only
        /// if <c>Verbose</c> is true in <c>GetDataSourceInput</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16777216)]
        public string SelectSqlQuery { get; set; }

        /// <summary>
        /// Checks to see if the SelectSqlQuery property is set.
        /// </summary>
        internal bool IsSetSelectSqlQuery() => this.SelectSqlQuery != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The role (DataPipelineDefaultRole) assumed by the Data Pipeline service to monitor
        /// the progress of the copy task from Amazon RDS to Amazon S3. For more information,
        /// see <a href="https://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-iam-roles.html">Role
        /// templates</a> for data pipelines.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;
    }
}

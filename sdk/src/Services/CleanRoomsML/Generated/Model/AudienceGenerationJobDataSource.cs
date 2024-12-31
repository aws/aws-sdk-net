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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Defines the Amazon S3 bucket where the seed audience for the generating audience is
    /// stored.
    /// </summary>
    public partial class AudienceGenerationJobDataSource
    {
        private S3ConfigMap _dataSource;
        private string _roleArn;
        private ComputeConfiguration _sqlComputeConfiguration;
        private ProtectedQuerySQLParameters _sqlParameters;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Defines the Amazon S3 bucket where the seed audience for the generating audience is
        /// stored. A valid data source is a JSON line file in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"user_id": "111111"}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{"user_id": "222222"}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>...</c> 
        /// </para>
        /// </summary>
        public S3ConfigMap DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that can read the Amazon S3 bucket where the seed audience
        /// is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SqlComputeConfiguration.
        /// </summary>
        public ComputeConfiguration SqlComputeConfiguration
        {
            get { return this._sqlComputeConfiguration; }
            set { this._sqlComputeConfiguration = value; }
        }

        // Check to see if SqlComputeConfiguration property is set
        internal bool IsSetSqlComputeConfiguration()
        {
            return this._sqlComputeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqlParameters. 
        /// <para>
        /// The protected SQL query parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ProtectedQuerySQLParameters SqlParameters
        {
            get { return this._sqlParameters; }
            set { this._sqlParameters = value; }
        }

        // Check to see if SqlParameters property is set
        internal bool IsSetSqlParameters()
        {
            return this._sqlParameters != null;
        }

    }
}
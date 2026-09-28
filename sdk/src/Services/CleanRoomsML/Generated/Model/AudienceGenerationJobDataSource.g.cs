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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Defines the Amazon S3 bucket where the seed audience for the generating audience is
    /// stored.
    /// </summary>
    public partial class AudienceGenerationJobDataSource
    {
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
        public S3ConfigMap DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that can read the Amazon S3 bucket where the seed audience
        /// is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SqlComputeConfiguration.
        /// </summary>
        public ComputeConfiguration SqlComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SqlComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetSqlComputeConfiguration() => this.SqlComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property SqlParameters. 
        /// <para>
        /// The protected SQL query parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ProtectedQuerySQLParameters SqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqlParameters property is set.
        /// </summary>
        internal bool IsSetSqlParameters() => this.SqlParameters != null;
    }
}

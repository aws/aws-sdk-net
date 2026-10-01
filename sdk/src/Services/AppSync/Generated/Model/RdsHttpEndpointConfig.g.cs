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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The Amazon Relational Database Service (Amazon RDS) HTTP endpoint configuration.
    /// </summary>
    public partial class RdsHttpEndpointConfig
    {
        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// Amazon Web Services Region for Amazon RDS HTTP endpoint.
        /// </para>
        /// </summary>
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property AwsSecretStoreArn. 
        /// <para>
        /// Amazon Web Services secret store Amazon Resource Name (ARN) for database credentials.
        /// </para>
        /// </summary>
        public string AwsSecretStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsSecretStoreArn property is set.
        /// </summary>
        internal bool IsSetAwsSecretStoreArn() => this.AwsSecretStoreArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Logical database name.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// Amazon RDS cluster Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string DbClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDbClusterIdentifier() => this.DbClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Logical schema name.
        /// </para>
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;
    }
}

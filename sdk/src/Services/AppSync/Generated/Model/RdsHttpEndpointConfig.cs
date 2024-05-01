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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
        private string _awsRegion;
        private string _awsSecretStoreArn;
        private string _databaseName;
        private string _dbClusterIdentifier;
        private string _schema;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// Amazon Web Services Region for Amazon RDS HTTP endpoint.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSecretStoreArn. 
        /// <para>
        /// Amazon Web Services secret store Amazon Resource Name (ARN) for database credentials.
        /// </para>
        /// </summary>
        public string AwsSecretStoreArn
        {
            get { return this._awsSecretStoreArn; }
            set { this._awsSecretStoreArn = value; }
        }

        // Check to see if AwsSecretStoreArn property is set
        internal bool IsSetAwsSecretStoreArn()
        {
            return this._awsSecretStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Logical database name.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// Amazon RDS cluster Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string DbClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DbClusterIdentifier property is set
        internal bool IsSetDbClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Logical schema name.
        /// </para>
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Provides information about the Amazon Redshift database configuration.
    /// </summary>
    public partial class RedshiftSourceConfig
    {
        private string _clusterIdentifier;
        private string _databaseHost;
        private string _databaseName;
        private int? _databasePort;
        private string _roleArn;
        private string _secretManagerArn;
        private string _tableName;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// A string identifying the Redshift cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseHost. 
        /// <para>
        /// The name of the database host.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string DatabaseHost
        {
            get { return this._databaseHost; }
            set { this._databaseHost = value; }
        }

        // Check to see if DatabaseHost property is set
        internal bool IsSetDatabaseHost()
        {
            return this._databaseHost != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Redshift database name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property DatabasePort. 
        /// <para>
        /// The port number where the database can be accessed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? DatabasePort
        {
            get { return this._databasePort; }
            set { this._databasePort = value; }
        }

        // Check to see if DatabasePort property is set
        internal bool IsSetDatabasePort()
        {
            return this._databasePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role providing access to the database.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property SecretManagerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Secrets Manager role.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SecretManagerArn
        {
            get { return this._secretManagerArn; }
            set { this._secretManagerArn = value; }
        }

        // Check to see if SecretManagerArn property is set
        internal bool IsSetSecretManagerArn()
        {
            return this._secretManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name of the Redshift database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Contains information about the Amazon Virtual Private Cloud (VPC) configuration.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}
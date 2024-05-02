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
    /// Details about an Amazon Athena datasource.
    /// </summary>
    public partial class AthenaSourceConfig
    {
        private BackTestConfiguration _backTestConfiguration;
        private string _databaseName;
        private string _dataCatalog;
        private string _roleArn;
        private string _s3ResultsPath;
        private string _tableName;
        private string _workGroupName;

        /// <summary>
        /// Gets and sets the property BackTestConfiguration. 
        /// <para>
        /// Settings for backtest mode.
        /// </para>
        /// </summary>
        public BackTestConfiguration BackTestConfiguration
        {
            get { return this._backTestConfiguration; }
            set { this._backTestConfiguration = value; }
        }

        // Check to see if BackTestConfiguration property is set
        internal bool IsSetBackTestConfiguration()
        {
            return this._backTestConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property DataCatalog. 
        /// <para>
        /// The database's data catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataCatalog
        {
            get { return this._dataCatalog; }
            set { this._dataCatalog = value; }
        }

        // Check to see if DataCatalog property is set
        internal bool IsSetDataCatalog()
        {
            return this._dataCatalog != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An IAM role that gives Amazon Lookout for Metrics permission to access the data.
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
        /// Gets and sets the property S3ResultsPath. 
        /// <para>
        /// The database's results path.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3ResultsPath
        {
            get { return this._s3ResultsPath; }
            set { this._s3ResultsPath = value; }
        }

        // Check to see if S3ResultsPath property is set
        internal bool IsSetS3ResultsPath()
        {
            return this._s3ResultsPath != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The database's table name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property WorkGroupName. 
        /// <para>
        /// The database's work group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string WorkGroupName
        {
            get { return this._workGroupName; }
            set { this._workGroupName = value; }
        }

        // Check to see if WorkGroupName property is set
        internal bool IsSetWorkGroupName()
        {
            return this._workGroupName != null;
        }

    }
}
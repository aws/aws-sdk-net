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
    /// Contains information about source data used to generate metrics.
    /// </summary>
    public partial class MetricSource
    {
        private AppFlowConfig _appFlowConfig;
        private AthenaSourceConfig _athenaSourceConfig;
        private CloudWatchConfig _cloudWatchConfig;
        private RDSSourceConfig _rdsSourceConfig;
        private RedshiftSourceConfig _redshiftSourceConfig;
        private S3SourceConfig _s3SourceConfig;

        /// <summary>
        /// Gets and sets the property AppFlowConfig. 
        /// <para>
        /// Details about an AppFlow datasource.
        /// </para>
        /// </summary>
        public AppFlowConfig AppFlowConfig
        {
            get { return this._appFlowConfig; }
            set { this._appFlowConfig = value; }
        }

        // Check to see if AppFlowConfig property is set
        internal bool IsSetAppFlowConfig()
        {
            return this._appFlowConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AthenaSourceConfig. 
        /// <para>
        /// Details about an Amazon Athena datasource.
        /// </para>
        /// </summary>
        public AthenaSourceConfig AthenaSourceConfig
        {
            get { return this._athenaSourceConfig; }
            set { this._athenaSourceConfig = value; }
        }

        // Check to see if AthenaSourceConfig property is set
        internal bool IsSetAthenaSourceConfig()
        {
            return this._athenaSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchConfig. 
        /// <para>
        /// Details about an Amazon CloudWatch monitoring datasource.
        /// </para>
        /// </summary>
        public CloudWatchConfig CloudWatchConfig
        {
            get { return this._cloudWatchConfig; }
            set { this._cloudWatchConfig = value; }
        }

        // Check to see if CloudWatchConfig property is set
        internal bool IsSetCloudWatchConfig()
        {
            return this._cloudWatchConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RDSSourceConfig. 
        /// <para>
        /// Details about an Amazon Relational Database Service (RDS) datasource.
        /// </para>
        /// </summary>
        public RDSSourceConfig RDSSourceConfig
        {
            get { return this._rdsSourceConfig; }
            set { this._rdsSourceConfig = value; }
        }

        // Check to see if RDSSourceConfig property is set
        internal bool IsSetRDSSourceConfig()
        {
            return this._rdsSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftSourceConfig. 
        /// <para>
        /// Details about an Amazon Redshift database datasource.
        /// </para>
        /// </summary>
        public RedshiftSourceConfig RedshiftSourceConfig
        {
            get { return this._redshiftSourceConfig; }
            set { this._redshiftSourceConfig = value; }
        }

        // Check to see if RedshiftSourceConfig property is set
        internal bool IsSetRedshiftSourceConfig()
        {
            return this._redshiftSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property S3SourceConfig.
        /// </summary>
        public S3SourceConfig S3SourceConfig
        {
            get { return this._s3SourceConfig; }
            set { this._s3SourceConfig = value; }
        }

        // Check to see if S3SourceConfig property is set
        internal bool IsSetS3SourceConfig()
        {
            return this._s3SourceConfig != null;
        }

    }
}
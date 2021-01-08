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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the starting parameters for an Kinesis Data Analytics application.
    /// </summary>
    public partial class RunConfiguration
    {
        private ApplicationRestoreConfiguration _applicationRestoreConfiguration;
        private FlinkRunConfiguration _flinkRunConfiguration;
        private List<SqlRunConfiguration> _sqlRunConfigurations = new List<SqlRunConfiguration>();

        /// <summary>
        /// Gets and sets the property ApplicationRestoreConfiguration. 
        /// <para>
        /// Describes the restore behavior of a restarting application.
        /// </para>
        /// </summary>
        public ApplicationRestoreConfiguration ApplicationRestoreConfiguration
        {
            get { return this._applicationRestoreConfiguration; }
            set { this._applicationRestoreConfiguration = value; }
        }

        // Check to see if ApplicationRestoreConfiguration property is set
        internal bool IsSetApplicationRestoreConfiguration()
        {
            return this._applicationRestoreConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkRunConfiguration. 
        /// <para>
        /// Describes the starting parameters for a Flink-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public FlinkRunConfiguration FlinkRunConfiguration
        {
            get { return this._flinkRunConfiguration; }
            set { this._flinkRunConfiguration = value; }
        }

        // Check to see if FlinkRunConfiguration property is set
        internal bool IsSetFlinkRunConfiguration()
        {
            return this._flinkRunConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqlRunConfigurations. 
        /// <para>
        /// Describes the starting parameters for a SQL-based Kinesis Data Analytics application
        /// application.
        /// </para>
        /// </summary>
        public List<SqlRunConfiguration> SqlRunConfigurations
        {
            get { return this._sqlRunConfigurations; }
            set { this._sqlRunConfigurations = value; }
        }

        // Check to see if SqlRunConfigurations property is set
        internal bool IsSetSqlRunConfigurations()
        {
            return this._sqlRunConfigurations != null && this._sqlRunConfigurations.Count > 0; 
        }

    }
}
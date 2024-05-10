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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the updates to the starting parameters for a Managed Service for Apache
    /// Flink application.
    /// </summary>
    public partial class RunConfigurationUpdate
    {
        private ApplicationRestoreConfiguration _applicationRestoreConfiguration;
        private FlinkRunConfiguration _flinkRunConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationRestoreConfiguration. 
        /// <para>
        /// Describes updates to the restore behavior of a restarting application.
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
        /// Describes the starting parameters for a Managed Service for Apache Flink application.
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

    }
}
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
    /// Describes the starting properties for a Managed Service for Apache Flink application.
    /// </summary>
    public partial class RunConfigurationDescription
    {
        private ApplicationRestoreConfiguration _applicationRestoreConfigurationDescription;
        private FlinkRunConfiguration _flinkRunConfigurationDescription;

        /// <summary>
        /// Gets and sets the property ApplicationRestoreConfigurationDescription. 
        /// <para>
        /// Describes the restore behavior of a restarting application.
        /// </para>
        /// </summary>
        public ApplicationRestoreConfiguration ApplicationRestoreConfigurationDescription
        {
            get { return this._applicationRestoreConfigurationDescription; }
            set { this._applicationRestoreConfigurationDescription = value; }
        }

        // Check to see if ApplicationRestoreConfigurationDescription property is set
        internal bool IsSetApplicationRestoreConfigurationDescription()
        {
            return this._applicationRestoreConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkRunConfigurationDescription.
        /// </summary>
        public FlinkRunConfiguration FlinkRunConfigurationDescription
        {
            get { return this._flinkRunConfigurationDescription; }
            set { this._flinkRunConfigurationDescription = value; }
        }

        // Check to see if FlinkRunConfigurationDescription property is set
        internal bool IsSetFlinkRunConfigurationDescription()
        {
            return this._flinkRunConfigurationDescription != null;
        }

    }
}
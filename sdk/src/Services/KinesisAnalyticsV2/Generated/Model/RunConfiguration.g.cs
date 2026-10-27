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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the starting parameters for an Managed Service for Apache Flink application.
    /// </summary>
    public partial class RunConfiguration
    {
        /// <summary>
        /// Gets and sets the property ApplicationRestoreConfiguration. 
        /// <para>
        /// Describes the restore behavior of a restarting application.
        /// </para>
        /// </summary>
        public ApplicationRestoreConfiguration ApplicationRestoreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationRestoreConfiguration property is set.
        /// </summary>
        internal bool IsSetApplicationRestoreConfiguration() => this.ApplicationRestoreConfiguration != null;

        /// <summary>
        /// Gets and sets the property FlinkRunConfiguration. 
        /// <para>
        /// Describes the starting parameters for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public FlinkRunConfiguration FlinkRunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FlinkRunConfiguration property is set.
        /// </summary>
        internal bool IsSetFlinkRunConfiguration() => this.FlinkRunConfiguration != null;

        /// <summary>
        /// Gets and sets the property SqlRunConfigurations. 
        /// <para>
        /// Describes the starting parameters for a SQL-based Kinesis Data Analytics application
        /// application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SqlRunConfiguration> SqlRunConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SqlRunConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SqlRunConfigurations property is set.
        /// </summary>
        internal bool IsSetSqlRunConfigurations() => this.SqlRunConfigurations != null && (this.SqlRunConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

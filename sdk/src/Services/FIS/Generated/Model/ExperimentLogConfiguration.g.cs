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

namespace Amazon.FIS.Model
{
    /// <summary>
    /// Describes the configuration for experiment logging.
    /// </summary>
    public partial class ExperimentLogConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsConfiguration. 
        /// <para>
        /// The configuration for experiment logging to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public ExperimentCloudWatchLogsLogConfiguration CloudWatchLogsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsConfiguration() => this.CloudWatchLogsConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogSchemaVersion. 
        /// <para>
        /// The schema version.
        /// </para>
        /// </summary>
        public int? LogSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the LogSchemaVersion property is set.
        /// </summary>
        internal bool IsSetLogSchemaVersion() => this.LogSchemaVersion.HasValue;

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The configuration for experiment logging to Amazon S3.
        /// </para>
        /// </summary>
        public ExperimentS3LogConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;
    }
}

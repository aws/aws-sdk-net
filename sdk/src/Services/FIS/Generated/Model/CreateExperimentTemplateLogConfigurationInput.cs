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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
    /// Specifies the configuration for experiment logging.
    /// </summary>
    public partial class CreateExperimentTemplateLogConfigurationInput
    {
        private ExperimentTemplateCloudWatchLogsLogConfigurationInput _cloudWatchLogsConfiguration;
        private int? _logSchemaVersion;
        private ExperimentTemplateS3LogConfigurationInput _s3Configuration;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsConfiguration. 
        /// <para>
        /// The configuration for experiment logging to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public ExperimentTemplateCloudWatchLogsLogConfigurationInput CloudWatchLogsConfiguration
        {
            get { return this._cloudWatchLogsConfiguration; }
            set { this._cloudWatchLogsConfiguration = value; }
        }

        // Check to see if CloudWatchLogsConfiguration property is set
        internal bool IsSetCloudWatchLogsConfiguration()
        {
            return this._cloudWatchLogsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LogSchemaVersion. 
        /// <para>
        /// The schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? LogSchemaVersion
        {
            get { return this._logSchemaVersion; }
            set { this._logSchemaVersion = value; }
        }

        // Check to see if LogSchemaVersion property is set
        internal bool IsSetLogSchemaVersion()
        {
            return this._logSchemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The configuration for experiment logging to Amazon S3.
        /// </para>
        /// </summary>
        public ExperimentTemplateS3LogConfigurationInput S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

    }
}
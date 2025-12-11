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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateTelemetryPipelineConfiguration operation.
    /// Validates a pipeline configuration without creating the pipeline. This operation checks
    /// the configuration for syntax errors and compatibility issues.
    /// </summary>
    public partial class ValidateTelemetryPipelineConfigurationRequest : AmazonObservabilityAdminRequest
    {
        private TelemetryPipelineConfiguration _configuration;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The pipeline configuration to validate for syntax and compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TelemetryPipelineConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

    }
}
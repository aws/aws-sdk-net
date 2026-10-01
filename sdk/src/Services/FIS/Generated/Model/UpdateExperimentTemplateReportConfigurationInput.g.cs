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
    /// Specifies the input for the experiment report configuration.
    /// </summary>
    public partial class UpdateExperimentTemplateReportConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// The data sources for the experiment report.
        /// </para>
        /// </summary>
        public ExperimentTemplateReportConfigurationDataSourcesInput DataSources { get; set; }

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// Describes the output destinations of the experiment report. 
        /// </para>
        /// </summary>
        public ExperimentTemplateReportConfigurationOutputsInput Outputs { get; set; }

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null;

        /// <summary>
        /// Gets and sets the property PostExperimentDuration. 
        /// <para>
        /// The duration after the experiment end time for the data sources to include in the
        /// report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string PostExperimentDuration { get; set; }

        /// <summary>
        /// Checks to see if the PostExperimentDuration property is set.
        /// </summary>
        internal bool IsSetPostExperimentDuration() => this.PostExperimentDuration != null;

        /// <summary>
        /// Gets and sets the property PreExperimentDuration. 
        /// <para>
        /// The duration before the experiment start time for the data sources to include in the
        /// report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string PreExperimentDuration { get; set; }

        /// <summary>
        /// Checks to see if the PreExperimentDuration property is set.
        /// </summary>
        internal bool IsSetPreExperimentDuration() => this.PreExperimentDuration != null;
    }
}

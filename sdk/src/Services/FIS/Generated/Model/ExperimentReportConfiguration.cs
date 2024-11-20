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
    /// Describes the report configuration for the experiment. For more information, see <a
    /// href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-report-configuration">Experiment
    /// report configurations for AWS FIS</a>.
    /// </summary>
    public partial class ExperimentReportConfiguration
    {
        private ExperimentReportConfigurationDataSources _dataSources;
        private ExperimentReportConfigurationOutputs _outputs;
        private string _postExperimentDuration;
        private string _preExperimentDuration;

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// The data sources for the experiment report.
        /// </para>
        /// </summary>
        public ExperimentReportConfigurationDataSources DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The output destinations of the experiment report.
        /// </para>
        /// </summary>
        public ExperimentReportConfigurationOutputs Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null;
        }

        /// <summary>
        /// Gets and sets the property PostExperimentDuration. 
        /// <para>
        /// The duration after the experiment end time for the data sources to include in the
        /// report.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string PostExperimentDuration
        {
            get { return this._postExperimentDuration; }
            set { this._postExperimentDuration = value; }
        }

        // Check to see if PostExperimentDuration property is set
        internal bool IsSetPostExperimentDuration()
        {
            return this._postExperimentDuration != null;
        }

        /// <summary>
        /// Gets and sets the property PreExperimentDuration. 
        /// <para>
        /// The duration before the experiment start time for the data sources to include in the
        /// report.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string PreExperimentDuration
        {
            get { return this._preExperimentDuration; }
            set { this._preExperimentDuration = value; }
        }

        // Check to see if PreExperimentDuration property is set
        internal bool IsSetPreExperimentDuration()
        {
            return this._preExperimentDuration != null;
        }

    }
}
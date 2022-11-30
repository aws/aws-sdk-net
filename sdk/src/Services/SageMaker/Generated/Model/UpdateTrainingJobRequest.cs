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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrainingJob operation.
    /// Update a model training job to request a new Debugger profiling configuration or to
    /// change warm pool retention length.
    /// </summary>
    public partial class UpdateTrainingJobRequest : AmazonSageMakerRequest
    {
        private ProfilerConfigForUpdate _profilerConfig;
        private List<ProfilerRuleConfiguration> _profilerRuleConfigurations = new List<ProfilerRuleConfiguration>();
        private ResourceConfigForUpdate _resourceConfig;
        private string _trainingJobName;

        /// <summary>
        /// Gets and sets the property ProfilerConfig. 
        /// <para>
        /// Configuration information for Amazon SageMaker Debugger system monitoring, framework
        /// profiling, and storage paths.
        /// </para>
        /// </summary>
        public ProfilerConfigForUpdate ProfilerConfig
        {
            get { return this._profilerConfig; }
            set { this._profilerConfig = value; }
        }

        // Check to see if ProfilerConfig property is set
        internal bool IsSetProfilerConfig()
        {
            return this._profilerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilerRuleConfigurations. 
        /// <para>
        /// Configuration information for Amazon SageMaker Debugger rules for profiling system
        /// and framework metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ProfilerRuleConfiguration> ProfilerRuleConfigurations
        {
            get { return this._profilerRuleConfigurations; }
            set { this._profilerRuleConfigurations = value; }
        }

        // Check to see if ProfilerRuleConfigurations property is set
        internal bool IsSetProfilerRuleConfigurations()
        {
            return this._profilerRuleConfigurations != null && this._profilerRuleConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The training job <code>ResourceConfig</code> to update warm pool retention length.
        /// </para>
        /// </summary>
        public ResourceConfigForUpdate ResourceConfig
        {
            get { return this._resourceConfig; }
            set { this._resourceConfig = value; }
        }

        // Check to see if ResourceConfig property is set
        internal bool IsSetResourceConfig()
        {
            return this._resourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of a training job to update the Debugger profiling configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
        }

    }
}
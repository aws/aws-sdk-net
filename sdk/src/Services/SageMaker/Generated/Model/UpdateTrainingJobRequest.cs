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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<ProfilerRuleConfiguration> _profilerRuleConfigurations = AWSConfigs.InitializeCollections ? new List<ProfilerRuleConfiguration>() : null;
        private RemoteDebugConfigForUpdate _remoteDebugConfig;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._profilerRuleConfigurations != null && (this._profilerRuleConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoteDebugConfig. 
        /// <para>
        /// Configuration for remote debugging while the training job is running. You can update
        /// the remote debugging configuration when the <c>SecondaryStatus</c> of the job is <c>Downloading</c>
        /// or <c>Training</c>.To learn more about the remote debugging functionality of SageMaker,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-remote-debugging.html">Access
        /// a training container through Amazon Web Services Systems Manager (SSM) for remote
        /// debugging</a>.
        /// </para>
        /// </summary>
        public RemoteDebugConfigForUpdate RemoteDebugConfig
        {
            get { return this._remoteDebugConfig; }
            set { this._remoteDebugConfig = value; }
        }

        // Check to see if RemoteDebugConfig property is set
        internal bool IsSetRemoteDebugConfig()
        {
            return this._remoteDebugConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The training job <c>ResourceConfig</c> to update warm pool retention length.
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
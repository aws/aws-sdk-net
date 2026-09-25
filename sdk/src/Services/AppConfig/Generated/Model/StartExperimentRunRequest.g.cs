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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the StartExperimentRun operation. Starts an experiment
    /// run for the specified experiment definition. An experiment run delivers treatments
    /// to the target audience and collects metrics. You can start multiple experiment runs
    /// from the same experiment definition. <note> <para> Billing for this experiment begins
    /// when you call this operation and continues until the experiment is stopped. For pricing
    /// details, see <a href="https://aws.amazon.com/systems-manager/pricing/">AppConfig pricing</a>.
    /// </para> </note>
    /// </summary>
    public partial class StartExperimentRunRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The application ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetApplicationIdentifier() => this.ApplicationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeploymentParameters. 
        /// <para>
        /// The deployment parameters for the experiment run, including a KMS key identifier for
        /// encryption.
        /// </para>
        /// </summary>
        public DeploymentParameters DeploymentParameters { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentParameters property is set.
        /// </summary>
        internal bool IsSetDeploymentParameters() => this.DeploymentParameters != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of this experiment run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionIdentifier. 
        /// <para>
        /// The experiment definition ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ExperimentDefinitionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentDefinitionIdentifier property is set.
        /// </summary>
        internal bool IsSetExperimentDefinitionIdentifier() => this.ExperimentDefinitionIdentifier != null;

        /// <summary>
        /// Gets and sets the property ExposurePercentage. 
        /// <para>
        /// The percentage of the target audience to expose to treatments. Set to 0 to validate
        /// the experiment before exposing production users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ExposurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ExposurePercentage property is set.
        /// </summary>
        internal bool IsSetExposurePercentage() => this.ExposurePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the experiment run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// Treatment assignment overrides that assign specific entity IDs to treatments directly,
        /// bypassing random assignment.
        /// </para>
        /// </summary>
        public TreatmentOverrides TreatmentOverrides { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentOverrides property is set.
        /// </summary>
        internal bool IsSetTreatmentOverrides() => this.TreatmentOverrides != null;
    }
}

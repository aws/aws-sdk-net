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
    /// Container for the parameters to the UpdateExperimentRun operation. Updates a running
    /// experiment. Use this operation to increase audience exposure, modify treatment assignment
    /// overrides, or update the description of an active experiment run. Audience exposure
    /// can only be increased, not decreased.
    /// </summary>
    public partial class UpdateExperimentRunRequest : AmazonAppConfigRequest
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
        /// The updated deployment parameters for the experiment run.
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
        /// An updated description for the experiment run.
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
        /// The new exposure percentage. This value can only be increased from the current setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ExposurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ExposurePercentage property is set.
        /// </summary>
        internal bool IsSetExposurePercentage() => this.ExposurePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The run number to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Run { get; set; }

        /// <summary>
        /// Checks to see if the Run property is set.
        /// </summary>
        internal bool IsSetRun() => this.Run.HasValue;

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// The updated treatment assignment overrides that assign specific entity IDs to treatments,
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

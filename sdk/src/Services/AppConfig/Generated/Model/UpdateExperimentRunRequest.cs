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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
    /// Container for the parameters to the UpdateExperimentRun operation.
    /// Updates a running experiment. Use this operation to increase audience exposure, modify
    /// treatment assignment overrides, or update the description of an active experiment
    /// run. Audience exposure can only be increased, not decreased.
    /// </summary>
    public partial class UpdateExperimentRunRequest : AmazonAppConfigRequest
    {
        private string _applicationIdentifier;
        private DeploymentParameters _deploymentParameters;
        private string _description;
        private string _experimentDefinitionIdentifier;
        private float? _exposurePercentage;
        private int? _run;
        private TreatmentOverrides _treatmentOverrides;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The application ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentParameters. 
        /// <para>
        /// Updated deployment parameters.
        /// </para>
        /// </summary>
        public DeploymentParameters DeploymentParameters
        {
            get { return this._deploymentParameters; }
            set { this._deploymentParameters = value; }
        }

        // Check to see if DeploymentParameters property is set
        internal bool IsSetDeploymentParameters()
        {
            return this._deploymentParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description for the experiment run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionIdentifier. 
        /// <para>
        /// The experiment definition ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ExperimentDefinitionIdentifier
        {
            get { return this._experimentDefinitionIdentifier; }
            set { this._experimentDefinitionIdentifier = value; }
        }

        // Check to see if ExperimentDefinitionIdentifier property is set
        internal bool IsSetExperimentDefinitionIdentifier()
        {
            return this._experimentDefinitionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ExposurePercentage. 
        /// <para>
        /// The new exposure percentage. This value can only be increased from the current setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? ExposurePercentage
        {
            get { return this._exposurePercentage; }
            set { this._exposurePercentage = value; }
        }

        // Check to see if ExposurePercentage property is set
        internal bool IsSetExposurePercentage()
        {
            return this._exposurePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The run number to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Run
        {
            get { return this._run; }
            set { this._run = value; }
        }

        // Check to see if Run property is set
        internal bool IsSetRun()
        {
            return this._run.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// Updated treatment assignment overrides.
        /// </para>
        /// </summary>
        public TreatmentOverrides TreatmentOverrides
        {
            get { return this._treatmentOverrides; }
            set { this._treatmentOverrides = value; }
        }

        // Check to see if TreatmentOverrides property is set
        internal bool IsSetTreatmentOverrides()
        {
            return this._treatmentOverrides != null;
        }

    }
}
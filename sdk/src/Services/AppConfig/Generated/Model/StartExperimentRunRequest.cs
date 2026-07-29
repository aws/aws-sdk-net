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
    /// Container for the parameters to the StartExperimentRun operation.
    /// Starts an experiment run for the specified experiment definition. An experiment run
    /// delivers treatments to the target audience and collects metrics. You can start multiple
    /// experiment runs from the same experiment definition.
    /// 
    ///  <note> 
    /// <para>
    /// Billing for this experiment begins when you call this operation and continues until
    /// the experiment is stopped. For pricing details, see <a href="https://aws.amazon.com/systems-manager/pricing/">AppConfig
    /// pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartExperimentRunRequest : AmazonAppConfigRequest
    {
        private string _applicationIdentifier;
        private DeploymentParameters _deploymentParameters;
        private string _description;
        private string _experimentDefinitionIdentifier;
        private float? _exposurePercentage;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// The deployment parameters for the experiment run, including a KMS key identifier for
        /// encryption.
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
        /// A description of this experiment run.
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
        /// The percentage of the target audience to expose to treatments. Set to 0 to validate
        /// the experiment before exposing production users.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the experiment run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// Treatment assignment overrides that assign specific entity IDs to treatments directly,
        /// bypassing random assignment.
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
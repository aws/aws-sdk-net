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
    /// Container for the parameters to the CreateExperimentDefinition operation.
    /// Creates an experiment definition in AppConfig. An experiment definition describes
    /// the purpose, scope, and operational configuration of an experiment, including the
    /// target audience, feature flag, and treatment configurations.
    /// </summary>
    public partial class CreateExperimentDefinitionRequest : AmazonAppConfigRequest
    {
        private string _applicationIdentifier;
        private string _audienceDescription;
        private string _audienceRule;
        private string _configurationProfileIdentifier;
        private TreatmentInput _control;
        private string _environmentIdentifier;
        private string _flagKey;
        private string _hypothesis;
        private string _launchCriteria;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<TreatmentInput> _treatments = AWSConfigs.InitializeCollections ? new List<TreatmentInput>() : null;

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
        /// Gets and sets the property AudienceDescription. 
        /// <para>
        /// A description of the intended audience for the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AudienceDescription
        {
            get { return this._audienceDescription; }
            set { this._audienceDescription = value; }
        }

        // Check to see if AudienceDescription property is set
        internal bool IsSetAudienceDescription()
        {
            return this._audienceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AudienceRule. 
        /// <para>
        /// A rule that defines which users are eligible to be assigned to treatments during the
        /// experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16384)]
        public string AudienceRule
        {
            get { return this._audienceRule; }
            set { this._audienceRule = value; }
        }

        // Check to see if AudienceRule property is set
        internal bool IsSetAudienceRule()
        {
            return this._audienceRule != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileIdentifier. 
        /// <para>
        /// The configuration profile ID or name that stores the feature flag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConfigurationProfileIdentifier
        {
            get { return this._configurationProfileIdentifier; }
            set { this._configurationProfileIdentifier = value; }
        }

        // Check to see if ConfigurationProfileIdentifier property is set
        internal bool IsSetConfigurationProfileIdentifier()
        {
            return this._configurationProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// The control treatment that represents the baseline experience for comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TreatmentInput Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The environment ID or name where the experiment will run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FlagKey. 
        /// <para>
        /// The key of the existing feature flag to use with the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlagKey
        {
            get { return this._flagKey; }
            set { this._flagKey = value; }
        }

        // Check to see if FlagKey property is set
        internal bool IsSetFlagKey()
        {
            return this._flagKey != null;
        }

        /// <summary>
        /// Gets and sets the property Hypothesis. 
        /// <para>
        /// A description of the goal or hypothesis the experiment is designed to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Hypothesis
        {
            get { return this._hypothesis; }
            set { this._hypothesis = value; }
        }

        // Check to see if Hypothesis property is set
        internal bool IsSetHypothesis()
        {
            return this._hypothesis != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchCriteria. 
        /// <para>
        /// Information about the conditions under which you would launch the winning treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LaunchCriteria
        {
            get { return this._launchCriteria; }
            set { this._launchCriteria = value; }
        }

        // Check to see if LaunchCriteria property is set
        internal bool IsSetLaunchCriteria()
        {
            return this._launchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the experiment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the experiment definition. Tags help organize and categorize
        /// your AppConfig resources.
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
        /// Gets and sets the property Treatments. 
        /// <para>
        /// A list of treatments to evaluate during the experiment. Each treatment defines a distinct
        /// variation compared to the control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<TreatmentInput> Treatments
        {
            get { return this._treatments; }
            set { this._treatments = value; }
        }

        // Check to see if Treatments property is set
        internal bool IsSetTreatments()
        {
            return this._treatments != null && (this._treatments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
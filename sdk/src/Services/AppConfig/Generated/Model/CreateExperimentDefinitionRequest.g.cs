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
    /// Container for the parameters to the CreateExperimentDefinition operation. Creates
    /// an experiment definition in AppConfig. An experiment definition describes the purpose,
    /// scope, and operational configuration of an experiment, including the target audience,
    /// feature flag, and treatment configurations.
    /// </summary>
    public partial class CreateExperimentDefinitionRequest : AmazonAppConfigRequest
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
        /// Gets and sets the property AudienceDescription. 
        /// <para>
        /// A description of the intended audience for the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AudienceDescription { get; set; }

        /// <summary>
        /// Checks to see if the AudienceDescription property is set.
        /// </summary>
        internal bool IsSetAudienceDescription() => this.AudienceDescription != null;

        /// <summary>
        /// Gets and sets the property AudienceRule. 
        /// <para>
        /// A rule that defines which users are eligible to be assigned to treatments during the
        /// experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16384)]
        public string AudienceRule { get; set; }

        /// <summary>
        /// Checks to see if the AudienceRule property is set.
        /// </summary>
        internal bool IsSetAudienceRule() => this.AudienceRule != null;

        /// <summary>
        /// Gets and sets the property ConfigurationProfileIdentifier. 
        /// <para>
        /// The configuration profile ID or name that stores the feature flag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ConfigurationProfileIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationProfileIdentifier property is set.
        /// </summary>
        internal bool IsSetConfigurationProfileIdentifier() => this.ConfigurationProfileIdentifier != null;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// The control treatment that represents the baseline experience for comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TreatmentInput Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The environment ID or name where the experiment will run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlagKey. 
        /// <para>
        /// The key of the existing feature flag to use with the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlagKey { get; set; }

        /// <summary>
        /// Checks to see if the FlagKey property is set.
        /// </summary>
        internal bool IsSetFlagKey() => this.FlagKey != null;

        /// <summary>
        /// Gets and sets the property Hypothesis. 
        /// <para>
        /// A description of the goal or hypothesis the experiment is designed to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Hypothesis { get; set; }

        /// <summary>
        /// Checks to see if the Hypothesis property is set.
        /// </summary>
        internal bool IsSetHypothesis() => this.Hypothesis != null;

        /// <summary>
        /// Gets and sets the property LaunchCriteria. 
        /// <para>
        /// Information about the conditions under which you would launch the winning treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LaunchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the LaunchCriteria property is set.
        /// </summary>
        internal bool IsSetLaunchCriteria() => this.LaunchCriteria != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the experiment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the experiment definition. Tags help organize and categorize
        /// your AppConfig resources.
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
        /// Gets and sets the property Treatments. 
        /// <para>
        /// A list of treatments to evaluate during the experiment. Each treatment defines a distinct
        /// variation compared to the control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<TreatmentInput> Treatments { get; set; } = AWSConfigs.InitializeCollections ? new List<TreatmentInput>() : null;

        /// <summary>
        /// Checks to see if the Treatments property is set.
        /// </summary>
        internal bool IsSetTreatments() => this.Treatments != null && (this.Treatments.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

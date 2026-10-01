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
    /// This is the response object from the UpdateExperimentDefinition operation.
    /// </summary>
    public partial class UpdateExperimentDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

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
        /// The rule that defines which users are eligible to be assigned to treatments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string AudienceRule { get; set; }

        /// <summary>
        /// Checks to see if the AudienceRule property is set.
        /// </summary>
        internal bool IsSetAudienceRule() => this.AudienceRule != null;

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The configuration profile ID associated with the experiment.
        /// </para>
        /// </summary>
        public string ConfigurationProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationProfileId property is set.
        /// </summary>
        internal bool IsSetConfigurationProfileId() => this.ConfigurationProfileId != null;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// The control treatment used as the baseline for comparison.
        /// </para>
        /// </summary>
        public Treatment Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the experiment definition was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The environment ID where the experiment runs.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property FlagKey. 
        /// <para>
        /// The key of the feature flag used by the experiment.
        /// </para>
        /// </summary>
        public string FlagKey { get; set; }

        /// <summary>
        /// Checks to see if the FlagKey property is set.
        /// </summary>
        internal bool IsSetFlagKey() => this.FlagKey != null;

        /// <summary>
        /// Gets and sets the property Hypothesis. 
        /// <para>
        /// The hypothesis that the experiment is designed to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Hypothesis { get; set; }

        /// <summary>
        /// Checks to see if the Hypothesis property is set.
        /// </summary>
        internal bool IsSetHypothesis() => this.Hypothesis != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The experiment definition ID.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt experiment data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LaunchCriteria. 
        /// <para>
        /// The conditions under which the winning treatment should be launched.
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
        /// The name of the experiment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the experiment definition. Valid values: <c>ACTIVE</c>, <c>IDLE</c>,
        /// <c>ARCHIVED</c>.
        /// </para>
        /// </summary>
        public ExperimentDefinitionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Treatments. 
        /// <para>
        /// The list of treatments defined for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<Treatment> Treatments { get; set; } = AWSConfigs.InitializeCollections ? new List<Treatment>() : null;

        /// <summary>
        /// Checks to see if the Treatments property is set.
        /// </summary>
        internal bool IsSetTreatments() => this.Treatments != null && (this.Treatments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the experiment definition was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}

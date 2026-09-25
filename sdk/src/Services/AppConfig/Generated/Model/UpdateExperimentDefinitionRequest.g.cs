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
    /// Container for the parameters to the UpdateExperimentDefinition operation. Updates
    /// an experiment definition. You can update treatments, the control, audience rules,
    /// and other properties. You cannot update an experiment definition while an experiment
    /// run is active.
    /// </summary>
    public partial class UpdateExperimentDefinitionRequest : AmazonAppConfigRequest
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
        /// An updated audience description.
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
        /// An updated audience rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string AudienceRule { get; set; }

        /// <summary>
        /// Checks to see if the AudienceRule property is set.
        /// </summary>
        internal bool IsSetAudienceRule() => this.AudienceRule != null;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// An updated control treatment.
        /// </para>
        /// </summary>
        public TreatmentInput Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

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
        /// Gets and sets the property Hypothesis. 
        /// <para>
        /// An updated hypothesis.
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
        /// Updated launch criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LaunchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the LaunchCriteria property is set.
        /// </summary>
        internal bool IsSetLaunchCriteria() => this.LaunchCriteria != null;

        /// <summary>
        /// Gets and sets the property Treatments. 
        /// <para>
        /// The updated list of treatments to evaluate during the experiment. Each treatment defines
        /// a distinct variation compared to the control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<TreatmentInput> Treatments { get; set; } = AWSConfigs.InitializeCollections ? new List<TreatmentInput>() : null;

        /// <summary>
        /// Checks to see if the Treatments property is set.
        /// </summary>
        internal bool IsSetTreatments() => this.Treatments != null && (this.Treatments.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

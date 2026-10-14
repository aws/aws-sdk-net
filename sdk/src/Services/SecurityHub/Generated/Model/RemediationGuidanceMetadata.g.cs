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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The metadata of the remediation guidance.
    /// </summary>
    public partial class RemediationGuidanceMetadata
    {
        /// <summary>
        /// Gets and sets the property AutomationLevel. 
        /// <para>
        /// The extent to which the guidance can be automated, for example <c>Full</c>.
        /// </para>
        /// </summary>
        public string AutomationLevel { get; set; }

        /// <summary>
        /// Checks to see if the AutomationLevel property is set.
        /// </summary>
        internal bool IsSetAutomationLevel() => this.AutomationLevel != null;

        /// <summary>
        /// Gets and sets the property ExposureType. 
        /// <para>
        /// The exposure type of the related exposure findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExposureType { get; set; }

        /// <summary>
        /// Checks to see if the ExposureType property is set.
        /// </summary>
        internal bool IsSetExposureType() => this.ExposureType != null;

        /// <summary>
        /// Gets and sets the property FixEffect. 
        /// <para>
        /// When the fix takes effect, for example <c>Immediate</c> or <c>Deferred</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FixEffect { get; set; }

        /// <summary>
        /// Checks to see if the FixEffect property is set.
        /// </summary>
        internal bool IsSetFixEffect() => this.FixEffect != null;

        /// <summary>
        /// Gets and sets the property GeneratedAt. 
        /// <para>
        /// Timestamp of when the guidance was generated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedAt property is set.
        /// </summary>
        internal bool IsSetGeneratedAt() => this.GeneratedAt.HasValue;

        /// <summary>
        /// Gets and sets the property HumanReviewRequired. 
        /// <para>
        /// Specifies whether human review is required.
        /// </para>
        /// </summary>
        public bool? HumanReviewRequired { get; set; }

        /// <summary>
        /// Checks to see if the HumanReviewRequired property is set.
        /// </summary>
        internal bool IsSetHumanReviewRequired() => this.HumanReviewRequired.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Reversibility. 
        /// <para>
        /// The extent to which changes made in accordance with the guidance can be reversed,
        /// for example <c>Fully reversible</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Reversibility { get; set; }

        /// <summary>
        /// Checks to see if the Reversibility property is set.
        /// </summary>
        internal bool IsSetReversibility() => this.Reversibility != null;

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The risk when implementing the guidance provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Checks to see if the RiskLevel property is set.
        /// </summary>
        internal bool IsSetRiskLevel() => this.RiskLevel != null;

        /// <summary>
        /// Gets and sets the property TraitTitles. 
        /// <para>
        /// The titles of traits this guidance applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<string> TraitTitles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TraitTitles property is set.
        /// </summary>
        internal bool IsSetTraitTitles() => this.TraitTitles != null && (this.TraitTitles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// Verification status of the guidance.
        /// </para>
        /// </summary>
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStatus property is set.
        /// </summary>
        internal bool IsSetVerificationStatus() => this.VerificationStatus != null;
    }
}

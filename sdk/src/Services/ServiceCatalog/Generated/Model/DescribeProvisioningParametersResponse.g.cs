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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeProvisioningParameters operation.
    /// </summary>
    public partial class DescribeProvisioningParametersResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConstraintSummaries. 
        /// <para>
        /// Information about the constraints used to provision the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConstraintSummary> ConstraintSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ConstraintSummary>() : null;

        /// <summary>
        /// Checks to see if the ConstraintSummaries property is set.
        /// </summary>
        internal bool IsSetConstraintSummaries() => this.ConstraintSummaries != null && (this.ConstraintSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactOutputKeys. 
        /// <para>
        /// A list of the keys and descriptions of the outputs. These outputs can be referenced
        /// from a provisioned product launched from this provisioning artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<ProvisioningArtifactOutput> ProvisioningArtifactOutputKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifactOutput>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningArtifactOutputKeys property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactOutputKeys() => this.ProvisioningArtifactOutputKeys != null && (this.ProvisioningArtifactOutputKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactOutputs. 
        /// <para>
        /// The output of the provisioning artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated and returns the Id and Description of the Provisioning Artifact. Use ProvisioningArtifactOutputKeys instead to get the Keys and Descriptions of the outputs.")]
        [AWSProperty(Min = 0, Max = 60)]
        public List<ProvisioningArtifactOutput> ProvisioningArtifactOutputs { get; set; } = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifactOutput>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningArtifactOutputs property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactOutputs() => this.ProvisioningArtifactOutputs != null && (this.ProvisioningArtifactOutputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactParameters. 
        /// <para>
        /// Information about the parameters used to provision the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisioningArtifactParameter> ProvisioningArtifactParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifactParameter>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningArtifactParameters property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactParameters() => this.ProvisioningArtifactParameters != null && (this.ProvisioningArtifactParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactPreferences. 
        /// <para>
        /// An object that contains information about preferences, such as Regions and accounts,
        /// for the provisioning artifact.
        /// </para>
        /// </summary>
        public ProvisioningArtifactPreferences ProvisioningArtifactPreferences { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactPreferences property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactPreferences() => this.ProvisioningArtifactPreferences != null;

        /// <summary>
        /// Gets and sets the property TagOptions. 
        /// <para>
        /// Information about the TagOptions associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagOptionSummary> TagOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<TagOptionSummary>() : null;

        /// <summary>
        /// Checks to see if the TagOptions property is set.
        /// </summary>
        internal bool IsSetTagOptions() => this.TagOptions != null && (this.TagOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Any additional metadata specifically related to the provisioning of the product. For
        /// example, see the <c>Version</c> field of the CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageInstruction> UsageInstructions { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageInstruction>() : null;

        /// <summary>
        /// Checks to see if the UsageInstructions property is set.
        /// </summary>
        internal bool IsSetUsageInstructions() => this.UsageInstructions != null && (this.UsageInstructions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

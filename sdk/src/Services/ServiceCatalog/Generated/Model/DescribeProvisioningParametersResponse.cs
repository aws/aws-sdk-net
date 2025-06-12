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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
        private List<ConstraintSummary> _constraintSummaries = AWSConfigs.InitializeCollections ? new List<ConstraintSummary>() : null;
        private List<ProvisioningArtifactOutput> _provisioningArtifactOutputKeys = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifactOutput>() : null;
        private List<ProvisioningArtifactOutput> _provisioningArtifactOutputs = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifactOutput>() : null;
        private List<ProvisioningArtifactParameter> _provisioningArtifactParameters = AWSConfigs.InitializeCollections ? new List<ProvisioningArtifactParameter>() : null;
        private ProvisioningArtifactPreferences _provisioningArtifactPreferences;
        private List<TagOptionSummary> _tagOptions = AWSConfigs.InitializeCollections ? new List<TagOptionSummary>() : null;
        private List<UsageInstruction> _usageInstructions = AWSConfigs.InitializeCollections ? new List<UsageInstruction>() : null;

        /// <summary>
        /// Gets and sets the property ConstraintSummaries. 
        /// <para>
        /// Information about the constraints used to provision the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConstraintSummary> ConstraintSummaries
        {
            get { return this._constraintSummaries; }
            set { this._constraintSummaries = value; }
        }

        // Check to see if ConstraintSummaries property is set
        internal bool IsSetConstraintSummaries()
        {
            return this._constraintSummaries != null && (this._constraintSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactOutputKeys. 
        /// <para>
        /// A list of the keys and descriptions of the outputs. These outputs can be referenced
        /// from a provisioned product launched from this provisioning artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=60)]
        public List<ProvisioningArtifactOutput> ProvisioningArtifactOutputKeys
        {
            get { return this._provisioningArtifactOutputKeys; }
            set { this._provisioningArtifactOutputKeys = value; }
        }

        // Check to see if ProvisioningArtifactOutputKeys property is set
        internal bool IsSetProvisioningArtifactOutputKeys()
        {
            return this._provisioningArtifactOutputKeys != null && (this._provisioningArtifactOutputKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactOutputs. 
        /// <para>
        /// The output of the provisioning artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated and returns the Id and Description of the Provisioning Artifact. Use ProvisioningArtifactOutputKeys instead to get the Keys and Descriptions of the outputs.")]
        [AWSProperty(Max=60)]
        public List<ProvisioningArtifactOutput> ProvisioningArtifactOutputs
        {
            get { return this._provisioningArtifactOutputs; }
            set { this._provisioningArtifactOutputs = value; }
        }

        // Check to see if ProvisioningArtifactOutputs property is set
        internal bool IsSetProvisioningArtifactOutputs()
        {
            return this._provisioningArtifactOutputs != null && (this._provisioningArtifactOutputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactParameters. 
        /// <para>
        /// Information about the parameters used to provision the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisioningArtifactParameter> ProvisioningArtifactParameters
        {
            get { return this._provisioningArtifactParameters; }
            set { this._provisioningArtifactParameters = value; }
        }

        // Check to see if ProvisioningArtifactParameters property is set
        internal bool IsSetProvisioningArtifactParameters()
        {
            return this._provisioningArtifactParameters != null && (this._provisioningArtifactParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactPreferences. 
        /// <para>
        /// An object that contains information about preferences, such as Regions and accounts,
        /// for the provisioning artifact.
        /// </para>
        /// </summary>
        public ProvisioningArtifactPreferences ProvisioningArtifactPreferences
        {
            get { return this._provisioningArtifactPreferences; }
            set { this._provisioningArtifactPreferences = value; }
        }

        // Check to see if ProvisioningArtifactPreferences property is set
        internal bool IsSetProvisioningArtifactPreferences()
        {
            return this._provisioningArtifactPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property TagOptions. 
        /// <para>
        /// Information about the TagOptions associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagOptionSummary> TagOptions
        {
            get { return this._tagOptions; }
            set { this._tagOptions = value; }
        }

        // Check to see if TagOptions property is set
        internal bool IsSetTagOptions()
        {
            return this._tagOptions != null && (this._tagOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Any additional metadata specifically related to the provisioning of the product. For
        /// example, see the <c>Version</c> field of the CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageInstruction> UsageInstructions
        {
            get { return this._usageInstructions; }
            set { this._usageInstructions = value; }
        }

        // Check to see if UsageInstructions property is set
        internal bool IsSetUsageInstructions()
        {
            return this._usageInstructions != null && (this._usageInstructions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
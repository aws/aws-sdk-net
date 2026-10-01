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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssetCompositeModel operation.
    /// </summary>
    public partial class DescribeAssetCompositeModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionDefinitions. 
        /// <para>
        /// The available actions for a composite model on this asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionDefinition> ActionDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionDefinition>() : null;

        /// <summary>
        /// Checks to see if the ActionDefinitions property is set.
        /// </summary>
        internal bool IsSetActionDefinitions() => this.ActionDefinitions != null && (this.ActionDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetCompositeModelDescription. 
        /// <para>
        /// A description for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AssetCompositeModelDescription { get; set; }

        /// <summary>
        /// Checks to see if the AssetCompositeModelDescription property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelDescription() => this.AssetCompositeModelDescription != null;

        /// <summary>
        /// Gets and sets the property AssetCompositeModelExternalId. 
        /// <para>
        /// An external ID to assign to the asset model.
        /// </para>
        ///  
        /// <para>
        /// If the composite model is a component-based composite model, or one nested inside
        /// a component model, you can only set the external ID using <c>UpdateAssetModelCompositeModel</c>
        /// and specifying the derived ID of the model or property from the created model it's
        /// a part of.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetCompositeModelExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetCompositeModelExternalId property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelExternalId() => this.AssetCompositeModelExternalId != null;

        /// <summary>
        /// Gets and sets the property AssetCompositeModelId. 
        /// <para>
        /// The ID of a composite model on this asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetCompositeModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetCompositeModelId property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelId() => this.AssetCompositeModelId != null;

        /// <summary>
        /// Gets and sets the property AssetCompositeModelName. 
        /// <para>
        /// The unique, friendly name for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AssetCompositeModelName { get; set; }

        /// <summary>
        /// Checks to see if the AssetCompositeModelName property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelName() => this.AssetCompositeModelName != null;

        /// <summary>
        /// Gets and sets the property AssetCompositeModelPath. 
        /// <para>
        /// The path to the composite model listing the parent composite models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetCompositeModelPathSegment> AssetCompositeModelPath { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelPathSegment>() : null;

        /// <summary>
        /// Checks to see if the AssetCompositeModelPath property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelPath() => this.AssetCompositeModelPath != null && (this.AssetCompositeModelPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetCompositeModelProperties. 
        /// <para>
        /// The property definitions of the composite model that was used to create the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetProperty> AssetCompositeModelProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetProperty>() : null;

        /// <summary>
        /// Checks to see if the AssetCompositeModelProperties property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelProperties() => this.AssetCompositeModelProperties != null && (this.AssetCompositeModelProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetCompositeModelSummaries. 
        /// <para>
        /// The list of composite model summaries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetCompositeModelSummary> AssetCompositeModelSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelSummary>() : null;

        /// <summary>
        /// Checks to see if the AssetCompositeModelSummaries property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelSummaries() => this.AssetCompositeModelSummaries != null && (this.AssetCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetCompositeModelType. 
        /// <para>
        /// The composite model type. Valid values are <c>AWS/ALARM</c>, <c>CUSTOM</c>, or <c>
        /// AWS/L4E_ANOMALY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AssetCompositeModelType { get; set; }

        /// <summary>
        /// Checks to see if the AssetCompositeModelType property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelType() => this.AssetCompositeModelType != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format. This ID uniquely identifies the asset within
        /// IoT SiteWise and can be used with other IoT SiteWise APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;
    }
}

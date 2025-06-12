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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
        private List<ActionDefinition> _actionDefinitions = AWSConfigs.InitializeCollections ? new List<ActionDefinition>() : null;
        private string _assetCompositeModelDescription;
        private string _assetCompositeModelExternalId;
        private string _assetCompositeModelId;
        private string _assetCompositeModelName;
        private List<AssetCompositeModelPathSegment> _assetCompositeModelPath = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelPathSegment>() : null;
        private List<AssetProperty> _assetCompositeModelProperties = AWSConfigs.InitializeCollections ? new List<AssetProperty>() : null;
        private List<AssetCompositeModelSummary> _assetCompositeModelSummaries = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelSummary>() : null;
        private string _assetCompositeModelType;
        private string _assetId;

        /// <summary>
        /// Gets and sets the property ActionDefinitions. 
        /// <para>
        /// The available actions for a composite model on this asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionDefinition> ActionDefinitions
        {
            get { return this._actionDefinitions; }
            set { this._actionDefinitions = value; }
        }

        // Check to see if ActionDefinitions property is set
        internal bool IsSetActionDefinitions()
        {
            return this._actionDefinitions != null && (this._actionDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelDescription. 
        /// <para>
        /// A description for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AssetCompositeModelDescription
        {
            get { return this._assetCompositeModelDescription; }
            set { this._assetCompositeModelDescription = value; }
        }

        // Check to see if AssetCompositeModelDescription property is set
        internal bool IsSetAssetCompositeModelDescription()
        {
            return this._assetCompositeModelDescription != null;
        }

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
        [AWSProperty(Min=2, Max=128)]
        public string AssetCompositeModelExternalId
        {
            get { return this._assetCompositeModelExternalId; }
            set { this._assetCompositeModelExternalId = value; }
        }

        // Check to see if AssetCompositeModelExternalId property is set
        internal bool IsSetAssetCompositeModelExternalId()
        {
            return this._assetCompositeModelExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelId. 
        /// <para>
        /// The ID of a composite model on this asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetCompositeModelId
        {
            get { return this._assetCompositeModelId; }
            set { this._assetCompositeModelId = value; }
        }

        // Check to see if AssetCompositeModelId property is set
        internal bool IsSetAssetCompositeModelId()
        {
            return this._assetCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelName. 
        /// <para>
        /// The unique, friendly name for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetCompositeModelName
        {
            get { return this._assetCompositeModelName; }
            set { this._assetCompositeModelName = value; }
        }

        // Check to see if AssetCompositeModelName property is set
        internal bool IsSetAssetCompositeModelName()
        {
            return this._assetCompositeModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelPath. 
        /// <para>
        /// The path to the composite model listing the parent composite models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetCompositeModelPathSegment> AssetCompositeModelPath
        {
            get { return this._assetCompositeModelPath; }
            set { this._assetCompositeModelPath = value; }
        }

        // Check to see if AssetCompositeModelPath property is set
        internal bool IsSetAssetCompositeModelPath()
        {
            return this._assetCompositeModelPath != null && (this._assetCompositeModelPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelProperties. 
        /// <para>
        /// The property definitions of the composite model that was used to create the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetProperty> AssetCompositeModelProperties
        {
            get { return this._assetCompositeModelProperties; }
            set { this._assetCompositeModelProperties = value; }
        }

        // Check to see if AssetCompositeModelProperties property is set
        internal bool IsSetAssetCompositeModelProperties()
        {
            return this._assetCompositeModelProperties != null && (this._assetCompositeModelProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelSummaries. 
        /// <para>
        /// The list of composite model summaries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetCompositeModelSummary> AssetCompositeModelSummaries
        {
            get { return this._assetCompositeModelSummaries; }
            set { this._assetCompositeModelSummaries = value; }
        }

        // Check to see if AssetCompositeModelSummaries property is set
        internal bool IsSetAssetCompositeModelSummaries()
        {
            return this._assetCompositeModelSummaries != null && (this._assetCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelType. 
        /// <para>
        /// The composite model type. Valid values are <c>AWS/ALARM</c>, <c>CUSTOM</c>, or <c>
        /// AWS/L4E_ANOMALY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetCompositeModelType
        {
            get { return this._assetCompositeModelType; }
            set { this._assetCompositeModelType = value; }
        }

        // Check to see if AssetCompositeModelType property is set
        internal bool IsSetAssetCompositeModelType()
        {
            return this._assetCompositeModelType != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format. This ID uniquely identifies the asset within
        /// IoT SiteWise and can be used with other IoT SiteWise APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

    }
}
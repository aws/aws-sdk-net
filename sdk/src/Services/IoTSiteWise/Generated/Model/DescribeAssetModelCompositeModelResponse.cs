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
    /// This is the response object from the DescribeAssetModelCompositeModel operation.
    /// </summary>
    public partial class DescribeAssetModelCompositeModelResponse : AmazonWebServiceResponse
    {
        private List<ActionDefinition> _actionDefinitions = AWSConfigs.InitializeCollections ? new List<ActionDefinition>() : null;
        private string _assetModelCompositeModelDescription;
        private string _assetModelCompositeModelExternalId;
        private string _assetModelCompositeModelId;
        private string _assetModelCompositeModelName;
        private List<AssetModelCompositeModelPathSegment> _assetModelCompositeModelPath = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModelPathSegment>() : null;
        private List<AssetModelProperty> _assetModelCompositeModelProperties = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;
        private List<AssetModelCompositeModelSummary> _assetModelCompositeModelSummaries = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModelSummary>() : null;
        private string _assetModelCompositeModelType;
        private string _assetModelId;
        private CompositionDetails _compositionDetails;

        /// <summary>
        /// Gets and sets the property ActionDefinitions. 
        /// <para>
        /// The available actions for a composite model on this asset model.
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
        /// Gets and sets the property AssetModelCompositeModelDescription. 
        /// <para>
        /// The description for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AssetModelCompositeModelDescription
        {
            get { return this._assetModelCompositeModelDescription; }
            set { this._assetModelCompositeModelDescription = value; }
        }

        // Check to see if AssetModelCompositeModelDescription property is set
        internal bool IsSetAssetModelCompositeModelDescription()
        {
            return this._assetModelCompositeModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelExternalId. 
        /// <para>
        /// The external ID of a composite model on this asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string AssetModelCompositeModelExternalId
        {
            get { return this._assetModelCompositeModelExternalId; }
            set { this._assetModelCompositeModelExternalId = value; }
        }

        // Check to see if AssetModelCompositeModelExternalId property is set
        internal bool IsSetAssetModelCompositeModelExternalId()
        {
            return this._assetModelCompositeModelExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        /// The ID of a composite model on this asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelCompositeModelId
        {
            get { return this._assetModelCompositeModelId; }
            set { this._assetModelCompositeModelId = value; }
        }

        // Check to see if AssetModelCompositeModelId property is set
        internal bool IsSetAssetModelCompositeModelId()
        {
            return this._assetModelCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelName. 
        /// <para>
        /// The unique, friendly name for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelCompositeModelName
        {
            get { return this._assetModelCompositeModelName; }
            set { this._assetModelCompositeModelName = value; }
        }

        // Check to see if AssetModelCompositeModelName property is set
        internal bool IsSetAssetModelCompositeModelName()
        {
            return this._assetModelCompositeModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelPath. 
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
        public List<AssetModelCompositeModelPathSegment> AssetModelCompositeModelPath
        {
            get { return this._assetModelCompositeModelPath; }
            set { this._assetModelCompositeModelPath = value; }
        }

        // Check to see if AssetModelCompositeModelPath property is set
        internal bool IsSetAssetModelCompositeModelPath()
        {
            return this._assetModelCompositeModelPath != null && (this._assetModelCompositeModelPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelProperties. 
        /// <para>
        /// The property definitions of the composite model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelProperty> AssetModelCompositeModelProperties
        {
            get { return this._assetModelCompositeModelProperties; }
            set { this._assetModelCompositeModelProperties = value; }
        }

        // Check to see if AssetModelCompositeModelProperties property is set
        internal bool IsSetAssetModelCompositeModelProperties()
        {
            return this._assetModelCompositeModelProperties != null && (this._assetModelCompositeModelProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelSummaries. 
        /// <para>
        /// The list of composite model summaries for the composite model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelCompositeModelSummary> AssetModelCompositeModelSummaries
        {
            get { return this._assetModelCompositeModelSummaries; }
            set { this._assetModelCompositeModelSummaries = value; }
        }

        // Check to see if AssetModelCompositeModelSummaries property is set
        internal bool IsSetAssetModelCompositeModelSummaries()
        {
            return this._assetModelCompositeModelSummaries != null && (this._assetModelCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelType. 
        /// <para>
        /// The composite model type. Valid values are <c>AWS/ALARM</c>, <c>CUSTOM</c>, or <c>
        /// AWS/L4E_ANOMALY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelCompositeModelType
        {
            get { return this._assetModelCompositeModelType; }
            set { this._assetModelCompositeModelType = value; }
        }

        // Check to see if AssetModelCompositeModelType property is set
        internal bool IsSetAssetModelCompositeModelType()
        {
            return this._assetModelCompositeModelType != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property CompositionDetails. 
        /// <para>
        /// Metadata for the composition relationship established by using <c>composedAssetModelId</c>
        /// in <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModelCompositeModel.html">
        /// <c>CreateAssetModelCompositeModel</c> </a>. For instance, an array detailing the path
        /// of the composition relationship for this composite model.
        /// </para>
        /// </summary>
        public CompositionDetails CompositionDetails
        {
            get { return this._compositionDetails; }
            set { this._compositionDetails = value; }
        }

        // Check to see if CompositionDetails property is set
        internal bool IsSetCompositionDetails()
        {
            return this._compositionDetails != null;
        }

    }
}
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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssetModel operation.
    /// Updates an asset model and all of the assets that were created from the model. Each
    /// asset created from the model inherits the updated asset model's property and hierarchy
    /// definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
    /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// This operation overwrites the existing model with the provided model. To avoid deleting
    /// your asset model's properties or hierarchies, you must include their IDs and definitions
    /// in the updated asset model payload. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetModel.html">DescribeAssetModel</a>.
    /// </para>
    ///  
    /// <para>
    /// If you remove a property from an asset model, AWS IoT SiteWise deletes all previous
    /// data for that property. If you remove a hierarchy definition from an asset model,
    /// AWS IoT SiteWise disassociates every asset associated with that hierarchy. You can't
    /// change the type or data type of an existing property.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateAssetModelRequest : AmazonIoTSiteWiseRequest
    {
        private List<AssetModelCompositeModel> _assetModelCompositeModels = new List<AssetModelCompositeModel>();
        private string _assetModelDescription;
        private List<AssetModelHierarchy> _assetModelHierarchies = new List<AssetModelHierarchy>();
        private string _assetModelId;
        private string _assetModelName;
        private List<AssetModelProperty> _assetModelProperties = new List<AssetModelProperty>();
        private string _clientToken;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModels. 
        /// <para>
        /// The composite asset models that are part of this asset model. Composite asset models
        /// are asset models that contain specific properties. Each composite model has a type
        /// that defines the properties that the composite model supports. Use composite asset
        /// models to define alarms on this asset model.
        /// </para>
        /// </summary>
        public List<AssetModelCompositeModel> AssetModelCompositeModels
        {
            get { return this._assetModelCompositeModels; }
            set { this._assetModelCompositeModels = value; }
        }

        // Check to see if AssetModelCompositeModels property is set
        internal bool IsSetAssetModelCompositeModels()
        {
            return this._assetModelCompositeModels != null && this._assetModelCompositeModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelDescription. 
        /// <para>
        /// A description for the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AssetModelDescription
        {
            get { return this._assetModelDescription; }
            set { this._assetModelDescription = value; }
        }

        // Check to see if AssetModelDescription property is set
        internal bool IsSetAssetModelDescription()
        {
            return this._assetModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelHierarchies. 
        /// <para>
        /// The updated hierarchy definitions of the asset model. Each hierarchy specifies an
        /// asset model whose assets can be children of any other assets created from this asset
        /// model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-hierarchies.html">Asset
        /// hierarchies</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 hierarchies per asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public List<AssetModelHierarchy> AssetModelHierarchies
        {
            get { return this._assetModelHierarchies; }
            set { this._assetModelHierarchies = value; }
        }

        // Check to see if AssetModelHierarchies property is set
        internal bool IsSetAssetModelHierarchies()
        {
            return this._assetModelHierarchies != null && this._assetModelHierarchies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model to update.
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
        /// Gets and sets the property AssetModelName. 
        /// <para>
        /// A unique, friendly name for the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelName
        {
            get { return this._assetModelName; }
            set { this._assetModelName = value; }
        }

        // Check to see if AssetModelName property is set
        internal bool IsSetAssetModelName()
        {
            return this._assetModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelProperties. 
        /// <para>
        /// The updated property definitions of the asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-properties.html">Asset
        /// properties</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 200 properties per asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public List<AssetModelProperty> AssetModelProperties
        {
            get { return this._assetModelProperties; }
            set { this._assetModelProperties = value; }
        }

        // Check to see if AssetModelProperties property is set
        internal bool IsSetAssetModelProperties()
        {
            return this._assetModelProperties != null && this._assetModelProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

    }
}
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
    /// A filter used to match specific data binding values based on criteria. This filter
    /// allows searching for data bindings by asset, asset model, asset property, or asset
    /// model property.
    /// </summary>
    public partial class DataBindingValueFilter
    {
        private AssetBindingValueFilter _asset;
        private AssetModelBindingValueFilter _assetModel;
        private AssetModelPropertyBindingValueFilter _assetModelProperty;
        private AssetPropertyBindingValueFilter _assetProperty;

        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        /// Filter criteria for matching data bindings based on a specific asset. Used to list
        /// all data bindings referencing a particular asset or its properties.
        /// </para>
        /// </summary>
        public AssetBindingValueFilter Asset
        {
            get { return this._asset; }
            set { this._asset = value; }
        }

        // Check to see if Asset property is set
        internal bool IsSetAsset()
        {
            return this._asset != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModel. 
        /// <para>
        /// Filter criteria for matching data bindings based on a specific asset model. Used to
        /// list all data bindings referencing a particular asset model or its properties.
        /// </para>
        /// </summary>
        public AssetModelBindingValueFilter AssetModel
        {
            get { return this._assetModel; }
            set { this._assetModel = value; }
        }

        // Check to see if AssetModel property is set
        internal bool IsSetAssetModel()
        {
            return this._assetModel != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelProperty. 
        /// <para>
        /// Filter criteria for matching data bindings based on a specific asset model property.
        /// Used to list all data bindings referencing a particular property of an asset model.
        /// </para>
        /// </summary>
        public AssetModelPropertyBindingValueFilter AssetModelProperty
        {
            get { return this._assetModelProperty; }
            set { this._assetModelProperty = value; }
        }

        // Check to see if AssetModelProperty property is set
        internal bool IsSetAssetModelProperty()
        {
            return this._assetModelProperty != null;
        }

        /// <summary>
        /// Gets and sets the property AssetProperty. 
        /// <para>
        /// Filter criteria for matching data bindings based on a specific asset property. Used
        /// to list all data bindings referencing a particular property of an asset.
        /// </para>
        /// </summary>
        public AssetPropertyBindingValueFilter AssetProperty
        {
            get { return this._assetProperty; }
            set { this._assetProperty = value; }
        }

        // Check to see if AssetProperty property is set
        internal bool IsSetAssetProperty()
        {
            return this._assetProperty != null;
        }

    }
}
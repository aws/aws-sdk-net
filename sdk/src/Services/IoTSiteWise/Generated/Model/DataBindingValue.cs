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
    /// Represents a value used in a data binding. It can be an asset property or an asset
    /// model property.
    /// </summary>
    public partial class DataBindingValue
    {
        private AssetModelPropertyBindingValue _assetModelProperty;
        private AssetPropertyBindingValue _assetProperty;

        /// <summary>
        /// Gets and sets the property AssetModelProperty.
        /// </summary>
        public AssetModelPropertyBindingValue AssetModelProperty
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
        /// The asset property value used in the data binding.
        /// </para>
        /// </summary>
        public AssetPropertyBindingValue AssetProperty
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
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
    /// Maps a property from an interface asset model to a property in the asset model where
    /// the interface is applied.
    /// </summary>
    public partial class PropertyMapping
    {
        private string _assetModelPropertyId;
        private string _interfaceAssetModelPropertyId;

        /// <summary>
        /// Gets and sets the property AssetModelPropertyId. 
        /// <para>
        /// The ID of the property in the asset model where the interface is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string AssetModelPropertyId
        {
            get { return this._assetModelPropertyId; }
            set { this._assetModelPropertyId = value; }
        }

        // Check to see if AssetModelPropertyId property is set
        internal bool IsSetAssetModelPropertyId()
        {
            return this._assetModelPropertyId != null;
        }

        /// <summary>
        /// Gets and sets the property InterfaceAssetModelPropertyId. 
        /// <para>
        /// The ID of the property in the interface asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string InterfaceAssetModelPropertyId
        {
            get { return this._interfaceAssetModelPropertyId; }
            set { this._interfaceAssetModelPropertyId = value; }
        }

        // Check to see if InterfaceAssetModelPropertyId property is set
        internal bool IsSetInterfaceAssetModelPropertyId()
        {
            return this._interfaceAssetModelPropertyId != null;
        }

    }
}
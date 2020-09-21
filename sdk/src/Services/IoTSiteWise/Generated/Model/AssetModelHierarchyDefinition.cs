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
    /// Contains an asset model hierarchy used in asset model creation. An asset model hierarchy
    /// determines the kind (or type) of asset that can belong to a hierarchy.
    /// </summary>
    public partial class AssetModelHierarchyDefinition
    {
        private string _childAssetModelId;
        private string _name;

        /// <summary>
        /// Gets and sets the property ChildAssetModelId. 
        /// <para>
        /// The ID of an asset model for this hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ChildAssetModelId
        {
            get { return this._childAssetModelId; }
            set { this._childAssetModelId = value; }
        }

        // Check to see if ChildAssetModelId property is set
        internal bool IsSetChildAssetModelId()
        {
            return this._childAssetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset model hierarchy definition (as specified in the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModel.html">CreateAssetModel</a>
        /// or <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>
        /// API operation).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
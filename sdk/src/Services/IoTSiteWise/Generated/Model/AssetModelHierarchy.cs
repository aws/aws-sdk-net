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
    /// Describes an asset hierarchy that contains a hierarchy's name, ID, and child asset
    /// model ID that specifies the type of asset that can be in this hierarchy.
    /// </summary>
    public partial class AssetModelHierarchy
    {
        private string _childAssetModelId;
        private string _id;
        private string _name;

        /// <summary>
        /// Gets and sets the property ChildAssetModelId. 
        /// <para>
        /// The ID of the asset model. All assets in this hierarchy must be instances of the <code>childAssetModelId</code>
        /// asset model.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the asset model hierarchy. This ID is a <code>hierarchyId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset model hierarchy that you specify by using the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModel.html">CreateAssetModel</a>
        /// or <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>
        /// API operation.
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
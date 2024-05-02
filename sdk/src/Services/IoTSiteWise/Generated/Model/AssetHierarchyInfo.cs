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
    /// Contains information about a parent asset and a child asset that are related through
    /// an asset hierarchy.
    /// </summary>
    public partial class AssetHierarchyInfo
    {
        private string _childAssetId;
        private string _parentAssetId;

        /// <summary>
        /// Gets and sets the property ChildAssetId. 
        /// <para>
        /// The ID of the child asset in this asset relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ChildAssetId
        {
            get { return this._childAssetId; }
            set { this._childAssetId = value; }
        }

        // Check to see if ChildAssetId property is set
        internal bool IsSetChildAssetId()
        {
            return this._childAssetId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentAssetId. 
        /// <para>
        /// The ID of the parent asset in this asset relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ParentAssetId
        {
            get { return this._parentAssetId; }
            set { this._parentAssetId = value; }
        }

        // Check to see if ParentAssetId property is set
        internal bool IsSetParentAssetId()
        {
            return this._parentAssetId != null;
        }

    }
}
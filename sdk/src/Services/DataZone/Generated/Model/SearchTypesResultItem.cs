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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the results of the <c>SearchTypes</c> action.
    /// </summary>
    public partial class SearchTypesResultItem
    {
        private AssetTypeItem _assetTypeItem;
        private FormTypeData _formTypeItem;
        private LineageNodeTypeItem _lineageNodeTypeItem;

        /// <summary>
        /// Gets and sets the property AssetTypeItem. 
        /// <para>
        /// The asset type included in the results of the <c>SearchTypes</c> action.
        /// </para>
        /// </summary>
        public AssetTypeItem AssetTypeItem
        {
            get { return this._assetTypeItem; }
            set { this._assetTypeItem = value; }
        }

        // Check to see if AssetTypeItem property is set
        internal bool IsSetAssetTypeItem()
        {
            return this._assetTypeItem != null;
        }

        /// <summary>
        /// Gets and sets the property FormTypeItem. 
        /// <para>
        /// The form type included in the results of the <c>SearchTypes</c> action.
        /// </para>
        /// </summary>
        public FormTypeData FormTypeItem
        {
            get { return this._formTypeItem; }
            set { this._formTypeItem = value; }
        }

        // Check to see if FormTypeItem property is set
        internal bool IsSetFormTypeItem()
        {
            return this._formTypeItem != null;
        }

        /// <summary>
        /// Gets and sets the property LineageNodeTypeItem. 
        /// <para>
        /// The details of a data lineage node type.
        /// </para>
        /// </summary>
        public LineageNodeTypeItem LineageNodeTypeItem
        {
            get { return this._lineageNodeTypeItem; }
            set { this._lineageNodeTypeItem = value; }
        }

        // Check to see if LineageNodeTypeItem property is set
        internal bool IsSetLineageNodeTypeItem()
        {
            return this._lineageNodeTypeItem != null;
        }

    }
}
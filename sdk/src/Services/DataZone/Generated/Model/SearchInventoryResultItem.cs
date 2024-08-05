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
    /// The details of the search results.
    /// </summary>
    public partial class SearchInventoryResultItem
    {
        private AssetItem _assetItem;
        private DataProductResultItem _dataProductItem;
        private GlossaryItem _glossaryItem;
        private GlossaryTermItem _glossaryTermItem;

        /// <summary>
        /// Gets and sets the property AssetItem. 
        /// <para>
        /// The asset item included in the search results.
        /// </para>
        /// </summary>
        public AssetItem AssetItem
        {
            get { return this._assetItem; }
            set { this._assetItem = value; }
        }

        // Check to see if AssetItem property is set
        internal bool IsSetAssetItem()
        {
            return this._assetItem != null;
        }

        /// <summary>
        /// Gets and sets the property DataProductItem. 
        /// <para>
        /// The data product.
        /// </para>
        /// </summary>
        public DataProductResultItem DataProductItem
        {
            get { return this._dataProductItem; }
            set { this._dataProductItem = value; }
        }

        // Check to see if DataProductItem property is set
        internal bool IsSetDataProductItem()
        {
            return this._dataProductItem != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryItem. 
        /// <para>
        /// The glossary item included in the search results.
        /// </para>
        /// </summary>
        public GlossaryItem GlossaryItem
        {
            get { return this._glossaryItem; }
            set { this._glossaryItem = value; }
        }

        // Check to see if GlossaryItem property is set
        internal bool IsSetGlossaryItem()
        {
            return this._glossaryItem != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTermItem. 
        /// <para>
        /// The glossary term item included in the search results.
        /// </para>
        /// </summary>
        public GlossaryTermItem GlossaryTermItem
        {
            get { return this._glossaryTermItem; }
            set { this._glossaryTermItem = value; }
        }

        // Check to see if GlossaryTermItem property is set
        internal bool IsSetGlossaryTermItem()
        {
            return this._glossaryTermItem != null;
        }

    }
}
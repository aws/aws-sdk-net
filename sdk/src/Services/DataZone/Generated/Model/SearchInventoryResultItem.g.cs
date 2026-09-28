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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AssetItem. 
        /// <para>
        /// The asset item included in the search results.
        /// </para>
        /// </summary>
        public AssetItem AssetItem { get; set; }

        /// <summary>
        /// Checks to see if the AssetItem property is set.
        /// </summary>
        internal bool IsSetAssetItem() => this.AssetItem != null;

        /// <summary>
        /// Gets and sets the property DataProductItem. 
        /// <para>
        /// The data product.
        /// </para>
        /// </summary>
        public DataProductResultItem DataProductItem { get; set; }

        /// <summary>
        /// Checks to see if the DataProductItem property is set.
        /// </summary>
        internal bool IsSetDataProductItem() => this.DataProductItem != null;

        /// <summary>
        /// Gets and sets the property GlossaryItem. 
        /// <para>
        /// The glossary item included in the search results.
        /// </para>
        /// </summary>
        public GlossaryItem GlossaryItem { get; set; }

        /// <summary>
        /// Checks to see if the GlossaryItem property is set.
        /// </summary>
        internal bool IsSetGlossaryItem() => this.GlossaryItem != null;

        /// <summary>
        /// Gets and sets the property GlossaryTermItem. 
        /// <para>
        /// The glossary term item included in the search results.
        /// </para>
        /// </summary>
        public GlossaryTermItem GlossaryTermItem { get; set; }

        /// <summary>
        /// Checks to see if the GlossaryTermItem property is set.
        /// </summary>
        internal bool IsSetGlossaryTermItem() => this.GlossaryTermItem != null;
    }
}

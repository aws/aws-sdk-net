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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetIterableForms operation.
    /// Retrieves multiple items from an iterable form on an asset in Glue Data Catalog in
    /// a single request.
    /// </summary>
    public partial class BatchGetIterableFormsRequest : AmazonGlueRequest
    {
        private string _assetIdentifier;
        private List<string> _itemIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _iterableFormName;

        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The unique identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1087)]
        public string AssetIdentifier
        {
            get { return this._assetIdentifier; }
            set { this._assetIdentifier = value; }
        }

        // Check to see if AssetIdentifier property is set
        internal bool IsSetAssetIdentifier()
        {
            return this._assetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ItemIdentifiers. 
        /// <para>
        /// The list of item identifiers to retrieve. Each identifier can be an item ID or item
        /// name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ItemIdentifiers
        {
            get { return this._itemIdentifiers; }
            set { this._itemIdentifiers = value; }
        }

        // Check to see if ItemIdentifiers property is set
        internal bool IsSetItemIdentifiers()
        {
            return this._itemIdentifiers != null && (this._itemIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IterableFormName. 
        /// <para>
        /// The name of the iterable form to retrieve items from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string IterableFormName
        {
            get { return this._iterableFormName; }
            set { this._iterableFormName = value; }
        }

        // Check to see if IterableFormName property is set
        internal bool IsSetIterableFormName()
        {
            return this._iterableFormName != null;
        }

    }
}
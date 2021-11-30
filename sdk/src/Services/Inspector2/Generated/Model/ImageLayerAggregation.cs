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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The details that define an aggregation based on container image layers.
    /// </summary>
    public partial class ImageLayerAggregation
    {
        private List<StringFilter> _layerHashes = new List<StringFilter>();
        private List<StringFilter> _repositories = new List<StringFilter>();
        private List<StringFilter> _resourceIds = new List<StringFilter>();
        private ImageLayerSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property LayerHashes. 
        /// <para>
        /// The hashes associated with the layers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> LayerHashes
        {
            get { return this._layerHashes; }
            set { this._layerHashes = value; }
        }

        // Check to see if LayerHashes property is set
        internal bool IsSetLayerHashes()
        {
            return this._layerHashes != null && this._layerHashes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Repositories. 
        /// <para>
        /// The repository associated with the container image hosting the layers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Repositories
        {
            get { return this._repositories; }
            set { this._repositories = value; }
        }

        // Check to see if Repositories property is set
        internal bool IsSetRepositories()
        {
            return this._repositories != null && this._repositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The ID of the container image layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value to sort results by.
        /// </para>
        /// </summary>
        public ImageLayerSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort results by.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}
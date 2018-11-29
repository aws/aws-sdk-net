/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the ListLayerVersions operation.
    /// </summary>
    public partial class ListLayerVersionsResponse : AmazonWebServiceResponse
    {
        private List<LayerVersionsListItem> _layerVersions = new List<LayerVersionsListItem>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property LayerVersions. 
        /// <para>
        /// A list of versions.
        /// </para>
        /// </summary>
        public List<LayerVersionsListItem> LayerVersions
        {
            get { return this._layerVersions; }
            set { this._layerVersions = value; }
        }

        // Check to see if LayerVersions property is set
        internal bool IsSetLayerVersions()
        {
            return this._layerVersions != null && this._layerVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// A pagination token returned when the response doesn't contain all versions.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}
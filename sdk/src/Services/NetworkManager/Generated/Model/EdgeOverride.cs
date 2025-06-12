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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the edge that's used for the override.
    /// </summary>
    public partial class EdgeOverride
    {
        private List<List<string>> _edgeSets = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private string _useEdge;

        /// <summary>
        /// Gets and sets the property EdgeSets. 
        /// <para>
        /// The list of edge locations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> EdgeSets
        {
            get { return this._edgeSets; }
            set { this._edgeSets = value; }
        }

        // Check to see if EdgeSets property is set
        internal bool IsSetEdgeSets()
        {
            return this._edgeSets != null && (this._edgeSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseEdge. 
        /// <para>
        /// The edge that should be used when overriding the current edge order.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string UseEdge
        {
            get { return this._useEdge; }
            set { this._useEdge = value; }
        }

        // Check to see if UseEdge property is set
        internal bool IsSetUseEdge()
        {
            return this._useEdge != null;
        }

    }
}
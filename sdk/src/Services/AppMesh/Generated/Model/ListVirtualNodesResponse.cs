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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// <zonbook></zonbook><xhtml></xhtml>
    /// </summary>
    public partial class ListVirtualNodesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VirtualNodeRef> _virtualNodes = AWSConfigs.InitializeCollections ? new List<VirtualNodeRef>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>ListVirtualNodes</c> request.
        /// When the results of a <c>ListVirtualNodes</c> request exceed <c>limit</c>, you can
        /// use this value to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualNodes. 
        /// <para>
        /// The list of existing virtual nodes for the specified service mesh.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VirtualNodeRef> VirtualNodes
        {
            get { return this._virtualNodes; }
            set { this._virtualNodes = value; }
        }

        // Check to see if VirtualNodes property is set
        internal bool IsSetVirtualNodes()
        {
            return this._virtualNodes != null && (this._virtualNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
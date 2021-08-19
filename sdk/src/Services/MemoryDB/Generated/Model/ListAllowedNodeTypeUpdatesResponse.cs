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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// This is the response object from the ListAllowedNodeTypeUpdates operation.
    /// </summary>
    public partial class ListAllowedNodeTypeUpdatesResponse : AmazonWebServiceResponse
    {
        private List<string> _scaleDownNodeTypes = new List<string>();
        private List<string> _scaleUpNodeTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ScaleDownNodeTypes. 
        /// <para>
        /// A list node types which you can use to scale down your cluster.
        /// </para>
        /// </summary>
        public List<string> ScaleDownNodeTypes
        {
            get { return this._scaleDownNodeTypes; }
            set { this._scaleDownNodeTypes = value; }
        }

        // Check to see if ScaleDownNodeTypes property is set
        internal bool IsSetScaleDownNodeTypes()
        {
            return this._scaleDownNodeTypes != null && this._scaleDownNodeTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScaleUpNodeTypes. 
        /// <para>
        /// A list node types which you can use to scale up your cluster.
        /// </para>
        /// </summary>
        public List<string> ScaleUpNodeTypes
        {
            get { return this._scaleUpNodeTypes; }
            set { this._scaleUpNodeTypes = value; }
        }

        // Check to see if ScaleUpNodeTypes property is set
        internal bool IsSetScaleUpNodeTypes()
        {
            return this._scaleUpNodeTypes != null && this._scaleUpNodeTypes.Count > 0; 
        }

    }
}
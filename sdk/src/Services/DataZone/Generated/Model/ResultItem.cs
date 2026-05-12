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
    /// Resulting entity from the query.
    /// </summary>
    public partial class ResultItem
    {
        private LineageNodeItem _lineageNode;

        /// <summary>
        /// Gets and sets the property LineageNode. 
        /// <para>
        /// Resulting data lineage node from the query.
        /// </para>
        /// </summary>
        public LineageNodeItem LineageNode
        {
            get { return this._lineageNode; }
            set { this._lineageNode = value; }
        }

        // Check to see if LineageNode property is set
        internal bool IsSetLineageNode()
        {
            return this._lineageNode != null;
        }

    }
}
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
    /// This is the response object from the PurchaseReservedNodesOffering operation.
    /// </summary>
    public partial class PurchaseReservedNodesOfferingResponse : AmazonWebServiceResponse
    {
        private ReservedNode _reservedNode;

        /// <summary>
        /// Gets and sets the property ReservedNode. 
        /// <para>
        /// Represents the output of a <code>PurchaseReservedNodesOffering</code> operation.
        /// </para>
        /// </summary>
        public ReservedNode ReservedNode
        {
            get { return this._reservedNode; }
            set { this._reservedNode = value; }
        }

        // Check to see if ReservedNode property is set
        internal bool IsSetReservedNode()
        {
            return this._reservedNode != null;
        }

    }
}
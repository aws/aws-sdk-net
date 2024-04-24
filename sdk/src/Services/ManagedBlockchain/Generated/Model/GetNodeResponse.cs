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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
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
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// This is the response object from the GetNode operation.
    /// </summary>
    public partial class GetNodeResponse : AmazonWebServiceResponse
    {
        private Node _node;

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// Properties of the node configuration.
        /// </para>
        /// </summary>
        public Node Node
        {
            get { return this._node; }
            set { this._node = value; }
        }

        // Check to see if Node property is set
        internal bool IsSetNode()
        {
            return this._node != null;
        }

    }
}
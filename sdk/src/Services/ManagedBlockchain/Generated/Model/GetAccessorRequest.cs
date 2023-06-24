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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccessor operation.
    /// Returns detailed information about an accessor. An accessor object is a container
    /// that has the information required for token based access to your Ethereum nodes.
    /// </summary>
    public partial class GetAccessorRequest : AmazonManagedBlockchainRequest
    {
        private string _accessorId;

        /// <summary>
        /// Gets and sets the property AccessorId. 
        /// <para>
        /// The unique identifier of the accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AccessorId
        {
            get { return this._accessorId; }
            set { this._accessorId = value; }
        }

        // Check to see if AccessorId property is set
        internal bool IsSetAccessorId()
        {
            return this._accessorId != null;
        }

    }
}
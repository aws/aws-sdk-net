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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBClusterEndpoint operation.
    /// Deletes a custom endpoint and removes it from an Amazon Neptune DB cluster.
    /// </summary>
    public partial class DeleteDBClusterEndpointRequest : AmazonNeptuneRequest
    {
        private string _dbClusterEndpointIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier associated with the custom endpoint. This parameter is stored as a
        /// lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterEndpointIdentifier
        {
            get { return this._dbClusterEndpointIdentifier; }
            set { this._dbClusterEndpointIdentifier = value; }
        }

        // Check to see if DBClusterEndpointIdentifier property is set
        internal bool IsSetDBClusterEndpointIdentifier()
        {
            return this._dbClusterEndpointIdentifier != null;
        }

    }
}
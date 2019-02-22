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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetDevEndpoints operation.
    /// Returns a list of resource metadata for a given list of DevEndpoint names. After calling
    /// the <code>ListDevEndpoints</code> operation, you can call this operation to access
    /// the data to which you have been granted permissions. This operation supports all IAM
    /// permissions, including permission conditions that uses tags.
    /// </summary>
    public partial class BatchGetDevEndpointsRequest : AmazonGlueRequest
    {
        private List<string> _devEndpointNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DevEndpointNames. 
        /// <para>
        /// The list of DevEndpoint names, which may be the names returned from the <code>ListDevEndpoint</code>
        /// operation.
        /// </para>
        /// </summary>
        public List<string> DevEndpointNames
        {
            get { return this._devEndpointNames; }
            set { this._devEndpointNames = value; }
        }

        // Check to see if DevEndpointNames property is set
        internal bool IsSetDevEndpointNames()
        {
            return this._devEndpointNames != null && this._devEndpointNames.Count > 0; 
        }

    }
}
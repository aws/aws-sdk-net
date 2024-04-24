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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The connection properties of an outbound connection.
    /// </summary>
    public partial class ConnectionProperties
    {
        private CrossClusterSearchConnectionProperties _crossClusterSearch;
        private string _endpoint;

        /// <summary>
        /// Gets and sets the property CrossClusterSearch. 
        /// <para>
        /// The connection properties for cross cluster search.
        /// </para>
        /// </summary>
        public CrossClusterSearchConnectionProperties CrossClusterSearch
        {
            get { return this._crossClusterSearch; }
            set { this._crossClusterSearch = value; }
        }

        // Check to see if CrossClusterSearch property is set
        internal bool IsSetCrossClusterSearch()
        {
            return this._crossClusterSearch != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. <important> 
        /// <para>
        /// The Endpoint attribute cannot be modified. 
        /// </para>
        ///  </important> 
        /// <para>
        /// The endpoint of the remote domain. Applicable for VPC_ENDPOINT connection mode.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

    }
}
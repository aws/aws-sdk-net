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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// This is the response object from the ListCustomRoutingPortMappings operation.
    /// </summary>
    public partial class ListCustomRoutingPortMappingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PortMapping> _portMappings = new List<PortMapping>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property PortMappings. 
        /// <para>
        /// The port mappings for a custom routing accelerator.
        /// </para>
        /// </summary>
        public List<PortMapping> PortMappings
        {
            get { return this._portMappings; }
            set { this._portMappings = value; }
        }

        // Check to see if PortMappings property is set
        internal bool IsSetPortMappings()
        {
            return this._portMappings != null && this._portMappings.Count > 0; 
        }

    }
}
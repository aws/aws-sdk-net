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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetCrossRegionRouting operation.
    /// </summary>
    public partial class GetCrossRegionRoutingResponse : AmazonWebServiceResponse
    {
        private List<string> _isolatedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IsolatedRegions. 
        /// <para>
        /// The list of Regions for which cross-region routing is currently disabled (isolated).
        /// When a Region appears in this list, contacts originating in that Region will not be
        /// routed to agents in other Regions, and agents in that Region will not receive contacts
        /// from other Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IsolatedRegions
        {
            get { return this._isolatedRegions; }
            set { this._isolatedRegions = value; }
        }

        // Check to see if IsolatedRegions property is set
        internal bool IsSetIsolatedRegions()
        {
            return this._isolatedRegions != null && (this._isolatedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
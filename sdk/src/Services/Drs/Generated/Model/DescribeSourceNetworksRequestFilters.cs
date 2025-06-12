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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// A set of filters by which to return Source Networks.
    /// </summary>
    public partial class DescribeSourceNetworksRequestFilters
    {
        private string _originAccountID;
        private string _originRegion;
        private List<string> _sourceNetworkIDs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property OriginAccountID. 
        /// <para>
        /// Filter Source Networks by account ID containing the protected VPCs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OriginAccountID
        {
            get { return this._originAccountID; }
            set { this._originAccountID = value; }
        }

        // Check to see if OriginAccountID property is set
        internal bool IsSetOriginAccountID()
        {
            return this._originAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// Filter Source Networks by the region containing the protected VPCs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string OriginRegion
        {
            get { return this._originRegion; }
            set { this._originRegion = value; }
        }

        // Check to see if OriginRegion property is set
        internal bool IsSetOriginRegion()
        {
            return this._originRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceNetworkIDs. 
        /// <para>
        /// An array of Source Network IDs that should be returned. An empty array means all Source
        /// Networks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SourceNetworkIDs
        {
            get { return this._sourceNetworkIDs; }
            set { this._sourceNetworkIDs = value; }
        }

        // Check to see if SourceNetworkIDs property is set
        internal bool IsSetSourceNetworkIDs()
        {
            return this._sourceNetworkIDs != null && (this._sourceNetworkIDs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
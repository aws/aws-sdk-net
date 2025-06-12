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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// The list of network function groups and edge overrides for the service insertion action.
    /// Used for both the <c>send-to</c> and <c>send-via</c> actions.
    /// </summary>
    public partial class Via
    {
        private List<NetworkFunctionGroup> _networkFunctionGroups = AWSConfigs.InitializeCollections ? new List<NetworkFunctionGroup>() : null;
        private List<EdgeOverride> _withEdgeOverrides = AWSConfigs.InitializeCollections ? new List<EdgeOverride>() : null;

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroups. 
        /// <para>
        /// The list of network function groups associated with the service insertion action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkFunctionGroup> NetworkFunctionGroups
        {
            get { return this._networkFunctionGroups; }
            set { this._networkFunctionGroups = value; }
        }

        // Check to see if NetworkFunctionGroups property is set
        internal bool IsSetNetworkFunctionGroups()
        {
            return this._networkFunctionGroups != null && (this._networkFunctionGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WithEdgeOverrides. 
        /// <para>
        /// Describes any edge overrides. An edge override is a specific edge to be used for traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeOverride> WithEdgeOverrides
        {
            get { return this._withEdgeOverrides; }
            set { this._withEdgeOverrides = value; }
        }

        // Check to see if WithEdgeOverrides property is set
        internal bool IsSetWithEdgeOverrides()
        {
            return this._withEdgeOverrides != null && (this._withEdgeOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
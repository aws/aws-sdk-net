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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterEndpoint operation.
    /// Modifies the properties of an endpoint in an Amazon Neptune DB cluster.
    /// </summary>
    public partial class ModifyDBClusterEndpointRequest : AmazonNeptuneRequest
    {
        private string _dbClusterEndpointIdentifier;
        private string _endpointType;
        private List<string> _excludedMembers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _staticMembers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier of the endpoint to modify. This parameter is stored as a lowercase
        /// string.
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

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of the endpoint. One of: <c>READER</c>, <c>WRITER</c>, <c>ANY</c>.
        /// </para>
        /// </summary>
        public string EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedMembers. 
        /// <para>
        /// List of DB instance identifiers that aren't part of the custom endpoint group. All
        /// other eligible instances are reachable through the custom endpoint. Only relevant
        /// if the list of static members is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludedMembers
        {
            get { return this._excludedMembers; }
            set { this._excludedMembers = value; }
        }

        // Check to see if ExcludedMembers property is set
        internal bool IsSetExcludedMembers()
        {
            return this._excludedMembers != null && (this._excludedMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StaticMembers. 
        /// <para>
        /// List of DB instance identifiers that are part of the custom endpoint group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StaticMembers
        {
            get { return this._staticMembers; }
            set { this._staticMembers = value; }
        }

        // Check to see if StaticMembers property is set
        internal bool IsSetStaticMembers()
        {
            return this._staticMembers != null && (this._staticMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
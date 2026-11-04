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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ModifyDBClusterEndpoint operation. Modifies the
    /// properties of an endpoint in an Amazon Neptune DB cluster.
    /// </summary>
    public partial class ModifyDBClusterEndpointRequest : AmazonNeptuneRequest
    {
        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier of the endpoint to modify. This parameter is stored as a lowercase
        /// string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBClusterEndpointIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterEndpointIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterEndpointIdentifier() => this.DBClusterEndpointIdentifier != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of the endpoint. One of: <c>READER</c>, <c>WRITER</c>, <c>ANY</c>.
        /// </para>
        /// </summary>
        public string EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property ExcludedMembers. 
        /// <para>
        /// List of DB instance identifiers that aren't part of the custom endpoint group. All
        /// other eligible instances are reachable through the custom endpoint. Only relevant
        /// if the list of static members is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludedMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedMembers property is set.
        /// </summary>
        internal bool IsSetExcludedMembers() => this.ExcludedMembers != null && (this.ExcludedMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StaticMembers. 
        /// <para>
        /// List of DB instance identifiers that are part of the custom endpoint group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StaticMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StaticMembers property is set.
        /// </summary>
        internal bool IsSetStaticMembers() => this.StaticMembers != null && (this.StaticMembers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the ListEnvironmentAccountConnections operation.
    /// </summary>
    public partial class ListEnvironmentAccountConnectionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EnvironmentAccountConnections. 
        /// <para>
        /// An array of environment account connections with details that's returned by Proton.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EnvironmentAccountConnectionSummary> EnvironmentAccountConnections { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentAccountConnectionSummary>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentAccountConnections property is set.
        /// </summary>
        internal bool IsSetEnvironmentAccountConnections() => this.EnvironmentAccountConnections != null && (this.EnvironmentAccountConnections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next environment account connection in
        /// the array of environment account connections, after the current requested list of
        /// environment account connections.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

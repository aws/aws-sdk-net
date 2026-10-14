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

namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Container for the parameters to the ListConnections operation. Lists all connection
    /// objects to which the caller has access. <para> Allows for optional filtering by the
    /// following properties: </para> <ul> <li> <para> <c>state</c> </para> </li> <li> <para>
    /// <c>environmentId</c> </para> </li> <li> <para> <c>provider</c> </para> </li> <li>
    /// <para> <c>attach point</c> </para> </li> </ul> <para> Only <a>Connection</a> objects
    /// matching all filters will be returned. </para>
    /// </summary>
    public partial class ListConnectionsRequest : AmazonInterconnectRequest
    {
        /// <summary>
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// Filter results to only include <a>Connection</a> objects attached to the given <a>AttachPoint</a>.
        /// </para>
        /// </summary>
        public AttachPoint AttachPoint { get; set; }

        /// <summary>
        /// Checks to see if the AttachPoint property is set.
        /// </summary>
        internal bool IsSetAttachPoint() => this.AttachPoint != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// Filter the results to only include <a>Connection</a> objects on the given <a>Environment</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The max number of list results in a single paginated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token from a previous paginated response indicating you wish to get the
        /// next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// Filter the results to only include <a>Connection</a> objects to the given <a>Provider</a>.
        /// </para>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filter the results to only include <a>Connection</a> objects in the given <a>Connection$state</a>.
        /// </para>
        /// </summary>
        public ConnectionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}

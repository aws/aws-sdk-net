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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstanceTypes operation. Retrieves a list
    /// of instance types supported by Amazon WorkSpaces Instances, enabling precise workspace
    /// infrastructure configuration.
    /// </summary>
    public partial class ListInstanceTypesRequest : AmazonWorkspacesInstancesRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceConfigurationFilter. 
        /// <para>
        /// Optional filter to narrow instance type results based on configuration requirements.
        /// Only returns instance types that support the specified combination of tenancy, platform
        /// type, and billing mode.
        /// </para>
        /// </summary>
        public InstanceConfigurationFilter InstanceConfigurationFilter { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConfigurationFilter property is set.
        /// </summary>
        internal bool IsSetInstanceConfigurationFilter() => this.InstanceConfigurationFilter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of instance types to return in a single API call. Enables pagination
        /// of instance type results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token for retrieving subsequent pages of instance type results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

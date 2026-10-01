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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the ListConnectorDefinitionVersions operation. Lists
    /// the versions of a connector definition, which are containers for connectors. Connectors
    /// run on the Greengrass core and contain built-in integration with local infrastructure,
    /// device protocols, AWS, and other cloud services.
    /// </summary>
    public partial class ListConnectorDefinitionVersionsRequest : AmazonGreengrassRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorDefinitionId. The ID of the connector definition.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectorDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDefinitionId property is set.
        /// </summary>
        internal bool IsSetConnectorDefinitionId() => this.ConnectorDefinitionId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of results to be returned
        /// per request.
        /// </summary>
        public string MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults != null;

        /// <summary>
        /// Gets and sets the property NextToken. The token for the next set of results, or ''null''
        /// if there are no additional results.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the ListDataAutomationLibraryEntities operation. Lists
    /// all stored entities in the library
    /// </summary>
    public partial class ListDataAutomationLibraryEntitiesRequest : AmazonBedrockDataAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property EntityType. The entity type for which the entity list is
        /// requested
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property LibraryArn. ARN generated at the server side when a DataAutomationLibrary
        /// is created
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string LibraryArn { get; set; }

        /// <summary>
        /// Checks to see if the LibraryArn property is set.
        /// </summary>
        internal bool IsSetLibraryArn() => this.LibraryArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Pagination token for retrieving the next set
        /// of results
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

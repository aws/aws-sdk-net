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
    /// Container for the parameters to the GetSubscriptionDefinitionVersion operation. Retrieves
    /// information about a subscription definition version.
    /// </summary>
    public partial class GetSubscriptionDefinitionVersionRequest : AmazonGreengrassRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. The token for the next set of results, or ''null''
        /// if there are no additional results.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionId. The ID of the subscription definition.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriptionDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionDefinitionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionDefinitionId() => this.SubscriptionDefinitionId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionVersionId. The ID of the subscription
        /// definition version. This value maps to the ''Version'' property of the corresponding
        /// ''VersionInformation'' object, which is returned by ''ListSubscriptionDefinitionVersions''
        /// requests. If the version is the last one that was associated with a subscription definition,
        /// the value also maps to the ''LatestVersion'' property of the corresponding ''DefinitionInformation''
        /// object.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriptionDefinitionVersionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionDefinitionVersionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionDefinitionVersionId() => this.SubscriptionDefinitionVersionId != null;
    }
}

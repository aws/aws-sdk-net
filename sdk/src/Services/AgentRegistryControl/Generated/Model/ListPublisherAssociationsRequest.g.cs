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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the ListPublisherAssociations operation. List the
    /// registry record associations your account created. Pass publisherArn to list only
    /// the associations for that publisher; omit it to list associations across all publishers.
    /// Results are eventually consistent, so an association you just created or removed can
    /// take a few seconds to appear in or disappear from the list.
    /// </summary>
    public partial class ListPublisherAssociationsRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PublisherArn.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PublisherArn { get; set; }

        /// <summary>
        /// Checks to see if the PublisherArn property is set.
        /// </summary>
        internal bool IsSetPublisherArn() => this.PublisherArn != null;
    }
}

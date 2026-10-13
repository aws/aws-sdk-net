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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// This is the response object from the ListResolverRuleAssociations operation.
    /// </summary>
    public partial class ListResolverRuleAssociationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The value that you specified for <c>MaxResults</c> in the request.
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
        /// If more than <c>MaxResults</c> rule associations match the specified criteria, you
        /// can submit another <c>ListResolverRuleAssociation</c> request to get the next group
        /// of results. In the next request, specify the value of <c>NextToken</c> from the previous
        /// response. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResolverRuleAssociations. 
        /// <para>
        /// The associations that were created between Resolver rules and VPCs using the current
        /// Amazon Web Services account, and that match the specified filters, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolverRuleAssociation> ResolverRuleAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<ResolverRuleAssociation>() : null;

        /// <summary>
        /// Checks to see if the ResolverRuleAssociations property is set.
        /// </summary>
        internal bool IsSetResolverRuleAssociations() => this.ResolverRuleAssociations != null && (this.ResolverRuleAssociations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

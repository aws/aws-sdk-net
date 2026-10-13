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
    /// This is the response object from the ListResolverConfigs operation.
    /// </summary>
    public partial class ListResolverConfigsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a response includes the last of the Resolver configurations that are associated
        /// with the current Amazon Web Services account, <c>NextToken</c> doesn't appear in the
        /// response.
        /// </para>
        ///  
        /// <para>
        /// If a response doesn't include the last of the configurations, you can get more configurations
        /// by submitting another <c>ListResolverConfigs</c> request. Get the value of <c>NextToken</c>
        /// that Amazon Route 53 returned in the previous response and include it in <c>NextToken</c>
        /// in the next request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResolverConfigs. 
        /// <para>
        /// An array that contains one <c>ResolverConfigs</c> element for each Resolver configuration
        /// that is associated with the current Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolverConfig> ResolverConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<ResolverConfig>() : null;

        /// <summary>
        /// Checks to see if the ResolverConfigs property is set.
        /// </summary>
        internal bool IsSetResolverConfigs() => this.ResolverConfigs != null && (this.ResolverConfigs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the ListIdentityProviderConfigs operation.
    /// </summary>
    public partial class ListIdentityProviderConfigsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IdentityProviderConfigs. 
        /// <para>
        /// The identity provider configurations for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdentityProviderConfig> IdentityProviderConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<IdentityProviderConfig>() : null;

        /// <summary>
        /// Checks to see if the IdentityProviderConfigs property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfigs() => this.IdentityProviderConfigs != null && (this.IdentityProviderConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>ListIdentityProviderConfigsResponse</c>
        /// request. When the results of a <c>ListIdentityProviderConfigsResponse</c> request
        /// exceed <c>maxResults</c>, you can use this value to retrieve the next page of results.
        /// This value is <c>null</c> when there are no more results to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is used only to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

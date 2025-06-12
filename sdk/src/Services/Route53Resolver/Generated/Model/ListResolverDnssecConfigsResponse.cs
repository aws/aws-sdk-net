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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
    /// This is the response object from the ListResolverDnssecConfigs operation.
    /// </summary>
    public partial class ListResolverDnssecConfigsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResolverDnssecConfig> _resolverDnssecConfigs = AWSConfigs.InitializeCollections ? new List<ResolverDnssecConfig>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a response includes the last of the DNSSEC configurations that are associated with
        /// the current Amazon Web Services account, <c>NextToken</c> doesn't appear in the response.
        /// </para>
        ///  
        /// <para>
        /// If a response doesn't include the last of the configurations, you can get more configurations
        /// by submitting another <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ListResolverDnssecConfigs.html">ListResolverDnssecConfigs</a>
        /// request. Get the value of <c>NextToken</c> that Amazon Route 53 returned in the previous
        /// response and include it in <c>NextToken</c> in the next request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverDnssecConfigs. 
        /// <para>
        /// An array that contains one <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ResolverDnssecConfig.html">ResolverDnssecConfig</a>
        /// element for each configuration for DNSSEC validation that is associated with the current
        /// Amazon Web Services account. It doesn't contain disabled DNSSEC configurations for
        /// the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolverDnssecConfig> ResolverDnssecConfigs
        {
            get { return this._resolverDnssecConfigs; }
            set { this._resolverDnssecConfigs = value; }
        }

        // Check to see if ResolverDnssecConfigs property is set
        internal bool IsSetResolverDnssecConfigs()
        {
            return this._resolverDnssecConfigs != null && (this._resolverDnssecConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
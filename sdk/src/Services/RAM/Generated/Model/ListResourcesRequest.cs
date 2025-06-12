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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the ListResources operation.
    /// Lists the resources that you added to a resource share or the resources that are shared
    /// with you.
    /// </summary>
    public partial class ListResourcesRequest : AmazonRAMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _principal;
        private List<string> _resourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceOwner _resourceOwner;
        private ResourceRegionScopeFilter _resourceRegionScope;
        private List<string> _resourceShareArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the total number of results that you want included on each page of the response.
        /// If you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the number you specify, the <c>NextToken</c>
        /// response element is returned with a value (not null). Include the specified value
        /// as the <c>NextToken</c> request parameter in the next call to the operation to get
        /// the next part of the results. Note that the service might return fewer results than
        /// the maximum even when there are more results available. You should check <c>NextToken</c>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>NextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>NextToken</c> response to request the next page of results.
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
        /// Gets and sets the property Principal. 
        /// <para>
        /// Specifies that you want to list only the resource shares that are associated with
        /// the specified principal.
        /// </para>
        /// </summary>
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// Specifies that you want to list only the resource shares that include resources with
        /// the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && (this._resourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// Specifies that you want to list only the resource shares that match the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>SELF</c> </b> – resources that your account shares with other accounts
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>OTHER-ACCOUNTS</c> </b> – resources that other accounts share with your account
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceOwner ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegionScope. 
        /// <para>
        /// Specifies that you want the results to include only resources that have the specified
        /// scope.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> – the results include both global and regional resources or resource types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GLOBAL</c> – the results include only global resources or resource types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGIONAL</c> – the results include only regional resources or resource types.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default value is <c>ALL</c>.
        /// </para>
        /// </summary>
        public ResourceRegionScopeFilter ResourceRegionScope
        {
            get { return this._resourceRegionScope; }
            set { this._resourceRegionScope = value; }
        }

        // Check to see if ResourceRegionScope property is set
        internal bool IsSetResourceRegionScope()
        {
            return this._resourceRegionScope != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// Specifies that you want to list only resources in the resource shares identified by
        /// the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceShareArns
        {
            get { return this._resourceShareArns; }
            set { this._resourceShareArns = value; }
        }

        // Check to see if ResourceShareArns property is set
        internal bool IsSetResourceShareArns()
        {
            return this._resourceShareArns != null && (this._resourceShareArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies that you want to list only the resource shares that include resources of
        /// the specified resource type.
        /// </para>
        ///  
        /// <para>
        /// For valid values, query the <a>ListResourceTypes</a> operation.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}
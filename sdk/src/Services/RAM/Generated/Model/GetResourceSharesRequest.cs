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
    /// Container for the parameters to the GetResourceShares operation.
    /// Retrieves details about the resource shares that you own or that are shared with you.
    /// </summary>
    public partial class GetResourceSharesRequest : AmazonRAMRequest
    {
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private string _permissionArn;
        private int? _permissionVersion;
        private ResourceOwner _resourceOwner;
        private List<string> _resourceShareArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceShareStatus _resourceShareStatus;
        private List<TagFilter> _tagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of an individual resource share that you want to retrieve details
        /// about.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// Specifies that you want to retrieve details of only those resource shares that use
        /// the managed permission with this <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a>.
        /// </para>
        /// </summary>
        public string PermissionArn
        {
            get { return this._permissionArn; }
            set { this._permissionArn = value; }
        }

        // Check to see if PermissionArn property is set
        internal bool IsSetPermissionArn()
        {
            return this._permissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionVersion. 
        /// <para>
        /// Specifies that you want to retrieve details for only those resource shares that use
        /// the specified version of the managed permission.
        /// </para>
        /// </summary>
        public int? PermissionVersion
        {
            get { return this._permissionVersion; }
            set { this._permissionVersion = value; }
        }

        // Check to see if PermissionVersion property is set
        internal bool IsSetPermissionVersion()
        {
            return this._permissionVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// Specifies that you want to retrieve details of only those resource shares that match
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>SELF</c> </b> – resource shares that your account shares with other accounts
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>OTHER-ACCOUNTS</c> </b> – resource shares that other accounts share with your
        /// account
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
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> of individual resource shares that you want information
        /// about.
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
        /// Gets and sets the property ResourceShareStatus. 
        /// <para>
        /// Specifies that you want to retrieve details of only those resource shares that have
        /// this status.
        /// </para>
        /// </summary>
        public ResourceShareStatus ResourceShareStatus
        {
            get { return this._resourceShareStatus; }
            set { this._resourceShareStatus = value; }
        }

        // Check to see if ResourceShareStatus property is set
        internal bool IsSetResourceShareStatus()
        {
            return this._resourceShareStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// Specifies that you want to retrieve details of only those resource shares that match
        /// the specified tag keys and values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagFilter> TagFilters
        {
            get { return this._tagFilters; }
            set { this._tagFilters = value; }
        }

        // Check to see if TagFilters property is set
        internal bool IsSetTagFilters()
        {
            return this._tagFilters != null && (this._tagFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
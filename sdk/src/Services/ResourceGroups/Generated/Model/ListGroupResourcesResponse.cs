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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
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
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// This is the response object from the ListGroupResources operation.
    /// </summary>
    public partial class ListGroupResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<QueryError> _queryErrors = AWSConfigs.InitializeCollections ? new List<QueryError>() : null;
        private List<ResourceIdentifier> _resourceIdentifiers = AWSConfigs.InitializeCollections ? new List<ResourceIdentifier>() : null;
        private List<ListGroupResourcesItem> _resources = AWSConfigs.InitializeCollections ? new List<ListGroupResourcesItem>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <c>NextToken</c> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <c>NextToken</c> response element comes back as <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property QueryErrors. 
        /// <para>
        /// A list of <c>QueryError</c> objects. Each error contains an <c>ErrorCode</c> and <c>Message</c>.
        /// Possible values for ErrorCode are <c>CLOUDFORMATION_STACK_INACTIVE</c>, <c>CLOUDFORMATION_STACK_NOT_EXISTING</c>,
        /// <c>CLOUDFORMATION_STACK_UNASSUMABLE_ROLE</c> and <c>RESOURCE_TYPE_NOT_SUPPORTED</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryError> QueryErrors
        {
            get { return this._queryErrors; }
            set { this._queryErrors = value; }
        }

        // Check to see if QueryErrors property is set
        internal bool IsSetQueryErrors()
        {
            return this._queryErrors != null && (this._queryErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. <important> 
        /// <para>
        ///  <b> <i>Deprecated - don't use this parameter. Use the <c>Resources</c> response field
        /// instead.</i> </b> 
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This field is deprecated, use Resources instead.")]
        public List<ResourceIdentifier> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && (this._resourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// An array of resources from which you can determine each resource's identity, type,
        /// and group membership status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListGroupResourcesItem> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
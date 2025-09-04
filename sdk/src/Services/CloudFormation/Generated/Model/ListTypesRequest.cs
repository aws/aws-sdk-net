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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListTypes operation.
    /// Returns summary information about all extensions, including your private resource
    /// types, modules, and Hooks as well as all public extensions from Amazon Web Services
    /// and third-party publishers.
    /// </summary>
    public partial class ListTypesRequest : AmazonCloudFormationRequest
    {
        private DeprecatedStatus _deprecatedStatus;
        private TypeFilters _filters;
        private int? _maxResults;
        private string _nextToken;
        private ProvisioningType _provisioningType;
        private RegistryType _type;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property DeprecatedStatus. 
        /// <para>
        /// The deprecation status of the extension that you want to get summary information about.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LIVE</c>: The extension is registered for use in CloudFormation operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPRECATED</c>: The extension has been deregistered and can no longer be used
        /// in CloudFormation operations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeprecatedStatus DeprecatedStatus
        {
            get { return this._deprecatedStatus; }
            set { this._deprecatedStatus = value; }
        }

        // Check to see if DeprecatedStatus property is set
        internal bool IsSetDeprecatedStatus()
        {
            return this._deprecatedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filter criteria to use in determining which extensions to return.
        /// </para>
        ///  
        /// <para>
        /// Filters must be compatible with <c>Visibility</c> to return valid results. For example,
        /// specifying <c>AWS_TYPES</c> for <c>Category</c> and <c>PRIVATE</c> for <c>Visibility</c>
        /// returns an empty list of types, but specifying <c>PUBLIC</c> for <c>Visibility</c>
        /// returns the desired list.
        /// </para>
        /// </summary>
        public TypeFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If the previous paginated request didn't return all the remaining results, the response
        /// object's <c>NextToken</c> parameter value is set to a token. To retrieve the next
        /// set of results, call this action again and assign that token to the request object's
        /// <c>NextToken</c> parameter. If there are no remaining results, the previous response
        /// object's <c>NextToken</c> parameter is set to <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ProvisioningType. 
        /// <para>
        /// For resource types, the provisioning behavior of the resource type. CloudFormation
        /// determines the provisioning type during registration, based on the types of handlers
        /// in the schema handler package submitted.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULLY_MUTABLE</c>: The resource type includes an update handler to process updates
        /// to the type during stack update operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMMUTABLE</c>: The resource type doesn't include an update handler, so the type
        /// can't be updated and must instead be replaced during stack update operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_PROVISIONABLE</c>: The resource type doesn't include create, read, and delete
        /// handlers, and therefore can't actually be provisioned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>FULLY_MUTABLE</c>.
        /// </para>
        /// </summary>
        public ProvisioningType ProvisioningType
        {
            get { return this._provisioningType; }
            set { this._provisioningType = value; }
        }

        // Check to see if ProvisioningType property is set
        internal bool IsSetProvisioningType()
        {
            return this._provisioningType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of extension.
        /// </para>
        /// </summary>
        public RegistryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The scope at which the extensions are visible and usable in CloudFormation operations.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRIVATE</c>: Extensions that are visible and usable within this account and Region.
        /// This includes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Private extensions you have registered in this account and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Public extensions that you have activated in this account and Region.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PUBLIC</c>: Extensions that are publicly visible and available to be activated
        /// within any Amazon Web Services account. This includes extensions from Amazon Web Services,
        /// in addition to third-party publishers.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>PRIVATE</c>.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}
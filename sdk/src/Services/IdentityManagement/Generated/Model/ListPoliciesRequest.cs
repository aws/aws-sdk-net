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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListPolicies operation.
    /// Lists all the managed policies that are available in your Amazon Web Services account,
    /// including your own customer-defined managed policies and all Amazon Web Services managed
    /// policies.
    /// 
    ///  
    /// <para>
    /// You can filter the list of policies that is returned using the optional <c>OnlyAttached</c>,
    /// <c>Scope</c>, and <c>PathPrefix</c> parameters. For example, to list only the customer
    /// managed policies in your Amazon Web Services account, set <c>Scope</c> to <c>Local</c>.
    /// To list only Amazon Web Services managed policies, set <c>Scope</c> to <c>AWS</c>.
    /// </para>
    ///  
    /// <para>
    /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// IAM resource-listing operations return a subset of the available attributes for the
    /// resource. For example, this operation does not return tags, even though they are an
    /// attribute of the returned object. To view all of the information for a customer manged
    /// policy, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListPoliciesRequest : AmazonIdentityManagementServiceRequest
    {
        private string _marker;
        private int? _maxItems;
        private bool? _onlyAttached;
        private string _pathPrefix;
        private PolicyUsageType _policyUsageFilter;
        private PolicyScopeType _scope;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <c>Marker</c>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=320)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If additional items exist beyond the maximum you specify, the
        /// <c>IsTruncated</c> response element is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, the number of items defaults to 100. Note that
        /// IAM might return fewer results, even when there are more results available. In that
        /// case, the <c>IsTruncated</c> response element returns <c>true</c>, and <c>Marker</c>
        /// contains a value to include in the subsequent call that tells the service where to
        /// continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnlyAttached. 
        /// <para>
        /// A flag to filter the results to only the attached policies.
        /// </para>
        ///  
        /// <para>
        /// When <c>OnlyAttached</c> is <c>true</c>, the returned list contains only the policies
        /// that are attached to an IAM user, group, or role. When <c>OnlyAttached</c> is <c>false</c>,
        /// or when the parameter is not included, all policies are returned.
        /// </para>
        /// </summary>
        public bool? OnlyAttached
        {
            get { return this._onlyAttached; }
            set { this._onlyAttached = value; }
        }

        // Check to see if OnlyAttached property is set
        internal bool IsSetOnlyAttached()
        {
            return this._onlyAttached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        /// The path prefix for filtering the results. This parameter is optional. If it is not
        /// included, it defaults to a slash (/), listing all policies. This parameter allows
        /// (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string
        /// of characters consisting of either a forward slash (/) by itself or a string that
        /// must begin and end with forward slashes. In addition, it can contain any ASCII character
        /// from the ! (<c>\u0021</c>) through the DEL character (<c>\u007F</c>), including most
        /// punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string PathPrefix
        {
            get { return this._pathPrefix; }
            set { this._pathPrefix = value; }
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this._pathPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyUsageFilter. 
        /// <para>
        /// The policy usage method to use for filtering the results.
        /// </para>
        ///  
        /// <para>
        /// To list only permissions policies, set <c>PolicyUsageFilter</c> to <c>PermissionsPolicy</c>.
        /// To list only the policies used to set permissions boundaries, set the value to <c>PermissionsBoundary</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, all policies are returned. 
        /// </para>
        /// </summary>
        public PolicyUsageType PolicyUsageFilter
        {
            get { return this._policyUsageFilter; }
            set { this._policyUsageFilter = value; }
        }

        // Check to see if PolicyUsageFilter property is set
        internal bool IsSetPolicyUsageFilter()
        {
            return this._policyUsageFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope to use for filtering the results.
        /// </para>
        ///  
        /// <para>
        /// To list only Amazon Web Services managed policies, set <c>Scope</c> to <c>AWS</c>.
        /// To list only the customer managed policies in your Amazon Web Services account, set
        /// <c>Scope</c> to <c>Local</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, or if it is set to <c>All</c>,
        /// all policies are returned.
        /// </para>
        /// </summary>
        public PolicyScopeType Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}
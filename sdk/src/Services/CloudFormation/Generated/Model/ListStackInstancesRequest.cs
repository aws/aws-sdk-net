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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListStackInstances operation.
    /// Returns summary information about stack instances that are associated with the specified
    /// stack set. You can filter for stack instances that are associated with a specific
    /// Amazon Web Services account name or Region, or that have a specific status.
    /// </summary>
    public partial class ListStackInstancesRequest : AmazonCloudFormationRequest
    {
        private CallAs _callAs;
        private List<StackInstanceFilter> _filters = new List<StackInstanceFilter>();
        private int? _maxResults;
        private string _nextToken;
        private string _stackInstanceAccount;
        private string _stackInstanceRegion;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <code>SELF</code> is specified. Use <code>SELF</code> for stack sets with
        /// self-managed permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <code>SELF</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <code>DELEGATED_ADMIN</code>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The status that stack instances are filtered by.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<StackInstanceFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <code>NextToken</code>
        /// value that you can assign to the <code>NextToken</code> request parameter to get the
        /// next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If the previous request didn't return all of the remaining results, the response's
        /// <code>NextToken</code> parameter value is set to a token. To retrieve the next set
        /// of results, call <code>ListStackInstances</code> again and assign that token to the
        /// request object's <code>NextToken</code> parameter. If there are no remaining results,
        /// the previous response object's <code>NextToken</code> parameter is set to <code>null</code>.
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
        /// Gets and sets the property StackInstanceAccount. 
        /// <para>
        /// The name of the Amazon Web Services account that you want to list stack instances
        /// for.
        /// </para>
        /// </summary>
        public string StackInstanceAccount
        {
            get { return this._stackInstanceAccount; }
            set { this._stackInstanceAccount = value; }
        }

        // Check to see if StackInstanceAccount property is set
        internal bool IsSetStackInstanceAccount()
        {
            return this._stackInstanceAccount != null;
        }

        /// <summary>
        /// Gets and sets the property StackInstanceRegion. 
        /// <para>
        /// The name of the Region where you want to list stack instances.
        /// </para>
        /// </summary>
        public string StackInstanceRegion
        {
            get { return this._stackInstanceRegion; }
            set { this._stackInstanceRegion = value; }
        }

        // Check to see if StackInstanceRegion property is set
        internal bool IsSetStackInstanceRegion()
        {
            return this._stackInstanceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the stack set that you want to list stack instances for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

    }
}
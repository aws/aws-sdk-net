/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListStackInstances operation.
    /// Returns summary information about stack instances that are associated with the specified
    /// stack set. You can filter for stack instances that are associated with a specific
    /// AWS account name or region.
    /// </summary>
    public partial class ListStackInstancesRequest : AmazonCloudFormationRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _stackInstanceAccount;
        private string _stackInstanceRegion;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <code>NextToken</code>
        /// value that you can assign to the <code>NextToken</code> request parameter to get the
        /// next set of results.
        /// </para>
        /// </summary>
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
        /// The name of the AWS account that you want to list stack instances for.
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
        /// The name of the region where you want to list stack instances. 
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
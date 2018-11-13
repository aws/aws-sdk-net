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
    /// Container for the parameters to the DescribeStackResourceDrifts operation.
    /// Returns drift information for the resources that have been checked for drift in the
    /// specified stack. This includes actual and expected configuration values for resources
    /// where AWS CloudFormation detects configuration drift.
    /// 
    ///  
    /// <para>
    /// For a given stack, there will be one <code>StackResourceDrift</code> for each stack
    /// resource that has been checked for drift. Resources that have not yet been checked
    /// for drift are not included. Resources that do not currently support drift detection
    /// are not checked, and so not included. For a list of resources that support drift detection,
    /// see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
    /// that Support Drift Detection</a>.
    /// </para>
    ///  
    /// <para>
    /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
    /// to detect drift on all supported resources for a given stack.
    /// </para>
    /// </summary>
    public partial class DescribeStackResourceDriftsRequest : AmazonCloudFormationRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _stackName;
        private List<string> _stackResourceDriftStatusFilters = new List<string>();

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
        /// A string that identifies the next page of stack resource drift results.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for which you want drift information.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StackResourceDriftStatusFilters. 
        /// <para>
        /// The resource drift status values to use as filters for the resource drift results
        /// returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DELETED</code>: The resource differs from its expected template configuration
        /// in that the resource has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFIED</code>: One or more resource properties differ from their expected
        /// template values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: The resources's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation does not currently return this value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> StackResourceDriftStatusFilters
        {
            get { return this._stackResourceDriftStatusFilters; }
            set { this._stackResourceDriftStatusFilters = value; }
        }

        // Check to see if StackResourceDriftStatusFilters property is set
        internal bool IsSetStackResourceDriftStatusFilters()
        {
            return this._stackResourceDriftStatusFilters != null && this._stackResourceDriftStatusFilters.Count > 0; 
        }

    }
}
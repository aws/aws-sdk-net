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
    /// This is the response object from the DescribeStackResourceDrifts operation.
    /// </summary>
    public partial class DescribeStackResourceDriftsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StackResourceDrift> _stackResourceDrifts = new List<StackResourceDrift>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all of the remaining results, <code>NextToken</code>
        /// is set to a token. To retrieve the next set of results, call <code>DescribeStackResourceDrifts</code>
        /// again and assign that token to the request object's <code>NextToken</code> parameter.
        /// If the request returns all results, <code>NextToken</code> is set to <code>null</code>.
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
        /// Gets and sets the property StackResourceDrifts. 
        /// <para>
        /// Drift information for the resources that have been checked for drift in the specified
        /// stack. This includes actual and expected configuration values for resources where
        /// AWS CloudFormation detects drift.
        /// </para>
        ///  
        /// <para>
        /// For a given stack, there will be one <code>StackResourceDrift</code> for each stack
        /// resource that has been checked for drift. Resources that have not yet been checked
        /// for drift are not included. Resources that do not currently support drift detection
        /// are not checked, and so not included. For a list of resources that support drift detection,
        /// see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        /// </summary>
        public List<StackResourceDrift> StackResourceDrifts
        {
            get { return this._stackResourceDrifts; }
            set { this._stackResourceDrifts = value; }
        }

        // Check to see if StackResourceDrifts property is set
        internal bool IsSetStackResourceDrifts()
        {
            return this._stackResourceDrifts != null && this._stackResourceDrifts.Count > 0; 
        }

    }
}
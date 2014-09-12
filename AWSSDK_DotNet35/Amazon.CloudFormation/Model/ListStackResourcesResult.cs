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
    /// The output for a <a>ListStackResources</a> action.
    /// </summary>
    public partial class ListStackResourcesResult : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StackResourceSummary> _stackResourceSummaries = new List<StackResourceSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// String that identifies the start of the next list of stack resources, if there is
        /// one.
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
        /// Gets and sets the property StackResourceSummaries. 
        /// <para>
        /// A list of <code>StackResourceSummary</code> structures.
        /// </para>
        /// </summary>
        public List<StackResourceSummary> StackResourceSummaries
        {
            get { return this._stackResourceSummaries; }
            set { this._stackResourceSummaries = value; }
        }

        // Check to see if StackResourceSummaries property is set
        internal bool IsSetStackResourceSummaries()
        {
            return this._stackResourceSummaries != null && this._stackResourceSummaries.Count > 0; 
        }

    }
}
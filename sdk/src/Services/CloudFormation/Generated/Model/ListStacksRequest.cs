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
    /// Container for the parameters to the ListStacks operation.
    /// Returns the summary information for stacks whose status matches the specified <c>StackStatusFilter</c>.
    /// Summary information for stacks that have been deleted is kept for 90 days after the
    /// stack is deleted. If no <c>StackStatusFilter</c> is specified, summary information
    /// for all stacks is returned (including existing stacks and stacks that have been deleted).
    /// </summary>
    public partial class ListStacksRequest : AmazonCloudFormationRequest
    {
        private string _nextToken;
        private List<string> _stackStatusFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string that identifies the next page of stacks that you want to retrieve.
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
        /// Gets and sets the property StackStatusFilter. 
        /// <para>
        /// Stack status to use as a filter. Specify one or more stack status codes to list only
        /// stacks with the specified status codes. For a complete list of stack status codes,
        /// see the <c>StackStatus</c> parameter of the <a>Stack</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackStatusFilter
        {
            get { return this._stackStatusFilter; }
            set { this._stackStatusFilter = value; }
        }

        // Check to see if StackStatusFilter property is set
        internal bool IsSetStackStatusFilter()
        {
            return this._stackStatusFilter != null && (this._stackStatusFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
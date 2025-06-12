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
    /// The output for a <a>ListStackResources</a> action.
    /// </summary>
    public partial class ListStackResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StackResourceSummary> _stackResourceSummaries = AWSConfigs.InitializeCollections ? new List<StackResourceSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the output exceeds 1 MB, a string that identifies the next page of stack resources.
        /// If no additional page exists, this value is null.
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
        /// Gets and sets the property StackResourceSummaries. 
        /// <para>
        /// A list of <c>StackResourceSummary</c> structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StackResourceSummary> StackResourceSummaries
        {
            get { return this._stackResourceSummaries; }
            set { this._stackResourceSummaries = value; }
        }

        // Check to see if StackResourceSummaries property is set
        internal bool IsSetStackResourceSummaries()
        {
            return this._stackResourceSummaries != null && (this._stackResourceSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
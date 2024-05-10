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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListComponentBuildVersions operation.
    /// Returns the list of component build versions for the specified semantic version.
    /// 
    ///  <note> 
    /// <para>
    /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
    /// You can assign values for the first three, and can filter on all of them.
    /// </para>
    ///  
    /// <para>
    ///  <b>Filtering:</b> With semantic versioning, you have the flexibility to use wildcards
    /// (x) to specify the most recent versions or nodes when selecting the base image or
    /// components for your recipe. When you use a wildcard in any node, all nodes to the
    /// right of the first wildcard must also be wildcards.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListComponentBuildVersionsRequest : AmazonImagebuilderRequest
    {
        private string _componentVersionArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComponentVersionArn. 
        /// <para>
        /// The component version Amazon Resource Name (ARN) whose versions you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComponentVersionArn
        {
            get { return this._componentVersionArn; }
            set { this._componentVersionArn = value; }
        }

        // Check to see if ComponentVersionArn property is set
        internal bool IsSetComponentVersionArn()
        {
            return this._componentVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum items to return in a request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// A token to specify where to start paginating. This is the nextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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

    }
}
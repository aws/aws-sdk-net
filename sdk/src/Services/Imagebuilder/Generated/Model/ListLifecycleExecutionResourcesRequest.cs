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
    /// Container for the parameters to the ListLifecycleExecutionResources operation.
    /// List resources that the runtime instance of the image lifecycle identified for lifecycle
    /// actions.
    /// </summary>
    public partial class ListLifecycleExecutionResourcesRequest : AmazonImagebuilderRequest
    {
        private string _lifecycleExecutionId;
        private int? _maxResults;
        private string _nextToken;
        private string _parentResourceId;

        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Use the unique identifier for a runtime instance of the lifecycle policy to get runtime
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LifecycleExecutionId
        {
            get { return this._lifecycleExecutionId; }
            set { this._lifecycleExecutionId = value; }
        }

        // Check to see if LifecycleExecutionId property is set
        internal bool IsSetLifecycleExecutionId()
        {
            return this._lifecycleExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specify the maximum number of items to return in a request.
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

        /// <summary>
        /// Gets and sets the property ParentResourceId. 
        /// <para>
        /// You can leave this empty to get a list of Image Builder resources that were identified
        /// for lifecycle actions.
        /// </para>
        ///  
        /// <para>
        /// To get a list of associated resources that are impacted for an individual resource
        /// (the parent), specify its Amazon Resource Name (ARN). Associated resources are produced
        /// from your image and distributed when you run a build, such as AMIs or container images
        /// stored in ECR repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ParentResourceId
        {
            get { return this._parentResourceId; }
            set { this._parentResourceId = value; }
        }

        // Check to see if ParentResourceId property is set
        internal bool IsSetParentResourceId()
        {
            return this._parentResourceId != null;
        }

    }
}
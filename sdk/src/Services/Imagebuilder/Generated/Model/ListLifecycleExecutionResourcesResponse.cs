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
    /// This is the response object from the ListLifecycleExecutionResources operation.
    /// </summary>
    public partial class ListLifecycleExecutionResourcesResponse : AmazonWebServiceResponse
    {
        private string _lifecycleExecutionId;
        private LifecycleExecutionState _lifecycleExecutionState;
        private string _nextToken;
        private List<LifecycleExecutionResource> _resources = AWSConfigs.InitializeCollections ? new List<LifecycleExecutionResource>() : null;

        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Runtime details for the specified runtime instance of the lifecycle policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LifecycleExecutionState. 
        /// <para>
        /// The current state of the lifecycle runtime instance.
        /// </para>
        /// </summary>
        public LifecycleExecutionState LifecycleExecutionState
        {
            get { return this._lifecycleExecutionState; }
            set { this._lifecycleExecutionState = value; }
        }

        // Check to see if LifecycleExecutionState property is set
        internal bool IsSetLifecycleExecutionState()
        {
            return this._lifecycleExecutionState != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for paginated responses. When this field isn't empty, there are
        /// additional elements that the service hasn't included in this request. Use this token
        /// with the next request to retrieve additional objects.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// A list of resources that were identified for lifecycle actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleExecutionResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
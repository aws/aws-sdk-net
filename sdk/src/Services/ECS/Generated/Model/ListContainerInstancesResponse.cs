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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListContainerInstancesResponse : AmazonWebServiceResponse
    {
        private List<string> _containerInstanceArns = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ContainerInstanceArns. 
        /// <para>
        /// The list of container instances with full Amazon Resource Name (ARN) entries for each
        /// container instance associated with the specified cluster.
        /// </para>
        /// </summary>
        public List<string> ContainerInstanceArns
        {
            get { return this._containerInstanceArns; }
            set { this._containerInstanceArns = value; }
        }

        // Check to see if ContainerInstanceArns property is set
        internal bool IsSetContainerInstanceArns()
        {
            return this._containerInstanceArns != null && this._containerInstanceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListContainerInstances</code>
        /// request. When the results of a <code>ListContainerInstances</code> request exceed
        /// <code>maxResults</code>, this value can be used to retrieve the next page of results.
        /// This value is <code>null</code> when there are no more results to return.
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

    }
}
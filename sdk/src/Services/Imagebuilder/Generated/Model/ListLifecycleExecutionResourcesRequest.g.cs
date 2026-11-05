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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListLifecycleExecutionResources operation. Lists
    /// resources that the runtime instance of the image lifecycle identified for lifecycle
    /// actions.
    /// </summary>
    public partial class ListLifecycleExecutionResourcesRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// The unique identifier for a runtime instance of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LifecycleExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleExecutionId property is set.
        /// </summary>
        internal bool IsSetLifecycleExecutionId() => this.LifecycleExecutionId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in a single request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. Use the <c>nextToken</c> value from
        /// a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ParentResourceId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an image build version to get the output resources
        /// for, such as AMIs or container images in Amazon ECR. You can get this value from the
        /// <c>resourceId</c> in the top-level response. If you leave this property empty, the
        /// response lists the Image Builder resources that the lifecycle execution identified
        /// for lifecycle actions. If the image build version that you specify in <c>parentResourceId</c>
        /// wasn't part of this lifecycle execution, the response contains an empty list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ParentResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ParentResourceId property is set.
        /// </summary>
        internal bool IsSetParentResourceId() => this.ParentResourceId != null;
    }
}

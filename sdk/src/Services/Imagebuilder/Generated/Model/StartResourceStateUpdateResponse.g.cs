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
    /// This is the response object from the StartResourceStateUpdate operation.
    /// </summary>
    public partial class StartResourceStateUpdateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Identifies the lifecycle execution that performs the resource state update. Image
        /// Builder only returns this field when it started a lifecycle execution for the update.
        /// Use it with <a>GetLifecycleExecution</a> to track progress.
        /// </para>
        /// </summary>
        public string LifecycleExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleExecutionId property is set.
        /// </summary>
        internal bool IsSetLifecycleExecutionId() => this.LifecycleExecutionId != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The requested Amazon Resource Name (ARN) of the Image Builder resource for the asynchronous
        /// update.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}

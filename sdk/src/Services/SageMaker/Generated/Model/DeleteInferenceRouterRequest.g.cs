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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInferenceRouter operation. Deletes an inference
    /// router. The endpoints and inference components that the router sends requests to aren't
    /// deleted. <para> If the router is being created, updated, or deleted, you get a <c>ConflictException</c>.
    /// </para>
    /// </summary>
    public partial class DeleteInferenceRouterRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property InferenceRouterName. 
        /// <para>
        /// The name of the inference router to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InferenceRouterName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceRouterName property is set.
        /// </summary>
        internal bool IsSetInferenceRouterName() => this.InferenceRouterName != null;
    }
}

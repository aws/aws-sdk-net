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

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// This is the response object from the CreateRealtimeEndpoint operation.
    /// </summary>
    public partial class CreateRealtimeEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>MLModel</c>. This value should
        /// be identical to the value of the <c>MLModelId</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;

        /// <summary>
        /// Gets and sets the property RealtimeEndpointInfo. 
        /// <para>
        /// The endpoint information of the <c>MLModel</c> 
        /// </para>
        /// </summary>
        public RealtimeEndpointInfo RealtimeEndpointInfo { get; set; }

        /// <summary>
        /// Checks to see if the RealtimeEndpointInfo property is set.
        /// </summary>
        internal bool IsSetRealtimeEndpointInfo() => this.RealtimeEndpointInfo != null;
    }
}

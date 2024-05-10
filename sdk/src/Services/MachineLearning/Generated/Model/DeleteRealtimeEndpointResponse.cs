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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
    /// Represents the output of an <c>DeleteRealtimeEndpoint</c> operation.
    /// 
    ///  
    /// <para>
    /// The result contains the <c>MLModelId</c> and the endpoint information for the <c>MLModel</c>.
    /// 
    /// </para>
    /// </summary>
    public partial class DeleteRealtimeEndpointResponse : AmazonWebServiceResponse
    {
        private string _mlModelId;
        private RealtimeEndpointInfo _realtimeEndpointInfo;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>MLModel</c>. This value should
        /// be identical to the value of the <c>MLModelId</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

        /// <summary>
        /// Gets and sets the property RealtimeEndpointInfo. 
        /// <para>
        /// The endpoint information of the <c>MLModel</c> 
        /// </para>
        /// </summary>
        public RealtimeEndpointInfo RealtimeEndpointInfo
        {
            get { return this._realtimeEndpointInfo; }
            set { this._realtimeEndpointInfo = value; }
        }

        // Check to see if RealtimeEndpointInfo property is set
        internal bool IsSetRealtimeEndpointInfo()
        {
            return this._realtimeEndpointInfo != null;
        }

    }
}
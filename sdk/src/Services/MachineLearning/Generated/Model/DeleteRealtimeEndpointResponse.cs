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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of an <code>DeleteRealtimeEndpoint</code> operation.
    /// 
    ///  
    /// <para>
    /// The result contains the <code>MLModelId</code> and the endpoint information for the
    /// <code>MLModel</code>. 
    /// </para>
    /// </summary>
    public partial class DeleteRealtimeEndpointResponse : AmazonWebServiceResponse
    {
        private string _mlModelId;
        private RealtimeEndpointInfo _realtimeEndpointInfo;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>MLModel</code>. This value should
        /// be identical to the value of the <code>MLModelId</code> in the request.
        /// </para>
        /// </summary>
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
        /// The endpoint information of the <code>MLModel</code> 
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
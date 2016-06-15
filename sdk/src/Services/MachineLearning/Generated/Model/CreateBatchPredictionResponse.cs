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
    /// Represents the output of a <code>CreateBatchPrediction</code> operation, and is an
    /// acknowledgement that Amazon ML received the request.
    /// 
    ///  
    /// <para>
    /// The <code>CreateBatchPrediction</code> operation is asynchronous. You can poll for
    /// status updates by using the <code>&gt;GetBatchPrediction</code> operation and checking
    /// the <code>Status</code> parameter of the result. 
    /// </para>
    /// </summary>
    public partial class CreateBatchPredictionResponse : AmazonWebServiceResponse
    {
        private string _batchPredictionId;

        /// <summary>
        /// Gets and sets the property BatchPredictionId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>BatchPrediction</code>. This
        /// value is identical to the value of the <code>BatchPredictionId</code> in the request.
        /// </para>
        /// </summary>
        public string BatchPredictionId
        {
            get { return this._batchPredictionId; }
            set { this._batchPredictionId = value; }
        }

        // Check to see if BatchPredictionId property is set
        internal bool IsSetBatchPredictionId()
        {
            return this._batchPredictionId != null;
        }

    }
}
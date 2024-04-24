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
    /// Container for the parameters to the UpdateBatchPrediction operation.
    /// Updates the <c>BatchPredictionName</c> of a <c>BatchPrediction</c>.
    /// 
    ///  
    /// <para>
    /// You can use the <c>GetBatchPrediction</c> operation to view the contents of the updated
    /// data element.
    /// </para>
    /// </summary>
    public partial class UpdateBatchPredictionRequest : AmazonMachineLearningRequest
    {
        private string _batchPredictionId;
        private string _batchPredictionName;

        /// <summary>
        /// Gets and sets the property BatchPredictionId. 
        /// <para>
        /// The ID assigned to the <c>BatchPrediction</c> during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property BatchPredictionName. 
        /// <para>
        /// A new user-supplied name or description of the <c>BatchPrediction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string BatchPredictionName
        {
            get { return this._batchPredictionName; }
            set { this._batchPredictionName = value; }
        }

        // Check to see if BatchPredictionName property is set
        internal bool IsSetBatchPredictionName()
        {
            return this._batchPredictionName != null;
        }

    }
}
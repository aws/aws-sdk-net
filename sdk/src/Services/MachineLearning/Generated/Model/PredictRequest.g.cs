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
    /// Container for the parameters to the Predict operation. Generates a prediction for
    /// the observation using the specified <c>ML Model</c>. <para> <b>Note:</b> Not all response
    /// parameters will be populated. Whether a response parameter is populated depends on
    /// the type of model requested. </para>
    /// </summary>
    public partial class PredictRequest : AmazonMachineLearningRequest
    {
        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A unique identifier of the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;

        /// <summary>
        /// Gets and sets the property PredictEndpoint.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string PredictEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PredictEndpoint property is set.
        /// </summary>
        internal bool IsSetPredictEndpoint() => this.PredictEndpoint != null;

        /// <summary>
        /// Gets and sets the property Record.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Record { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Record property is set.
        /// </summary>
        internal bool IsSetRecord() => this.Record != null && (this.Record.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

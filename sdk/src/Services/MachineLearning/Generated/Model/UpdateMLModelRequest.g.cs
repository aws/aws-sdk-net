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
    /// Container for the parameters to the UpdateMLModel operation. Updates the <c>MLModelName</c>
    /// and the <c>ScoreThreshold</c> of an <c>MLModel</c>. <para> You can use the <c>GetMLModel</c>
    /// operation to view the contents of the updated data element. </para>
    /// </summary>
    public partial class UpdateMLModelRequest : AmazonMachineLearningRequest
    {
        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID assigned to the <c>MLModel</c> during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;

        /// <summary>
        /// Gets and sets the property MLModelName. 
        /// <para>
        /// A user-supplied name or description of the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MLModelName { get; set; }

        /// <summary>
        /// Checks to see if the MLModelName property is set.
        /// </summary>
        internal bool IsSetMLModelName() => this.MLModelName != null;

        /// <summary>
        /// Gets and sets the property ScoreThreshold. 
        /// <para>
        /// The <c>ScoreThreshold</c> used in binary classification <c>MLModel</c> that marks
        /// the boundary between a positive prediction and a negative prediction.
        /// </para>
        ///  
        /// <para>
        /// Output values greater than or equal to the <c>ScoreThreshold</c> receive a positive
        /// result from the <c>MLModel</c>, such as <c>true</c>. Output values less than the <c>ScoreThreshold</c>
        /// receive a negative response from the <c>MLModel</c>, such as <c>false</c>.
        /// </para>
        /// </summary>
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ScoreThreshold property is set.
        /// </summary>
        internal bool IsSetScoreThreshold() => this.ScoreThreshold.HasValue;
    }
}

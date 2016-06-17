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
    /// Container for the parameters to the UpdateMLModel operation.
    /// Updates the <code>MLModelName</code> and the <code>ScoreThreshold</code> of an <code>MLModel</code>.
    /// 
    ///  
    /// <para>
    /// You can use the <code>GetMLModel</code> operation to view the contents of the updated
    /// data element.
    /// </para>
    /// </summary>
    public partial class UpdateMLModelRequest : AmazonMachineLearningRequest
    {
        private string _mlModelId;
        private string _mlModelName;
        private float? _scoreThreshold;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID assigned to the <code>MLModel</code> during creation.
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
        /// Gets and sets the property MLModelName. 
        /// <para>
        /// A user-supplied name or description of the <code>MLModel</code>.
        /// </para>
        /// </summary>
        public string MLModelName
        {
            get { return this._mlModelName; }
            set { this._mlModelName = value; }
        }

        // Check to see if MLModelName property is set
        internal bool IsSetMLModelName()
        {
            return this._mlModelName != null;
        }

        /// <summary>
        /// Gets and sets the property ScoreThreshold. 
        /// <para>
        /// The <code>ScoreThreshold</code> used in binary classification <code>MLModel</code>
        /// that marks the boundary between a positive prediction and a negative prediction.
        /// </para>
        ///  
        /// <para>
        /// Output values greater than or equal to the <code>ScoreThreshold</code> receive a positive
        /// result from the <code>MLModel</code>, such as <code>true</code>. Output values less
        /// than the <code>ScoreThreshold</code> receive a negative response from the <code>MLModel</code>,
        /// such as <code>false</code>.
        /// </para>
        /// </summary>
        public float ScoreThreshold
        {
            get { return this._scoreThreshold.GetValueOrDefault(); }
            set { this._scoreThreshold = value; }
        }

        // Check to see if ScoreThreshold property is set
        internal bool IsSetScoreThreshold()
        {
            return this._scoreThreshold.HasValue; 
        }

    }
}
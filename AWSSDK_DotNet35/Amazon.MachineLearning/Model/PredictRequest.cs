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
    /// Container for the parameters to the Predict operation.
    /// Generates a prediction for the observation using the specified <code>MLModel</code>.
    /// 
    ///  <note><title>Note</title> 
    /// <para>
    /// Not all response parameters will be populated because this is dependent on the type
    /// of requested model.
    /// </para>
    /// </note>
    /// </summary>
    public partial class PredictRequest : AmazonMachineLearningRequest
    {
        private string _mlModelId;
        private string _predictEndpoint;
        private Dictionary<string, string> _record = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A unique identifier of the <code>MLModel</code>.
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
        /// Gets and sets the property PredictEndpoint.
        /// </summary>
        public string PredictEndpoint
        {
            get { return this._predictEndpoint; }
            set { this._predictEndpoint = value; }
        }

        // Check to see if PredictEndpoint property is set
        internal bool IsSetPredictEndpoint()
        {
            return this._predictEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Record.
        /// </summary>
        public Dictionary<string, string> Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null && this._record.Count > 0; 
        }

    }
}
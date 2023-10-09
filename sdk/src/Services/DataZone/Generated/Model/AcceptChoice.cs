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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Specifies the prediction (aka, the automatically generated piece of metadata) and
    /// the target (for example, a column name) that can be accepted.
    /// </summary>
    public partial class AcceptChoice
    {
        private int? _predictionChoice;
        private string _predictionTarget;

        /// <summary>
        /// Gets and sets the property PredictionChoice. 
        /// <para>
        /// Specifies the prediction (aka, the automatically generated piece of metadata) that
        /// can be accepted.
        /// </para>
        /// </summary>
        public int PredictionChoice
        {
            get { return this._predictionChoice.GetValueOrDefault(); }
            set { this._predictionChoice = value; }
        }

        // Check to see if PredictionChoice property is set
        internal bool IsSetPredictionChoice()
        {
            return this._predictionChoice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictionTarget. 
        /// <para>
        /// Specifies the target (for example, a column name) where a prediction can be accepted.
        /// </para>
        /// </summary>
        public string PredictionTarget
        {
            get { return this._predictionTarget; }
            set { this._predictionTarget = value; }
        }

        // Check to see if PredictionTarget property is set
        internal bool IsSetPredictionTarget()
        {
            return this._predictionTarget != null;
        }

    }
}
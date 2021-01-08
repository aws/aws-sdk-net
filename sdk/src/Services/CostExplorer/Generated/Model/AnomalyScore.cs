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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Quantifies the anomaly. The higher score means that it is more anomalous.
    /// </summary>
    public partial class AnomalyScore
    {
        private double? _currentScore;
        private double? _maxScore;

        /// <summary>
        /// Gets and sets the property CurrentScore. 
        /// <para>
        ///  The last observed score. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double CurrentScore
        {
            get { return this._currentScore.GetValueOrDefault(); }
            set { this._currentScore = value; }
        }

        // Check to see if CurrentScore property is set
        internal bool IsSetCurrentScore()
        {
            return this._currentScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxScore. 
        /// <para>
        ///  The maximum score observed during the <code>AnomalyDateInterval</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double MaxScore
        {
            get { return this._maxScore.GetValueOrDefault(); }
            set { this._maxScore = value; }
        }

        // Check to see if MaxScore property is set
        internal bool IsSetMaxScore()
        {
            return this._maxScore.HasValue; 
        }

    }
}
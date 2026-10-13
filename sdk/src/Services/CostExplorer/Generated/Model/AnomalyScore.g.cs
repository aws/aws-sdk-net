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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Quantifies the anomaly. The higher score means that it's more anomalous.
    /// </summary>
    public partial class AnomalyScore
    {
        /// <summary>
        /// Gets and sets the property CurrentScore. 
        /// <para>
        /// The last observed score. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? CurrentScore { get; set; }

        /// <summary>
        /// Checks to see if the CurrentScore property is set.
        /// </summary>
        internal bool IsSetCurrentScore() => this.CurrentScore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxScore. 
        /// <para>
        /// The maximum score that's observed during the <c>AnomalyDateInterval</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? MaxScore { get; set; }

        /// <summary>
        /// Checks to see if the MaxScore property is set.
        /// </summary>
        internal bool IsSetMaxScore() => this.MaxScore.HasValue;
    }
}

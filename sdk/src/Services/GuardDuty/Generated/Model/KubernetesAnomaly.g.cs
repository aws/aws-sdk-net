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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about anomalous Kubernetes behavior.
    /// </summary>
    public partial class KubernetesAnomaly
    {
        /// <summary>
        /// Gets and sets the property AnomalyScore. 
        /// <para>
        /// The anomaly score of the behavior.
        /// </para>
        /// </summary>
        public string AnomalyScore { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyScore property is set.
        /// </summary>
        internal bool IsSetAnomalyScore() => this.AnomalyScore != null;

        /// <summary>
        /// Gets and sets the property BaselineContext. 
        /// <para>
        /// A description of the normal behavior that the activity was compared against.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string BaselineContext { get; set; }

        /// <summary>
        /// Checks to see if the BaselineContext property is set.
        /// </summary>
        internal bool IsSetBaselineContext() => this.BaselineContext != null;

        /// <summary>
        /// Gets and sets the property TrainingPeriod. 
        /// <para>
        /// The period over which the normal behavior was established.
        /// </para>
        /// </summary>
        public string TrainingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPeriod property is set.
        /// </summary>
        internal bool IsSetTrainingPeriod() => this.TrainingPeriod != null;

        /// <summary>
        /// Gets and sets the property UnusualBehavior. 
        /// <para>
        /// A description of the unusual behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string UnusualBehavior { get; set; }

        /// <summary>
        /// Checks to see if the UnusualBehavior property is set.
        /// </summary>
        internal bool IsSetUnusualBehavior() => this.UnusualBehavior != null;
    }
}

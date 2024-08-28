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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the observation generated after evaluating the rules and analyzers.
    /// </summary>
    public partial class DataQualityObservation
    {
        private string _description;
        private MetricBasedObservation _metricBasedObservation;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality observation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MetricBasedObservation. 
        /// <para>
        /// An object of type <c>MetricBasedObservation</c> representing the observation that
        /// is based on evaluated data quality metrics.
        /// </para>
        /// </summary>
        public MetricBasedObservation MetricBasedObservation
        {
            get { return this._metricBasedObservation; }
            set { this._metricBasedObservation = value; }
        }

        // Check to see if MetricBasedObservation property is set
        internal bool IsSetMetricBasedObservation()
        {
            return this._metricBasedObservation != null;
        }

    }
}
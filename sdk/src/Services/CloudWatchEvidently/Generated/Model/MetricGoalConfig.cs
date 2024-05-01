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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Use this structure to tell Evidently whether higher or lower values are desired for
    /// a metric that is used in an experiment.
    /// </summary>
    public partial class MetricGoalConfig
    {
        private ChangeDirectionEnum _desiredChange;
        private MetricDefinitionConfig _metricDefinition;

        /// <summary>
        /// Gets and sets the property DesiredChange. 
        /// <para>
        ///  <c>INCREASE</c> means that a variation with a higher number for this metric is performing
        /// better.
        /// </para>
        ///  
        /// <para>
        ///  <c>DECREASE</c> means that a variation with a lower number for this metric is performing
        /// better.
        /// </para>
        /// </summary>
        public ChangeDirectionEnum DesiredChange
        {
            get { return this._desiredChange; }
            set { this._desiredChange = value; }
        }

        // Check to see if DesiredChange property is set
        internal bool IsSetDesiredChange()
        {
            return this._desiredChange != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinition. 
        /// <para>
        /// A structure that contains details about the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricDefinitionConfig MetricDefinition
        {
            get { return this._metricDefinition; }
            set { this._metricDefinition = value; }
        }

        // Check to see if MetricDefinition property is set
        internal bool IsSetMetricDefinition()
        {
            return this._metricDefinition != null;
        }

    }
}
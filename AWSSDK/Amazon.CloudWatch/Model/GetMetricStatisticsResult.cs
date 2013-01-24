/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The output for the GetMetricStatistics action. </para>
    /// </summary>
    public class GetMetricStatisticsResult  
    {
        
        private string label;
        private List<Datapoint> datapoints = new List<Datapoint>();

        /// <summary>
        /// A label describing the specified metric.
        ///  
        /// </summary>
        public string Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        /// <summary>
        /// Sets the Label property
        /// </summary>
        /// <param name="label">The value to set for the Label property </param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsResult WithLabel(string label)
        {
            this.label = label;
            return this;
        }
            

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this.label != null;       
        }

        /// <summary>
        /// The datapoints for the specified metric.
        ///  
        /// </summary>
        public List<Datapoint> Datapoints
        {
            get { return this.datapoints; }
            set { this.datapoints = value; }
        }
        /// <summary>
        /// Adds elements to the Datapoints collection
        /// </summary>
        /// <param name="datapoints">The values to add to the Datapoints collection </param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsResult WithDatapoints(params Datapoint[] datapoints)
        {
            foreach (Datapoint element in datapoints)
            {
                this.datapoints.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Datapoints collection
        /// </summary>
        /// <param name="datapoints">The values to add to the Datapoints collection </param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsResult WithDatapoints(IEnumerable<Datapoint> datapoints)
        {
            foreach (Datapoint element in datapoints)
            {
                this.datapoints.Add(element);
            }

            return this;
        }

        // Check to see if Datapoints property is set
        internal bool IsSetDatapoints()
        {
            return this.datapoints.Count > 0;       
        }
    }
}

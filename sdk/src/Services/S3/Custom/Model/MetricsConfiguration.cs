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


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for MetricsConfiguration
    /// </summary>
    public class MetricsConfiguration
    {
        private string metricsId;
        private MetricsFilter metricsFilter;

        /// <summary>
        /// The ID used to identify the metrics configuration.
        /// </summary>
        public string MetricsId
        {
            get { return this.metricsId; }
            set { this.metricsId = value; }
        }

        // Check to see if MetricsId property is set
        internal bool IsSetMetricsId()
        {
            return this.metricsId != null;
        }

        
        /// <summary>
        /// Specifies a metrics configuration filter. 
        /// The metrics configuration will only include objects that meet the filter's criteria. 
        /// A filter must be a prefix, a tag, or a conjunction (MetricsAndOperator).
        /// </summary>
        public MetricsFilter MetricsFilter
        {
            get { return this.metricsFilter; }
            set { this.metricsFilter = value; }
        }

        // Check to see if MetricsFilter property is set
        internal bool IsSetMetricsFilter()
        {
            return this.metricsFilter != null;
        }
    }
}
